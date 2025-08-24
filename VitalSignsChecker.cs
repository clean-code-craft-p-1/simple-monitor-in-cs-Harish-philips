using checker;

namespace VitalSignsMonitoring {
   

    public class VitalSignsChecker {

        #region Fields

        private readonly IAlertReporter alertReporter;
        private VitalSignRange currentRange;

        #endregion Fields

        #region Constructor
        public VitalSignsChecker(IAlertReporter alertReporter = null) {
            this.alertReporter = alertReporter ?? new ConsoleAlertReporter();
            this.currentRange = PatientRanges.Adult; // Default to adult ranges
        }
        #endregion Constructor

        #region Public Methods
        // Basic check with default (adult) ranges
        public bool AreVitalsOk(float temperature, int pulseRate, int spo2) {
            var vitalSigns = new List<VitalSign> {
                VitalSignFactory.CreateTemperature(temperature, currentRange),
                VitalSignFactory.CreatePulseRate(pulseRate, currentRange),
                VitalSignFactory.CreateSpo2(spo2, currentRange)
            };

            return AreVitalsOk(vitalSigns);
        }

        // Check for specific patient category
        public bool AreVitalsOk(float temperature, int pulseRate, int spo2, PatientCategory category) {
            var previousRange = currentRange;
            SetPatientCategory(category);
            bool result = AreVitalsOk(temperature, pulseRate, spo2);
            currentRange = previousRange;
            return result;
        }
        #endregion Public Methods

        #region Private Methods
        private void SetPatientCategory(PatientCategory category) {
            currentRange = category switch {
                PatientCategory.Adult => PatientRanges.Adult,
                PatientCategory.Child => PatientRanges.Child,
                PatientCategory.Infant => PatientRanges.Infant,
                _ => throw new ArgumentException($"Unknown patient category: {category}")
            };
        }

        // Pure function that can handle any number of vital signs
        private bool AreVitalsOk(IEnumerable<VitalSign> vitalSigns) {
            // Check if any vital signs are out of range
            var outOfRangeVitals = vitalSigns.Where(sign => !sign.IsWithinLimits()).ToList();
            
            if (outOfRangeVitals.Any()) {
                // Report each out-of-range vital
                foreach (var vitalSign in outOfRangeVitals) {
                    alertReporter.ReportAlert(vitalSign.GetAlertMessage());
                }
                return false;
            }

            alertReporter.ReportNormal(vitalSigns);
            return true;
        }

        #endregion Private Methods
    }
}

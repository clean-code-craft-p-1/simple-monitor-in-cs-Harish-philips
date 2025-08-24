using VitalSignsMonitoring;

namespace checker {
    /// <summary>
    /// Predefined vital sign ranges for different patient categories.
    /// This allows for flexible configuration based on patient demographics.
    /// </summary>
    public static class PatientRanges {
        // Adult ranges using defined constants
        public static readonly VitalSignRange Adult = new VitalSignRange {
            Temperature = new Range(VitalSignConstants.AdultTemperatureLowerLimit, VitalSignConstants.AdultTemperatureUpperLimit),
            PulseRate = new Range(VitalSignConstants.AdultPulseRateLowerLimit, VitalSignConstants.AdultPulseRateUpperLimit),
            Spo2 = new Range(VitalSignConstants.AdultSpo2LowerLimit, VitalSignConstants.AdultSpo2UpperLimit)
        };

        // Child ranges using defined constants
        public static readonly VitalSignRange Child = new VitalSignRange {
            Temperature = new Range(VitalSignConstants.ChildTemperatureLowerLimit, VitalSignConstants.ChildTemperatureUpperLimit),
            PulseRate = new Range(VitalSignConstants.ChildPulseRateLowerLimit, VitalSignConstants.ChildPulseRateUpperLimit),
            Spo2 = new Range(VitalSignConstants.ChildSpo2LowerLimit, VitalSignConstants.ChildSpo2UpperLimit)
        };

        // Infant ranges using defined constants
        public static readonly VitalSignRange Infant = new VitalSignRange {
            Temperature = new Range(VitalSignConstants.InfantTemperatureLowerLimit, VitalSignConstants.InfantTemperatureUpperLimit),
            PulseRate = new Range(VitalSignConstants.InfantPulseRateLowerLimit, VitalSignConstants.InfantPulseRateUpperLimit),
            Spo2 = new Range(VitalSignConstants.InfantSpo2LowerLimit, VitalSignConstants.InfantSpo2UpperLimit)
        };
    }
}

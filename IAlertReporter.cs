using System.Collections.Generic;

namespace VitalSignsMonitoring {
    public interface IAlertReporter {
        void ReportAlert(string message);
        void ReportNormal(IEnumerable<VitalSign> vitalSigns);
    }
}

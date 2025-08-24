using checker;
using VitalSignsMonitoring;

class Checker {

    // Maintain backward compatibility with the original method signature
    public static bool VitalsOk(float temperature, int pulseRate, int spo2) {
        var checker = new VitalSignsChecker();
        return checker.AreVitalsOk(temperature, pulseRate, spo2);
    }

    public static bool VitalsOk(float temperature, int pulseRate, int spo2, PatientCategory patientCategory) {
        var checker = new VitalSignsChecker();
        return checker.AreVitalsOk(temperature, pulseRate, spo2, patientCategory);
    }
}

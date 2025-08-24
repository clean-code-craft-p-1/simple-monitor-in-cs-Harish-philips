using VitalSignsMonitoring;

namespace checker {
    public static class VitalSignFactory {

        public static VitalSign CreateTemperature(float value, VitalSignRange range) {
            return new VitalSign("Temperature", value,
                range.Temperature.Lower,
                range.Temperature.Upper);
        }

        public static VitalSign CreatePulseRate(int value, VitalSignRange range) {
            return new VitalSign("Pulse Rate", value,
                range.PulseRate.Lower,
                range.PulseRate.Upper);
        }

        public static VitalSign CreateSpo2(int value, VitalSignRange range) {
            return new VitalSign("Oxygen Saturation", value,
                range.Spo2.Lower,
                range.Spo2.Upper);
        }
    }
}

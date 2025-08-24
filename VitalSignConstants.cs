namespace VitalSignsMonitoring {

    /// <summary>
    /// Constants for vital sign ranges for all patient categories.
    /// </summary>
    public static class VitalSignConstants {
        // Adult vital sign ranges
        // Temperature ranges (in Fahrenheit)
        public const float AdultTemperatureLowerLimit = 95.0f;
        public const float AdultTemperatureUpperLimit = 102.0f;

        // Pulse rate ranges (beats per minute)
        public const float AdultPulseRateLowerLimit = 60.0f;
        public const float AdultPulseRateUpperLimit = 100.0f;

        // SPO2 ranges (percentage)
        public const float AdultSpo2LowerLimit = 90.0f;
        public const float AdultSpo2UpperLimit = 100.0f;

        // Child vital sign ranges
        // Temperature ranges (in Fahrenheit)
        public const float ChildTemperatureLowerLimit = 96.0f;
        public const float ChildTemperatureUpperLimit = 102.0f;

        // Pulse rate ranges (beats per minute)
        public const float ChildPulseRateLowerLimit = 70.0f;
        public const float ChildPulseRateUpperLimit = 120.0f;

        // SPO2 ranges (percentage)
        public const float ChildSpo2LowerLimit = 94.0f;
        public const float ChildSpo2UpperLimit = 100.0f;

        // Infant vital sign ranges
        // Temperature ranges (in Fahrenheit)
        public const float InfantTemperatureLowerLimit = 97.0f;
        public const float InfantTemperatureUpperLimit = 100.0f;

        // Pulse rate ranges (beats per minute)
        public const float InfantPulseRateLowerLimit = 80.0f;
        public const float InfantPulseRateUpperLimit = 160.0f;

        // SPO2 ranges (percentage)
        public const float InfantSpo2LowerLimit = 95.0f;
        public const float InfantSpo2UpperLimit = 100.0f;

        // Legacy constants for backward compatibility
        public const float TemperatureLowerLimit = AdultTemperatureLowerLimit;
        public const float TemperatureUpperLimit = AdultTemperatureUpperLimit;
        public const float PulseRateLowerLimit = AdultPulseRateLowerLimit;
        public const float PulseRateUpperLimit = AdultPulseRateUpperLimit;
        public const float Spo2LowerLimit = AdultSpo2LowerLimit;
        public const float Spo2UpperLimit = AdultSpo2UpperLimit;
    }
}

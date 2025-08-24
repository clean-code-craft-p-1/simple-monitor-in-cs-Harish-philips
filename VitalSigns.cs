using System;

namespace VitalSignsMonitoring {
    public class VitalSign {
        public string Name { get; }
        public float Value { get; }
        public float LowerLimit { get; }
        public float UpperLimit { get; }

        public VitalSign(string name, float value, float lowerLimit, float upperLimit) {
            Name = name;
            Value = value;
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
        }

        public bool IsWithinLimits() {
            return Value >= LowerLimit && Value <= UpperLimit;
        }

        public string GetAlertMessage() {
            return $"{Name} out of range!";
        }
    }
}

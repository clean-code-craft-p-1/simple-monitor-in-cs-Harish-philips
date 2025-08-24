
namespace checker {
    public class Range {
        public float Lower { get; set; }
        public float Upper { get; set; }

        public Range(float lower, float upper) {
            Lower = lower;
            Upper = upper;
        }
    }

    public class VitalSignRange {
        public Range Temperature { get; set; }
        public Range PulseRate { get; set; }
        public Range Spo2 { get; set; }
    }
}

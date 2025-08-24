
namespace VitalSignsMonitoring {
    public class ConsoleAlertReporter : IAlertReporter {
        public void ReportAlert(string message) {
            Console.WriteLine(message);
            // Visual blinking alert
            for (int i = 0; i < 6; i++) {
                Console.Write("\r* ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\r *");
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void ReportNormal(IEnumerable<VitalSign> vitalSigns) {
            Console.WriteLine("Vitals received within normal range");

            foreach (var vitalSign in vitalSigns) {
                Console.WriteLine($"{vitalSign.Name}: {vitalSign.Value}");
            }
        }
    }
}

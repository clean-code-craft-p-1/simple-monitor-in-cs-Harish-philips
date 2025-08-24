using Xunit;
using Moq;

using VitalSignsMonitoring;

public class CheckerTests {

    [Fact]
    public void NotOkWhenAnyVitalIsOffRange() {
        // Legacy tests - using original interface
        Assert.False(Checker.VitalsOk(99f, 102, 70)); // Pulse rate out of range
        Assert.True(Checker.VitalsOk(98.1f, 70, 98));  // All vitals within range
    }

    [Theory]
    [InlineData(94.9f, 70, 95, false)]  // Temperature too low
    [InlineData(102.1f, 70, 95, false)] // Temperature too high
    [InlineData(98f, 59, 95, false)]    // Pulse too low
    [InlineData(98f, 101, 95, false)]   // Pulse too high
    [InlineData(98f, 70, 89, false)]    // SPO2 too low
    [InlineData(98f, 70, 95, true)]     // All vitals ok
    public void CheckerShouldDetectVitalRanges(float temperature, int pulseRate, int spo2, bool expectedResult) {
        // Arrange - use a mock reporter to avoid console output during tests
        var mockReporter = new Mock<IAlertReporter>();
        var checker = new VitalSignsChecker(mockReporter.Object);

        // Act
        var result = checker.AreVitalsOk(temperature, pulseRate, spo2);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ReporterShouldBeCalledWithCorrectMessageWhenVitalsNotOk() {
        // Arrange
        var mockReporter = new Mock<IAlertReporter>();
        var checker = new VitalSignsChecker(mockReporter.Object);

        // Act - Temperature out of range
        checker.AreVitalsOk(104f, 70, 95);

        // Assert - verify that the alert was reported with the correct message
        mockReporter.Verify(r => r.ReportAlert("Temperature out of range!"), Times.Once);
    }
}
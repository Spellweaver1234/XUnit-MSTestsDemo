using Moq;

using Xunit;

namespace ReporterApp
{
    public class ReporterTests
    {
        [Fact]
        public void ReturnNumberOfSentReports()
        {
            var reportBuilder = new Mock<IReportBuilder>();
            var reportSender = new Mock<IReportSender>();

            // задаем поведение для интерфейса IReportBuilder
            // Здесь говорится: "При вызове функции CreateReports вернуть List<Report> состоящий из 2х объектов"
            reportBuilder
                .Setup(m => m.CreateRegularReports())
                .Returns(new List<Report> { new Report(), new Report() });

            var reporter = new Reporter(reportBuilder.Object, reportSender.Object);

            var reportCount = reporter.SendReports();

            Assert.Equal(2, reportCount);
        }

        [Fact]
        public void Equal2and2()
        {
            Assert.Equal(2, 2);
        }
    }
}
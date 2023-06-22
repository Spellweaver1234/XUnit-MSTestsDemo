namespace ReporterApp
{
    public class Reporter
    {
        private readonly IReportBuilder reportBuilder;
        private readonly IReportSender reportSender;

        public Reporter(IReportBuilder reportBuilder, IReportSender reportSender)
        {
            this.reportBuilder = reportBuilder;
            this.reportSender = reportSender;
        }

        public int SendReports()
        {
            return reportBuilder.CreateRegularReports().Count;
        }
    }
}
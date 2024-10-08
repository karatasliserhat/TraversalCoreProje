namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IApiSetting
    {
        string AboutControllerBaseUrl { get; set; }
        string About2ControllerBaseUrl { get; set; }
        string ContactControllerBaseUrl { get; set; }
        string DestinationControllerBaseUrl { get; set; }
        string FeatureControllerBaseUrl { get; set; }
        string Feature2ControllerBaseUrl { get; set; }
        string GuideControllerBaseUrl { get; set; }
        string NewsLetterControllerBaseUrl { get; set; }
        string SubAboutControllerBaseUrl { get; set; }
        string TestimonialControllerBaseUrl { get; set; }
        string StatisticsControllerBaseUrl { get; set; }
        string CommentsControllerBaseUrl { get; set; }
        public string AccountControllerBaseUrl { get; set; }
        public string UserControllerBaseUrl { get; set; }
        public string ReserVationControllerBaseUrl { get; set; }
        public string ExcelReportControllerBaseUrl { get; set; }
    }
}

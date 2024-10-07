namespace TraversalCoreProje.ViewModels
{
    public class ResultReservationViewModel:ResultBaseViewModel
    {
        public int AppUserId { get; set; }
        public string PersonCount { get; set; }
        public int DestinationId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string DestinationCityName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string StatusL { get; set; }
        public string PersonNameSurname { get => PersonName + " " + PersonSurname; }
        public string DataProtect { get; set; }
    }
}

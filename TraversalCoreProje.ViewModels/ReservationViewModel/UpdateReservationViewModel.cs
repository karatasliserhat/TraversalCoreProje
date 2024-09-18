namespace TraversalCoreProje.ViewModels
{
    public class UpdateReservationViewModel:UpdateBaseViewModel
    {
        public int AppUserId { get; set; }
        public string PersonCount { get; set; }
        public int DestinationId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string StatusL { get; set; }
    }
}

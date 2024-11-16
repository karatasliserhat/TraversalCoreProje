
namespace TraversalCoreProje.ViewModels
{
    public class BookingExchangeDataViewModel
    {
        public string base_currency_date { get; set; }
        public string base_currency { get; set; }
        public ExchangeRateViewModel[] exchange_rates { get; set; }
    }
}

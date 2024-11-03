namespace WeddingManagement.Models
{
    public class BookedEvents
    {
        public int BookedEventsId { get; set; }
        public string EventType { get; set; }
        public string CustomerName { get; set; }
        public int CustomerNumber { get; set; }
        public string IsItBooked { get; set; }
    }
}

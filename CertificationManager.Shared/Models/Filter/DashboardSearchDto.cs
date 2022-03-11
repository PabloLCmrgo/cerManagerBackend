namespace CertificationManager.Shared.Models.Filter
{
    public class DashboardSearchDto : ISearchable
    {
        public int? OrderNo { get; set; }
        public int? ProbillNo { get; set; }
        public string PoNumber { get; set; }
        public string PickupNumber { get; set; }
        public string DeliveryNumber { get; set; }
        public int? TripNo { get; set; }
        public string DriverCode { get; set; }
        public string Truck { get; set; }
        public string Trailer { get; set; }
        public string BolNo { get; set; }
    }
}

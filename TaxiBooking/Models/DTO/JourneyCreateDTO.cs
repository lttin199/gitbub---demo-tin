using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaxiBooking.Models.DTO
{
    public class JourneyCreateDTO
    {
        public string CustomerId { get; set; }
        public string DriverId { get; set; }
        public string LicensePlate { get; set; }
        public string StartAddr { get; set; }
        public float StartLat { get; set; }
        public float StartLng { get; set; }
        public string EndAddr { get; set; }
        public float EndLat { get; set; }
        public float EndLng { get; set; }
        public float Distance { get; set; }
        public TimeOnly TimeStart { get; set; }
        public int State { get; set; }
        public float TotalPrice { get; set; }

    }
}

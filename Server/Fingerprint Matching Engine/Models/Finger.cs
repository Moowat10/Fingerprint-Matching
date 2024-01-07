using System.ComponentModel.DataAnnotations;

namespace FingerprintMatchingEngine.Models
{
    public class Finger
    {
        [Key]
        public int FingerId { get; set; }

        [Obsolete]
        [Required]
        public string EmpolyeeID { get; set; }

        [Required]
        public string LedgerID { get; set; }

        [Required]
        public string EmployeeFinger { get; set; }


    }
}
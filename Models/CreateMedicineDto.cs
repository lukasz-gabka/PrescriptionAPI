using System.ComponentModel.DataAnnotations;

namespace PrescriptionAPI.Models
{
    public class CreateMedicineDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Dosage { get; set; }
        [Required]
        public int TreatmentTime { get; set; }
        [StringLength(300)]
        public string? Comment { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public int? FirstDayException { get; set; }
        public int? LastDayException { get; set; }
        [Required]
        public string DosageString { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace PrescriptionAPI.Models
{
    public class CreatePatientDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        public string Symptoms { get; set; }
        [MinLength(1)]
        public virtual IEnumerable<CreateMedicineDto> Medicines { get; set; }
    }
}
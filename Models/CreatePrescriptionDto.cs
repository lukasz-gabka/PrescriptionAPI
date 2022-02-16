using System.ComponentModel.DataAnnotations;

namespace PrescriptionAPI.Models
{
    public class CreatePrescriptionDto
    {
        public bool IsActive { get; set; } = true;
        [MinLength(1)]
        public virtual IEnumerable<CreatePatientDto> Patients { get; set; }
    }
}

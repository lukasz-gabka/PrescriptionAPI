using System.ComponentModel.DataAnnotations;

namespace PrescriptionAPI.Models;

public class PatientDto
{
    public int Id { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(300)]
    public string Symptoms { get; set; }
    public virtual IEnumerable<MedicineDto> Medicines { get; set; }
    public int PrescriptionId { get; set; }
}

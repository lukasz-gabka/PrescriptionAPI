namespace PrescriptionAPI.Models;

public class PrescriptionDto
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public virtual IEnumerable<PatientDto> Patients { get; set; }
}

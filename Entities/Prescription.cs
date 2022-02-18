namespace PrescriptionAPI.Entities;

public class Prescription
{
    public int Id { get; set; }
    public bool IsActive { get; set; } = true;
    public virtual IEnumerable<Patient> Patients { get; set; }
}

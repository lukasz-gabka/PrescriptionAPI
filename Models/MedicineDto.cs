using System.ComponentModel.DataAnnotations;

namespace PrescriptionAPI.Models;

public class MedicineDto
{
    public int Id { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    public int Dosage { get; set; }
    public int TreatmentTime { get; set; }
    [StringLength(300)]
    public string? Comment { get; set; }
    public DateTime StartDate { get; set; }
    public int? FirstDayException { get; set; }
    public int? LastDayException { get; set; }
    public string DosageString { get; set; }
    public int PatientId { get; set; }
}

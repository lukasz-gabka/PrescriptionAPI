using System.Text.Json.Serialization;

namespace PrescriptionAPI.Entities;

public class Medicine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Dosage { get; set; }
    public int TreatmentTime { get; set; }
    public string? Comment { get; set; }
    public DateTime StartDate { get; set; }
    public int? FirstDayException { get; set; }
    public int? LastDayException { get; set; }
    public string DosageString { get; set; }
    public int PatientId { get; set; }
    [JsonIgnore]
    public virtual Patient Patient { get; set; }
}

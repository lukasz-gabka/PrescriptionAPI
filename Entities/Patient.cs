using System.Text.Json.Serialization;

namespace PrescriptionAPI.Entities;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Symptoms { get; set; }
    public virtual IEnumerable<Medicine> Medicines { get; set; }
    public int PrescriptionId { get; set; }
    [JsonIgnore]
    public virtual Prescription Prescription { get; set; }
}

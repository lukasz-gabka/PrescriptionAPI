using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PrescriptionAPI.Entities;

public class Patient
{
    public int Id { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(300)]
    public string Symptoms { get; set; }
    public virtual IEnumerable<Medicine> Medicines { get; set; }
    public int PrescriptionId { get; set; }
    [JsonIgnore]
    public virtual Prescription Prescription { get; set; }
}

using AutoMapper;
using PrescriptionAPI.Entities;
using PrescriptionAPI.Models;

namespace PrescriptionAPI;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreatePrescriptionDto, Prescription>();
        CreateMap<CreatePatientDto, Patient>();
        CreateMap<CreateMedicineDto, Medicine>();
    }
}

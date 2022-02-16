using AutoMapper;
using PrescriptionAPI.Entities;
using PrescriptionAPI.Models;

namespace PrescriptionAPI.Services;

public class PrescriptionService
{
    private readonly ApiDbContext _dbContext;
    private readonly IMapper _mapper;

    public PrescriptionService(ApiDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public int Create(CreatePrescriptionDto dto)
    {
        var prescription = _mapper.Map<Prescription>(dto);

        _dbContext.Add(prescription);
        _dbContext.SaveChanges();

        return prescription.Id;
    }
}

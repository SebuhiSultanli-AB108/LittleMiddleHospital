using AutoMapper;
using LittleMiddleHospital.BL.DTOs;
using LittleMiddleHospital.Core.Entities;
using LittleMiddleHospital.Core.RepositoryInterfaces;

namespace LittleMiddleHospital.BL.Service.PatienceService;

public class PatienceService(IPatienceRepository _repository, IMapper _mapper) : IPatienceService
{
    public async Task CreatePatience(PatientCreateDTO dto)
    {
        await _repository.AddAsync(_mapper.Map<Patient>(dto));
    }

    public async Task DeletePatience(int id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public List<Patient> GetAllPatience()
    {
        return _mapper.Map<List<Patient>>(_repository.GetAll());
    }

    public async Task<Patient?> GetPatienceById(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
}
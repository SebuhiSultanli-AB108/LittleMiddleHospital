using AutoMapper;
using LittleMiddleHospital.BL.DTOs;
using LittleMiddleHospital.Core.Entities;
using LittleMiddleHospital.Core.RepositoryInterfaces;

namespace LittleMiddleHospital.BL.Service.InsuranceServices;

public class InsuranceService(IInsuranceRepository _repository, IMapper _mapper) : IInsuranceService
{
    public async Task CreatePatience(InsuranceCreateDTO dto)
    {
        await _repository.AddAsync(_mapper.Map<Insurance>(dto));
    }

    public async Task DeletePatience(int id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public List<Insurance> GetAllPatience()
    {
        return _mapper.Map<List<Insurance>>(_repository.GetAll());
    }

    public async Task<Insurance?> GetPatienceById(int id)
    {
        return await _repository.GetByIdAsync(id);
    }
}
using LittleMiddleHospital.Core.Entities;
using LittleMiddleHospital.Core.RepositoryInterfaces;
using LittleMiddleHospital.DAL.Context;

namespace LittleMiddleHospital.DAL.RepositoryImplements;

public class InsuranceRepository : GenericRepository<Insurance>, IInsuranceRepository
{
    readonly SqlServer _context;
    public InsuranceRepository(SqlServer context) : base(context)
    {
        _context = context;
    }
}
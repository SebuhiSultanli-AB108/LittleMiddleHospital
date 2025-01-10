using LittleMiddleHospital.Core.Entities;
using LittleMiddleHospital.Core.RepositoryInterfaces;
using LittleMiddleHospital.DAL.Context;

namespace LittleMiddleHospital.DAL.RepositoryImplements;

public class PatienceRepository : GenericRepository<Patient>, IPatienceRepository
{
    readonly SqlServer _context;
    public PatienceRepository(SqlServer context) : base(context)
    {
        _context = context;
    }
}
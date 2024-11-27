using System.Linq.Expressions;
using OPDispensary.System.Entity;

namespace OPDispensary.System.Services.DMS.Drug;

public interface ISysDrugService : ITransient
{
    public Task<List<DMSDrug>> GetDrugList(Expression<Func<DMSDrug, bool>> whereExpression);
    public Task<DMSDrug> GetDrug(Expression<Func<DMSDrug, bool>> whereExpression);
    public Task<DMSDrug> AddDrug(DMSDrug drug);
    public Task<bool> UpdateDrug(DMSDrug drug);
}
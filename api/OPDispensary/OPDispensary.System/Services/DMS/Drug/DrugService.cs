using System.Linq.Expressions;
using OPDispensary.System.Entity;

namespace OPDispensary.System.Services.DMS.Drug;

public class DrugService : DbRepository<DMSDrug>, IDrugService
{
    public async Task<List<DMSDrug>> GetDrugList(Expression<Func<DMSDrug, bool>> whereExpression)
    {
        return await Context.Queryable<DMSDrug>().Where(whereExpression).ToListAsync();
    }

    public async Task<DMSDrug> GetDrug(Expression<Func<DMSDrug, bool>> whereExpression)
    {
        return await Context.Queryable<DMSDrug>().FirstAsync(whereExpression);
    }

    public async Task<DMSDrug> AddDrug(DMSDrug drug)
    {
        return await Context.Insertable(drug).ExecuteReturnEntityAsync();
    }

    public async Task<bool> UpdateDrug(DMSDrug drug)
    {
        return await Context.Updateable(drug).ExecuteCommandAsync() > 0;
    }
}
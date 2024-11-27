using System.Linq.Expressions;
using MySqlConnector;
using OPDispensary.System.Entity;

namespace OPDispensary.System.Services.DMS.Drug;

public class SysSysDrugService : DbRepository<DMSDrug>, ISysDrugService
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
        try
        {
            var result = await Context.Insertable(drug).ExecuteReturnEntityAsync();
            return result;
        }
        catch (MySqlException ex) when (ex.Message.Contains("unique_Name"))
        {
            throw new InvalidOperationException("药品名称已存在，请检查后重试。", ex);
        }
        catch (MySqlException ex)
        {
            throw new InvalidOperationException("数据库操作失败，请稍后再试。", ex);
        }
    }

    public async Task<bool> UpdateDrug(DMSDrug drug)
    {
        return await Context.Updateable(drug).ExecuteCommandAsync() > 0;
    }
}
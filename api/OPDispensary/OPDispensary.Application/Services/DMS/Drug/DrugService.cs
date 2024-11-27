using Microsoft.Extensions.Logging;
using OPDispensary.Application.Services.DMS.Drug.Dto;
using OPDispensary.System.Entity;
using OPDispensary.System.Services.DMS.Drug;
using Mapper = MapsterMapper.Mapper;

namespace OPDispensary.Application.Services.DMS.Drug;

public class DrugService : DbRepository<DMSDrug>, IDrugService
{
    private readonly ISysDrugService _sysDrugService;
    private readonly ILogger<ILogger> _logger;
    public DrugService(ISysDrugService sysDrugService, ILogger<ILogger> logger)
    {
        _sysDrugService = sysDrugService;
        _logger = logger;
    }
    public async Task<dynamic> Add(AddDrugInput input)
    {
        return await _sysDrugService.AddDrug(input.Adapt<DMSDrug>());
    }

    public async Task<bool> Delete(BaseIdListInput input)
    {
        throw new NotImplementedException();
    }

    public async Task<DMSDrug> Detail(BaseIdInput input)
    {
        throw new NotImplementedException();
    }

    public async Task<dynamic> Edit(EditDrugInput input)
    {
        throw new NotImplementedException();
    }

    public async Task<dynamic> Export(DrugPageInput input)
    {
        throw new NotImplementedException();
    }

    public async Task<ImportResultOutPut<AddDrugInput>> Import(ImportResultInput<AddDrugInput> input)
    {
        throw new NotImplementedException();
    }

    public async Task<SqlSugarPagedList<DMSDrug>> Page(DrugPageInput input)
    {
        throw new NotImplementedException();
    }
}
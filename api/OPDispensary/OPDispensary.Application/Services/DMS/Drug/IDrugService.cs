using OPDispensary.Application.Services.DMS.Drug.Dto;
using OPDispensary.System.Entity;

namespace OPDispensary.Application.Services.DMS.Drug;

public interface IDrugService : ITransient
{
    Task<dynamic> Add(AddDrugInput input);

    Task<bool> Delete(BaseIdListInput input);

    Task<DMSDrug> Detail(BaseIdInput input);

    Task<dynamic> Edit(EditDrugInput input);

    Task<dynamic> Export(DrugPageInput input);

    Task<ImportResultOutPut<AddDrugInput>> Import(ImportResultInput<AddDrugInput> input);

    Task<SqlSugarPagedList<DMSDrug>> Page(DrugPageInput input);
    
}
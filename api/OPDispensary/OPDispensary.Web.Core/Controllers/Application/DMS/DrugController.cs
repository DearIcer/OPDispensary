using Microsoft.AspNetCore.Mvc;
using OPDispensary.Application.Services.DMS.Drug;
using OPDispensary.Application.Services.DMS.Drug.Dto;

namespace OPDispensary.Web.Core.Controllers.Application.DMS;

[ApiDescriptionSettings("Application", Tag = "药品管理")]
[Route("biz/dms/drug")]
[RolePermission]
public class DrugController : IDynamicApiController
{
    private  readonly IDrugService _drugService;
    public DrugController(IDrugService drugService)
    {
        _drugService = drugService;
    }
    
    /// <summary>
    ///     添加药品
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost("add")]
    [DisplayName("添加药品")]
    public async Task<dynamic> Add([FromBody] AddDrugInput input)
    {
        return await _drugService.Add(input);
    }
}
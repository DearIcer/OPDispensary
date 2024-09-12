using System.ComponentModel.DataAnnotations;
using OPDispensary.System.Entity;

namespace OPDispensary.Application.Services.DMS.Drug.Dto;

public class AddDrugInput
{
    /// <summary>
    ///     药品编码
    /// </summary>
    [Required]
    public virtual string DrugCode { get; set; }

    /// <summary>
    ///     药品名称
    /// </summary>
    [Required]
    public virtual string Name { get; set; }

    /// <summary>
    ///     生产厂家
    /// </summary>
    [Required]
    public virtual string Manufacturer { get; set; }

    /// <summary>
    ///     规格
    /// </summary>
    [Required]
    public virtual string Specification { get; set; }

    /// <summary>
    ///     单位
    /// </summary>
    [Required]
    public DrugUnit Unit { get; set; }

    /// <summary>
    ///     剂型
    /// </summary>
    [Required]
    public DosageForm DosageForm { get; set; }

    /// <summary>
    ///     包装
    /// </summary>
    [Required]
    public virtual string Packaging { get; set; }

    /// <summary>
    ///     药品类型
    /// </summary>
    [Required]
    public DrugType DrugType { get; set; }

    /// <summary>
    ///     药品描述
    /// </summary>
    [Required]
    public virtual string Description { get; set; }

    /// <summary>
    ///     药品状态
    /// </summary>
    [Required]
    public DrugStatus DrugStatus { get; set; }

    /// <summary>
    ///     价格
    /// </summary>
    [Required]
    public decimal Price { get; set; }

    /// <summary>
    ///     库存数量
    /// </summary>
    [Required]
    public virtual int StockQuantity { get; set; }

    /// <summary>
    ///     过期日期
    /// </summary>
    [Required]
    public DateTime ExpiryDate { get; set; }

    /// <summary>
    ///     供应商ID
    /// </summary>
    [Required]
    public virtual int SupplierID { get; set; }
}
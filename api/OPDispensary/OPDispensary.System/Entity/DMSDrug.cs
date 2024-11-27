using System.ComponentModel;

namespace OPDispensary.System.Entity;

[SugarTable("dms_drug", TableDescription = "药品表")]
[SugarIndex("unique_Name",nameof(DMSDrug.Name),OrderByType.Desc,true)]
[Tenant(SqlSugarConst.DB_DEFAULT)]
public class DMSDrug : BaseEntity
{
    [Required]
    [SugarColumn(ColumnName = "DrugCode", ColumnDescription = "药品编码")]
    public virtual string DrugCode { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Name", ColumnDescription = "药品名称")]
    public virtual string Name { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Manufacturer", ColumnDescription = "生产厂家")]
    public virtual string Manufacturer { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Specification", ColumnDescription = "规格")]
    public virtual string Specification { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Unit", ColumnDescription = "单位")]
    public DrugUnit Unit { get; set; }

    [Required]
    [SugarColumn(ColumnName = "DosageForm", ColumnDescription = "剂型")]
    public DosageForm DosageForm { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Packaging", ColumnDescription = "包装")]
    public virtual string Packaging { get; set; }

    [Required]
    [SugarColumn(ColumnName = "DrugType", ColumnDescription = "药品类型")]
    public DrugType DrugType { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Description", ColumnDescription = "药品描述")]
    public virtual string Description { get; set; }

    [Required]
    [SugarColumn(ColumnName = "DrugStatus", ColumnDescription = "药品状态")]
    public DrugStatus DrugStatus { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Price", ColumnDescription = "价格")]
    public decimal Price { get; set; }

    [Required]
    [SugarColumn(ColumnName = "StockQuantity", ColumnDescription = "库存数量")]
    public virtual int StockQuantity { get; set; }

    [Required]
    [SugarColumn(ColumnName = "ExpiryDate", ColumnDescription = "过期日期")]
    public DateTime ExpiryDate { get; set; }

    [Required]
    [SugarColumn(ColumnName = "SupplierID", ColumnDescription = "供应商ID")]
    public virtual long SupplierID { get; set; }
    
    [Required]
    [SugarColumn(ColumnName = "IsDelete", ColumnDescription = "软删除")]
    public virtual bool IsDelete { get; set; }
}

public enum DrugStatus
{
    [Description("在库")] IN_STOCK,
    [Description("缺货")] OUT_OF_STOCK
}

public enum DrugType
{
    [Description("处方")] PRESCRIPTION,
    [Description("非处方")] NON_PRESCRIPTION
}

public enum DosageForm
{
    [Description("片剂")] PILL,
    [Description("盒剂")] BOX,
    [Description("瓶剂")] BOTTLE,
    [Description("Tube")] TUBE
}

public enum DrugUnit
{
    [Description("盒")] BOX,
    [Description("瓶")] BOTTLE,
    [Description("支")] BRANCH,
    [Description("片")] PILL
}
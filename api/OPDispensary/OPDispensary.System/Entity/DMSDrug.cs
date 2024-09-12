using System.ComponentModel;

namespace OPDispensary.System.Entity;

[SugarTable("dms_drug", TableDescription = "药品表")]
[Tenant(SqlSugarConst.DB_DEFAULT)]
public class DMSDrug : BaseEntity
{
    [SugarColumn(ColumnName = "DrugID", ColumnDescription = "药品ID")]
    public int DrugID { get; set; }

    [SugarColumn(ColumnName = "DrugCode", ColumnDescription = "药品编码")]
    public virtual string DrugCode { get; set; }

    [SugarColumn(ColumnName = "Name", ColumnDescription = "药品名称")]
    public virtual string Name { get; set; }

    [SugarColumn(ColumnName = "Manufacturer", ColumnDescription = "生产厂家")]
    public virtual string Manufacturer { get; set; }

    [SugarColumn(ColumnName = "Specification", ColumnDescription = "规格")]
    public virtual string Specification { get; set; }

    [SugarColumn(ColumnName = "Unit", ColumnDescription = "单位")]
    public DrugUnit Unit { get; set; }

    [SugarColumn(ColumnName = "DosageForm", ColumnDescription = "剂型")]
    public DosageForm DosageForm { get; set; }

    [SugarColumn(ColumnName = "Packaging", ColumnDescription = "包装")]
    public virtual string Packaging { get; set; }

    [SugarColumn(ColumnName = "DrugType", ColumnDescription = "药品类型")]
    public DrugType DrugType { get; set; }

    [SugarColumn(ColumnName = "Description", ColumnDescription = "药品描述")]
    public virtual string Description { get; set; }

    [SugarColumn(ColumnName = "DrugStatus", ColumnDescription = "药品状态")]
    public DrugStatus DrugStatus { get; set; }

    [SugarColumn(ColumnName = "Price", ColumnDescription = "价格")]
    public decimal Price { get; set; }

    [SugarColumn(ColumnName = "StockQuantity", ColumnDescription = "库存数量")]
    public virtual int StockQuantity { get; set; }

    [SugarColumn(ColumnName = "ExpiryDate", ColumnDescription = "过期日期")]
    public DateTime ExpiryDate { get; set; }

    [SugarColumn(ColumnName = "SupplierID", ColumnDescription = "供应商ID")]
    public virtual int SupplierID { get; set; }
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
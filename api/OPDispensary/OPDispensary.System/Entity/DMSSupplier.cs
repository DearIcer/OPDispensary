using System.ComponentModel;

namespace OPDispensary.Application.Entity;

[SugarTable("dms_supplier", TableDescription = "供应商表")]
[Tenant(SqlSugarConst.DB_DEFAULT)]
public class DMSSupplier : BaseEntity
{   
    [Required]
    [SugarColumn(ColumnName = "SupplierCode", ColumnDescription = "供应商编码")]
    public virtual string SupplierCode { get; set; }

    [Required]
    [SugarColumn(ColumnName = "SupplierName", ColumnDescription = "供应商名称")]
    public virtual string SupplierName { get; set; }

    [Required]
    [SugarColumn(ColumnName = "ContactPerson", ColumnDescription = "联系人")]
    public virtual string ContactPerson { get; set; }

    [Required]
    [SugarColumn(ColumnName = "ContactNumber", ColumnDescription = "联系电话")]
    public virtual string ContactNumber { get; set; }

    [Required]
    [SugarColumn(ColumnName = "SupplierType", ColumnDescription = "供应商类型")]
    public SupplierType SupplierType { get; set; }

    [SugarColumn(ColumnName = "Remark", ColumnDescription = "备注")]
    public virtual string Remark { get; set; }

    [Required]
    [SugarColumn(ColumnName = "SupplierStatus", ColumnDescription = "供应商状态")]
    public virtual SupplierStatus SupplierStatus { get; set; }

    [Required]
    [SugarColumn(ColumnName = "Address", ColumnDescription = "地址")]
    public virtual string Address { get; set; }
}

public enum SupplierType
{
    [Description("供应商")] SUPPLIER,
    [Description("客户")] CUSTOMER
}

public enum SupplierStatus
{
    [Description("启用")] ENABLE,
    [Description("停用")] DISABLE
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcadmin10.Models
{
    [ModelMetadataType(typeof(z_metaWarehouses))]
    public partial class Warehouses
    {

    }
}

public class z_metaWarehouses
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "倉庫編號")]
    public string? WarehouseNo { get; set; }
    [Display(Name = "倉庫名稱")]
    public string? WarehouseName { get; set; }
    [Display(Name = "備註")]
    public string? Remark { get; set; }
}
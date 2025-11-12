namespace mvcadmin10.Models
{
    [ModelMetadataType(typeof(z_metaWorkflowRoutes))]
    public partial class WorkflowRoutes
    {

    }
}
public class z_metaWorkflowRoutes
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "程式代號")]
    public string? PrgNo { get; set; }
    [Display(Name = "路線順序")]
    public string? RouteOrder { get; set; }
    [Display(Name = "角色代號")]
    public string? RoleNo { get; set; }
    [Display(Name = "角色名稱")]
    public string? RoleName { get; set; }
    [Display(Name = "備註")]
    public string? Remark { get; set; }
}

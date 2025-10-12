using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcadmin10.Models
{
    public class z_sqlWarehouses : DapperSql<Warehouses>
    {
        public z_sqlWarehouses()
        {
            OrderByColumn = SessionService.SortColumn;
            OrderByDirection = SessionService.SortDirection;
            DefaultOrderByColumn = "Warehouses.WarehouseNo";
            DefaultOrderByDirection = "ASC";
            DropDownValueColumn = "Warehouses.WarehouseNo";
            DropDownTextColumn = "Warehouses.WarehouseName";
            DropDownOrderColumn = "Warehouses.WarehouseNo ASC";
            if (string.IsNullOrEmpty(OrderByColumn)) OrderByColumn = DefaultOrderByColumn;
            if (string.IsNullOrEmpty(OrderByDirection)) OrderByDirection = DefaultOrderByDirection;
        }
    }
}
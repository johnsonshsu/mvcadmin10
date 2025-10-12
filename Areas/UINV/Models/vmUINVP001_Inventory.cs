using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcadmin10.Models
{
    /// <summary>
    /// UINVP002 - 進貨入庫單 ViewModel
    /// </summary>
    public class vmUINVP001_Inventory : BaseClass
    {
        /// <summary>
        /// UINVP002 - 進貨入庫單表頭檔
        /// </summary>
        public Inventorys InventoryModel { get; set; } = new Inventorys();
        /// <summary>
        /// UINVP002 - 進貨入庫單明細檔
        /// </summary>
        public List<InventorysDetail> InventorysDetailModel { get; set; } = new List<InventorysDetail>();

        public vmUINVP001_Inventory()
        {
            using var sqlInventorys = new z_sqlInventorys();
            using var sqlInventorysDetail = new z_sqlInventorysDetail();
            InventoryModel = sqlInventorys.GetMasterData();
            string baseNo = (InventoryModel == null) ? "" : InventoryModel.BaseNo;
            InventorysDetailModel = sqlInventorysDetail.GetDataList(baseNo);
        }
    }
}
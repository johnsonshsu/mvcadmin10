using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcadmin10.Models
{
    public class vmUINVP004_WarehouseStatus : BaseClass
    {
        /// <summary>
        /// UINVP002 - 進貨入庫單表頭檔
        /// </summary>
        public Warehouses MasterModel { get; set; } = new Warehouses();
        /// <summary>
        /// UINVP002 - 進貨入庫單明細檔
        /// </summary>
        public List<InvDetails> DetailModel { get; set; } = new List<InvDetails>();

        public vmUINVP004_WarehouseStatus()
        {
            using var sqlMaster = new z_sqlWarehouses();
            using var sqlDetail = new z_sqlInvDetails();
            MasterModel = sqlMaster.GetMasterData();
            if (MasterModel == null) MasterModel = new Warehouses();
            string baseNo = (MasterModel == null) ? "" : MasterModel.WarehouseNo;
            DetailModel = sqlDetail.GetWarehouseDataList(baseNo);
            if (DetailModel == null) DetailModel = new List<InvDetails>();
        }
    }
}
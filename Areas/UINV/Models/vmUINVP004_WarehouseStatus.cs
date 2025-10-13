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
        public Warehouses InvMastersModel { get; set; } = new Warehouses();
        /// <summary>
        /// UINVP002 - 進貨入庫單明細檔
        /// </summary>
        public List<InvDetails> InvDetailsModel { get; set; } = new List<InvDetails>();

        public vmUINVP004_WarehouseStatus()
        {
            using var sqlMaster = new z_sqlWarehouses();
            using var sqlDetail = new z_sqlInvDetails();
            InvMastersModel = sqlMaster.GetMasterData();
            if (InvMastersModel == null) InvMastersModel = new Warehouses();
            string baseNo = (InvMastersModel == null) ? "" : InvMastersModel.WarehouseNo;
            InvDetailsModel = sqlDetail.GetWarehouseDataList(baseNo);
            if (InvDetailsModel == null) InvDetailsModel = new List<InvDetails>();
        }
    }
}
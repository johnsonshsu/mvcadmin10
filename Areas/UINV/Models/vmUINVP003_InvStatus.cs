using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcadmin10.Models
{
    public class vmUINVP003_InvStatus : BaseClass
    {
        /// <summary>
        /// UINVP002 - 進貨入庫單表頭檔
        /// </summary>
        public InvMasters InvMastersModel { get; set; } = new InvMasters();
        /// <summary>
        /// UINVP002 - 進貨入庫單明細檔
        /// </summary>
        public List<InvDetails> InvDetailsModel { get; set; } = new List<InvDetails>();

        public vmUINVP003_InvStatus()
        {
            using var sqlMaster = new z_sqlInvMasters();
            using var sqlDetail = new z_sqlInvDetails();
            InvMastersModel = sqlMaster.GetMasterData();
            if (InvMastersModel == null) InvMastersModel = new InvMasters();
            string baseNo = (InvMastersModel == null) ? "" : InvMastersModel.ProductNo;
            InvDetailsModel = sqlDetail.GetDataList(baseNo);
            if (InvDetailsModel == null) InvDetailsModel = new List<InvDetails>();
        }
    }
}
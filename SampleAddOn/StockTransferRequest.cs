using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXS.Retail.Extensibility.Modules.Inventory;
using CXS.SubSystem.Inventory;
using System.Windows.Forms;
using CXS.Retail.Extensibility;

namespace SampleAddOnForMCEvents
{
    class StockTransferRequest : StockTransferRequestViewModuleBase
    {
        /// <summary>
        /// On Before Cancel on StockTransferRequestAddEditView under Business Transactions .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>

        public override void OnBeforeSave(object sender, EventArgs<CXS.SubSystem.Inventory.StockTransferRequest> args)
        {
            if(args.Item.RequestNumber != args.Item.Id)
            {
                args.Cancel = true;
                args.Message = "Stock transfer request number must match with request number";
                args.MessageType = CXS.Retail.ViewModel.Message.MessageType.Error;
            }
        }

    }
}

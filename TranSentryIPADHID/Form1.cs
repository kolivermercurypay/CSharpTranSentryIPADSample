using System;
using System.Windows.Forms;

namespace TranSentryIPADHID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwiped_Click(object sender, EventArgs e)
        {
            ProcessIPAD(false);
        }

        private void btnKeyed_Click(object sender, EventArgs e)
        {
            ProcessIPAD(true);
        }

        private static void ProcessIPAD(bool isManual)
        {
            //Declare initial objects
            Transaction.Request saleRequest = new Transaction.Request();
            Transaction.PinPadConfig pinPadConfig = new Transaction.PinPadConfig();
            MercuryShield.TranSentry tranSentry = new MercuryShield.TranSentry();
            Transaction.Response response = new Transaction.Response();
            String responseText = String.Empty;

            MPS.POS.Utils.Logging.LogData("Here is some information", "DataLog");
            
            //Populate base Request fields common to all transactions (i.e. config file values)
            saleRequest.CreditServers = "x1.mercurydev.net;x2.mercurydev.net";
            saleRequest.MerchantID = "395347308=E2ETKN";
            saleRequest.Memo = "[Product, Version]"; // Supply your POS product and version number
            saleRequest.UserID = "Test"; // UserID PA-DSS requirement logging

            //Populate unique per request fields.  POS Supplied.
            saleRequest.InvoiceNumber = "1";
            saleRequest.ReferenceNumber = "1";
            saleRequest.AmountData.PurchaseAmount = 1.25;
            saleRequest.TokenFrequency = MSEnum.TokenFrequencies.OneTime;

            //The following per-request fields define the request type.
            saleRequest.ImplementationType = "E2E";
            saleRequest.TenderType = MSEnum.TenderTypes.Credit;
            saleRequest.TransactionType = MSEnum.TransactionTypes.Sale;

            if (isManual)
            {
                saleRequest.ProcessingSetName = "MagTekIPAD Manual";
            }
            else
            {
                saleRequest.ProcessingSetName = "MagTekIPAD Swiped";
            }

            // Set the PinPadConfig Fields used by E2E and pass to the Request
            pinPadConfig.TimeOutValue = 30;
            pinPadConfig.DelayBeforeSendingDataToDevice = 0;
            pinPadConfig.CaptureSignature = true;
            pinPadConfig.PinPadType = Transaction.PinPadType.Unknown;
            saleRequest.PinPadConfig = pinPadConfig;
         
            // Set the request object in the TranSentry object, process, and capture the response.
            tranSentry.TranSentryRequest = saleRequest;
            tranSentry.ProcessRequest();
            response = tranSentry.TranSentryResponse;

            //
            //Handle the response however you wish.
            //
            responseText = "Credit Sale Response" + Environment.NewLine;
            responseText = responseText + Environment.NewLine;
            responseText = responseText + "CmdStatus: " + response.CmdStatus + Environment.NewLine;
            responseText = responseText + "TextResponse: " + response.TextResponse + Environment.NewLine;
            responseText = responseText + "ProcessData: " + response.ProcessData;

            MessageBox.Show(responseText, "TranSentry");
        }

        
    }
}

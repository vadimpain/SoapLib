using System;
using System.Collections.Generic;
using System.Text;

namespace SoapRequest
{
    public class DocumentTender
    {
        private static DocumentTender instance;

        public static DocumentTender Instance
        {
            get { return instance ?? (instance = new DocumentTender()); }
        }

        public string FinanceSource;

        public string IDSAP;

        public string OfferNumber;

        public string DocumentBaseCode;

        public string PurchaseType;

        public string KindPursh;

        public string KindTender;

        public string FinanceArticle;

        public string PurchaseMethod;

        public string ExceptionFromSMSP;
    }
}

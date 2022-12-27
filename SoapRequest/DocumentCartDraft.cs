using System;
using System.Collections.Generic;
using System.Text;

namespace SoapRequest
{
    public class DocumentCartDraft
    {
        private static DocumentCartDraft instance;

        public static DocumentCartDraft Instance
        {
            get { return instance ?? (instance = new DocumentCartDraft()); }
        }

        public string ID;

        public string ContractType;

        public string ContractCategorySAP;

        public string ContractTypeSAP;

        public string Created;

        public string CounterpartyName;

        public string AlternativePayerOrPayee;

        public string AlternativeSubject;

        public string TotalAmount;

        public string LeadingDocument;

        public string SubsidiaryBranch;

        public string ContractCuratorSAP;

        public string CoExecutors;

        public string FinancialSign;

        public string Started;

        public string Ended;

        public string CFO;

        public string KindSumChange;

        public string OKPD2;

        public string BankGuarantee;

        public string Comment;
    }
}

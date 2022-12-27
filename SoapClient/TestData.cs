using System;
using System.Collections.Generic;
using System.Text;

namespace SoapClient
{
    public class TestData
    {
        public static SoapRequest.DocumentBody GetExampleDocumentBody()
        {
            var documentBody = SoapRequest.DocumentBody.Instance;
            documentBody.GUID = "TestDocumentBody";
            documentBody.ID = "TestDocumentBody";
            documentBody.RegistrationNumber = "TestDocumentBody";
            documentBody.RelevanceSign = "TestDocumentBody";
            documentBody.TotalAmount = "TestDocumentBody";
            documentBody.Format = "TestDocumentBody";
            documentBody.CounterpartyName = "TestDocumentBody";
            documentBody.Body = "TestDocumentBody";
            documentBody.AlternativePayerOrPayee = "TestDocumentBody";

            return documentBody;
        }

        public static SoapRequest.DocumentCartDraft GetExampleDocumentCartDraft()
        {
            var documentCartDraft = SoapRequest.DocumentCartDraft.Instance;
            documentCartDraft.AlternativePayerOrPayee = "TestDocumentCartDraft";
            documentCartDraft.AlternativeSubject = "TestDocumentCartDraft";
            documentCartDraft.BankGuarantee = "TestDocumentCartDraft";
            documentCartDraft.CFO = "TestDocumentCartDraft";
            documentCartDraft.CoExecutors = "TestDocumentCartDraft";
            documentCartDraft.Comment = "TestDocumentCartDraft";
            documentCartDraft.ContractCategorySAP = "TestDocumentCartDraft";
            documentCartDraft.ContractCuratorSAP = "TestDocumentCartDraft";
            documentCartDraft.ContractType = "TestDocumentCartDraft";
            documentCartDraft.ContractTypeSAP = "TestDocumentCartDraft";
            documentCartDraft.CounterpartyName = "TestDocumentCartDraft";
            documentCartDraft.Created = "TestDocumentCartDraft";
            documentCartDraft.Ended = "TestDocumentCartDraft";
            documentCartDraft.FinancialSign = "TestDocumentCartDraft";
            documentCartDraft.ID = "TestDocumentCartDraft";
            documentCartDraft.KindSumChange = "TestDocumentCartDraft";
            documentCartDraft.LeadingDocument = "TestDocumentCartDraft";
            documentCartDraft.OKPD2 = "TestDocumentCartDraft";
            documentCartDraft.Started = "TestDocumentCartDraft";
            documentCartDraft.SubsidiaryBranch = "TestDocumentCartDraft";
            documentCartDraft.TotalAmount = "TestDocumentCartDraft";

            return documentCartDraft;
        }

        public static SoapRequest.DocumentTender GetExampleDocumentTender()
        {
            var documentTender = SoapRequest.DocumentTender.Instance;
            documentTender.DocumentBaseCode = "TestDocumentTender";
            documentTender.ExceptionFromSMSP = "TestDocumentTender";
            documentTender.FinanceArticle = "TestDocumentTender";
            documentTender.FinanceSource = "TestDocumentTender";
            documentTender.IDSAP = "TestDocumentTender";
            documentTender.KindPursh = "TestDocumentTender";
            documentTender.KindTender = "TestDocumentTender";
            documentTender.OfferNumber = "TestDocumentTender";
            documentTender.PurchaseMethod = "TestDocumentTender";
            documentTender.PurchaseType = "TestDocumentTender";

            return documentTender;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapRequest
{
    public class SoapRequest
    {
        EDocumentCardDraft.eDocumentCardDraftOutClient eDocumentCardDraftOutClient = null;
        EDocumentBody.eDocumentBodyOutClient eDocumentBodyOutClient = null;
        EDocumentTender.eDocumentTenderOutClient eDocumentTenderOutClient = null;

        public enum TypeDocument
        {
            EDocumentCardDraft,
            EDocumentBody,
            EDocumentTender
        }

        /// <summary>
        /// Конструктор для инициализации запроса.
        /// </summary>
        /// <param name="url">Адрес.</param>
        /// <param name="userName">Логин.</param>
        /// <param name="password">Пароль.</param>
        /// <param name="typeDocument">Тип договора.</param>
        public SoapRequest(string url, string userName, string password, TypeDocument typeDocument)
        {
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            binding.MaxBufferSize = int.MaxValue;
            binding.MaxReceivedMessageSize = int.MaxValue;
            binding.SendTimeout = new TimeSpan(0, 10, 0);

            switch (typeDocument)
            {
                case TypeDocument.EDocumentCardDraft:
                    eDocumentCardDraftOutClient = new EDocumentCardDraft.eDocumentCardDraftOutClient(binding, new EndpointAddress(url));
                    eDocumentCardDraftOutClient.ClientCredentials.UserName.UserName = userName;
                    eDocumentCardDraftOutClient.ClientCredentials.UserName.Password = password;
                    break;
                case TypeDocument.EDocumentBody:
                    eDocumentBodyOutClient = new EDocumentBody.eDocumentBodyOutClient(binding, new EndpointAddress(url));
                    eDocumentBodyOutClient.ClientCredentials.UserName.UserName = userName;
                    eDocumentBodyOutClient.ClientCredentials.UserName.Password = password;
                    break;
                case TypeDocument.EDocumentTender:
                    eDocumentTenderOutClient = new EDocumentTender.eDocumentTenderOutClient(binding, new EndpointAddress(url));
                    eDocumentTenderOutClient.ClientCredentials.UserName.UserName = userName;
                    eDocumentTenderOutClient.ClientCredentials.UserName.Password = password;
                    break;
            }
        }

        /// <summary>
        /// Передача карточки договора.
        /// </summary>
        /// <param name="documentCartDraft">Содержимое карточки.</param>
        /// <returns>Возвращает задачу.</returns>
        public void SetEDocumentCardDraft(DocumentCartDraft documentCartDraft)
        {
            var request = new EDocumentCardDraft.eDocumentCardDraft();
            request.OUTSIDE_NUMBER = documentCartDraft.ID;
            request.ZCNTRLEGALFORM = documentCartDraft.ContractType;
            request.ZCNTRCAT = documentCartDraft.ContractCategorySAP;
            request.ZCNTRTYPE = documentCartDraft.ContractTypeSAP;
            request.ZCNTRDATE = documentCartDraft.Created;
            request.ZPARTNER = documentCartDraft.CounterpartyName;
            request.ZPAYRCP = documentCartDraft.AlternativePayerOrPayee;
            request.ZCNTRDSCRP = documentCartDraft.AlternativeSubject;
            request.ZCNTRSUM = documentCartDraft.TotalAmount;
            request.ZPARENTCARDNU = documentCartDraft.LeadingDocument;
            request.ZGSBER = documentCartDraft.SubsidiaryBranch;
            request.ZEXECUTOR = documentCartDraft.ContractCuratorSAP;
            request.PARTICIPANT_CNTR = documentCartDraft.CoExecutors;
            request.FINANCIAL_SIGN = documentCartDraft.FinancialSign;
            request.ZSTARTDATE = documentCartDraft.Started;
            request.ZENDDATE = documentCartDraft.Ended;
            request.ZFISTL = documentCartDraft.CFO;
            request.NOT_SUM_CNTR = documentCartDraft.KindSumChange;
            request.OKPD2 = documentCartDraft.OKPD2;
            request.BANKGARANT = documentCartDraft.BankGuarantee;
            request.ZCOMMENTARY = documentCartDraft.Comment;

            var task = eDocumentCardDraftOutClient.ExportAsyncAsync(request);
            task.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Передача тендерного документа для неконкурентной закупки.
        /// </summary>
        /// <param name="documentTender">содержимое тендерного документа.</param>
        /// <returns>Возвращает задачу.</returns>
        public void SetEDocumentTender(DocumentTender documentTender)
        {
            var request = new EDocumentTender.eDocumentTender();
            request.SOURCE_FIN = documentTender.FinanceSource;
            request.GUID = documentTender.IDSAP;
            request.KIND_PURCH = documentTender.KindPursh;
            request.NUM_PREDLOG = documentTender.OfferNumber;
            request.DOC_BASE_CODE = documentTender.DocumentBaseCode;
            request.TYPE_PURCH = documentTender.PurchaseType;
            request.KIND_TENDER = documentTender.KindTender;
            request.OWN_FIPOS = documentTender.FinanceArticle;
            request.METHOD_PURCH = documentTender.PurchaseMethod;
            request.SMSP_ISKL_ZAK = documentTender.ExceptionFromSMSP;

            var task = eDocumentTenderOutClient.ExportAsyncAsync(request);
            task.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Передача скан-копии договора, формата (расширения) файла и регистрационного номера.
        /// </summary>
        /// <param name="documentBody">Содержимое скан-копии</param>
        /// <returns>Возвращает задачу.</returns>
        public void SetEDocumentBody(DocumentBody documentBody)
        {
            var request = new EDocumentBody.eDocumentBody();
            request.ID = documentBody.ID;
            request.GUID = documentBody.GUID;
            request.Format = documentBody.Format;
            request.Regnum = documentBody.RegistrationNumber;
            request.ZPARTNER = documentBody.CounterpartyName;
            request.ZPAYRCP = documentBody.AlternativePayerOrPayee;
            request.ZCNTRSUM = documentBody.TotalAmount;
            request.ZRELEVANT_NK = documentBody.RelevanceSign;
            request.Body = documentBody.Body;

            var task = eDocumentBodyOutClient.ExportAsyncAsync(request);
            task.GetAwaiter().GetResult();
        }
    }
}

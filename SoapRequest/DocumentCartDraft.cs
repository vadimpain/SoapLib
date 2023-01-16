using System;
using System.Xml.Serialization;

namespace SoapRequest
{
  [Serializable]
  [XmlRoot("eDocumentCartDraft")]
  public class DocumentCartDraft : SAPRequestBody
  {
    [XmlIgnore]
    private static DocumentCartDraft instance;
    new public static DocumentCartDraft Instance
    {
      get { return instance ?? (instance = new DocumentCartDraft()); }
    }
    public DocumentCartDraft()
    {
      this.Namespace = "edoc";
      this.NamespaceURI = "http://inform.gazprom.ru/C/IUSPT2/eDocumentCardDraft";
      this.NodeName = "eDocumentCartDraft";
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

    public override string SerializeBody()
    {
      return base.SerializeBody(this.GetType(), this);
    }
  }
}

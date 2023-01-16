using System;
using System.Xml.Serialization;

namespace SoapRequest
{
  [Serializable]
  [XmlRoot("eDocumentTender")]
  public class DocumentTender : SAPRequestBody
  {
    [XmlIgnore]
    private static DocumentTender instance;
    public static DocumentTender Instance
    {
      get { return instance ?? (instance = new DocumentTender()); }
    }

    public DocumentTender()
    {
      this.Namespace = "edoc";
      this.NamespaceURI = "http://inform.gazprom.ru/C/IUSPT2/eDocumentTender";
      this.NodeName = "eDocumentTender";
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

    public override string SerializeBody()
    {
      return base.SerializeBody(this.GetType(), this);
    }
  }
}

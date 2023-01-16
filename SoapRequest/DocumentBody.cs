using System;
using System.Xml.Serialization;

namespace SoapRequest
{
  [Serializable]
  [XmlRoot(ElementName = "eDocumentBody")]
  public class DocumentBody : SAPRequestBody
  {
    [XmlIgnore]
    private static DocumentBody instance;
    new public static DocumentBody Instance
    {
      get { return instance ?? (instance = new DocumentBody()); }
    }
    public DocumentBody()
    {
      this.Namespace = "edoc";
      this.NamespaceURI = "http://inform.gazprom.ru/C/IUSPT2/eDocumentBody";
      this.NodeName = "eDocumentBody";
    }

    public string ID;

    public string GUID;

    public string Format;

    public string RegistrationNumber;

    public string CounterpartyName;

    public string AlternativePayerOrPayee;

    public string TotalAmount;

    public string RelevanceSign;

    public string Body;

  }
}

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SoapRequest
{
  [Serializable]
  public class SAPRequestBody
  {
    [XmlIgnore]
    private static SAPRequestBody instance;

    [XmlIgnore]
    public string Namespace { get; set; }

    [XmlIgnore]
    public string NamespaceURI { get; set; }

    [XmlIgnore]
    public string NodeName { get; set; }

    public static SAPRequestBody Instance
    {
      get { return instance ?? (instance = new SAPRequestBody()); }
    }

    public virtual string SerializeBody()
    {
      return SerializeBody(this.GetType(), this);
    }

    public virtual string SerializeBody(Type type, object body)
    {
      var xns = new XmlSerializerNamespaces();
      xns.Add(string.Empty, string.Empty);
      XmlSerializer serializer = new XmlSerializer(type);
      using (var sww = new StringWriter())
      {
        var settings = new XmlWriterSettings();
        settings.OmitXmlDeclaration = true;
        using (XmlWriter writer = XmlWriter.Create(sww, settings))
        {
          serializer.Serialize(writer, body, xns);
          return sww.ToString();
        }
      }
    }
  }
}

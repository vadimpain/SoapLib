using System;
using System.Collections.Generic;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.IO;

namespace SoapRequest
{
  public class SoapRequest
  {
    public enum TypeDocument
    {
      EDocumentCardDraft,
      EDocumentBody,
      EDocumentTender
    }

    private string prefix;
    private string namespaceURI;

    /// <summary>
    /// Конструктор для инициализации запроса.
    /// </summary>
    /// <param name="url">Адрес.</param>
    /// <param name="userName">Логин.</param>
    /// <param name="password">Пароль.</param>
    /// <param name="typeDocument">Тип договора.</param>
    public SoapRequest(string url, string userName, string password, SAPRequestBody requestBody)
    {
      System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
      System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;

      prefix = "soapenv";
      namespaceURI = "http://schemas.xmlsoap.org/soap/envelope/";

      var xmlRequest = GetEmptyRequest();
      xmlRequest.DocumentElement.SetAttribute($"xmlns:{requestBody.Namespace}", requestBody.NamespaceURI);

      var nsmgr = new XmlNamespaceManager(xmlRequest.NameTable);
      nsmgr.AddNamespace(prefix, namespaceURI);
      nsmgr.AddNamespace(requestBody.Namespace, requestBody.NamespaceURI);

      var bodyNode = xmlRequest.SelectSingleNode($".//{prefix}:Body", nsmgr);
      var body = requestBody.SerializeBody();
      bodyNode.InnerXml = body.Replace(requestBody.NodeName, $"{requestBody.Namespace}:{requestBody.NodeName}");

      Console.WriteLine("Body: " + xmlRequest.InnerXml);

      var encodingBody = Encoding.ASCII.GetBytes(xmlRequest.InnerXml);
      var headerAuth = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(userName + ":" + password));
      var action = "http://sap.com/xi/WebService/soap1.1";

      // Создаем запрос
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
      request.ContentType = "text/xml;charset=UTF-8";
      request.Method = "POST";
      request.ContentLength = encodingBody.Length;
      request.Headers.Add("Authorization", " Basic " + headerAuth);
      request.Headers.Add("SoapAction", action);
      request.PreAuthenticate = true;

      // Заголовки
      Console.WriteLine("Headers:");
      foreach (string key in request.Headers.Keys)
      {
        Console.WriteLine(" - " + key + ": " + request.Headers.Get(key));
      }
      // Отправка сообщения
      using (var stream = request.GetRequestStream())
      {
        stream.Write(encodingBody, 0, encodingBody.Length);
      }

      // Получение ответа с сервера
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
      Console.WriteLine("End: " + responseString);
    }

    private XmlDocument GetEmptyRequest()
    {
      var request = new XmlDocument();
      var envelope = request.CreateElement(prefix, "Envelope", namespaceURI);
      request.AppendChild(envelope);
      var header = request.CreateElement(prefix, "Header", namespaceURI);
      envelope.AppendChild(header);
      var body = request.CreateElement(prefix, "Body", namespaceURI);
      envelope.AppendChild(body);
      return request;
    }
  }
}

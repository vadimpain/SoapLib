using System;
using System.IO;
using System.Net;
using System.Text;
using NLog;
using SoapRequest;

namespace SoapClient
{
  public class Program
  {
    static void Main(string[] args)
    {
      Logger logger = LogManager.GetCurrentClassLogger();
      const string DefaultConfigSettingsName = @"_ConfigSettings.json";
      var settings = ParserJson.GetJsonSettings(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultConfigSettingsName));
      
      var url = settings.URL;
      var username = settings.Username;
      var password = settings.Password;
      Test(url, username, password);
      /*
      try
      {
        
        logger.Info(string.Format("Use URL: {0}", url));
        logger.Info(string.Format("Use Username: {0}", username));
        logger.Info(string.Format("Use Password: {0}", password));

        logger.Info("Generate a request Body");
        var docBody = TestData.GetExampleDocumentBody();
        var soapRequestBody = new SoapRequest.SoapRequest(url, username, password, docBody);

        logger.Info("Sending a request Body");

        logger.Info("Sending a request CardDraft");
        var soapRequestCardDraft = new SoapRequest.SoapRequest(url, username, password, TestData.GetExampleDocumentCartDraft());

        logger.Info("Sending a request Tender");
        var soapRequestTender = new SoapRequest.SoapRequest(url, username, password, TestData.GetExampleDocumentTender());
      }
      catch (Exception ex)
      {
        logger.Error(ex.Message);
        if (ex.InnerException != null)
          logger.Error(ex.InnerException.Message);
      }*/
    }

    static void Test(string url, string userName, string password)
    {
      try
      {
        var action = "http://sap.com/xi/WebService/soap1.1";
        var body = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:edoc=\"http://inform.gazprom.ru/C/IUSPT2/eDocumentCardDraft\"><soapenv:Header/><soapenv:Body><edoc:eDocumentCardDraft><OUTSIDE_NUMBER>350520967</OUTSIDE_NUMBER><ZCNTRCAT>USLUG1_05</ZCNTRCAT><ZCNTRTYPE>006</ZCNTRTYPE><ZCNTRDATE>20221208000000</ZCNTRDATE><ZPARTNER>2000024514</ZPARTNER><ZPAYRCP>2000024514</ZPAYRCP><ZCNTRDSCRP>Размещение отходов 4-5 классов опасности, не относящихся к ТКО, на специализированном полигоне для нужд Кунгурского ЛПУМГ в 2023 году</ZCNTRDSCRP><ZCNTRSUM>17000</ZCNTRSUM><ZPARENTCARDNU>350504700</ZPARENTCARDNU><ZGSBER>2336</ZGSBER><ZEXECUTOR>TCUKMA</ZEXECUTOR><ZCNTRLEGALFORM>002</ZCNTRLEGALFORM><PARTICIPANT_CNTR>TCUPIA02</PARTICIPANT_CNTR><OKPD2>38.21.29.000</OKPD2><BANKGARANT/><SUM_NDS>0</SUM_NDS><ZCOMMENTARY>за размещение отходов 4-5 классов опасности</ZCOMMENTARY><TEMPLATE/><GSBER_REG/><TYPE_CNTR/><FINANCIAL_SIGN>02</FINANCIAL_SIGN><ZSIGNDATE/><ZSTARTDATE>20221208</ZSTARTDATE><ZENDDATE>20231231</ZENDDATE><ZENDDATEPAY/><ZFISTL/><GSBER_DCC/><ZTERM/><HBKID/><SIGNED_BY/><ZCNTRSUMADD/><ZCNTRNDSADD/><NOT_SUM_CNTR>03</NOT_SUM_CNTR><ZFIPOS/><ZBUSINESSPARTNER/><ZPAYRCP_FP/><ZFISTL_ITEM/><DEPARTM_CONTROL/><FINCODE/><ZLSCH/><ZSTARTDATE_FP/><ZENDDATE_FP/></edoc:eDocumentCardDraft></soapenv:Body></soapenv:Envelope>";
        var headerAuth = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(userName + ":" + password));
        var encodingBody = Encoding.ASCII.GetBytes(body);
        Console.WriteLine("URL:");
        Console.WriteLine(url);
        // Включаем прототокл TLS1.1
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
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
      catch (Exception e)
      {
        Console.WriteLine("ERROR:");
        Console.WriteLine(e.Message);
        Console.WriteLine(e.Source);
        Console.WriteLine(e.StackTrace);
      }
      finally
      {
        // Завершение работы
        Console.ReadKey();
      }
    }
  }
}

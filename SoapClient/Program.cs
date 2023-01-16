using System;
using System.IO;
using System.Threading.Tasks;
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

      try
      {
        var url = settings.URL;
        var username = settings.Username;
        var password = settings.Password;

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
      }
    }
  }
}

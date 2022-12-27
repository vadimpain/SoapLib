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
            const string DefaultConfigSettingsName = @"_ConfigSettings.xml";
            ConfigSettingsService.SetSourcePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultConfigSettingsName));

            try
            {
                var url = ConfigSettingsService.GetConfigSettingsValueByName("URL");
                var username = ConfigSettingsService.GetConfigSettingsValueByName("Username");
                var password = ConfigSettingsService.GetConfigSettingsValueByName("Password");
                logger.Info(string.Format("Use URL: {0}", url));
                logger.Info(string.Format("Use Username: {0}", username));
                logger.Info(string.Format("Use Password: {0}", password));

                logger.Info("Sending a request Body");
                var soapRequestBody = new SoapRequest.SoapRequest(url, username, password, SoapRequest.SoapRequest.TypeDocument.EDocumentBody);
                soapRequestBody.SetEDocumentBody(TestData.GetExampleDocumentBody());

                logger.Info("Sending a request CardDraft");
                var soapRequestCardDraft = new SoapRequest.SoapRequest(url, username, password, SoapRequest.SoapRequest.TypeDocument.EDocumentCardDraft);
                soapRequestCardDraft.SetEDocumentCardDraft(TestData.GetExampleDocumentCartDraft());

                logger.Info("Sending a request Tender");
                var soapRequestTender = new SoapRequest.SoapRequest(url, username, password, SoapRequest.SoapRequest.TypeDocument.EDocumentTender);
                soapRequestTender.SetEDocumentTender(TestData.GetExampleDocumentTender());
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}

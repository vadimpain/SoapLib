using System;
using System.Collections.Generic;
using System.Text;

namespace SoapRequest
{
    public class DocumentBody
    {
        private static DocumentBody instance;

        public static DocumentBody Instance
        {
            get { return instance ?? (instance = new DocumentBody()); }
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

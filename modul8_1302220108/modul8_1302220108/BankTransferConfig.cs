using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul8_1302220108
{
    internal class BankTransferConfig
    {
        private static string FilePath = "bank_transfer_config.json";
        private static dynamic config;

        public BankTransferConfig()
        {
            config.lang = "id";
            config.transfer.treshold = 25000000;
            config.transfer.low_fee = 6500;
            config.transfer.high_fee = 15000;
            config.confirmation.en = "yes";
            config.confirmation.id = "ya";
        }
        public static void LoadConfig()
        {
            string configJson = File.ReadAllText("bank_transfer_config.json");
            config = JsonConverter.DeserializeObject(configJson);
            config = new Newtonsoft.Json.Linq.JObject();
            config.transfer = new Newtonsoft.Json.Linq.JObject();
            config.methods = new Newtonsoft.Json.Linq.jArray { " “RTO (real-time)”, “SKN”, “RTGS”, “BI FAST” " }
            config.confirmation = new


        }

        public static string GetLang()
        {
            return config.Lang;
        }

        public static int GetThresshold()
        {
            return config.transfer.threshold;
        }

        public static int GetLowFee()
        {
            return config.transfer.low_fee;
        }

        public int GetHighFee()
        {
            return config.transfer.high_fee;
        }

        public static List<string> GetMethods()
        {
            return config.methods.ToObject<List<string>>();
        }

        public static string GetConfirmation(string lang)
        {
            return config.confirmation[lang];
        }
    }
}

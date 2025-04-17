using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300114
{
    class BankTransferConfig {
        public static string filePath = @"BankTransferConfig.json";
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public string[] methods { get; set; }
        public Confirmation confirmation { get; set; }

        public class Transfer {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }

        }

        public class Confirmation {
            public string en { get; set; }
            public string id { get; set; }
        }

        public BankTransferConfig(string lang, Transfer transfer, string[] methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }

        public BankTransferConfig()
        {

        }

        public BankTransferConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            BankTransferConfig data = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            return data;
        }
    } 
}

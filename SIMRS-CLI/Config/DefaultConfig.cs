using System;
using System.Security.Cryptography.Xml;
using SIMRS_CLI.Models;

namespace SIMRS_CLI.Config
{
    public static class DefaultConfig
    {
        public static BankTransferConfig BankTransferDefault()
        {
            Transfer tfData = new Transfer(250000000, 6500, 15000);
            Confirmation cfData = new Confirmation("yes", "ya");
            List<string> mtData = new List<string> { "RTO(real - time)", "SKN", "RTGS", "BI FAST" };
            return new BankTransferConfig("en", tfData, mtData, cfData);
        }
    }
}


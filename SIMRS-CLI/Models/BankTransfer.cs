﻿using System;
using System.Security.Cryptography.Xml;

namespace SIMRS_CLI.Models
{
    // Class Penampung Konfigurasi Bank Transfer
    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }

        public Transfer(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }

    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public Confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }

    public class BankTransfer
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }

        public BankTransfer() { }

        public BankTransfer(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}


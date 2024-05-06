using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal abstract class BaseService
    {
        protected string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        protected bool Confirmation(string message)
        {
            Console.WriteLine(message);
            Console.Write("Ketik Y untuk konfirmasi, huruf lain untuk membatalkan: ");
            string confirmation = Console.ReadLine().ToLower();
            return confirmation == "y";
        }

        public abstract void ShowAll();
        public abstract void ShowOne(string id);
        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();

    }
}

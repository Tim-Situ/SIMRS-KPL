using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal abstract class BaseService
    {
        public string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public bool Confirmation(string message)
        {
            Console.Write(message + " [y/n]: ");
            string confirmation = Console.ReadLine().ToLower();
            return confirmation == "y";
        }

        public abstract void ShowAll();
        public abstract void ShowOne(string id);
        public abstract string Create();
        public abstract string Update();
        public abstract string Delete();

    }
}

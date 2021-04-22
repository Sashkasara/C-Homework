using AbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class DevOps : Human, IDeveloper, IOperations
    {
        public bool AWCertified { get; set; }
        public bool AzureCertified { get; set; }

        public DevOps (string fullname, int age, long phone, bool awcert, bool azurecert)
            :base (fullname, age, phone)
        {
            AWCertified = awcert;
            AzureCertified = azurecert;
        }

        public override string GetIinfo()
        {
            string result = $"{FullName} ({Age}) - HAS :";
            result += AWCertified ? " Aws certified" : "";
            result += AzureCertified ? "Azure certified" : "";
            result += AWCertified || AzureCertified ? "" : "No certificates yet";
            return result;
        }

        public bool ChechInfrastructure(int status)
        {
            List<int> validStatuses = new List<int> { 200, 202, 204 };
            return validStatuses.Contains(status);
        }

        public void Code()
        {
            Console.WriteLine("tak.. tak.. tak");
            Console.WriteLine("Opens stack and exchange...");
            Console.WriteLine("tak..tak..tak...");
        }
    }
}

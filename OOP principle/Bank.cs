using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabla
{
    public abstract class Bank
    {
        public string Name { get; set; }

        public List<Client> Clients { get; set; } = new List<Client>();

        protected string BankIdIdentifier;

        public string CheckClient(long BankId)
        {
            Client client = Clients.Find(x => x.BankId == BankId);
            if (client != null)
            {
                return $"Full Name : {client.FullName}, Phone number : {client.PhoneNumber}, E-mail : {client.Email}, Bank Id : {client.BankId}, Balance : {client.BankBalance} ";

            }
            else
            {
                return "Sorry, you are not registred with our bank!";
            }
        }

        public void ClientRegistration(Client client)
        {
            Random random = new Random();
            long number = random.NextInt64(10000000000,99999999999);
            string numberToStrg = number.ToString();
            numberToStrg = BankIdIdentifier + numberToStrg.Substring(1);
            

            client.BankId = long.Parse(numberToStrg);
            
            
            Clients.Add(client);

        }


    }

}

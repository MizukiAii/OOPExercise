using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace blabla
{
    public abstract class Bank
    {
        public string Name { get; set; }

        public List<Client> Clients { get; set; } = new List<Client>(); 

         protected string BankIdIdentifier;

        public abstract string WithDraw(long BankId , decimal WithdrAwamount);
        
        public abstract string Deposit(long BankId , decimal DepositAmount);

        public string DeleteClientData(long BankId)
        {
            Client? client = Clients.Find(client => client.BankId == BankId);
            if (client != null)
            {
                Clients.Remove(client);
                return $"{client.FullName} your bank ID {BankId} has been sucessfully deleted.";

            }
            else
            {
                return "Sorry, you are not registred with our bank!";
            }


        }
         public string CheckClient(long BankId)
        {
            
            Client? client = Clients.Find(client => client.BankId == BankId);

            if(client != null)
            {
                return $"{client.FullName}, you`re current balance is: {client.BankBalance}";
            }
            else
            {
                return "Sorry, you are not registred with our bank!";

            }
        }


       
        public string CheckClient(long BankId, decimal balance)
        {
            Client client = Clients.Find(x => x.BankId == BankId);
            if (client != null)
            {
                return $"Full Name : {client.FullName}, Phone number : {client.PhoneNumber}, E-mail : {client.Email}, Bank Id : {client.BankId}, Balance : {balance} ";

            }
            else
            {
                return "Sorry, you are not registred with our bank!";
            }
        }


         public string ChangeClientName(long BankId , string NewName)
        {
            Client? client = Clients.Find(c => c.BankId == BankId);
            if (client != null)
            {
                string oldName = client.FullName;
                client.FullName = NewName;
                

                return $"Your new name has been changed from {oldName} to {NewName}";
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

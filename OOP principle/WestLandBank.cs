using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabla
{
    public class WestLandBank : Bank
    {
        public string Name = " Westland Bank";
        
        public WestLandBank()
        {
            BankIdIdentifier = "2";
        }

        public override string WithDraw(long BankId, decimal WithdrAwamount)
        {
            Client? client = Clients.Find(client => client.BankId == BankId);
            if (client != null && client.BankBalance >= WithdrAwamount)
            {
                client.BankBalance = client.BankBalance - WithdrAwamount;
                return $"The amount {WithdrAwamount} has been succesfully withdrawn and you`re new balance is {client.BankBalance}";
            }
            else if (client?.BankBalance < WithdrAwamount)
            {
                return "Insufficient founds!";

            }
            else
            {
                return "Sorry, you are not registred with our bank!";
            }
        }

        public override string Deposit(long BankId, decimal DepositAmount)
        {
            Client? client = Clients.Find(client => client.BankId == BankId);
            if (client != null)
            {
                client.BankBalance = client.BankBalance + DepositAmount;
                return $"The amount {DepositAmount} has been sucessfully added and you`re new balance is {client.BankBalance}";
            }
            else
            {
                return "Sorry, you are not registred with our bank!";
            }
        }
    }
}

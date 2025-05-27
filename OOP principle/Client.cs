using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabla
{
    public class Client
    {
       public string FullName;
       public int PhoneNumber;
       public string Email;
       public long BankId;
       public decimal BankBalance;

        public string ChangeName(string NewName)
        {
            FullName = NewName;
            return NewName;

        }
    }

    
}


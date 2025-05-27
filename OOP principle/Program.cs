// Lets say we have 2 banks "Scotland Bank" as S, and "Westland Bank" as W
// There are 3 clients registered in S and 2 in W
// "Gabriel Serban, 0775259148, sgaby100@gmail.com, BankId: 12385432456",500000$   }
// "Maria Francesca, 077234512, maria@gmail.com, BankId: 192332135532" 35000$      } ==> in S
// "Florin Costea, 077113452, Florin_costea@gmail.com, BankId: 192325335532" 130$  }

//"Mihai Rom, 071353232, MihaiS@gmail.com, 23435345343232, :4000$"  } 
//"Ioana Roman, 0712553211, IoanaR@gmail.com, 253321232445", : 15000$ }  => in W

// All the clients can read there balance, can add to the balance and can withdraw from balance; ! -- TO DO TMR
// All cleints can see and edit there details but cannot change there BankId beceause it is uniq
// Each bank can register new users,  a new user can be created only with the follow properties added
// : 
// -> Firstname, lastname, phoneNumber, email, initialBalanceToDeposit" after the user is registered a uinq id will be
// created by the specific bank so S starts with 1 and has 10 following digits after and W starts with 2 and same 10 digits
// And all registered users can ask for permanent deletion of there details if they want to.
// bank id e cardu fizic

using System.Net.WebSockets;
using blabla;

ScotlandBank scotlandbank = new ScotlandBank();

WestLandBank westlandbank = new WestLandBank();


Client Gabi = new Client();
Gabi.FullName = "Gabriel Serban";
Gabi.PhoneNumber = 0775259148;
Gabi.Email = "sgaby100@gmail.com";
Gabi.BankBalance = 50;
scotlandbank.ClientRegistration(Gabi);
string GabiDetails = scotlandbank.CheckClient(Gabi.BankId);
scotlandbank.CheckClient(Gabi.BankId, Gabi.BankBalance);


Client Maria = new Client();
Maria.FullName = "Maria Francesca";
Maria.PhoneNumber = 077234512;
Maria.Email = "maria@gmail.com";
Maria.BankBalance = 35000;
scotlandbank.ClientRegistration(Maria);
string MariaDetailds = scotlandbank.CheckClient(Maria.BankId);  
scotlandbank.CheckClient(Maria.BankId, Maria.BankBalance); 


Client Florin = new Client();
Florin.FullName = "Florin Costea";
Florin.PhoneNumber = 077113452;
Florin.Email = "Florin_costea@gmail.com";
Florin.BankBalance = 130;
scotlandbank.ClientRegistration(Florin);
string FlorinDetails = scotlandbank.CheckClient(Florin.BankId);
scotlandbank.CheckClient(Florin.BankId, Florin.BankBalance);





Client Mihai = new Client();
Mihai.FullName = "Mihai Rom";
Mihai.PhoneNumber = 071353232;
Mihai.Email = "MihaiS@gmail.com";
Mihai.BankBalance = 4000;
westlandbank.ClientRegistration(Mihai);
string mihaiDetails = westlandbank.CheckClient(Mihai.BankId);
westlandbank.CheckClient(Mihai.BankId, Mihai.BankBalance);


Client Ioana = new Client();
Ioana.FullName = "Ioana Roman";
Ioana.PhoneNumber = 0712553211;
Ioana.Email = "IoanaR@gmail.com";
Ioana.BankBalance = 15000;
westlandbank.ClientRegistration(Ioana);
string ioanaDetails = westlandbank.CheckClient(Ioana.BankId);
westlandbank.CheckClient(Ioana.BankId, Ioana.BankBalance);



//Console.WriteLine(scotlandbank.WithDraw(Gabi.BankId,25));
//Console.WriteLine(scotlandbank.Deposit(Gabi.BankId,100000000000));
//Console.WriteLine(scotlandbank.DeleteClientData(Gabi.BankId));
Gabi.ChangeName("Claudiu");
scotlandbank.ChangeClientName(Gabi.BankId, Gabi.FullName);
Console.WriteLine(scotlandbank.CheckClient(Gabi.BankId));




    
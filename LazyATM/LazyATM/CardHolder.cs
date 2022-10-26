using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyATM
{
    internal class CardHolder
    {
        public string CardNum       { get; set; }
        public int Pin              { get; set; }
        public string FirstName     { get; set; }
        public string LastName      { get; set; }
        public double Balance       { get; set; }
        
        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            CardNum = cardNum;
            Pin = pin;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;

        }

        public void getCardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
           CardHolder holder = new CardHolder(cardNum, pin, firstName, lastName, balance);
        }

        public void setNum(String newCardNum)
        {
            CardNum = newCardNum;
        }
        public void setPin(int newPin)
        {
            Pin = newPin;
        }
        public void setFirstName(String newFirstName)
        {
            FirstName = newFirstName;
        }
        public void setLastName(string newLastName)
        {
            LastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            Balance = newBalance;
        }



        //public void setCardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        //{
        //    new CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        //}

        //public String getNume()
        //{
        //    return CardNum;
        //}
        //public int getPin()
        //{
        //    return Pin;
        //}
        //public String getFirstName()
        //{
        //    return FirstName;
        //}
        //public String getLastName()
        //{
        //    return LastName;
        //}
        //public Double getBalance()
        //{
        //    return Balance;
        //} 


    }
}

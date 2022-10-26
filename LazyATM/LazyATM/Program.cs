namespace LazyATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following option...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show balance");
                Console.WriteLine("4. Exit");
            }

            void desposit(CardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to deposit? ");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.Balance + deposit);
                Console.WriteLine("Thank you for yoour $$. Your balance now is: " + currentUser.Balance);
            }

            void withdraw(CardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to withdraw: ");
                double withdrawal = Double.Parse(Console.ReadLine());
                //check if the user has enough money
                if(currentUser.Balance < withdrawal)
                {
                    Console.WriteLine("Insufficient balance! ");
                }
                else
                {
                    currentUser.setBalance(currentUser.Balance - withdrawal);
                    Console.WriteLine("You are good to go!");
                }
            }

            void balance(CardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.Balance);
            }

            List<CardHolder> cardHolders = new List<CardHolder>();
            cardHolders.Add(new CardHolder("6549265181496432", 1234, "Adrian", "Arca", 200.30));
            cardHolders.Add(new CardHolder("6549265117682221", 1201, "Osmar", "Gonzalez", 190.19));
            cardHolders.Add(new CardHolder("6549265175583365", 1008, "Tuva", "Kristiane", 500.76));
            cardHolders.Add(new CardHolder("6549265144551899", 2905, "Kaspara", "Lindberg", 3000.45));
            cardHolders.Add(new CardHolder("6549265181558466", 0304, "Sheriff", "Katt", 150.33));

            Console.WriteLine("Welcome to LazyATM");
            Console.WriteLine("Please insert your card");
            string debitCardNum = "";
            CardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    //check against or db
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                    if(currentUser != null) { break; }
                    else { Console.WriteLine("Card not recognized. Please try again"); }
                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }
            Console.WriteLine("Please enter your Pin code: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.Pin == userPin) { break; }
                    else { Console.WriteLine("Incorrect pin. Please try again"); }
                }
                catch
                {
                    Console.WriteLine("Incorrect pin. Please try again");
                }
            }
            Console.WriteLine("Welcome " + currentUser.FirstName);
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if(option == 1) { desposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            while(option != 0);
            Console.WriteLine("Thank you! Have a nice day!");
        }

        
    }
}
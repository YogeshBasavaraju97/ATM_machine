namespace ATM_machine_Application;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        void printOPtions()
        {
            Console.WriteLine("please chose from one of the following");
            Console.WriteLine("1. Deposite");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposite( CardHolder currentUser)
        {
            Console.WriteLine("How much money you would like to deposit?");
            double deposite = Double.Parse(Console.ReadLine());
            currentUser.setbalance(deposite);
            Console.WriteLine("Thank you. your new balance is :" + currentUser.getBalance());

        }

        void withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much money you would like to deposit?");
            double withdraw = Double.Parse(Console.ReadLine());
            if(currentUser.getBalance() < withdraw)
            {
                Console.WriteLine("Insufficient funds");

            }
            else
            {
                currentUser.setbalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("Thank you. your new balance is :" + currentUser.getBalance());
            }

            

        }

        void balance(CardHolder currentUser)
        {
            Console.WriteLine("current balance: " + currentUser.getBalance());
        }
        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("43534598989", 1234, "john", "griffith", 150.87));
        cardHolders.Add(new CardHolder("45455234564", 4546, "hella", "Dickenson", 345.7));
        cardHolders.Add(new CardHolder("57435634545", 4674, "Frieda", "Hardinging", 678.90));
        cardHolders.Add(new CardHolder("64756735654", 6765,"santosh", "venkey", 464.56));
        cardHolders.Add(new CardHolder("89989839494", 5679, "ram", "tom", 456.67));

        //promt user

        Console.WriteLine("Welcome to simpleATM");
        Console.WriteLine("Please insert your debit card: ");
        string debitCardNum = "";
        CardHolder currentuser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //Check against our db
                currentuser = cardHolders.FirstOrDefault(a => a.getNum() == debitCardNum);
                if (currentuser != null) { break; }
                else { Console.WriteLine("Card not recognised, Please try agiain"); }


            }
            catch { Console.WriteLine("Card not recognised, PLease try aginn");  }
        }

        Console.WriteLine("Please Enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if(currentuser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin, please try again"); }


            }
            catch { Console.WriteLine("Incorrect pin, please try again"); }
        }

        Console.WriteLine("Welcom" + currentuser.getFirstName() + ":)");
        int option = 0;
        do
        {
            printOPtions();
            try
            {
                option = int.Parse(Console.ReadLine());


            }
            catch { }

            if (option == 1) { deposite(currentuser); }
            else if (option == 2) { withdraw(currentuser); }
            else if (option == 3) { balance(currentuser); }
            else if (option == 4) { break; }
            else { option = 0; }

        } while (option == 4);
        Console.WriteLine("Thank you! have a nice day")


    
}


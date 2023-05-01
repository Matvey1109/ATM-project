using ATM;

class Program
{
    public static void Main(string[] args)
    {
        void PrintOptions()
        {
            Console.WriteLine("Please, choose from one of the following options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
            Console.Write(">>> ");
        }

        void Deposit(CardHolder currentUser)
        {
            Console.Write("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.Balance += deposit;
            Console.WriteLine("Thank you for your $$. Your balance now is: $" + currentUser.Balance);
        }
        
        void Withdraw(CardHolder currentUser)
        {
            Console.Write("How much $$ would you like to withdraw? ");
            double withdraw = Double.Parse(Console.ReadLine());
            if (withdraw <= currentUser.Balance)
            {
                currentUser.Balance -= withdraw;
                Console.WriteLine("Your balance now is: $" + currentUser.Balance);
            }
            else
            {
                Console.WriteLine("Not enough money :(");
            }
        }

        void Balance(CardHolder currentUser)
        {
            Console.WriteLine("Current balance is: $" + currentUser.Balance);
        }

        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("Alex", "Ivanov", 1234, 5678, 100.31));

        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Do you have a card?");
        Console.WriteLine("1. Yes\n2. No");
        int k = Int32.Parse(Console.ReadLine());
        switch (k)
        {
            case 1:
                break;
            case 2:
                Console.Write("Enter your first name: ");
                string curf = Console.ReadLine();
                Console.Write("Enter your last name: ");
                string curl = Console.ReadLine();
                Console.Write("Enter your card number: ");
                int curc = Int32.Parse(Console.ReadLine());
                Console.Write("Enter your pin: ");
                int curp = Int32.Parse(Console.ReadLine());
                CardHolder newCur = new CardHolder(curf, curl, curc, curp, 0);
                cardHolders.Add(newCur);
                break;
            default:
                Console.WriteLine("Enter valid option");
                break;
        }
        
        int debitCardNum;
        CardHolder currentUser;
        while (true)
        {
            try
            {
                Console.Write("Please enter your card number: ");
                debitCardNum = Int32.Parse(Console.ReadLine());
                currentUser = cardHolders.FirstOrDefault(a => a.CardNumber == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again");
            }
        }
        
        int curPin;
        while (true)
        {
            try
            {
                Console.Write("Please enter your pin: ");
                curPin = Int32.Parse(Console.ReadLine());
                if (currentUser.Pin == curPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect pin. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again");
            }
        }

        Console.WriteLine("Welcome, " + currentUser.FirstName + " " + currentUser.LastName + "!");
        int op = 0;
        do
        {
            PrintOptions();
            try
            {
                op = Int32.Parse(Console.ReadLine());
            }
            catch
            {
               
            }
            
            switch (op)
            {
                case 1:
                    Deposit(currentUser);
                    break;
                case 2:
                    Withdraw(currentUser);
                    break;
                case 3:
                    Balance(currentUser);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        } while (op != 4);
    }
}
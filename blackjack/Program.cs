// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalPlayer;
int totalDealer;
string message;
string switchControl = "menu";
int newCard;
System.Random random = new System.Random();

while (true)
{
    totalDealer = 0;
    totalPlayer = 0;
    message = "";
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("\n" + "Welcome to the C A S I N O!");
            Console.WriteLine("Write '21' to play 21");
            switchControl = Console.ReadLine();
            break;

        case "21":
            Console.WriteLine("Game is starting...");

            do
            {
                newCard = random.Next(1, 12);
                totalPlayer += newCard;
                Console.WriteLine("\n" + "Take your card");
                Console.WriteLine($"You got a {newCard}");
                Console.WriteLine($"Your total is {totalPlayer} \n");

                if (totalPlayer > 21)
                {
                    message = "Player busts! Dealer wins!";
                    Console.WriteLine(message);
                    switchControl = "menu";
                    break;
                }

                Console.WriteLine("Do you want another card?");
                Console.WriteLine("Type 'yes' to take another one");
            } while (Console.ReadLine().ToLower() == "yes");

            if (message == "Player busts! Dealer wins!") break;

            totalDealer = random.Next(14, 23);
            Console.WriteLine("\n" + $"The Dealer have {totalDealer}!");


            if (totalDealer > 21)
            {
                message = "Dealer busts! Player wins!";
                Console.WriteLine(message);
                switchControl = "menu";
                break;
            }

            if (totalPlayer > totalDealer && totalPlayer < 22)
            {
                message = "Player wins!";
                Console.WriteLine(message);
                switchControl = "menu";
                break;
            }
            else if (totalDealer > totalPlayer)
            {
                message = "Dealer wins!";
                Console.WriteLine(message);
                switchControl = "menu";
                break;
            }
            break;
        default:
            Console.WriteLine("\n" + "Invalid option, please try again.");
            switchControl = "menu";
            break;
    }



}
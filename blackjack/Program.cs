// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totalPlayer;
int totalDealer;
string message;
string switchControl = "menu";
int newCard;
int coins;
System.Random random = new System.Random();

while (true) {

    coins = 0;
    Console.WriteLine("\nHow many coins do you want?\n" +
        "Remember that you need one coin per round\n" +
        "Please enter a whole number");
    coins = int.Parse(Console.ReadLine());

    for (int i = 1; i <= coins; i++) {
        totalDealer = 0;
        totalPlayer = 0;
        message = "";
        switch (switchControl) {
            case "menu":
                Console.WriteLine("\n" + "Welcome to the C A S I N O!");
                Console.WriteLine("Write '21' to play 21");
                switchControl = Console.ReadLine();
                i--;
                break;

            case "21":
                Console.WriteLine("\nGame is starting...");
                do {
                    newCard = random.Next(1, 12);
                    totalPlayer += newCard;
                    Console.WriteLine($"\nTake your card. You got a {newCard}\n" +
                        $"Your total is {totalPlayer} \n");

                    if (totalPlayer > 21) {
                        message = "Player busts! Dealer wins!";
                        Console.Clear();
                        Console.WriteLine(message + "\n" +
                            $"Player total: {totalPlayer}\n" +
                            $"Dealer total: {totalDealer}");
                        Console.WriteLine($"\nYou have {(coins - i)} coin(s) left.");
                        break;
                    }

                    Console.WriteLine("Do you want another card?\n" + "Type 'yes' to take another one");
                } while (Console.ReadLine().ToLower() == "yes");

                if (message == "Player busts! Dealer wins!")
                    break;

                totalDealer = random.Next(14, 23);

                if (totalPlayer > totalDealer && totalPlayer < 22) {
                    message = "Player wins! One coin will be added!";
                    i--;
                } else {
                    message = "Dealer wins!";
                }

                Console.Clear();
                Console.WriteLine(message + "\n" +
                    $"Player total: {totalPlayer}\n" +
                    $"Dealer total: {totalDealer}");
                Console.WriteLine($"\nYou have {(coins - i)} coin(s) left.");
                break;
            default:
                Console.WriteLine("\n" + "Invalid option, please try again.");
                switchControl = "menu";
                break;
        }
    }
}
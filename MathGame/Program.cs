
using System.Text;
using System.Threading.Tasks.Sources;

Console.WriteLine("Hello! Please enter your name:");



string? name = Console.ReadLine();
bool quit = false;
List<string> games = new();

if (name == null)
{
    while (name == null)
    {
        Console.WriteLine("Incorrect entry. Please try again:");
        string? newName = Console.ReadLine();
        name = newName;
    }
    
}

name = name.ToUpper().Trim();

while (quit == false)
{
    main(name);
}



void main(string name) 
{
    Console.WriteLine(@$"Hello {name} please choose on of the options below:
                        A - Addition game
                        S - Subtraction game
                        M - Multiplication game
                        D - Division game
                        V - View previous games
                        Q - quit");
    string? userInput = Console.ReadLine(); 

    switch (userInput.ToLower().Trim())
    {
        case "a":
            AdditionGame();
            break;

        case "s":
            SubtractionGame();
            break;

        case "m":
            MultiplicationGame();
            break;

        case "d":
            DivisionGame();
            break;
        case "v":
            GetGames();
            break;



        case "q":
            Console.WriteLine("Quitting..");
            quit = true;
            break;
    }
}

void AdditionGame() 
{
    Console.Clear();
    Console.WriteLine("Addition game");
    var random = new Random();

    int firstNumber;
    int secondNumber;
    int answer;
    int score = 0;


    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(0, 10);
        secondNumber = random.Next(0, 10);
        Console.WriteLine($"{firstNumber} + {secondNumber} = ");
        string? answerInput = Console.ReadLine();

        if (answerInput != null)
        {
            bool conversion = int.TryParse(answerInput, out answer);
            int sum = firstNumber + secondNumber;

            if (answer == (sum) && conversion)
            {
                score++;
                Console.WriteLine(@"Correct answer! Press a key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Wrong answer. The answer is {sum}. Press a key to continue...");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong Input. Press a key to continue...");
            Console.ReadLine();
        }
    }
    AddHistory(games, score, "Addition");

}

void SubtractionGame() 
{
    Console.Clear();
    Console.WriteLine("Subtraction game");

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int answer;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(0, 10);
        secondNumber = random.Next(0, 10);
        Console.WriteLine($"{firstNumber} - {secondNumber} = ");
        string? answerInput = Console.ReadLine();

        if (answerInput != null)
        {
            bool conversion = int.TryParse(answerInput, out answer);
            int sum = firstNumber - secondNumber;

            if (answer == (sum) && conversion)
            {
                score++;
                Console.WriteLine("Correct answer! Press any key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Wrong answer. The answer is {sum}. Press any key to continue...");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong Input. Press any key to continue");
            Console.ReadLine();
        }
    }
    AddHistory(games, score, "Subtraction");
}

void MultiplicationGame() 
{
    Console.Clear();
    Console.WriteLine("Multiplication game");

    var random = new Random();

    int firstNumber;
    int secondNumber;
    int answer;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(0, 10);
        secondNumber = random.Next(0, 10);
        Console.WriteLine($"{firstNumber} * {secondNumber} = ");
        string? answerInput = Console.ReadLine();

        if (answerInput != null)
        {
            bool conversion = int.TryParse(answerInput, out answer);
            int product = firstNumber * secondNumber;

            if (answer == (product) && conversion)
            {
                score++;
                Console.WriteLine("Correct answer! Press any key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Wrong answer. The answer is {product}. Press any key to continue...");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong Input. Press any key to continue...");
            Console.ReadLine();
        }
    }
    AddHistory(games, score, "Multiplication");
}

void DivisionGame()
{
    Console.Clear();
    Console.WriteLine("Division game");
    int score = 0;


    for (int i = 0; i < 5; i++)

    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        int answer;

        Console.WriteLine($"{firstNumber} / {secondNumber} = ");
        string? answerInput = Console.ReadLine();

        if (answerInput != null)
        {
            bool conversion = int.TryParse(answerInput, out answer);
            int product = firstNumber / secondNumber;

            if (answer == product && conversion)
            {
                score++;
                Console.WriteLine("Correct answer! Press any key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Wrong answer. The correct answer is {product}. Press any key to continue...");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong Input. Press any key to continue...");
            Console.ReadLine();
        }
    }
    AddHistory(games, score, "Division");
}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0) 
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;



}

void GetGames() 
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("-------------------------------------");
    foreach (var game in games) 
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("-------------------------------------\n");
    Console.WriteLine("Press any key to return to the Main Menu.");
    Console.ReadLine();
}

void AddHistory(List<string> list, int score, string game ) 
{
    list.Add($" Date:{DateTime.UtcNow} - {game}: Score {score}");
}
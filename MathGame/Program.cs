
using System.Text;

Console.WriteLine("Hello! Please enter your name:");

string? name = Console.ReadLine();
bool quit = false;

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
        case "q":
            Console.WriteLine("Quitting..");
            Environment.Exit(1);
            quit = true;
            break;
    }
}

void AdditionGame() 
{
    Console.WriteLine("Addition game selected");
    var random = new Random();

    int firstNumber;
    int secondNumber;
    int answer;


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
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine($"Wrong answer. The answer is {sum}");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }


}

void SubtractionGame() 
{
    Console.WriteLine("Subtraction game selected");

    var random = new Random();
    int firstNumber;
    int secondNumber;
    int answer;

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
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine($"Wrong answer. The answer is {sum}");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

void MultiplicationGame() 
{
    Console.WriteLine("Multiplication game selected");

    var random = new Random();

    int firstNumber;
    int secondNumber;
    int answer;

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
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine($"Wrong answer. The answer is {product}");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
}

void DivisionGame()
{
    Console.WriteLine("Division game selected");


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
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine($"Wrong answer. The correct answer is {product}");
            }
        }
        else
        {
            Console.WriteLine("Wrong Input.");
        }
    }
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
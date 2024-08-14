
using System.Text;

Console.WriteLine("Hello! Please enter your name:");
Random Random = new Random();

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
    
    decimal firstNumber = Random.Next(0,10);
    decimal secondNumber = Random.Next(0,10);
    decimal answer;

    Console.WriteLine($"{firstNumber} + {secondNumber} = ");
    string? answerInput = Console.ReadLine();

    if (answerInput != null)
    {
        bool conversion = decimal.TryParse(answerInput, out answer);
        decimal sum = firstNumber + secondNumber;

        if (answer == (sum) && conversion)
        {
            Console.WriteLine("Correct answer!");
        }
        else
        {
            Console.WriteLine("Wrong answer.");
        }
    }
    else 
    {
        Console.WriteLine("Wrong Input.");
    }


}

void SubtractionGame() 
{
    Console.WriteLine("Subtraction game selected");

    decimal firstNumber = Random.Next(0, 10);
    decimal secondNumber = Random.Next(0, 10);
    decimal answer;

    Console.WriteLine($"{firstNumber} - {secondNumber} = ");
    string? answerInput = Console.ReadLine();

    if (answerInput != null)
    {
        bool conversion = decimal.TryParse(answerInput, out answer);
        decimal sum = firstNumber - secondNumber;

        if (answer == (sum) && conversion)
        {
            Console.WriteLine("Correct answer!");
        }
        else
        {
            Console.WriteLine("Wrong answer.");
        }
    }
    else
    {
        Console.WriteLine("Wrong Input.");
    }
}

void MultiplicationGame() 
{
    Console.WriteLine("Multiplication game selected");

    decimal firstNumber = Random.Next(0, 10);
    decimal secondNumber = Random.Next(0, 10);
    decimal answer;

    Console.WriteLine($"{firstNumber} * {secondNumber} = ");
    string? answerInput = Console.ReadLine();

    if (answerInput != null)
    {
        bool conversion = decimal.TryParse(answerInput, out answer);
        decimal product = firstNumber * secondNumber;

        if (answer == (product) && conversion)
        {
            Console.WriteLine("Correct answer!");
        }
        else
        {
            Console.WriteLine("Wrong answer.");
        }
    }
    else
    {
        Console.WriteLine("Wrong Input.");
    }
}

void DivisionGame()
{
    Console.WriteLine("Division game selected");
    Console.WriteLine("Addition game selected");
    bool integerDivision = false;
    decimal firstNumber = 1;
    decimal secondNumber = 1;
    while (!integerDivision)
    {
        firstNumber = Random.Next(2, 20);
        secondNumber = Random.Next(2, 20);
        if (firstNumber % secondNumber == 0 && firstNumber != secondNumber) 
        {
            integerDivision = true;
        }
    }
    decimal answer;

    Console.WriteLine($"{firstNumber} / {secondNumber} = ");
    string? answerInput = Console.ReadLine();

    if (answerInput != null)
    {
        bool conversion = decimal.TryParse(answerInput, out answer);
        decimal product = firstNumber / secondNumber;

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
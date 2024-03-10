bool operand1Required = true;
float operand1Value = 0;

while (operand1Required)
{
    Console.WriteLine("Enter the first operand: ");
    string operand1 = Console.ReadLine();
    bool oprrand1IsNumber = float.TryParse(operand1, out operand1Value);
    if (oprrand1IsNumber == false)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
    else
    {
        operand1Required = false;
    }
}

bool operatorRequired = true;
string operatorValue = "";

while (operatorRequired)
{
    Console.WriteLine("Enter the operator: ");
    operatorValue = Console.ReadLine();
    if (operatorValue == "+" || operatorValue == "-" || operatorValue == "*" || operatorValue == "/")
    {
        operatorRequired = false;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid operator (+, -, *, /).");
    }
}

bool operand2Required = true;
float operand2Value = 0;

while (operand2Required)
{
    Console.WriteLine("Enter the second operand: ");
    string operand2 = Console.ReadLine();
    bool oprrand2IsNumber = float.TryParse(operand2, out operand2Value);
    if (oprrand2IsNumber == false)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
    else
    {
        operand2Required = false;
    }
}

float result = 0;

// Calculate the result
// continue from here

Console.WriteLine("The result is: " + result);
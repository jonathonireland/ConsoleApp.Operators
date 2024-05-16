// See https://aka.ms/new-console-template for more information

int num2 = 0;
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
    Math Operations and Operators
 */

// add 
int sum = num1 + num2;
// multiply
int product = num1 * num2;
// divide 
int quotient = num1 / num2;
// subtraction 
int difference = num1 - num2;
// modulus
int mod = num1 % num2;

Console.WriteLine("****************** MATH RESULTS ******************");
Console.WriteLine("Sum: " +sum);
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("****************** END MATH RESULTS ******************");

/*
    Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("****************** LOGIC RESULTS ******************");
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal to: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine("****************** END LOGIC RESULTS ******************");
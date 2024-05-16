
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
Console.WriteLine();
Console.WriteLine("Sum: " +sum);
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("****************** END MATH RESULTS ******************");
Console.WriteLine();

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
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal to: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal to: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal to: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine("****************** END LOGIC RESULTS ******************");
Console.WriteLine();

/*
    Assignment Operations and Operators
*/

Console.WriteLine("****************** ASSIGNMENT RESULTS ******************");
Console.WriteLine();
num1 += 5;
Console.WriteLine($"Num 1 increased by 5: {num1}");
num1 -= 3;
Console.WriteLine($"Num 1 reduced by 3: {num1}");
num1 /= 2;
Console.WriteLine($"Num 1 divided by 2: {num1}");
num1 %= 2;
Console.WriteLine($"Num 1 mod by 2: {num1}");
num1 *= 10;
Console.WriteLine($"Num 1 multiplied by 10: {num1}");
Console.WriteLine("****************** END ASSIGNMENT RESULTS ******************");
Console.WriteLine();

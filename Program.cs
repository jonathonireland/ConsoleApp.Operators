

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

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
Console.Write("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
// num1 = num1 + randomValue
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
// num1 = num1 - randomValue
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}: {num1}");
// num1 = num1 / randomValue
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
// num1 = num1 % randomValue
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
// num1 = num1 * randomValue
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("****************** END ASSIGNMENT RESULTS ******************");
Console.WriteLine();

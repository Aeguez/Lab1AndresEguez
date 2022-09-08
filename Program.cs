// See https://aka.ms/new-console-template for more information

WorkWithIntegers();
OrderPrecedence();
TestLimits();
WorkingWithDoubles();
DecimalTypes();


void WorkWithIntegers() {

    int a = 18;
    int b = 6;

    // sum
    int c = a + b;
    Console.WriteLine(c);
    Console.ReadLine();

    // subtraction
    c = a - b;
    Console.WriteLine(c);
    Console.ReadLine();

    // multiplication
    c = a * b;
    Console.WriteLine(c);
    Console.ReadLine();

    // division
    c = a / b;
    Console.WriteLine(c);
    Console.ReadLine();

    // combined operation
    Console.WriteLine(c = a + b - 12 * 17);
    Console.ReadLine();
}

void OrderPrecedence() {

    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);
    Console.ReadLine();

    d = (a + b) * c;
    Console.WriteLine(d);
    Console.ReadLine();

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);
    Console.ReadLine();

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
    Console.ReadLine();
}

void TestLimits() {
    double a = 7;
    double b = 4;
    double c = 3;
    double d = (a + b) / c;
    double e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.ReadLine();

    Console.WriteLine($"remainder: {e}");
    Console.ReadLine();

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");
    Console.ReadLine();

    double third = 1.0 / 3.0;
    Console.WriteLine(third);
    Console.ReadLine(); 

    double what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
    Console.ReadLine();
    
    
    Console.WriteLine(((a + b *c) / d - e) + 50);
}

// Doubles 

void WorkingWithDoubles()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h);

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}
// Decimal types

void DecimalTypes() {
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}");
    Console.ReadLine();

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);
    Console.ReadLine();

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
    Console.ReadLine();
}

// area of a circle
    double radius = 2.50;
    double area = Math.Round(Math.PI * radius * radius);
    Console.WriteLine("The area of the circle is: " + area);
    Console.ReadLine();

// calculator

Console.WriteLine("Type a number: ");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type another number: ");
double num2 = Convert.ToInt32(Console.ReadLine());

//Sum
double sum = num1 + num2;
Console.WriteLine("Sum: " + sum);
Console.ReadLine();

//Substraction
double sub = num1 - num2;
Console.WriteLine("Substraction: " + sub);
Console.ReadLine();

//Multiplication
double mul = num1 * num2;
Console.WriteLine("Multiplication: " + mul);
Console.ReadLine();

//Division
double div = num1 / num2;
Console.WriteLine("Division: " + div);
Console.ReadLine();

//Module 
double mod = num1 % num2;
Console.WriteLine("Module: " + mod);
Console.ReadLine();


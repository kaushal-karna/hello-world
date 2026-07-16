# Detailed C# Notes

This file is a complete learning note for the Hello C# project. It combines the theory and practical examples inspired by the code comments in the repository.

## 1. Introduction to C#

C# is a modern, object-oriented programming language developed by Microsoft. It is widely used for:

- Desktop applications
- Web applications
- Console applications
- Game development
- Backend services

A simple C# program starts with a class and a Main method.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

## 2. Basic Program Structure

Every C# program generally has:

- Namespace
- Class
- Main method
- Statements

Example:

```csharp
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from C#");
        }
    }
}
```

## 3. Comments in C#

Comments are used to explain code and make it easier to understand.

```csharp
// Single-line comment

/*
This is a
multi-line comment
*/
```

In this project, comments are used to show examples of syntax and concepts.

## 4. Variables and Data Types

Variables store data in memory. C# has several built-in data types.

### Common Data Types

- int: integer values
- float: single-precision decimal values
- double: double-precision decimal values
- bool: true or false
- char: single character
- string: text

Example:

```csharp
int age = 25;
float weight = 62.5f;
double salary = 50000.75;
bool isActive = true;
char grade = 'A';
string name = "Kaushal";
```

## 5. Type Casting

Type casting converts one data type into another.

### Implicit Casting

```csharp
int a = 10;
double b = a;
```

### Explicit Casting

```csharp
double x = 10.75;
int y = (int)x;
```

### Conversion Methods

```csharp
string number = "100";
int result = Convert.ToInt32(number);
```

## 6. Input and Output

You can print output using Console.WriteLine.

```csharp
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name);
```

## 7. Operators

### Arithmetic Operators

```csharp
int a = 10;
int b = 3;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);
```

### Assignment Operators

```csharp
int x = 5;
x += 3;
x -= 2;
x *= 4;
x /= 2;
```

### Comparison Operators

```csharp
Console.WriteLine(5 > 3);
Console.WriteLine(5 < 3);
Console.WriteLine(5 >= 3);
Console.WriteLine(5 <= 3);
Console.WriteLine(5 != 3);
Console.WriteLine(5 == 3);
```

### Logical Operators

```csharp
bool a = true;
bool b = false;
Console.WriteLine(a && b);
Console.WriteLine(a || b);
Console.WriteLine(!a);
```

## 8. Math Class

C# provides a built-in Math class for common operations.

```csharp
int max = Math.Max(10, 20);
int min = Math.Min(10, 20);
double root = Math.Sqrt(49);
int abs = Math.Abs(-15);
```

## 9. Strings

Strings are used to store text.

```csharp
string hello = "Hello World";
Console.WriteLine(hello.Length);
Console.WriteLine(hello.ToUpper());
Console.WriteLine(hello.ToLower());
```

### String Concatenation

```csharp
string firstName = "Kaushal";
string lastName = "Karna";
string fullName = firstName + " " + lastName;
```

### String Interpolation

```csharp
string name = "Kaushal";
Console.WriteLine($"My name is {name}");
```

### Escape Sequences

```csharp
string text = "Hello\nWorld";
Console.WriteLine(text);
```

## 10. Conditional Statements

### If-Else

```csharp
int age = 20;

if (age < 18)
{
    Console.WriteLine("You are under 18");
}
else
{
    Console.WriteLine("You are an adult");
}
```

### Else If

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("Grade A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}
```

## 11. Switch Statements

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("Other day");
        break;
}
```

## 12. Loops

### For Loop

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

### While Loop

```csharp
int count = 0;
while (count < 3)
{
    Console.WriteLine(count);
    count++;
}
```

### Do While Loop

```csharp
int x = 0;
do
{
    Console.WriteLine(x);
    x++;
} while (x < 3);
```

## 13. Methods and Functions

Methods are reusable blocks of code.

```csharp
static void Greet(string name)
{
    Console.WriteLine($"Hello, {name}");
}
```

```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

## 14. Method Overloading

C# allows multiple methods with the same name but different parameters.

```csharp
static int Average(int a, int b)
{
    return (a + b) / 2;
}

static float Average(int a, int b, int c)
{
    return (a + b + c) / 3f;
}
```

## 15. Classes and Objects

Classes define a blueprint; objects are instances of the class.

```csharp
class Player
{
    public string name;
    private int health;

    public int GetHealth()
    {
        return health;
    }
}
```

## 16. Access Modifiers

Access modifiers control visibility.

- public: accessible everywhere
- private: accessible only inside the class
- protected: accessible in derived classes

## 17. Encapsulation

Encapsulation means wrapping data and methods into a single unit.

```csharp
class Player
{
    private int health;

    public void SetHealth(int h)
    {
        health = h;
    }

    public int GetHealth()
    {
        return health;
    }
}
```

## 18. Exception Handling

Use try-catch to handle runtime errors.

```csharp
try
{
    int x = 10;
    int y = 0;
    int result = x / y;
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero");
}
```

## 19. Arrays and Collections

### Array

```csharp
int[] numbers = { 1, 2, 3, 4 };
```

### List

```csharp
using System.Collections.Generic;

List<int> numbers = new List<int> { 1, 2, 3 };
```

## 20. Practical Learning Summary

This repository demonstrates:

- How to write and run a C# console app
- How to use variables, input, output, and operators
- How to write methods and classes
- How to organize simple project files

## 21. Practice Exercises

Try these exercises:

1. Create a program that asks for the user’s name and prints a greeting.
2. Write a method to calculate the square of a number.
3. Create a class called Student with properties for name and age.
4. Write a program to check if a number is even or odd.
5. Build a small calculator using methods.

## 22. Next Steps

Once you are comfortable with the basics, move on to:

- Object-oriented programming in depth
- Inheritance and polymorphism
- Interfaces
- Generics
- LINQ
- Asynchronous programming
- File handling
- Database programming

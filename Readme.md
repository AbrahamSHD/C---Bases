
# C# Basics Project

This project aims to provide an introduction to the fundamentals of the C# programming language. Throughout the code, basic concepts such as variables, data types, inheritance, interfaces, and generics are explored. Below are the main topics covered:

## Contents

1. **Variables and Basic Data Types**  
   The project begins with declaring and using variables in C#, covering several data types such as `int`, `decimal`, `double`, `float`, `bool`, and `dynamic`. It also demonstrates using string interpolation to print the values of these variables to the console.

2. **Inheritance**  
   An example of how inheritance works in C# is shown by creating a base class `Sale` and a derived class `SaleWithTax`. The derived class inherits from the base class and overrides the `GetInfo` method to add more specific details for the derived class.

3. **Interfaces**  
   The project introduces interfaces by creating two interfaces: `ISale` and `ISave`. It shows how a class can implement multiple interfaces, allowing it to have different responsibilities. Both the `Sale` and `Beer` classes implement the `ISave` interface, enabling them to use the `Save` method to perform actions defined by each class.

4. **Generics**  
   The project presents the use of generics in C# by implementing a class `MyList<T>`, which can store any type of data and has a limit on how many elements it can hold. This is made possible by generics, which allow for more flexible and reusable data type handling.

## Project Structure

The project consists of a main file called `Program.cs`, where the code examples illustrating the aforementioned concepts are implemented.

## Requirements

- **.NET SDK**: To run the project, you need to have the .NET SDK installed.
- **Editor**: It is recommended to use an editor such as Visual Studio or Visual Studio Code to develop and run the code.

## How to Run

1. Clone this repository to your local machine.
2. Open a terminal or command line.
3. Navigate to the project folder.
4. Run the following command to compile and execute the project:

   ```bash
   dotnet run

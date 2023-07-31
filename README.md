# C# Training Sandbox:

## C# Basics
 - Description: Your goal is to understand how you can write basic C# code in .NET
 - Source to learn from: https://learn.microsoft.com/en-us/dotnet/csharp/
### Task 1 - Under the folder CSharp.Basics create a folder named Task1 and create your first "Hello World!" like console application
#### Goal is to understand:
 - what is the program entry point
 - what options can be exploited in the entry point of the program
 - what is a namespace and how they can be used in a C# program
 - which namespace the Console static class belongs to
 - what other functionallity can be exploited from the Console class
#### Optional task(s):
 - Modify the "Hello World!" code in a way the user can write an input for the program and the input is printed on the console

### Task 2 - Under the folder CSharp.Basics create a folder named Task2 replicate your first console application. 
### Modify the code to declare string, char, int, float, double, decimal, boolean variables. Implement the following operations with the variables of the same type:
### add, substract, multiply, divide. Print the values of the variables formatted.
#### Goal is to understand:
 - Working with C# primitive types
 - What are the differences between string and the rest of primitive types
 - What is the binary representation of these primitives
 - How you can work with formatting primitives.
 - Take a look at the format and other methods of string type.
 - Take a look on how you can use Console.WriteLine to format primitives with double digit precission.
#### Optional task(s):
 - Modify your code to print the binary representation of the primitive types
 - Try to divide by the value 0 and draw conclusions, investigate possible handling(s) of the outcome
 - Try to multiply int maximum value by 2 and print the result of the operation and draw conclusions, investigate possible handling(s) of the outcome

### Task 3 - Under the folder CSharp.Basics create a folder named Task3 and create console app by replicating previous steps
### The application should ask user input for a number, then decide if the number is an odd or even number. The result "Odd" or "Even" should be printed.
#### Goal is to undrstand:
 - Control flow of application
 - User input parsing
#### Optional task(s):
 - Make the application accept and evaluate the input multiple times until escape is hit. When escape is hit the app should close
 - Modify the app in a way that user can specify a minimum and maximum range, than wait for user input (the number) and decide if it is in range or out of range. Result should be printed: "[min - max] - [number]: (Is/Is not) in range"
 - Modify the app in a way that user can input "Cat" "Mouse" "Horse" and based on input result should be written: "Is a {the input}". If anything else is introduced than result should be "Unknown input"

### Task 4 - Under the folder CSharp.Basics create a folder named Task4 and create console app by replicating previous steps
### Create a console app which works with arrays and lists, please structure the code to your best judgement
#### Goal is to understand:
 - What arrays and lists are
 - How to work with them via for, foreach loops
 - What methods and functions are
#### Tasks and subtasks
 - Define the following array of elements as an array: 1,2,3,4,5,..10
 - Create a method that prints the elements of the array to the console
 - Modify the method created so it can also print the elements of array in a reverse order
 - Create a function that adds the values of all elements and prints out the array and the sum of elements
 - Create a function that multiplies the odd numbers of the array, prints out the array and the multiplied value of the elements
 - Define a list of elements as 1.2, 3.4, 6.6, 9.9, 17.234
 - Create the same functionallity as for the arrays but now for the list
 - Define a 2 dimensional 3x3 array or matrix Ex: [1,2,3] [4,5,6] [7,8,9]
 - Create a method that prints the elements of the matrix with a format that displays a matrix of 3x3
 - Create a method that prints out the diagonals of the matrix in a single line. Ex: 1,5,9 3,5,7
 - Create a function that can add 2 3x3 matrices together and prints out the resulting matrix

### Task 5 - Under the folder CSharp.Basics create a folder named Task5 and create console app by replicating previous steps
### Create a console app which uses classes structs and interfaces
#### Goal is to understand:
 - What structs are and how they work
 - What classes are and how they work
 - What interfaces are and how they work and are used
#### Tasks:
 - Create a structure (keyword struct) which defines a point in the carthesian coordinate system (Should define X, Y to be able to define a point) name it Point.
 - Create a static helper method that receives a Point struct and prints the X Y coordinates to the console. Call the method in the Main method of the Program
 - Create a list of Points (a Point is a struct) on the carthesian coordinate system. Implement a new static helper method which received a list of points and prints all points to the console.
 - OPTIONAL: Transform the static helper methods to extension methods on a Point struct
 - Create a function which calculates the longitude of the edges of a list of points. As the input create a new set of points which have points defined on the negative side of the carthesian coordinate system. EX: [ { -3, -4 } { -2, -2 } { 2, 2 } { 3, 5 } { 7, -3 } ]
 - Create a class to define the same point, name it Point2D
 - Override the ToString method of the class to print the X, Y values of the Point2D to the console.
 - Create a list of Point2D class instances
 - Create a static helper method that prints the list of Point2D instances to the console by invoking their ToString method
 - Create a Triangle class which defines 3 Point2D members, create a member function which calculates the edges of the triangle. Call it and print the result to the console
 - Extract the edge calculating function to an interface called ICalculateEdges
 - Create a Square class which defines 4 Point2D members and impement the ICalculateEdges interface. Call the function and print the result to the console.

 - NOTE: Each member of a class should be initialized through the classes constructor

using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("Hello World");

    // example of declaring variables, composite formatting, and string interpolation
    int x = 100; 
    var y = "dogs";
    Console.WriteLine("I have {0} {1}", x, y);
    Console.WriteLine($"I have {x} {y}");

    // example of using user input
    var yourName = Console.ReadLine();
    Console.WriteLine("Your name is {0}", yourName);

    // example of constants
    const int num = 13;
    //num = 9; //error
    Console.WriteLine($" {num} ");
    
    // example of constants declared without value
    // const int color;
    // color = red;
    // Console.WriteLine($" {color}");

    // example of basic arithmetic
    int a = 1;
    int b = 2; 
    int c = a + b;
    Console.WriteLine($"{a}, {b}, {c}");

  }
}
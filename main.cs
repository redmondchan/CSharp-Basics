using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("Hello World");

    int x = 100; 
    var y = "dogs";
    Console.WriteLine("I have {0} {1}", x, y);
    Console.WriteLine($"I have {x} {y}");

    var yourName = Console.ReadLine();
    Console.WriteLine("Your name is {0}", yourName);

    const int num = 13;
    //num = 9; //error
    Console.WriteLine($" {num} ");

    // const int color;
    // color = red;
    // Console.WriteLine($" {color}");

    int a = 1;
    int b = 2; 
    int c = a + b;
    Console.WriteLine($"{a}, {b}, {c}");

  }
}
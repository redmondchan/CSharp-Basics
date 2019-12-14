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


  }
}
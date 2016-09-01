using System;

namespace Hello {
  class Program {
    static void Main(string[] args) {
      string name;

      Console.Write("Your Name: ");
      name = Console.ReadLine();

      Console.WriteLine($"Hello, {name}!");
    }
  }
}

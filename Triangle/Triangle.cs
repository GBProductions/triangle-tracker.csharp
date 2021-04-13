using System;
using Triangle.Models;

namespace TriangleTracker 
{
  public class TriangleProgram
  {
    public static void Main()
    {
      Console.WriteLine("Let's figure out if we have a triangle! Enter the length of one side (please use a numeral):");
      string stringAnswerOne = Console.ReadLine();
      int answerOne = int.Parse(stringAnswerOne);

      Console.WriteLine("Enter the length of the second side (please use a numeral):");
      string stringAnswerTwo = Console.ReadLine();
      int answerTwo = int.Parse(stringAnswerOne);

      Console.WriteLine("Enter the length of the third side (please use a numeral):");
      string stringAnswerThree = Console.ReadLine();
      int answerThree = int.Parse(stringAnswerOne);
    }
  }
}
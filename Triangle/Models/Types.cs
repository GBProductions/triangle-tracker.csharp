namespace Triangle.Models
{
  public class Types
  {
    public static string TriangleMethod(int answerOne, int answerTwo, int answerThree)
      {
        if ((answerOne == answerTwo) && (answerTwo == answerThree)) {
          return "This is an equilateral triangle.";
        } else {
          return "This is something else.";
        }
      }
  }
}
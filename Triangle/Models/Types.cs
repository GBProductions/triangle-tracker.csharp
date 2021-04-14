namespace Triangle.Models
{
  public class Types
  {
    public static string TriangleMethod(int answerOne, int answerTwo, int answerThree)
      {
        if ((answerOne == answerTwo) && (answerTwo == answerThree)) {
          return "This is an equailateral triangle.";
        } else {
          return "This is something else.";
        }
      }
  }
}
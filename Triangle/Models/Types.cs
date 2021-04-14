namespace Triangle.Models
{
  public class Types
  {
    public static string TriangleMethod(int answerOne, int answerTwo, int answerThree)
      { 
        if ((answerOne > (answerTwo + answerThree)) || (answerTwo > (answerOne + answerThree)) || (answerThree > (answerOne + answerTwo)))
        {
          return "This is something else.";
        }
        else if ((answerOne == answerTwo) && (answerTwo == answerThree) && (answerOne == answerThree)) 
        {
          return "This is an equilateral triangle.";
        }
        else if ((answerOne != answerTwo) && (answerTwo != answerThree))
        {
          return "This is a scalene triangle.";
        } 
        else 
        {
          return "This is an isosceles triangle.";
        }
      }
  }
}
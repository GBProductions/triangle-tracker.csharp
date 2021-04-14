using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleMethodTests
  { 
    [TestMethod]
    public void TriangleMethod_AreAllSidesEqual_TrueString()
    {
      Assert.AreEqual("This is an equilateral triangle.", Types.TriangleMethod(3, 3, 3));
    }

    [TestMethod]
    public void TriangleMethod_AreAllSidesEqual_FalseString()
    {
      Assert.AreEqual("This is something else.", Types.TriangleMethod(3, 4, 5));
    }
  }
}

  

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleMethodTests
  { 
    [TestMethod]
    public void TriangleMethod_NotATriangle_String()
    {
      Assert.AreEqual("This is something else.", Types.TriangleMethod(2, 2, 8));
    }

    [TestMethod]
    public void TriangleMethod_AreAllSidesEqual_String()
    {
      Assert.AreEqual("This is an equilateral triangle.", Types.TriangleMethod(3, 3, 3));
    }

    [TestMethod]
    public void TriangleMethod_AreNoSidesEqual_String()
    {
      Assert.AreEqual("This is a scalene triangle.", Types.TriangleMethod(3, 4, 5));
    }

    [TestMethod]
    public void TriangleMethod_AreTwoSidesEqual_String()
    {
      Assert.AreEqual("This is an isosceles triangle.", Types.TriangleMethod(3, 4, 4));
    }
  }
}

  

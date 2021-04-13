using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleMethodTests
  { 
    [TestMethod]
    public void TriangleMethod_AreAllSidesEqual_True()
    {
      Assert.AreEqual(true, Types.TriangleMethod(3, 3));
    }
  }
}
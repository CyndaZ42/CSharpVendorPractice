using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    // Test methods go here
    [TestMethod]
    public void Method_Behavior_ReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("Behavior is behaving", Vendor.Method("Behavior"));
    }
  }
}
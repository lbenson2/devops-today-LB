using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Controllers;

namespace NetOps.MSTesting.Tests
{
  public class ErrorViewModelTests
  {
    [TestMethod]
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModel(){RequestId = "fred"};

      Assert.IsTrue(sut.ShowRequestId);
    }    
  }
}
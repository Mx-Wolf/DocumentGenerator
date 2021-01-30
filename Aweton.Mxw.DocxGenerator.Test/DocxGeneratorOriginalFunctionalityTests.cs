using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Aweton.Mxw.DocxGenerator.Test
{
  [TestClass]
  public class DocxGeneratorOriginalFunctionalityTests
  {
    [TestMethod]
    public void CtorDoesNotCheckTheTemplateExists()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}");
      Assert.IsNotNull(dg);
    }
  }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aweton.Mxw.DocxGenerator.Test
{
  [TestClass]
  public class DocxGeneratorGenerateTests
  {
    [TestMethod]
    public void GenerateFilesThrowsIfNoDataLoaded()
    {
      var dg = new DocumentGenerator.DocxGenerator("", 0);
      dg.GenerateFiles(null);
    }
  }
}

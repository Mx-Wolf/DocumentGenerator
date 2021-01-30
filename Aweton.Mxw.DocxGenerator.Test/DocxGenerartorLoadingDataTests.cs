using DocumentGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Aweton.Mxw.DocxGenerator.Test
{
  [TestClass]
  public class DocxGenerartorLoadingDataTests
  {
    [TestMethod]
    public void AddLeafletNoThrowsOnFirstNullDictionary()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}", -1);
      Dictionary<string, string> tags = null;
      dg.AddLeaflet(tags);
      Assert.IsTrue(true);
    }
    [TestMethod]
    public void AddLeafletThrowsOnSecondNullDictionary()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}", -1);
      Dictionary<string, string> tags = null;
      dg.AddLeaflet(tags);
      _ = Assert.ThrowsException<NullReferenceException>(() => dg.AddLeaflet(tags));
    }

    [TestMethod]
    public void AddLeafletAcceptsFirstNullLeaflet()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}", -1);
      Leaflet ll = null;
      dg.AddLeaflet(ll);
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void AddLeafletThrowsOnSecondNullLeaflet()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}", -1);
      Leaflet ll = null;
      dg.AddLeaflet(ll);
      Assert.ThrowsException<NullReferenceException>(() => dg.AddLeaflet(ll));
    }
  }
}

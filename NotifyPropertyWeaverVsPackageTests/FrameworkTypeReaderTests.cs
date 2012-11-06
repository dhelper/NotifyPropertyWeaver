using NUnit.Framework;

[TestFixture]
public class FrameworkTypeReaderTests
{

    [Test]
    public void DotNet35()
    {
        Assert.AreEqual("DotNet_35", FrameworkTypeReader.GetFrameworkType(@"TestProjects\ProjectDotNet.csproj"));
    }
    [Test]
    public void Silverlight()
    {
        Assert.AreEqual("PCL", FrameworkTypeReader.GetFrameworkType(@"TestProjects\ProjectSilverlight.csproj"));
    }
    [Test]
    public void Phone()
    {
        Assert.AreEqual("PCL", FrameworkTypeReader.GetFrameworkType(@"TestProjects\ProjectPhone.csproj"));
    }
    [Test]
    public void PCL()
    {
        Assert.AreEqual("PCL", FrameworkTypeReader.GetFrameworkType(@"TestProjects\ProjectPCL.csproj"));
    }
}
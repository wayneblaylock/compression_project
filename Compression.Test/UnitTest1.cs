namespace Compression.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FindBiggest()
    {
        Assert.That(Compressor.FindBiggest("1"), Is.EqualTo(0));
        Assert.That(Compressor.FindBiggest("11"), Is.EqualTo(1));
        Assert.That(Compressor.FindBiggest("100"), Is.EqualTo(0));
        Assert.That(Compressor.FindBiggest("1011101"), Is.EqualTo(3));
    }

    [Test]
    public void CompressString()
    {
        Assert.That(Compressor.CompressString("11"), Is.EqualTo(("1",(1,1))));
        Assert.That(Compressor.CompressString("1010"), Is.EqualTo(("10",(2,2))));
        Assert.That(Compressor.CompressString("100101"), Is.EqualTo(("10",(2,3))));
        Assert.That(Compressor.CompressString("110101011101"), Is.EqualTo(("11010101",(4,8))));
    }
}
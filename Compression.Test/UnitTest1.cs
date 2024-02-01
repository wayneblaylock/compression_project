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
        Assert.That(CompressorHelper.FindBiggest("1"), Is.EqualTo((0,0)));
        Assert.That(CompressorHelper.FindBiggest("1010"), Is.EqualTo((2,2)));
        Assert.That(CompressorHelper.FindBiggest("100"), Is.EqualTo((0,0)));
        Assert.That(CompressorHelper.FindBiggest("1011101"), Is.EqualTo((3,4)));

    }

    [Test]
    public void CompressString()
    {
        Assert.That(CompressorHelper.CompressString("11",(1,1)), Is.EqualTo("1"));
        Assert.That(CompressorHelper.CompressString("1010",(2,2)), Is.EqualTo("10"));
        Assert.That(CompressorHelper.CompressString("100101",(2,3)), Is.EqualTo("1001"));
        Assert.That(CompressorHelper.CompressString("110101011101",(4,7)), Is.EqualTo("11010101"));
    }

}
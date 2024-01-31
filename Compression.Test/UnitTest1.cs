namespace Compression.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FindBiggest2()
    {
<<<<<<< HEAD
        Assert.That(CompressorHelper.FindBiggest("1"), Is.EqualTo(0));
        Assert.That(CompressorHelper.FindBiggest("1010"), Is.EqualTo(2));
        Assert.That(CompressorHelper.FindBiggest("100"), Is.EqualTo(0));
        Assert.That(CompressorHelper.FindBiggest("1011101"), Is.EqualTo(3));
=======
        // Assert.That(CompressorHelper.FindBiggest("101011"), Is.EqualTo(2));
        Assert.AreEqual(2, CompressorHelper.FindBiggestRepeat("1010"));
        Assert.AreEqual(5, CompressorHelper.FindBiggestRepeat("1010010100"));
        Assert.AreEqual(3, CompressorHelper.FindBiggestRepeat("1010101"));
        Assert.AreEqual(6, CompressorHelper.FindBiggestRepeat("101000101000"));

>>>>>>> 1f1d0617374f76c488defd4d85554277ece6c993
    }

    // [Test]
    // public void CompressString()
    // {
    //     Assert.That(Compressor.CompressString("11"), Is.EqualTo(("1",(1,1))));
    //     Assert.That(Compressor.CompressString("1010"), Is.EqualTo(("10",(2,2))));
    //     Assert.That(Compressor.CompressString("100101"), Is.EqualTo(("10",(2,3))));
    //     Assert.That(Compressor.CompressString("110101011101"), Is.EqualTo(("11010101",(4,8))));
    // }
}
using Compression;


// string bits = "10111011001011010101011101";
// Console.WriteLine(bits);
// (int,int) instructions = CompressorHelper.FindBiggest(bits);
// Console.WriteLine(instructions.ToString());
// string compressedBits = CompressorHelper.CompressString(bits, instructions);
// Console.WriteLine(compressedBits);

string bits = GenerateString.GetString(10);
Console.WriteLine(bits);
(string compressed, List<(int,int)>) output = Compressor.Compression(bits);
Console.WriteLine(output.compressed);
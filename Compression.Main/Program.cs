using Compression;


// string bits = "10111011001011010101011101";
// Console.WriteLine(bits);
// (int,int) instructions = CompressorHelper.FindBiggest(bits);
// Console.WriteLine(instructions.ToString());
// string compressedBits = CompressorHelper.CompressString(bits, instructions);
// Console.WriteLine(compressedBits);

string bits = GenerateString.GetString(10000);
Console.WriteLine("Original:");
Console.WriteLine(bits + "\n");
(string compressed, List<(int,int)> instructions) output = Compressor.Compression(bits);
Console.WriteLine("Compressed To:");
Console.WriteLine(output.compressed);
for (int i = 0; i < output.instructions.Count; i++) Console.Write($"{output.instructions[i].ToString()} ");
Console.WriteLine("\n");

string decompressed = Compressor.Decompression(output.compressed, output.instructions);
Console.WriteLine("Decompressed:");
Console.WriteLine(decompressed);

Console.WriteLine($"\nPre Compression and Post Compression Match: {bits == decompressed}");
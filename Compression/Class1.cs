namespace Compression;

public class Compressor : IBitStringCompressor
{
    public static string Compression()
    {
        return "hello";
    }
    public static string Decompression()
    {
        return "hello";
    }
}

public class GenerateString
{
    public static void GetString(int length)
    {
        Random random = new Random();
        string randstring = "";
        for (int i = 0; i < length; i++)
        {
            randstring += random.Next(0, 2);
        }
        Console.WriteLine(randstring);
    }
}

public class CompressorHelper
{
    public static int FindBiggest(string binaryString)
    {
        int maxLength = 0;
        int length = 1;

        for (int i = 1; i < binaryString.Length; i++)
        {
            if (binaryString[i] == binaryString[i - 1])
            {
                length++;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
            else
            {
                length = 1;
            }
        }

        return maxLength;
    }
    public static int FindBiggestRepeat(string code)
    {
        int checkLength = 2;
        if (code.Length <= 2)
        {
            return 0;
        }
        string currentChunk = code.Substring(0, checkLength);
        string uncheckedRepeats = code.Substring(checkLength, code.Length - checkLength);
        if (!uncheckedRepeats.Contains(currentChunk))
        {
            return 0;
        }
        while (uncheckedRepeats.Contains(currentChunk))
        {
            checkLength++;
            currentChunk = code.Substring(0, checkLength);
            uncheckedRepeats = code.Substring(checkLength, code.Length - checkLength);
        }
        return checkLength - 1;
    }
}
using System.Numerics;
using System.Security.AccessControl;

namespace Compression;

public class Compressor : IBitStringCompressor
{
    public static (string, List<(int, int)>) Compression(string bits){
        List<(int,int)> instructions = new List<(int, int)>();
        while (true){
            (int length,int start) instruction = CompressorHelper.FindBiggest(bits);
            //if (instruction.length < 2) break;
            if (instruction.length == 0){
                instruction = (0,(int)char.GetNumericValue(bits[0]));
                //Console.WriteLine($"{instruction}   {bits}");
                instructions.Insert(0, instruction);
                bits = bits.Substring(1);
            }
            else{
                //Console.WriteLine($"{instruction}   {bits}");
                instructions.Insert(0,instruction);
                bits = CompressorHelper.CompressString(bits, instruction);
            }
            if (bits.Length < 10) break;
        }
        return (bits, instructions);

    }
    public static string Decompression(string bits, List<(int length, int start)> instructions){
        for (int i = 0; i < instructions.Count; i++){
            (int length, int start) instruction = instructions[i];
            if (instruction.length == 0){
                bits = instruction.start.ToString() + bits;
            }
            else{
                bits = bits.Substring(0, instruction.start) + bits.Substring(0, instruction.length) + bits.Substring(instruction.start);
            }
        }
        return bits;
    }
}

public class GenerateString
{
    public static string GetString(int length)
    {
        Random random = new Random();
        string randstring = "";
        for (int i = 0; i < length; i++)
        {
            randstring += random.Next(0, 2);
        }
        return randstring;
    }
}

public class CompressorHelper
{
    public static (int, int) FindBiggest(string bits){
        int maxLength = 0;
        int maxLengthStart = 0;
        int length = 2;
        for (int i = length; i < bits.Length - length + 1; i++){
            bool lengthWorks = true;
            for (int j = 0; j < length; j++){
                // Console.WriteLine($"{j}=>{bits[j]}  {i+j}=>{bits[i+j]}");
                if (bits[j] != bits[i+j]) {
                    lengthWorks = false;
                    //Console.WriteLine("reset");
                    break;
                    }
            }
            if (lengthWorks) {
                maxLength = length;
                maxLengthStart = i;
                //Console.WriteLine($"Max Length updated to {maxLength} and Start to {maxLengthStart}");
                length ++;
                i = length;
            }
        }
        return (maxLength, maxLengthStart);
    }

    public static string CompressString(string bits, (int length, int start) instructions){
        string CompressedString = bits.Substring(0, instructions.start) + bits.Substring(instructions.start + instructions.length);
        return CompressedString;
    }
}
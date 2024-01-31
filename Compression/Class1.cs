namespace Compression;

public class Compressor : IBitStringCompressor{
    public static string Compression(){
        return "hello";
    }
    public static string Decompression(){
        return "hello";
        }
    public static 
}

public class GenerateString{
    public static void GetString(int length){
        Random random = new Random();
        string randstring = "";
        for (int i = 0; i < length; i++){
            randstring += random.Next(0,2);
        }
    Console.WriteLine(randstring);
    }
}
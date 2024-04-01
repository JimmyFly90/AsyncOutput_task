public class AsyncOutput
{
    // Set the file path to the file you downloaded here
    public static string filePath = "C:\\Users\\GAMER_PC\\Documents\\file.txt";

    public static void Main()
    {
        Console.WriteLine("Started Program");

        ReadFile(filePath);

        Console.WriteLine("<< ASYNC CHECK >>");

        Console.WriteLine("Ended Program");
    }

    public static string ReadFile(string fileName)
    {
        Console.WriteLine("Started Reading File");
        string text = File.ReadAllText(fileName);
        Console.WriteLine("Ended Reading File");
        return text;
    }
}
public class AsyncOutput
{
    // Set the file path to the file you downloaded here
    public static string filePath = "/Users/James.Flynn/Documents/AsyncOutput_task/AsyncOutput/file.txt";

    public static async Task Main()
    {
        Console.WriteLine("Started Program");

        Task fileReadingTask = ReadFile(filePath);

        Console.WriteLine("<< ASYNC CHECK >>");

        await fileReadingTask;

        Console.WriteLine("Ended Program");
    }

    public static async Task ReadFile(string fileName)
    {
        Console.WriteLine("Started Reading File");
        string text = await File.ReadAllTextAsync(fileName);
        Console.WriteLine("Ended Reading File");
    }
}
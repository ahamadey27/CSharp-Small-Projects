namespace _06_guess_word
{
    public class IO_classes
    {
        public static void WriteReadText(string filename, string content)
        {
            //write content to file
            File.WriteAllText(filename, content);

            //Read the content back from the file
            string readText = File.ReadAllText(filename);

            //output the read text
            Console.WriteLine(readText);
        }
    }
}

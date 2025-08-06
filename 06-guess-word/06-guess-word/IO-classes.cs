namespace _06_guess_word
{
    public class IO_classes
    {
        public static void WriteTextExample()
        {
            string writeText = "Hello Text";
            File.WriteAllText("filename.txt", writeText);
            //newly created text is read and stored in variable
            string readText = File.ReadAllText("filename.txt");
            //The read text is outputted
            Console.WriteLine(readText);
        }
    }
}

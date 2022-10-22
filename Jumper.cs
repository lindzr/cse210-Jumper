class Program {

    static void Main()
    {
        string newWord = "yes";
        string guessingWord = "";

        Words Word = new Words();


        do
        {
            Console.WriteLine("What difficulty do you want? (easy, intermediate, hard) ");
            string difficulty = Console.ReadLine();

            guessingWord = Word.retrieveWord(difficulty);
            Console.WriteLine(guessingWord);
            
            Console.WriteLine("New word? ");
            newWord = Console.ReadLine();
            
            } while (newWord != "no");
    }
}
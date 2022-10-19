string newWord = "yes";

Words guessingWord = new Words();

do
{
Console.WriteLine("What difficulty do you want? (easy, intermediate, hard) ");
string difficulty = Console.ReadLine();

guessingWord.retrieveWord(difficulty);
Console.WriteLine("New word? ");
newWord = Console.ReadLine();} while (newWord != "no");
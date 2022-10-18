// Ask for difficulty and picks random word from wordbanks

class Words
{
    string difficulty = "";

    public string retrieveWord(string difficulty)
    {
        if (difficulty == "easy")
        {
            List <string> wordbank = new List<string>(){"reach","heart","tiger","football"};
            int index = Random.Next(wordbank.Count);
             return Console.WriteLine(wordbank[index]);
        }
    
        else if (difficulty == "intermediate")
        {
            List <string> wordbank = new List<string>(){"blizzard", "staff", "kiwi", "witch", "zipper"};
            int index = Random.Next(wordbank.Count);
            return Console.WriteLine(wordbank[index]);
        }

        else
        {
            List <string> wordbank = new List<string>(){"waltz", "numbskull", "pneumonia", "marquis", "kitsch", "jazz"};
            int index = Random.Next(wordbank.Count);
            return Console.WriteLine(wordbank[index]);
        }

    }
}



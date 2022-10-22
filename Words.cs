// Ask for difficulty and picks random word from wordbanks

class Words
{
    string difficulty = "";
    Random generator = new Random();

    public string Difficulty {get; set;}
    
    public string retrieveWord(string difficulty)
    {
        if (difficulty == "easy")
        {
            List <string> wordbank = new List<string>(){"reach","heart","tiger","football"};
            int wordbankIndex = generator.Next(wordbank.Count);
            return (wordbank[wordbankIndex]);
        }
    
        else if (difficulty == "intermediate")
        {
            List <string> wordbank = new List<string>(){"blizzard", "staff", "kiwi", "witch", "zipper"};
            int wordbankIndex = generator.Next(wordbank.Count);
            return (wordbank[wordbankIndex]);
        }

        else
        {
            List <string> wordbank = new List<string>(){"waltz", "numbskull", "pneumonia", "marquis", "kitsch", "jazz"};
            int wordbankIndex = generator.Next(wordbank.Count);
            return (wordbank[wordbankIndex]);
        }

    }
}



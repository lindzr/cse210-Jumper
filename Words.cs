// Ask for difficulty and picks random word from wordbanks

class Words
{
    string difficulty = "";

    public string retrieveWord(string difficulty)
    {
        if (difficulty == "easy")
        {
            List <string> wordbank = new List<string>(){"reach","heart","tiger","football"};
        }
    
        else if (difficulty == "intermediate")
        {
            List <string> wordbank = new List<string>(){"blizzard", "staff", "kiwi", "witch", "zipper"};
        }

        else
        {
            List <string> wordbank = new List<string>(){"waltz", "numbskull", "pneumonia", "marquis", "kitsch", "jazz"};
        }

    }
}



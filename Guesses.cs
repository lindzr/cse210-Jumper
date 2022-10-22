/* This class will: 
- check if letter is in word 
- provide a list of previous guesses 
- contains for loop to determine how many instances a letter occurs */


class Guesses{
    List<string> previousGuesses = new List<string>;
    //insert getter from Words class to retrieve the word and letter/guess
    public string word = retrieveWord(difficulty);
    public string letter = GetLetter();
    public int numLetters = 0; 

//this function finds the number of occurences each letter has in the word. If a letter occurs multiple times numLettter will count those occurences and get returned.
    public int numRepeats()
    {
        do
        {
            numLetters = numLetters + 1;
            
        } 
        while (word.Contains(letter));

        return numLetters;
    }

//this function determines if the users guess was in the letter or not by returning a boolean
    public bool guessIsCorrect()
        {
            do
            {
                bool correctGuess = true;
            } 
            while (word.Contains(letter));

            return correctGuess;
        }

    public List<string> guessesBank(string letter)
        {
            previousGuesses.Add(letter);
            return previousGuesses;
        }



    //make a method to return a bool if guess is correct
    //make a method to return the number of instances the letter appears in the word
    //find index at which the letter occurs
    
}
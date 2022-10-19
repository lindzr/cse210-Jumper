/* This class will: 
- check if letter is in word 
- provide a list of previous guesses 
- contains for loop to determine how many instances a letter occurs */


class Guesses{
    List<string> previousGuesses = new List<string>;
    //insert getter from Words class to retrieve the word and letter/guess
    public string word = GetWord();
    public string letter = GetLetter();
    public int numLetters = 0; 

    public bool GuessIsCorrect()
    {
        do
        {
            numLetters = numLetters + 1;
            previousGuesses.Add(letter);
        } 
        while (word.contains(letter));

        return numLetters;
    }

    //make a method to return a bool if guess is correct
    //make a method to return the number of instances the letter appears in the word
    //find index at which the letter occurs
    
}
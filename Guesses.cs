/* This class will: 
- check if letter is in word 
- provide a list of previous guesses 
- contains for loop to determine how many instances a letter occurs */


class Guesses{
    List<string> previousGuesses = new List<string>;
    string word = GetWord();
    string letter = GetLetter();

    do
    {
        previousGuesses.Add(letter);
    } 
    while (word.contains(letter));

}
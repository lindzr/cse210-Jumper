<<<<<<< HEAD
=======
/* This class will: 
- check if letter is in word 
- provide a list of previous guesses 
- contains for loop to determine how many instances a letter occurs */

>>>>>>> 0721a0b6689541e2e20a7c9b9bad2c823550b0a4

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
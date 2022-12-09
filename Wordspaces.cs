using System;
using System.Collections.Generic;

//creates lists for the chosen word from Words and the hidden word which is displayed
//to the user. Compares the player guess to the chosen word to see if the hidden word
//reveals a number. Tells if the player guess is in the chosen word and checks if the
//game is over.

class Wordspaces : Person
{
    public string character {get ; set;}
    string chosenWord {get; set;}
    List<string> hiddenWordList = new List<string>();
    List<string> chosenWordList = new List<string>();


    public List<string> MakeChosenWordList() 
    {// makes list of the chosen word
        
        chosenWord = Words.retrieveWord();

        foreach (char c in chosenWord)
        {
            chosenWordList.Add(c.ToString());
        }
        return chosenWordList;
    }    

    public void MakeHiddenWordList()
    {//makes hidden word list
      character = "_";
      
      foreach ( string i in chosenWordList)
        {
            hiddenWordList.Add(character);
        }
        foreach (string i in hiddenWordList)
            {Console.Write(i);} 
            
    }
    public void checkGuess(string playerguess)
    {//checks player's guess against chosen word. Reveals hidden word letter if it is.
        for (int i = 0; i < chosenWordList.Count; i++)
        {
            if (playerguess == chosenWordList[i])
            {
                hiddenWordList[i] = playerguess;
            }
        }
        for (int j = 0; j < hiddenWordList.Count; j++)
            {
                Console.Write(hiddenWordList[j]);
            }       
    }

    public bool ContainsGuess(string playerguess)
    {//checks if player guess is in hidden word AFTER checkguess() has been used
        if (hiddenWordList.Contains(playerguess))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isGameOver(List<string> parachute)
    {//checks if game is over by losing the parachute or finding the whole hidden word
        if (parachute.Count == 0)
        {
            return true;
        }

        else if (!hiddenWordList.Contains("_"))
        {
            return true;
        }
        else if (parachute.Count > 0 && hiddenWordList.Contains("_"))
        { 
            return false;
        }
        else
        {
            return false;
        }
    }
}
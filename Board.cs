/* This class will: 
- create a position for each part of the image 
- alter the image if guesses are incorrect 
- end game method */

class Board {

//create visual board to display to user 
// private List<List<string>> parachute;
private string wordspaces;
}
static void createParachute() {
        string[] parachute = {
        ("_","_","_"),
        ("/","_","_","_","\\"),
        ("\\"," "," "," ","/"),
        ("\\"," ","/"),
        ("O"),
        ("/","|","\\"),
        ("/"," ","\\"),
        ("          "),
        ("^","^","^","^","^","^","^")};

        Console.WriteLine(parachute);
    }
    

//get word from Words class and update board to show correct number of letters 

private string wordSpaces;

public string WordSpaces {
    get {return this.wordSpaces;} 
    set {this.wordSpaces = "";}


static string GetWordSpaces() {
    string wordSpaces = "";
    
    foreach in wordSpaces {

    }

    return wordSpaces;
}

//replace underscore with the letter when guess correctly 

//and alter parachute image when guess incorrectly 

//game over WHEN parachute is gone (and head turns from O to X- dead)


//game over WHEN word is completed correctly and parachute still exists 

}


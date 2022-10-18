/* This class will: 
- create a position for each part of the image 
- alter the image if guesses are incorrect 
- end game method */

class Board {

//create visual board to display to user 
static void CreateBoard() {
    parachute = new List<List<string>> {
        List<string> ("_","_","_"),
        List<string> ("/","_","_","_","'\'"),
        List<string> ("'\'"," "," "," ","/"),
        List<string> ("'\'"," ","/"),
        List<string> ("O"),
        List<string> ("/","|","'\'"),
        List<string> ("/"," ","'\'"),
        List<string> ("          "),
        List<string> ("^","^","^","^","^","^","^")
    };
    
    Console.WriteLine(parachute);
}

//get word from Words class and update board to show correct number of letters 

//replace underscore with the letter when guess correctly 
//and alter parachute image when guess incorrectly 

//game over WHEN parachute is gone (and head turns from O to X- dead)
//game over WHEN word is completed correctly and parachute still exists 




}



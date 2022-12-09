using System.Collections.Generic;

class Parachute
{//makes and draws parachute
    List <string> parachuteList = new List<string>(){" ___","/___\\","\\   /"," \\ /"};
    
    public List<string> GetParachuteList()
    {
        return parachuteList;
    }

    public void DrawParachute(List<string> parachute)
    {   
        Console.WriteLine("");
        foreach (string i in parachute)
        {
            Console.WriteLine(i);
        }
    }
}
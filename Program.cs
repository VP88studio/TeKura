using System;
using System.ComponentModel.DataAnnotations;

class MainProgram
{
    static string goal = "Hi my name is Jim, I love coding and gaming, my favorite game is Minecraft.\nI have a simple understanding of how to code in 8 programming languages.\nI like hanging out with my friends at school but strugle to be there";
    static void Main()
    {
        //I coded this btw;
        string result = "";
        int fitness = 0;
        //candadites
        int candadites = 500;
        Console.WriteLine(goal.Length);
        int goallen = goal.Length;
        //should be 217
        int glen = goal.Length;
        List<string> AllowedCharacters = new List<string>() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", 
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ",", ".", " ", "\n", "'"};
        int alen = AllowedCharacters.Count;
        Console.WriteLine(alen);
        List<string> Candadites = new List<string>() {};
        List<int> FitnessList = new List<int>() {};
        //creating candadites
        for (int l = 0; l < candadites; l++)
        {
            for (int i = 0; i < glen; i++)
            {
                int index = Random.Shared.Next(0, alen);
                string clen = AllowedCharacters[index];
                result = result + clen;
            }
            for (int i = 0; i < glen; i++)
            {
                if (result[i] == goal[i])
                {
                    fitness += 1;
                }
            }
            FitnessList.Add(fitness);
            Candadites.Add(result);
            fitness = 0;
            result = "";
        }
        Console.WriteLine(Candadites[1]);
        Console.WriteLine(FitnessList[1]);
    }
}
public class Individual
{
    public int id;
    public string generationvalue;
    public int fitness;
}
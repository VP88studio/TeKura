using System;
using System.ComponentModel.DataAnnotations;

class MainProgram
{
    //debugfunc
    static string PrintPopValue(Individual i)
    {
        return $"ID: {i.id}\nGenerationValue: {i.generationvalue}\nFitness: {i.fitness}\nPlaceValues: {string.Join(", ", i.Places)}";
    }
    static string goal = "Hi my name is Jim, I love coding and gaming, my favorite game is Minecraft.\nI have a simple understanding of how to code in 8 programming languages.\nI like hanging out with my friends at school but strugle to be there";
    public static Individual MakeCandadite(int gcount, string genstring, int fitness, List<int> tempplace)
        {
        Individual Candadite = new Individual();
        Candadite.id = gcount;
        Candadite.generationvalue = genstring;
        Candadite.generationcount = 1;//tempbtw
        Candadite.fitness = fitness;
        Candadite.Places = tempplace;
        return Candadite;
    }
    static void Main()
    {
        //I coded this btw;
        string result = "";
        int placevalue = 0;
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
        List<int> TempPlaceValue = new List<int>();
        List<Individual> Population = new List<Individual>();
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
                placevalue += 1;
                if (result[i] == goal[i])
                {
                    TempPlaceValue.Add(placevalue);
                    fitness += 1;
                }
            }
            Population.Add(MakeCandadite(l, result, fitness, TempPlaceValue));
            fitness = 0;
            result = "";
            placevalue = 0;
            TempPlaceValue = new List<int>();
        }
        Console.WriteLine(PrintPopValue(Population[0]));
    }
}
public class Individual
{
    public int id;
    public List<int> Places = new List<int>();
    public string generationvalue;
    public int generationcount;
    public int fitness;
}
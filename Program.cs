using System;

class MainProgram
{
    static string goal = "Hi my name is Jim, I love coding and gaming, my favorite game is Minecraft.\nI have a simple understanding of how to code in 8 programming languages.\nI like hanging out with my friends at school but strugle to be there";
    static void Main()
    {
        Console.WriteLine(goal.Length);
        int goallen = goal.Length;
        //should be 217
        List<string> AllowedCharacters = new List<string>() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", 
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ",", ".", " ", "\n", "'"};
    }
}
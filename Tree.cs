using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎄 ПРОКачана ЯЛИНКА v2.0");
        Console.WriteLine("=======================\n");
        
        DrawFancyTree();
        Console.ReadLine();
    }
    
    static void DrawFancyTree()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("       *         ");
        
        string[] tree = {
            "       /\\       ",
            "      /  \\      ",
            "     /^^^^\\     ",
            "    /  **  \\    ",
            "   /   **   \\   ",
            "  /^^^^^^^^^\\  ",
            "/   *******   \\ ",
            "     ||||     ",
            "     ||||     "
        };
        
        foreach (string line in tree)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(line);
        }
        
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("      |||||      ");
        Console.WriteLine("      |||||      ");
        
        Console.ResetColor();
    }

}
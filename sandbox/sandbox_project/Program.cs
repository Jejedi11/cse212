using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
        List<int> data = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int amount = 1;

        int index = 0;
        List<int> rotatedData = new List<int>();
        foreach (int item in data)
        {
            rotatedData.Add(0);
        }
        foreach (int item in data)
        {
            int newIndex = (index + amount) % data.Count;
            Console.WriteLine(newIndex);
            rotatedData[newIndex] = item;
            index++;
        }
            Console.WriteLine("Final");
        data = rotatedData;
        foreach (int item in data)
        {
        Console.WriteLine(item);
        }
        
        Console.WriteLine(data[0]);
    }
}
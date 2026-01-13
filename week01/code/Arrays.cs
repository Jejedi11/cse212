using System.Net.Http.Headers;
using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Initialize an array of doubles with {lenght} being it's size.
        //
        // Start a loop that runs {length} times.
        // Multiply the {number} by the loop's incrementing variable.
        // Add the product to the array of doubles.
        // 
        // Return the array.

        double[] multiples = new double[length];
        for (int i = 1; i <= length; i++)
        {
            double product = number * i;
            multiples[i - 1] = product;
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // OLD PLAN:
        // create an index variable
        // initialize a temporary new list
        // Start a loop that runs of each item in {data}.
        // Add {amount to each item's index}.
        // If the new index is larger than the length of {data} subtract the length of {data} and add that item 
        // to the new list at the new index.
        // Else add the item to the new list at the new index.
        // increment the index variable
        // replace the old list with the new one.
        // 
        // The old plan did not work

        // NEW PLAN:
        // Make an index variable.
        // Initialize a list to store the new data in.
        // Using a loop, populate the new list with temporary data.
        // Create a loop that runs for each item in {data}.
        // Add the amount and index and use the modulus operator to wrap it to the proper index.
        // Replace the item at the new index.
        //increment the index.
        //Clear and add data to the data list.


        int index = 0;
        List<int> rotatedData = new List<int>();
        foreach (int item in data)
        {
            rotatedData.Add(0);
        }
        foreach (int item in data)
        {
            int newIndex = (index + amount) % data.Count;
            rotatedData[newIndex] = item;
            index++;
        }
        data.Clear();
        data.AddRange(rotatedData);
    }
}

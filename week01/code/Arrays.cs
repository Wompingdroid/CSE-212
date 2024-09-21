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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //I will solve this by making a loop that will depend on the length, 
        //then in that loop add the variable number to a sum and use Add() to put this number into the list ill return 

        double multiple = 0;
        var solution = new double[length];
        
        for(int i = 0; i < length; i++){
            multiple += number;
            solution[i] = multiple;
        }

        return solution; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //we are given an array and a number, ha have to take that number and shift the array that amount
        // I will make a temporary value storing variable and use the removeAt() to store then remove that int
        // I will then Add that stored value to the end of the list
        // I will use a loop that takes the difference from Length of the list and the amount wanted shifted and just "shift" it to the left the right amount of times needed
        int tempVar; 
        int shiftLeftAmount = data.Count - amount;
            //loop it
        for(int i = 0; i < shiftLeftAmount; i++){
            tempVar =data[0];
            data.RemoveAt(0);
            data.Add(tempVar);
        }

    }
}

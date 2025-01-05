using System;
class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World !!!");
        // Generate numbers
        int[] numbers = GenerateNumbers();
        // Reverse the array
        Reverse(numbers);
        // Print the reversed array
        PrintNumbers(numbers);
        RecursionBasics.PrintEven(21);
        RecursionBasics.RecursiveString("Angat");

        RecursionBasics fb = new RecursionBasics();
    
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"fib({i}) = {fb.Fib(i)}");
    }

    }
   
    // Method to generate an array of numbers
    public static int[] GenerateNumbers()

    {
        Console.WriteLine("How many array of number you want ?");
        int n = Convert.ToInt16(Console.ReadLine());
        int[] randIntNumbers = new int[n];
        Random randNumb = new Random();
        for(int i=0; i<n;++i){
            randIntNumbers[i]= Convert.ToInt32(randNumb.Next(0,10));
        }
        Console.Write("array before reverse are : ");
        Console.WriteLine(string.Join(",",randIntNumbers));
        return randIntNumbers;
    }
   // Method to reverse the array in place
    public static void Reverse(int[] listNumber)

    {
       /* int[] reverseArray = new int[listNumber.Length];
        for(int i=0;i<listNumber.Length;++i){

            reverseArray[listNumber.Length-1-i]=listNumber[i];
        }
        //Console.Write("Array after reversed are : ");
        //Console.WriteLine(string.Join(",",reverseArray));*/
        int start = 0;
        int end = listNumber.Length - 1;
        while (start < end)
        {
            // Swap elements to reverse the array
            int temp = listNumber[start];
            listNumber[start] = listNumber[end];
            listNumber[end] = temp;
            start++;
            end--;
        }
    }

    // Method to print the array
    public static void PrintNumbers(int[] arrayNumber)
    {
         Console.Write("Final reversed array is : ");
        Console.WriteLine(string.Join(",",arrayNumber));
    }

}


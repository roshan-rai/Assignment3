public class RecursionBasics{

    public static void PrintEven(int n){
        //n=20;
        if(n==0){
            Console.Write($"{n} now stop");
            return;
        }
        if(n%2==0){
            Console.Write($" {n} ");
            PrintEven(n-1);
        }
        else{
            PrintEven(n-1);
        }
    }
    public static void RecursiveString(string name){
        if(name.Length==1){
            Console.WriteLine(name);
            return;
        }
        Console.WriteLine(name[0]);
        RecursiveString(name.Remove(0,1));
    }

    public int Fib(int n){
        if(n==1 ||n==2){                 
            return 1;
        }
        return Fib(n-1)+ Fib(n-2);
    }
}

namespace Solution;

public static class DynamicProgramming {

    public static long FibonacciDynamic(long n, long[] storedResults)
    {    
        Utils.ShowCallStack(false); //DO NOT comment this line of code
        
        if (storedResults[n] != 0 || n == 0)
        {
            return storedResults[n];
        }

        storedResults[n] = FibonacciDynamic(n - 1, storedResults) + FibonacciDynamic(n - 2, storedResults);

        return storedResults[n];
    }
}    

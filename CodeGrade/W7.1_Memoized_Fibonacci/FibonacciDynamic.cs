
namespace Solution;

public static class DynamicProgramming {

    public static long FibonacciDynamic(long n, long[] results)
    {    
        Utils.ShowCallStack(false); //DO NOT comment this line of code
        
        if (results[n] != 0 || n == 0)
        {
            return results[n];
        }

        results[n] = FibonacciDynamic(n - 1, results) + FibonacciDynamic(n - 2, results);

        return results[n];
    }
}    

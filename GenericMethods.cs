

using System; 
using System.Collections.Generic; 



class GenericMethods 
{ 
    static void Swap<T>(ref T input1, ref T input2)
    {
        T temp = default(T);
    
        temp = input2;
        input2 = input1;
        input1 = temp;
    }
    
    static void Main(string[] args)
    {
        int first = 4;
        int second = 5;
    
        Swap<int>(ref first, ref second);
    }
} 



/*

In the above example, we have declared a Swap generic method.
In that method we have declared a Type argument after the method name <T>.
T is the type argument. In the main method, we pass Swap method with <int> type argument.
That means, we can only pass parameters of int types.
We declared two int parameters and pass into the Swap method.

*/


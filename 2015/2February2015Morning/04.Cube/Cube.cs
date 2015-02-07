using System;

class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        /* TOP
             :::::
            :///::
           :///:X:
          :///:XX:
                   */
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(' ', n - i - 1));
            if (i >= 1)
            {
                
                Console.Write(new string(':', 1));
                Console.Write(new string('/', n - 2));
                Console.Write(new string(':', 1));
                Console.Write(new string('X', i - 1));
                Console.WriteLine(new string(':', 1));
            }
            else
            {
                Console.WriteLine(new string(':', n + i));
            }
            
        }
        //Middle :::::XXX:

        Console.Write(new string(':', n));
        Console.Write(new string('X', n - 2));
        Console.WriteLine(new string(':', 1));


        /* BOTTOM
         
           :   :XX: 
           :   :X:  
           :   ::   
           :::::
                      */
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string(':', 1));
            Console.Write(new string(' ', n - 2));
            Console.Write(new string(':', 1));
            if (n - 3 - i >= 0)
            {
                Console.Write(new string('X', n - 3 - i));
            }
            
            Console.Write(new string(':', 1));
            Console.WriteLine(new string(' ', i + 1));
        }
        // last line
        Console.Write(new string(':', n));
        Console.Write(new string(' ', n - 1));
    }
}
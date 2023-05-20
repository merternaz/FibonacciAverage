using System;
using System.Collections.Generic;

namespace structures
{
    class Program
    {
        
        static void Main(string[] args)
        {


            Console.WriteLine("Derinlik giriniz ..");
            int x=Convert.ToInt32(Console.ReadLine());
            Fibonacci(x);

        }

        public static void Fibonacci(int limit){
            int x;
            float fiboSum=0;
            List<int> fibo=new List<int>();
            for(int i=0;i<limit;i++){

                if(i>1){
                    x=fibo[i-1]+fibo[i-2];
                    fibo.Add(x);
                }else{
                    fibo.Add(i);
                }
            }

            for(int a=0;a<fibo.Count;a++){
                Console.WriteLine("Fİbo dizisi:"+fibo[a]);
                fiboSum+=fibo[a];
            }

            Console.WriteLine("Fibonacci Ortalaması:"+fiboSum/fibo.Count);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {



          
            {
              
                Console.WriteLine("İlk sayıyı giriniz:");
                int sayi1 = int.Parse(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz:");
                int sayi2 = int.Parse(Console.ReadLine());

                
                int adet = 0;

               
                for (int i = sayi1; i <= sayi2; i++)
                {
                    if (i % 2 == 0) 
                    {
                        Console.WriteLine(i);  
                        adet++;  
                    }
                }

                
                Console.WriteLine("Çift sayıların adedi: " + adet);

                Console.ReadLine();  
            }
        }
    }



















}
    

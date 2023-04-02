// See https://aka.ms/new-console-template for more information
using System;
namespace UngDungDocSoThanhChu
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;
            Console.WriteLine("Nhap so:");
            so = Convert.ToInt32(Console.ReadLine());
            if(so < 0 || so > 999)
                Console.WriteLine("out of ability");
                        
            switch (so)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven"); 
                    break; 
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;            
                                
                default: switch(so/10){
                    case 2: Console.Write("twenty-");
                    break;
                    case 3: Console.Write("thirty-");
                    break;
                    case 4: Console.Write("forty-");
                    break;
                    case 5: Console.Write("fifty-");
                    break;
                    case 6: Console.Write("sixty-");
                    break;
                    case 7: Console.Write("seventy-");
                    break;
                    case 8: Console.Write("eighty-");
                    break;
                    case 9: Console.Write("ninty-");
                    break;
                    }                     
                    switch(so%10)
                    {
                    case 1: Console.WriteLine("one");
                    break;
                    case 2: Console.WriteLine("two");
                    break;
                    case 3: Console.WriteLine("three");
                    break;
                    case 4: Console.WriteLine("four");
                    break;
                    case 5: Console.WriteLine("five");
                    break;
                    case 6: Console.WriteLine("six");
                    break;
                    case 7: Console.WriteLine("seven");
                    break;
                    case 8: Console.WriteLine("eight");
                    break;
                    case 9: Console.WriteLine("nine");
                    break;
                    }
                    switch(so/100)
                    {
                    case 2: Console.Write("two hundred ");
                    break;
                    case 3: Console.Write("three hundred ");
                    break;
                    case 4: Console.Write("four hundred ");
                    break;
                    case 5: Console.Write("five hundred ");
                    break;
                    case 6: Console.Write("six hundred ");
                    break;
                    case 7: Console.Write("seven hunderd ");
                    break;
                    case 8: Console.Write("eight hundred ");
                    break;
                    case 9: Console.Write("nine hundred ");
                    break;
                    }
                    break;
                
            }
        }
    }
}
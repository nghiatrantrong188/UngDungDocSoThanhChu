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

            if(so >=0 && so <=10)     
            {       
                switch (so)
                {

                    case 0:
                    Console.WriteLine("zero");
                    break;
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
                    case 10:
                    Console.WriteLine("ten");
                    break;                        
                }
            }
            else if (so >= 11 && so < 20)
            {          
                switch(so)
                {
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
                }
            }
            else if(so >= 20 && so < 100)
            {
                int sohangchuc = so / 10;
                int lay_sothu2_cuahangchuc = so % 10;
                switch(sohangchuc){
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
                    if (lay_sothu2_cuahangchuc > 0)
                    {
                        Console.Write("");
                        switch (lay_sothu2_cuahangchuc)
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
                    }
            }                     
            else if(so >=100 && so < 1000)
            {
                int sohangtram = so / 100;
                int layso_hangtram = so % 100;
                 switch(sohangtram)
                    {
                    case 1: Console.Write("one hundred ");
                    break;
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
                    if (layso_hangtram > 0)
                    {
                        Console.Write(" And ");
                    if (layso_hangtram >= 1 && layso_hangtram <= 10)
                    {
                        switch (layso_hangtram)
                        {
                            case 1:
                                Console.WriteLine("One");
                                break;
                            case 2:
                                Console.WriteLine("Two");
                                break;
                            case 3:
                                Console.WriteLine("Three");
                                break;
                            case 4:
                                Console.WriteLine("Four");
                                break;
                            case 5:
                                Console.WriteLine("Five");
                                break;
                            case 6:
                                Console.WriteLine("Six");
                                break;
                            case 7:
                                Console.WriteLine("Seven");
                                break;
                            case 8:
                                Console.WriteLine("Eight");
                                break;
                            case 9:
                                Console.WriteLine("Nine");
                                break;
                            case 10:
                                Console.WriteLine("Ten");
                                break;
                        }
                    }
                    else if (layso_hangtram > 10 && layso_hangtram < 20)
                    {
                        switch (layso_hangtram)
                        {
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
                        }
                    }
                    else if (layso_hangtram >= 20 && layso_hangtram < 100)
                    {
                        int sohangchuc_cuahangtram = layso_hangtram / 10;
                        int sohangdonvi_cuahangtram = layso_hangtram % 10;

                        switch (sohangchuc_cuahangtram)
                        {
                            case 2:
                                Console.Write("Twenty");
                                break;
                            case 3:
                                Console.Write("Thirty");
                                break;
                            case 4:
                                Console.Write("Forty");
                                break;
                            case 5:
                                Console.Write("Fifty");
                                break;
                            case 6:
                                Console.Write("Sixty");
                                break;
                            case 7:
                                Console.Write("Seventy");
                                break;
                            case 8:
                                Console.Write("Eighty");
                                break;
                            case 9:
                                Console.Write("Ninety");
                                break;
                        }
                        if (sohangdonvi_cuahangtram > 0)
                        {
                            Console.Write("-");
                            if (sohangdonvi_cuahangtram >= 1 && sohangdonvi_cuahangtram <= 10)
                            {
                                switch (sohangdonvi_cuahangtram)
                                {
                                    case 1:
                                        Console.WriteLine("One");
                                        break;
                                    case 2:
                                        Console.WriteLine("Two");
                                        break;
                                    case 3:
                                        Console.WriteLine("Three");
                                        break;
                                    case 4:
                                        Console.WriteLine("Four");
                                        break;
                                    case 5:
                                        Console.WriteLine("Five");
                                        break;
                                    case 6:
                                        Console.WriteLine("Six");
                                        break;
                                    case 7:
                                        Console.WriteLine("Seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("Eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("Nine");
                                        break;
                                    case 10:
                                        Console.WriteLine("Ten");
                                        break;
                                }
                            }
                        }
                    }
                }               
            }
        }
    }
}
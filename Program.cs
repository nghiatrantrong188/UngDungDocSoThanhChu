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
                        Console.WriteLine("eleven"); 
                        break; 
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;        
                }
            }
            else if(so >= 20 && so < 100)
            {
                int sohangchuc = so / 10;
                int lay_sothu2_cuahangchuc = so % 10;
                switch(sohangchuc){
                    case 2: Console.Write("Twenty-");
                    break;
                    case 3: Console.Write("Thirty-");
                    break;
                    case 4: Console.Write("Forty-");
                    break;
                    case 5: Console.Write("Fifty-");
                    break;
                    case 6: Console.Write("Sixty-");
                    break;
                    case 7: Console.Write("Seventy-");
                    break;
                    case 8: Console.Write("Eighty-");
                    break;
                    case 9: Console.Write("Ninety-");
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
                    case 1: Console.Write("One hundred ");
                    break;
                    case 2: Console.Write("Two hundred ");
                    break;
                    case 3: Console.Write("Three hundred ");
                    break;
                    case 4: Console.Write("Four hundred ");
                    break;
                    case 5: Console.Write("Five hundred ");
                    break;
                    case 6: Console.Write("Six hundred ");
                    break;
                    case 7: Console.Write("Seven hunderd ");
                    break;
                    case 8: Console.Write("Eight hundred ");
                    break;
                    case 9: Console.Write("Nine hundred ");
                    break;
                    }
                    if (layso_hangtram > 0)
                    {
                        Console.Write("and ");
                    if (layso_hangtram >= 1 && layso_hangtram <= 10)
                    {
                        switch (layso_hangtram)
                        {
                            case 1:
                                Console.WriteLine("one");
                                break;
                            case 2:
                                Console.WriteLine("two");
                                break;
                            case 3:
                                Console.WriteLine("three");
                                break;
                            case 4:
                                Console.WriteLine("four");
                                break;
                            case 5:
                                Console.WriteLine("five");
                                break;
                            case 6:
                                Console.WriteLine("six");
                                break;
                            case 7:
                                Console.WriteLine("seven");
                                break;
                            case 8:
                                Console.WriteLine("eight");
                                break;
                            case 9:
                                Console.WriteLine("nine");
                                break;
                            case 10:
                                Console.WriteLine("ten");
                                break;
                        }
                    }
                    else if (layso_hangtram > 10 && layso_hangtram < 20)
                    {
                        switch (layso_hangtram)
                        {
                            case 11:
                                Console.WriteLine("eleven");
                                break;
                            case 12:
                                Console.WriteLine("twelve");
                                break;
                            case 13:
                                Console.WriteLine("thirteen");
                                break;
                            case 14:
                                Console.WriteLine("fourteen");
                                break;
                            case 15:
                                Console.WriteLine("fifteen");
                                break;
                            case 16:
                                Console.WriteLine("sixteen");
                                break;
                            case 17:
                                Console.WriteLine("seventeen");
                                break;
                            case 18:
                                Console.WriteLine("eighteen");
                                break;
                            case 19:
                                Console.WriteLine("nineteen");
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
                                Console.Write("twenty");
                                break;
                            case 3:
                                Console.Write("thirty");
                                break;
                            case 4:
                                Console.Write("forty");
                                break;
                            case 5:
                                Console.Write("fifty");
                                break;
                            case 6:
                                Console.Write("sixty");
                                break;
                            case 7:
                                Console.Write("seventy");
                                break;
                            case 8:
                                Console.Write("eighty");
                                break;
                            case 9:
                                Console.Write("ninety");
                                break;
                        }
                        if (sohangdonvi_cuahangtram > 0)
                        {
                            Console.Write(" ");
                            if (sohangdonvi_cuahangtram >= 1 && sohangdonvi_cuahangtram <= 10)
                            {
                                switch (sohangdonvi_cuahangtram)
                                {
                                    case 1:
                                        Console.WriteLine("one");
                                        break;
                                    case 2:
                                        Console.WriteLine("two");
                                        break;
                                    case 3:
                                        Console.WriteLine("three");
                                        break;
                                    case 4:
                                        Console.WriteLine("four");
                                        break;
                                    case 5:
                                        Console.WriteLine("five");
                                        break;
                                    case 6:
                                        Console.WriteLine("six");
                                        break;
                                    case 7:
                                        Console.WriteLine("seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("nine");
                                        break;
                                    case 10:
                                        Console.WriteLine("ten");
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
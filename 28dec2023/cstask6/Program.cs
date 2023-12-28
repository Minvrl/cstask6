using System;

namespace cstask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOp(2, 8, '*'); //Task 1
            Console.WriteLine(WantedSymbols("salam....",'.'));//Task2
            Console.WriteLine(CountWords("bu tapsiriq asan deyil"));//Task3
            Console.WriteLine(DigitSum(127));//Task4
            Console.WriteLine(Power(7,2));//Task5
            
            
            int[] arr = { 5, -3, 8, -2, 0, -7 };
            int[] resultArray = PositifiedArr(arr);
            Console.WriteLine("Yanliz musbetlerden ibaret array: {" + string.Join(", ", resultArray) + "}");//Task6

            Console.WriteLine(ReversedStr("salamlar hamiya"));//Task7

        }

        //1.Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.
        static void MathOp(int x, int y, char opt)
        {
            int result = 0;
            switch (opt)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if(y==0) Console.WriteLine("Bolen 0 ola bilmez !");
                    else result = x / y; break;
                default: 
                    Console.WriteLine("Operator yanlisdir!");
                    break;
            }
            Console.WriteLine(result);
        }
        //2.Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod
        static int WantedSymbols(string text,char chr)
        {
            int count = 0;
            for(int i=0; i<text.Length; i++)
            {
                if (text[i] == chr)
                {
                    count++;
                }
            }
            return count;
        }

        //3.Verilmiş yazıdaki sözlərin sayını qaytaran metod (söz dedikdə boşluqlarla ayrılmış bütün yazılar nəzərdə tutulur)
        static int CountWords(string str)
        {
            int wordCount = 0;  
            bool sozler = false;  

            for (int i = 0; i < str.Length; i++)
            {
                char chr = str[i];  

                if (chr == ' ')
                {
                    sozler = false; 
                }
                else
                {
                    if (!sozler)
                    {
                        wordCount++;
                        sozler = true;  
                    }
                }
            }

            return wordCount; 
        }


        //4.Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int DigitSum(int num)
        {
            int sum = 0;
            while(num>0)
            {
                int lastDigit = num % 10;
                num= num - lastDigit;
                num = num / 10;
                sum += lastDigit;

            }
            return sum;
        }

        //5.Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod
        static int Power(int num,int pow)
        {
            int result = 1;
            for(int i=0; i<pow; i++)
            {
                result *= num;
            }
            return result;
        }

        //6.Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod. Misalçün  metoda {1,-4,9,-8}
        //dəyərləri olan array göndərilsə metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.

        static int[] PositifiedArr(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for(int i=0; i<arr.Length ; i++)
            {
                if (arr[i] < 0)
                {
                    newArr[i] = arr[i] * -1;
                    
                }
                else 
                {
                    newArr[i] = arr[i];
                }

            }
            return newArr;
        }

        //7.Verilmiş yazını tərs formada qaytaran metod (Misalçün "salam" göndərilsə metoddan "malas" return ediləcək)
        static string ReversedStr(string str)
        {
            char[] charArr = new char[str.Length];
            int index = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                charArr[index] = str[i];
                index++;
            }
            return new string(charArr);
        }











    }
}

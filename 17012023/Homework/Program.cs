using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //homeworks
            #region task1   
            //int num1, num2, num3;

            //Console.WriteLine("1-ci ededi daxil edin:");
            //string num1Str = Console.ReadLine();
            //num1 = Convert.ToInt32(num1Str);

            //Console.WriteLine("2-ci ededi daxil edin:");
            //string num2Str = Console.ReadLine();
            //num2 = Convert.ToInt32(num2Str);

            //Console.WriteLine("3-cu ededi daxil edin:");
            //string num3Str = Console.ReadLine();
            //num3 = Convert.ToInt32(num3Str);

            //if (num1<= num2 && num1 <= num3)
            //{
            //    Console.WriteLine($"{num1} en kicikdir");
            //}
            //else if(num2<=num1 && num2 <= num3)
            //{
            //    Console.WriteLine($"{num2} en kicikdir");
            //}
            //else
            //{
            //    Console.WriteLine($"{num3} en kicikdir");
            //}
            #endregion

            #region task2
            //int[] numbers = { -45, -2, -4, -5, -213, -55 };

            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            //Console.WriteLine(max);
            #endregion

            #region task3
            //int[] numbers = { 45, 2, 45, 68, 99 ,33};

            //double count = 0;
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        sum += numbers[i];
            //        count++;
            //    }
            //}

            //if(count == 0)
            //{
            //    Console.WriteLine("#-e bolunen eded yoxdur");
            //}
            //else
            //{
            //    var result = sum / count;
            //    Console.WriteLine(result);
            //}
            #endregion

            #region task4
            //int[] numbers = { 45, 12, 452, 6448, 59, 33 };
            //bool hasWantedNumber = false;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]>=100 && numbers[i] <= 999)
            //    {
            //        hasWantedNumber = true;
            //        break;
            //    }
            //}

            //if(hasWantedNumber == true)
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //{
            //    Console.WriteLine("Yoxdur");
            //}

            #endregion


            //Class tasks
            #region task1
            //Verilmiş N dəyərindən verilmiş M dəyərinədək 21-ə bölünən
            //ədədlərin ədədi ortasını tapan proqram

            //int n = 100;
            //int m = 200;
            //double sum = 0;
            //int count = 0;

            ////for (int i = n; i < m; i++)
            ////{
            ////    if (i % 21 == 0)
            ////    {
            ////        sum += i;//sum=sum+i;
            ////        count++;
            ////    }
            ////}


            //while (n<m)
            //{
            //    if (n % 21 == 0)
            //    {
            //        sum += n;//sum=sum+i;
            //        count++;
            //    }
            //    n++;
            //}

            //if(count == 0)
            //{
            //    Console.WriteLine("21-e bolunen eded yoxdur");
            //}
            //else
            //{
            //    var result = sum / count;
            //    Console.WriteLine(result);
            //}


            #endregion


            #region task2
            //Verilmis N tam ededinin reqemleri cemin tapan proqram

            //int number = 54356;
            //int sumofDigits = 0;
            //while (number > 0)
            //{
            //    var lastDigit = number % 10;
            //    sumofDigits += lastDigit;
            //    //number = (number - lastDigit) / 10;
            //    number /=10;
            //}

            //Console.WriteLine(sumofDigits);

            //string word = "Hello";

            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}

            #endregion

            #region task3
            //Verilmis yazida 1 reqeminin olub olmadigini tapan proqram

            //Console.WriteLine("Yazini daxil edin:");
            //string word = Console.ReadLine();

            //bool hasWantedChar = false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if(word[i] == '1')
            //    {
            //        hasWantedChar = true;
            //        break;
            //    }
            //}

            //if(hasWantedChar == true)
            //{
            //    Console.WriteLine("Yazida 1  var");
            //}
            //else
            //{
            //    Console.WriteLine("Yazida 1 yoxdur");
            //}


            //string username;
            //bool has1 = false;
            //do
            //{
            //    Console.WriteLine("Username daxil edin:");
            //    username = Console.ReadLine();

            //    has1 = false;
            //    for (int i = 0; i < username.Length; i++)
            //    {
            //        if (username[i] == '1')
            //        {
            //            has1 = true;
            //            break;
            //        }
            //    }

            //} while (has1==true);




            //Console.WriteLine(username);
            #endregion



            ShowGroupInfo();

            ShowGroupInfo();

            ShowGroupInfo();

             var word = GetHello();


            var checkNum = IsEven(88);
            Console.WriteLine(checkNum);

            var result = Sum(40, 88);

            

        }

      static void  ShowGroupInfo()
      {
            Console.WriteLine("QrupNo: P231");
            Console.WriteLine("Qrup telebe sayi: 18");
            Console.WriteLine("Qrup ortalama bal: 70");
      }

        static string GetHello()
        {
            return "Hello";
        }

        static void ShowWord(string str)
        {
            Console.WriteLine(str);
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}

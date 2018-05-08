using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz Program

            //int num = 100;

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //        Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //

            //int n;

            //n = int.Parse(Console.ReadLine());

            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j < i)
            //        {
            //            Console.Write(" ");

            //        }
            //        else if(j >= i)
            //        {
            //            Console.Write("#");
            //        }


            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();


            //string[] ar = new string[3];
            //int[] A = new int[3];
            //int[] B = new int[3];

            //int Alice = 0;
            //int Bob = 0;

            //ar = Console.ReadLine().Split();
            //for (int i = 0; i < A.Length; i++)
            //{

            //    A[i] = int.Parse(ar[i]);


            //}

            //ar = Console.ReadLine().Split();
            //for (int i = 0; i < A.Length; i++)
            //{

            //    B[i] = int.Parse(ar[i]);


            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    if (A[i] > B[i])
            //    {
            //        Alice++;
            //    }
            //    else if (A[i] < B[i])
            //    {
            //        Bob++;
            //    }
            //}

            //Console.WriteLine(Alice + " " + Bob);
            //Console.ReadLine();


            //    int n;
            //    int d;

            //    string[] ar = new String[2];



            //ar = Console.ReadLine().Split();

            //    n = int.Parse(ar[0]);
            //    d = int.Parse(ar[1]);

            //    int[] num = new int[n];


            //    ar = Console.ReadLine().Split();
            //    for (int i = 0; i < n; i++)
            //    {
            //        num[i] = int.Parse(ar[i]);

            //    }

            //    int [] rotate = new int[n];

            //    for(int i = 0; i < d; i++)
            //    {
            //        rotate[4] = num[i];
            //        for(int j= 4; j > 0; j--)
            //        {
            //            rotate[] = n;
            //        }
            //    }

            //    //for (int i = 0; i < d; i++)
            //    //{
            //    //    rotate[i] = num[i];

            //    //}
            //    //num[0] = num[4];
            //    //for (int i = 0; i < d; i++)
            //    //{
            //    //    num[i+1] = rotate[i];


            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(num[i] + " ");


            //}



            //Console.ReadLine();
            //try
            //{
            //string answer = "NO";
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{


            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int k = int.Parse(Console.ReadLine());

            //foreach (int num in arr)
            //{
            //    if (num == k)
            //    {
            //        answer = "YES";
            //    }

            //}
            //Console.WriteLine(answer);
            //}
            //catch(Exception )
            //{
            //    Console.WriteLine("error");
            //}

            //List<int> num = new List<int>();
            //int[] arr;
            //int l = int.Parse(Console.ReadLine());
            //int r = int.Parse(Console.ReadLine());

            //for (int i = l; i <= r; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        num.Add(i);


            //    }


            //}
            //arr = num.ToArray();


            //for (int i=0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i] + " ");
            //}


            //double result = 0.0;
            //double negative = 0.0;
            //double positve = 0.0;
            //double zero = 0.0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        positve += 1;
            //    }
            //    else if (arr[i] < 0)
            //    {
            //        negative += 1;
            //    }
            //    else if (arr[i] == 0)
            //        zero += 1;
            //}
            //result = positve / arr.Length;
            //Console.WriteLine(result);

            //result = negative / arr.Length;
            //Console.WriteLine(result);

            //result = zero / arr.Length;
            //Console.WriteLine(result);


            //string dna = "AAAATTGCGCATGC";

            //Console.WriteLine("The DNA string is: " + dna);

            //char[] dnaLetters = dna.ToCharArray(); //translated dna strand to a character array
            ////got the length of the array to use in for loop

            //List<char> dnaComplementLetters = new List<char>();

            //for (int i = 0; i < dnaLetters.Length; i++)
            //{
            //    char dnaLetter = dnaLetters[i];
            //    char dnaComplementLetter;

            //    //convert dnaLetter to a string to use in switch statement
            //    switch (dnaLetters[i])
            //    {
            //        case 'A':
            //            dnaComplementLetter = 'T';
            //            dnaComplementLetters.Add(dnaComplementLetter);
            //            break;
            //        case 'T':
            //            dnaComplementLetter = 'A';
            //            dnaComplementLetters.Add(dnaComplementLetter);
            //            break;
            //        case 'G':
            //            dnaComplementLetter = 'C';
            //            dnaComplementLetters.Add(dnaComplementLetter);
            //            break;
            //        case 'C':
            //            dnaComplementLetter = 'G';
            //            dnaComplementLetters.Add(dnaComplementLetter);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid letter in dna string");
            //            break;
            //    }
            //}

            //dnaComplementLetters.Reverse();

            ////convert list<> into string
            //string complementDna = string.Join("", dnaComplementLetters);

            //Console.WriteLine("The new complement DNA string: " + complementDna);
            ////stop console from exiting after running
            //Console.ReadLine();

            //for (int i = 1; i <= 100; i++)
            //{
            //    int counter1 = 0;
            //    int counter2 = 0;
            //    for (int j = 2; j < i - 1; j++)
            //    {
            //        int remainder = i % j;
            //        if (remainder == 0)
            //        {
            //            counter1++;
            //        }
            //        else
            //        {
            //            counter2++;
            //        }
            //    }
            //    if (counter1 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            ////stop console from exiting after running
            //Console.ReadLine();

            //int n = int.Parse(Console.ReadLine());
            //int prime = 0;

            //if(n == 2)
            //{
            //    prime = 1;
            //}
            //else if(n % 2 != 0 )
            //{
            //    prime = 1;
            //}
            //else
            //{
            //    prime = 2;
            //}
            //Console.WriteLine(prime);
            //Console.ReadLine();

            int[] arr = new int [5];
            long sum = 0;
            long lowSum = 0;
            long highSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                    {
                        sum = sum + arr[j];
                    }
                }

                lowSum = sum;

                if (lowSum > highSum)
                {
                    highSum = lowSum;
                }
                sum = 0;

            }

            Console.WriteLine(lowSum + " " + highSum);
            Console.ReadLine();

        }

    }
}

namespace ass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter Nymber");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isparsed && number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);

            //    }



            //}

            //else 
            //{

            //    Console.WriteLine("invalid number");

            //}

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter Nymber");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isparsed && number > 0) 
            //{
            //    for (int i = 1; i <= 12; i++) 
            //    {
            //        int result = i * number;
            //        Console.WriteLine(result);


            //    }

            //}
            //else
            //{
            //    Console.WriteLine("ivalid number");
            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number


            //Console.Write("Enter Nymber");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isparsed && number > 0) 
            //{
            //  for (int i = 1; i < number; i++)
            //    {
            //        if ( i % 2 == 0)
            //        {
            //            Console.WriteLine($" {i} is  even number ");
            //        }

            //    }

            //}
            //else
            //{

            //    Console.WriteLine("invalid number ");

            //}

            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.Write(" Enter The Number: ");
            //bool niparsed = int.TryParse(Console.ReadLine(), out int number);
            //Console.Write("Enter The Power: ");
            //bool Pisparsed = int.TryParse(Console.ReadLine(),out int power );

            //if (niparsed && Pisparsed)
            //{ 
            //   double result = Math.Pow(number, power);
            //   Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine(" invalid number ");
            //}


            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage

            // Console.Write("number 1: ");
            // int number1 = int.Parse(Console.ReadLine());

            // Console.Write("number 2: ");
            // int number2 = int.Parse(Console.ReadLine());

            // Console.Write("number 3: ");
            // int number3 = int.Parse(Console.ReadLine());

            //Console.Write("number 4: ");
            //int number4 = int.Parse(Console.ReadLine());

            //Console.Write("number 5: ");
            //int number5 = int.Parse(Console.ReadLine());

            //int total = number1 + number2 + number3 + number4 + number5;
            //double average = total / 5;
            //double percent = average ;

            //Console.WriteLine($"Total : {total}");
            //Console.WriteLine($"average : {average} ");
            //Console.WriteLine($"percent : {percent } %");






            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string resvstring = null;

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    resvstring = ""+input[i];
            //    Console.Write (resvstring);

            //}

            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter The Number :  ");
            //int.TryParse(Console.ReadLine() , out int num);
            //string strint = num.ToString();
            //string resvint;
            //for (int i = strint.Length - 1; i >= 0; i--)
            //{
            //    resvint = "" + strint[i];
            //    Console.Write(resvint);

            //}


            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of ranges: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Input ending number of ranges: ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //if (num1 > 0 && num2 > 0) 
            //{
            //    for (int i = num1; i < num2;i++)
            //    {
            //        if( i/i ==1 && i/1 == i  && i%2 == 1  )
            //        {

            //            Console.WriteLine(i);
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.WriteLine("Enter Number: ");
            //if (int.TryParse(Console.ReadLine(), out int decnum))
            //{
            //    string result = "";

            //    if (decnum == 0)
            //    {
            //        result = "0";
            //    }
            //    else
            //    {
            //        while (decnum > 0)
            //        {
            //            int decint = decnum % 2;
            //            decnum = decnum / 2;
            //            result = decint.ToString() + result;
            //        }
            //    }

            //    Console.WriteLine(result);


            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1, y1: ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter x2, y2: ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter x3, y3: ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());



            #endregion

            #region   11 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = {1,2,3,4,5};
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine($"The sum of all elements is: {sum}") ;
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr1 = { 1, 5, 9 };
            //int[] arr2 = { 2, 6, 8 };
            //int n = arr1.Length;
            //int[] narry = = new int[n *2];

            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.


            //int[] arr = { 1, 2, 2, 3 ,3, 3, 3,4, 4 };
            //foreach (int num in arr)
            //{
            //    int count = 0;
            //    foreach (int item in arr)
            //    {
            //        if (num == item)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{num}  reapet {count} ");
            //}
            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 1, 5, 3, 9, 2, 8 ,10,23};
            //int max = arr[0];
            //int min = arr[0];

            //foreach (int num in arr)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    else if (num < min)
            //    {
            //        min = num;
            //    }
            //}

            //Console.WriteLine($"Maximum element is {max}");
            //Console.WriteLine($"Minimum element is {min}");


            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 1, 5, 3, 9, 2, 8, 10, 23 };
            //int max = arr[0];
            //int secondMax = arr[0];

            //foreach (int num in arr)
            //{
            //    if (num > max)
            //    {
            //        secondMax = max;
            //        max = num;
            //    }
            //    else if (num > secondMax && num != max)
            //    {
            //        secondMax = num;
            //    }
            //}



            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as in this Example


            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.


            //Console.WriteLine("Enter string:");
            //string input = Console.ReadLine();

            //string[] word = input.Split(' ');

            //Array.Reverse(word);

            //string reversedWords = string.Join(" ", word);

            //Console.WriteLine(reversedWords);




            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            Console.Write("Enter number of rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int column = int.Parse(Console.ReadLine());



            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter size : ");
            //int size = int.Parse(Console.ReadLine());
            
            //int[] arr = new int[size];

            //Console.WriteLine("Enter element :");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            #endregion

        }

    }
}

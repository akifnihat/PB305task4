namespace PB305task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            #region task1
            //int[] numbers = { 1, 7, 11, 9, 3 };
            //int sum = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //    sum += numbers[i];

            //Console.WriteLine("Array elementlərinin cemi: " + sum);


            //Console.ReadLine();

            #endregion

            #region task2
            //int[] numbers = { 10, 40, 7, 88, 21, 55 };


            //int max = numbers[0];


            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //        max = numbers[i];
            //}               


            //Console.WriteLine("Arrayın en boyuk elementi: " + max);

            //Console.ReadLine();

            #endregion

            #region task3
            //int[] numbers = { 11, 22, 33, 44, 55 };

            //int sum = numbers[0] + numbers[numbers.Length - 1];

            //Console.WriteLine("İlk ve son elementlerin cemi" + sum);


            #endregion

            #region task4

            //Console.Write("n ededini daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n <= 0)
            //{
            //    Console.WriteLine("n müsbet eded olmalıdır.");
            //    return;
            //}

            //int bolunen = n;

            //while (bolunen % 2 == 0)
            //{
            //    bolunen = bolunen / 2;
            //}

            //if (bolunen == 1)
            //{
            //    Console.WriteLine($"{n} — 2-nin quvvetidir.");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} — 2-nin quvveti deyil.");
            //}


            #endregion

            #region task5
            //Console.Write("n ededini daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n < 0)
            //{
            //    n = -n;
            //}

            //int count = 0;

            //if (n == 0)
            //{
            //    count = 1;
            //}
            //else
            //{
            //    while (n > 0)
            //    {
            //        n = n / 10;
            //        count++;
            //    }
            //}

            //Console.WriteLine("mertebe sayı: " + count);

            //Console.ReadLine();

            #endregion

            #region task6
            //int[] numbers = { 12, 22, 25, 34, 40, 55, 68, 98, 100,101};

            //int target = 55;

            //int first = 0;
            //int last = numbers.Length - 1;
            //int index = -1;

            //while (first <= last)
            //{
            //    int mid = first + (last - first) / 2;

            //    if (numbers[mid] == target)
            //    {
            //        index = mid;
            //        break;
            //    }
            //    else if (numbers[mid] < target)
            //    {
            //        first = mid + 1;
            //    }
            //    else
            //    {
            //        last = mid - 1;
            //    }
            //}
            //Console.WriteLine(index);

            #endregion

            #region task7

            //int[] numbers = { 1, 77, 111, 999, 3,-354,-541,33,3 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] >= 100 || numbers[i] <= -100)
            //    {
            //        sum += numbers[i];
            //    }
            //}
            //Console.WriteLine($"Verilmiş ədədlər siyahısındaki rəqəmlərinin sayı 2-dən böyük olan ədədlərin cəmi - {sum}");


            #endregion

            #region task8

            //var student1 = new
            //{
            //    GroupNo = "PB302",
            //    point = 23
            //};
            //var student2 = new
            //{
            //    GroupNo = "PB304",
            //    point = 77
            //};
            //var student3 = new
            //{
            //    GroupNo = "PB302",
            //    point = 78
            //};
            //double count = 0;
            //double sum = 0;

            //object[] students = { student1, student2, student3 };

            //if (student1.GroupNo == "PB302")
            //{
            //    sum += student1.point;
            //    count++;
            //}
            //if (student2.GroupNo == "PB302")
            //{
            //    sum += student2.point;
            //    count++;
            //}
            //if (student3.GroupNo == "PB302")
            //{
            //    sum += student3.point;
            //    count++;
            //}

            //double average = sum / count;
            //Console.WriteLine($"Average: {average}");

            #endregion

        }
    }
}
    


using System.Text;

namespace HomeworkSystem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = UTF8Encoding.UTF8;
            Console.OutputEncoding = UTF8Encoding.UTF8;

            //Task 1
            //Console.WriteLine("Поточна дата і час: " + DateTime.Now);

            //Task task1 = new Task(() =>
            //{
            //    PerformTask("Task1");
            //});
            //task1.Start();

            //Task task2 = Task.Factory.StartNew(() =>
            //{
            //    PerformTask("Task2");
            //});

            //Task task3 = Task.Run(() =>
            //{
            //    PerformTask("Task3");
            //});

            //Task.WaitAll(task1, task2, task3);

            //Console.WriteLine("Усі завдання завершено.");

            //Task 2
            //Console.WriteLine("Пошук простих чисел у діапазоні від 0 до 1000...");

            //Task<List<int>> primeTask = Task.Run(() =>
            //{
            //    return FindPrimes(0, 1000);
            //});

            //primeTask.Wait();

            //List<int> primes = primeTask.Result;

            //Console.WriteLine("Прості числа:");
            //foreach (int prime in primes)
            //{
            //    Console.Write(prime + " ");
            //}

            //Console.WriteLine("\nРобота завершена.");

            //Task 3
            //Console.WriteLine("Пошук простих чисел у заданому діапазоні...");

            //int startRange = 0;
            //int endRange = 1000;

            //Task<List<int>> primeTask = Task.Run(() =>
            //{
            //    return FindPrimes(startRange, endRange);
            //});

            //primeTask.Wait();

            //List<int> primes = primeTask.Result;

            //Console.WriteLine($"Кількість простих чисел у діапазоні від {startRange} до {endRange}: {primes.Count}");

            //Task 4
            //int[] array = { 45, 23, 89, 12, 67, 34, 90, 15, 78, 56 };

            //Console.WriteLine("Пошук значень у масиві:");
            //Console.WriteLine("Масив: " + string.Join(", ", array));

            //Task<int> minTask = Task.Run(() => FindMin(array));
            //Task<int> maxTask = Task.Run(() => FindMax(array));
            //Task<double> avgTask = Task.Run(() => CalculateAverage(array));
            //Task<int> sumTask = Task.Run(() => CalculateSum(array));

            //Task.WaitAll(minTask, maxTask, avgTask, sumTask);

            //int min = minTask.Result;
            //int max = maxTask.Result;
            //double avg = avgTask.Result;
            //int sum = sumTask.Result;

            //Console.WriteLine($"Мінімум: {min}");
            //Console.WriteLine($"Максимум: {max}");
            //Console.WriteLine($"Середнє арифметичне: {avg:F2}");
            //Console.WriteLine($"Сума: {sum}");

            //Task 5
            //int[] array = { 45, 23, 89, 12, 67, 34, 23, 12, 78, 56, 45, 89 };

            //Console.WriteLine("Початковий масив: " + string.Join(", ", array));

            //Task<int[]> removeDuplicatesTask = Task.Run(() =>
            //{
            //    return array.Distinct().ToArray();
            //});

            //Task<int[]> sortTask = removeDuplicatesTask.ContinueWith(previousTask =>
            //{
            //    int[] distinctArray = previousTask.Result;
            //    Array.Sort(distinctArray);
            //    return distinctArray;
            //});

            //int searchValue = 56;
            //Task<int> binarySearchTask = sortTask.ContinueWith(previousTask =>
            //{
            //    int[] sortedArray = previousTask.Result;
            //    return Array.BinarySearch(sortedArray, searchValue);
            //});

            //binarySearchTask.Wait();

            //int[] distinctArray = removeDuplicatesTask.Result;
            //int[] sortedArray = sortTask.Result;
            //int searchIndex = binarySearchTask.Result;

            //Console.WriteLine("Масив без повторювань: " + string.Join(", ", distinctArray));
            //Console.WriteLine("Відсортований масив: " + string.Join(", ", sortedArray));

            //if (searchIndex >= 0)
            //{
            //    Console.WriteLine($"Значення {searchValue} знайдено на позиції {searchIndex} у відсортованому масиві.");
            //}
            //else
            //{
            //    Console.WriteLine($"Значення {searchValue} не знайдено у масиві.");
            //}
        }

        static void PerformTask(string taskName)
        {
            Console.WriteLine($"{taskName} виконується. Поточний час: {DateTime.Now}");
            Task.Delay(2000).Wait();
            Console.WriteLine($"{taskName} завершено. Поточний час: {DateTime.Now}");
        }

        static List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static int FindMin(int[] array)
        {
            return array.Min();
        }

        static int FindMax(int[] array)
        {
            return array.Max();
        }

        static double CalculateAverage(int[] array)
        {
            return array.Average();
        }

        static int CalculateSum(int[] array)
        {
            return array.Sum();
        }
    }
}

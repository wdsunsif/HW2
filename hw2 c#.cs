
//Task1
// class Program
// {
//     static void Main(string[] args)
//     {
//         double[] A = new double[5];
//         Console.WriteLine("Введите 5 чисел для массива A:");
//         for (int i = 0; i < A.Length; i++)
//         {
//             if (double.TryParse(Console.ReadLine(), out double num))
//             {
//                 A[i] = num;
//             }
//             else
//             {
//                 Console.WriteLine("Ошибка");
//                 return;
//             }
//         }
//         Random random = new Random();
//         double[,] B = new double[3, 4];
//         Console.WriteLine("Массив B (случайные числа):");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 4; j++)
//             {
//                 B[i, j] = random.NextDouble() * 100;
//                 Console.Write($"{B[i, j]}");
//             }
//             Console.WriteLine();
//         }
//
//         double maxA = A[0], maxB = B[0, 0];
//         foreach (double num in A)
//         {
//             if (num > maxA)
//                 maxA = num;
//         }
//         foreach (double num in B)
//         {
//             if (num > maxB)
//                 maxB = num;
//         }
//         Console.WriteLine($"Общий максимальный элемент: {Math.Max(maxA, maxB)}");
//         
//         double minA = A[0], minB = B[0, 0];
//         foreach (double num in A)
//         {
//             if (num < minA)
//                 minA = num;
//         }
//         foreach (double num in B)
//         {
//             if (num < minB)
//                 minB = num;
//         }
//         Console.WriteLine($"Общий минимальный элемент: {Math.Min(minA, minB)}");
//         
//         double sumA = 0, sumB = 0;
//         foreach (double num in A)
//         {
//             sumA += num;
//         }
//         foreach (double num in B)
//         {
//             sumB += num;
//         }
//         Console.WriteLine($"Общая сумма всех элементов: {sumA + sumB}");
//         
//         double productA = 1, productB = 1;
//         foreach (double num in A)
//         {
//             productA *= num;
//         }
//         foreach (double num in B)
//         {
//             productB *= num;
//         }
//         Console.WriteLine($"Общее произведение всех элементов: {productA * productB}");
//         
//         double evenSumA = 0;
//         foreach (double num in A)
//         {
//             if (num % 2 == 0)
//                 evenSumA += num;
//         }
//         Console.WriteLine($"Сумма четных элементов массива A: {evenSumA}");
//         double oddColumnsSumB = 0;
//         for (int j = 0; j < 4; j++)
//         {
//             double columnSum = 0;
//             for (int i = 0; i < 3; i++)
//             {
//                 columnSum += B[i, j];
//             }
//             if (j % 2 != 0)
//                 oddColumnsSumB += columnSum;
//         }
//         Console.WriteLine($"Сумма нечетных столбцов массива B: {oddColumnsSumB}");
//     }
// }

//Task2
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] array = new int[5, 5];
//         Random random = new Random();
//         for (int i = 0; i < 5; i++)
//         {
//             for (int j = 0; j < 5; j++)
//             {
//                 array[i, j] = random.Next(-100, 101);
//             }
//         }
//         int min = array[0, 0];
//         int max = array[0, 0];
//         int minRow = 0, minCol = 0;
//         int maxRow = 0, maxCol = 0;
//
//         Console.WriteLine("Массив:");
//         for (int i = 0; i < 5; i++)
//         {
//             for (int j = 0; j < 5; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//                 if (array[i, j] < min)
//                 {
//                     min = array[i, j];
//                     minRow = i;
//                     minCol = j;
//                 }
//                 if (array[i, j] > max)
//                 {
//                     max = array[i, j];
//                     maxRow = i;
//                     maxCol = j;
//                 }
//             }
//             Console.WriteLine();
//         }
//         int sum = 0;
//         int startRow = Math.Min(minRow, maxRow);
//         int endRow = Math.Max(minRow, maxRow);
//         int startCol = Math.Min(minCol, maxCol);
//         int endCol = Math.Max(minCol, maxCol);
//
//         for (int i = startRow; i <= endRow; i++)
//         {
//             for (int j = startCol; j <= endCol; j++)
//             {
//                 sum += array[i, j];
//             }
//         }
//
//         Console.WriteLine($"Сумма элементов между минимальным ({min}) и максимальным ({max}) элементами: {sum}");
//     }
// }









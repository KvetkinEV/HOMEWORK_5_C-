//заполнение массива случайными двузначными числами
            Random rand = new Random();
            double[] numbers = new double[4];
            double result = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = rand.Next(10, 100);
                Console.Write(numbers[x] + " ");

            }
            //нахождение разницы между максимальным и минимальным элементов массива.

            foreach (double number in numbers)
            {
                result = numbers.Max() - numbers.Min();
                
            }



            //вывод разницы между максимальным и минимальным элементов массива.
            Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");
            Console.ReadLine();

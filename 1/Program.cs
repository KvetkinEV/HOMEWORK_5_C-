//заполнение массива случайными трехзначными числами
            Random rand = new Random();
            int[] numbers = new int[4];
            
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = rand.Next(100 , 1000);
                Console.Write(numbers[x] + " ");
            }
            //нахождение количества четных элементов
            int result = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0 && number != 0)
                {
                    result++;
                }
            }

            //вывод кол-ва четных элементов
            Console.WriteLine($"Количество четных элементов в массиве: {result}");
            Console.ReadLine();

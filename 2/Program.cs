//заполнение массива случайными двузначными числами
            Random rand = new Random();
            int[] numbers = new int[4];
       
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = rand.Next(10, 100);
                Console.Write(numbers[x] + " ");

            }
            //нахождение суммы элементов, стоящих на нечетных позициях

            var result = numbers.Where((element, index) => index % 2 == 0);
           
           
            //вывод суммы элементов, стоящих на нечетных позициях
            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result.Sum()}");
            Console.ReadLine();


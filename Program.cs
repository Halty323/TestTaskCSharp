namespace TestTask
{
    class Program
    {
        static void Main()
        {
            // Тест со списком вещественных чисел (положительных и отрицательных)
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { 0.111, -2.3, 5, 12.4, -44.1, 2.5213, 4.5, 5.746, 10.1, 24.88, -2.12, 12.7, 0, -100.567 }), -100.567 + -44.1);

            // Тест с простым массивом последовательных целых чисел
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 1 + 2);

            // Тест с минимально возможным массивом (2 элемента)
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { 1, 2 }), 1 + 2);

            // Тест с массивом, где два наименьших числа в начале
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 1 + 2);

            // Тест со случайными вещественными числами
            Random rnd = new Random();
            double[] randomDoubles = Enumerable.Repeat(0, 1000).Select(i => rnd.NextDouble() * 1000 - 500).ToArray();
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(randomDoubles), randomDoubles.OrderBy(x => x).Take(2).Sum());

            // Тест с большим массивом случайных целых чисел
            int[] largeArray = Enumerable.Repeat(0, 1000000).Select(i => rnd.Next()).ToArray();
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(largeArray), largeArray.OrderBy(x => x).Take(2).Sum());
            
            // Тест с двумя одинаковыми минимальными значениями
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { 1, 2, 3.2, 1 }), 2);
            
            // Тест с отрицательными числами и нулём
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { -5, -3, 0, 1, 2 }), -8);
            
            // Тест с большими числами, где может произойти переполнение
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { int.MaxValue, int.MaxValue, 1, 2 }), 3);
            
            // Тест с числами с плавающей точкой и округлением
            UnitTest.test(() => MinSumCalculator.SumTwoMinArray(new[] { 1.100000001, 1.100000002, 1.100000003 }), 2.200000003);
            
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

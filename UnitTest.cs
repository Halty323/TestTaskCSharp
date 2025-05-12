public class UnitTest
{
    public static bool assert<T>(T expected, T actual)
    {
        return expected?.Equals(actual) ?? false;
    }

    public static void test<T>(Func<T> func, T expected)
    {
        T actual = func();
        if (assert(expected, actual))
        {
            Console.WriteLine("Тест пройден успешно!");
            return;
        }
        Console.WriteLine("Тест не пройден!");
        Console.WriteLine($"Ожидалось: {expected}, Получено: {actual}");
    }
}
    
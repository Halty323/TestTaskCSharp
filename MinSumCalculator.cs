using System.Numerics;

public class MinSumCalculator
{
    public static T SumTwoMinArray<T>(IEnumerable<T> array) where T : IComparable<T>, IAdditionOperators<T, T, T>
    {
        if (array == null || array.Count() < 2)
            throw new ArgumentException("Некорректный массив");

        T min1 = array.First();
        T min2 = array.Skip(1).First();

        if (min1.CompareTo(min2) > 0)
        {
            (min1, min2) = (min2, min1);
        }

        foreach (T item in array.Skip(2))
        {
            if (item.CompareTo(min1) < 0)
            {
                (min1, min2) = (item, min1);
            }
            else if (item.CompareTo(min2) < 0)
            {
                min2 = item;
            }
        }

        return min1 + min2;
    }
}

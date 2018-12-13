using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWorkLinq
{
    public static class LinqLS
    {
        private static char[] vowels = new char[] { 'а', 'о', 'е', 'и', 'ю', 'я', 'э', 'А', 'О', 'Е', 'И', 'Ю', 'Я', 'Э', 'e', 'y', 'i', 'o', 'a', 'u', 'E', 'Y', 'I', 'O', 'A', 'U' };

        // Положительные числа(Select): написать метод,
        // который принимает перечисление чисел, и возвращает все
        // числа, отрицательные числа превратить в положительные.
        public static IEnumerable<int> ToPositive(IEnumerable<int> values)
        {
            return values.Select(i => i < 0 ? i : i);
        }

        // Булевая последовательность: написать метод, который
        // принимает перечисление чисел, каждое число
        // спроецировать в булевское значение.Если число больше 0
        // - true, в противном случае - false

        public static IEnumerable<bool> NumsToBool(IEnumerable<int> nums)
        {
            return nums.Select(i => i > 0);
        }

        // Из рациональных в целые: написать метод, который
        // принимает перечисление float, и возвращает перечисление
        // int.
        public static IEnumerable<int> FloatToInt(IEnumerable<float> vals)
        {
            return vals.Select(f => (int)f);
        }

        // Слова без гласных: написать метод, который принимает
        // перечисление строк, и возвращает перечисление строк без
        // гласных.

        public static IEnumerable<string> ExtractVowels(IEnumerable<string> text)
        {
            return text.Select(s => new string(s.Where(c => !vowels.Contains(c)).ToArray()));
        }

        // Свой Select: напишите свою версию Select в отдельном
        // классе MyLinq.cs.

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "source is null");
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector), "selector is null");
            }

            foreach (TSource element in source)
            {
                yield return selector(element);
            }
        }

        public static void DisplayToConsole<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}

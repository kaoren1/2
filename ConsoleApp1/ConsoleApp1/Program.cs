using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Linq.Expressions;
M:
int i = 0;
do
{
    Console.WriteLine("Выберите действие: ");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    string j = Console.ReadLine();
    if (int.TryParse(j, out var c) == true)
    {
        if (c > 0 && c < 10)
        {
            if (c != 9)
            {
                bool num = true;
                while (num == true)
                {
                        i = c;
                        switch (c)
                        {
                            case 1:
                                Console.Write("Введите первое число: ");
                                string K1 = Console.ReadLine();
                                Console.Write("Введите второе число: ");
                                string L1 = Console.ReadLine();
                                bool num1 = double.TryParse(K1, out var A1);
                                bool num2 = double.TryParse(L1, out var B1);
                                if (num1 == true && num2 == true)
                                {
                                    if (A1 >= double.MinValue && A1 <= double.MaxValue && B1 >= double.MinValue && B1 <= double.MaxValue)
                                    {
                                        double ans = (A1 + B1);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");

                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 2:
                                Console.Write("Введите первое число: ");
                                string K2 = Console.ReadLine();
                                Console.Write("Введите второе число: ");
                                string L2 = Console.ReadLine();
                                bool num3 = double.TryParse(K2, out var A2);
                                bool num4 = double.TryParse(L2, out var B2);
                                if (num3 == true && num4 == true)
                                {
                                    if (A2 >= double.MinValue && A2 <= double.MaxValue && B2 >= double.MinValue && B2 <= double.MaxValue)
                                    {
                                        double ans = (A2 - B2);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 3:
                                Console.Write("Введите первое число: ");
                                string K3 = Console.ReadLine();
                                Console.Write("Введите второе число: ");
                                string L3 = Console.ReadLine();
                                bool num5 = double.TryParse(K3, out var A3);
                                bool num6 = double.TryParse(L3, out var B3);
                                if (num5 == true && num6 == true)
                                {
                                    if (A3 >= double.MinValue && A3 <= double.MaxValue && B3 >= double.MinValue && B3 <= double.MaxValue)
                                    {
                                        double ans = (A3 * B3);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 4:
                                Console.Write("Введите первое число: ");
                                string K4 = Console.ReadLine();
                                Console.Write("Введите второе число: ");
                                string L4 = Console.ReadLine();
                                bool num7 = double.TryParse(K4, out var A4);
                                bool num8 = double.TryParse(L4, out var B4);
                                if (num7 == true && num8 == true)
                                {
                                    if (A4 >= double.MinValue && A4 <= double.MaxValue && B4 >= double.MinValue && B4 <= double.MaxValue && B4 != 0)
                                    {
                                        double ans = (A4 / B4);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 5:
                                Console.Write("Введите первое число: ");
                                string K5 = Console.ReadLine();
                                Console.Write("Введите степень: ");
                                string L5 = Console.ReadLine();
                                bool num9 = double.TryParse(K5, out var A5);
                                bool num10 = double.TryParse(L5, out var B5);
                                if (num9 == true && num10 == true)
                                {
                                    if (A5 >= double.MinValue && A5 <= double.MaxValue && B5 >= double.MinValue && B5 <= double.MaxValue)
                                    {
                                        double ans = Math.Pow(A5, B5);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 6:
                                Console.Write("Введите число: ");
                                string K6 = Console.ReadLine();
                                bool num11 = double.TryParse(K6, out var A6);
                                if (num11 == true)
                                {
                                    if (A6 >= 0 && A6 <= double.MaxValue)
                                    {
                                        double ans = Math.Sqrt(A6);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 7:
                                Console.Write("Введите число: ");
                                string K7 = Console.ReadLine();
                                bool num12 = double.TryParse(K7, out var A7);
                                if (num12 == true)
                                {
                                    if (A7 >= 0 && A7 <= double.MaxValue)
                                    {
                                        double ans = (A7 / 100);
                                        Console.WriteLine("Результат: " + ans);
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 8:
                                Console.Write("Введите число: ");
                                string K8 = Console.ReadLine();
                                bool num13 = int.TryParse(K8, out var A8);
                                if (num13 == true)
                                {
                                    if (A8 >= 0 && A8 <= int.MaxValue)
                                    {
                                        int x = 1;
                                        for (int f = 1; A8 >= f; ++f)
                                        {
                                            x = x * f;
                                        }
                                        Console.WriteLine("Результат: " + x);
                                        Console.WriteLine(" ");
                                }
                                    else
                                    {
                                        Console.WriteLine("Введено некорректное значение");
                                        Console.WriteLine(" ");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введено некорректное значение");
                                    Console.WriteLine(" ");
                                }
                                break;
                            case 9:
                                Console.WriteLine(" ");
                                break;
                        }
                
                    num = false;
                }
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Введено некорректное действие");
            Console.WriteLine(" ");
            goto M;
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное действие");
        Console.WriteLine(" ");
        goto M;
    }
}
while (i != 9);
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
class Zadachi
{
    static void Main()
    {

    }
}
/*
1. Напишите программу, в которой пользователь вводит число, а программа проверяет,
делится ли это число на 3 и на 7. Результаты проверки отображаются в сообщении в
диалоговом онке. Используйте обработку исключений.
        int num;
        try
        {
            num = Int32.Parse(Interaction.InputBox("Введите число, Программа проверит делится ли оно на 3 и на 7"));
        }
        catch
        {
            MessageBox.Show("Попробуйте еще раз", "Упс, что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
            num = Int32.Parse(Interaction.InputBox("Введите число, Программа проверит делится ли оно на 3 и на 7"));
        }
        if (num % 3 == 0 && num % 7 == 0)
            MessageBox.Show("Число делится на 3 и на 7");
        else
            MessageBox.Show("Число не делится на 3 и на 7");

2. Напишите программу, в которой пользователь последовательно вовдит два целых числа.
Программа определяет, какое  из чисел больше или они равны, и выводит сообщение в диалоговом окне.
Используйте обработку исключений.
        bool temp = false;
        int num1 = 0, num2 = 0;
        while (temp == false)
        {
            try
            {
                num1 = Int32.Parse(Interaction.InputBox("Введите первое целое число"));
                num2 = Int32.Parse(Interaction.InputBox("Введите второе целое число"));
                temp = true;
            }
            catch
            {
                MessageBox.Show("Советую вам сделать то, что она просит",
                    "Упс",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                continue;
            }
        }
        if (num1 == num2)
            MessageBox.Show($"Числа равны, {num1} = {num2}");
        else if (num1 > num2)
            MessageBox.Show($"Первое число больше второго, {num1} > {num2}");
        else
            MessageBox.Show($"Второе число больше первого, {num2} > {num1}");

3. Напишите программу, в которой вычисляется сумма чисел, которые вводит пользователь. 
Программа выводит запрос на ввод числа, считывает введенное пользователем число, прибавляет
его к сумме и снова выводит запрос на ввод числа. Процесс продолжается до тех пор, пока пользователь
не введет нулевое значение. Используйте обработку исключений.
        Console.WriteLine("Вводите целые числа по очереди, которые хотите сложить");
        int n, sum = 0;
        bool temp = false;
        while (temp == false)
        {
            try
            {
                n = Int32.Parse(Console.ReadLine());
                while (n != 0)
                {
                    Console.WriteLine("Их сумма равна: {0}", sum += n);
                    n = Int32.Parse(Console.ReadLine());
                }
                temp = true;
            }
            catch
            {
                Console.WriteLine("Упс, что-то пошло не так");
                Console.WriteLine("Вводите целые числа по очереди, которые хотите сложить");
                continue;
            }
        }

4. Напишите программу, в которой пользователь вводи целое число в диапазоне от 1 до 7, а программа
определяет по этому числу день недели. Если введенное пользователем число выходит за допустимый
диапазон, выводится сообщение о том, что введено некорректное значение. Используйте оператор выбора 
switch. Прелдложите механизм обработки ошибки, связанной с вводом нечислового значения.
        int num = 0;
        Console.WriteLine("Введите целое число в диапазонен от 1 до 7");
        try
        {
            num = Int32.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Что-то пошло не так");
            Console.WriteLine("Введите целое число в диапазонен от 1 до 7");
            num = Int32.Parse(Console.ReadLine());
        }
        switch (num)
        {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Введено неккоректное значение");
                break;
        }

6. Напишите программу, в которой вычисляется сумма нечетных чисел.
        int sum = 0;
        Console.WriteLine("Сумму скольких первых нечетных чисел вы хотите узнать?");
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            sum += 2 * i + 1;
            Console.Write("{0} ", 2 * i + 1);
        }
        Console.WriteLine($"\n{sum}");

7. Напишите программу для вычисления суммы квадратов натуральных чисел.
        int sum = 0;
        Console.WriteLine("Сумму квадратов скольких первых чисел вы хотите узнать?");
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            sum += i * i;
        }
        Console.WriteLine(sum);

8. Напишите программу, которая выводит последовательность числей Фибоначчи.
        int sum = 1, n = 1;
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(sum);
            Console.WriteLine(n);
            sum += n;
            n += sum;
        }
9. Напишите программу, в которой пользователь вводит два целых числа.
Программа выведет все целые числа - начиная с наименьшего из двух,
заканчивая наибольшим.
        int z = 0, n = 0;
        bool temp = false;
        while (temp == false)
        {
            try
            {
                Console.WriteLine("Введите два числа");
                z = Int32.Parse(Console.ReadLine());
                n = Int32.Parse(Console.ReadLine());
                temp = true;
            }
            catch
            {
                Console.WriteLine("Ошибка");
                continue;
            }
        }
        if (n > z)
        {
            for (int i = z; i <= n; i++)
                Console.WriteLine(i);
        }
        else if (n < z)
        {
            for (int i = n; i <= z; i++)
                Console.WriteLine(i);
        }
        else
            Console.WriteLine(z);

10. Напишите программу, в которой вычисляется сумма чисел, удовлетворящих таким критериям:
при делении числа на 5 в остатке получается 2, или при делении на 3 в остатке получается 1

        int sum = 0, i1 = 1, n;
        n = Int32.Parse(Console.ReadLine());
        for (int i = 4; i <= 100; i++)
        {
            while (i1 <= n)
            {
                if (i % 5 == 2 || i % 3 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                    i1++;
                }
                else
                    break;
                break;
            }
        }
        Console.WriteLine(sum);
 */

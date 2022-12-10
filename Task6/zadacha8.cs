// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine ());
int k = 1;
            while (k <= num)
            {
                int result = k % 2;
                if (result != 1)
                {
                    Console.WriteLine("четное " + k);
                    k++;
                }
                else
                {
                    k++;
                }
            }

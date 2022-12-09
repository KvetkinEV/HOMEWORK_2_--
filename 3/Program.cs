Console.Write("Введи число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            if (chislo % 7 == 0 && chislo % 23 == 0)
            {
                Console.WriteLine(chislo + " -> ДА");
            }
            else
                Console.WriteLine(chislo + " -> нет");
            Console.ReadLine();


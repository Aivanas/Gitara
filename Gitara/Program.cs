namespace Gitara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать туда!");
            Console.WriteLine("Для завершения работы программы выберите 'Выход из программы'");
            Chooser(); 
        }

        static void Chooser()
        {

            
            int[] Big_Octave = new int[] {654, 693, 734, 777, 824, 873, 925, 980, 1038, 1100, 1165, 1235 };
            int[] Small_Octave = new int[] { 1308, 1386, 1468, 1556, 1648, 1746, 1850, 1960, 2077, 2200, 2331, 2469 };
            int[] First_Octave = new int[] { 2616, 2772, 2937, 3111, 3296, 3492, 3700, 3920, 4153, 4400, 4662, 4939 };
            int[] Second_Octave = new int[] { 5233, 5544, 5873, 6223, 6593, 6985, 7400, 7840, 8306, 8800, 9323, 9878 };
            int[] Third_Octave = new int[] { 10470, 11090, 11750, 12450, 13190, 1397, 14800, 15680, 16610, 17600, 18650, 19760  };
            int[] Fourth_Octave = new int[] { 20930, 22170, 23490, 24890, 26370, 27940, 29600, 31360, 33220, 35200, 37290, 39610 };


            bool smthng = true;
            while (smthng)
            {
                Console.WriteLine("Какая октава вас интересует?");
                Console.WriteLine("F1: Выход из программы");
                
                Console.WriteLine("F3: Большая октава");
                Console.WriteLine("F4: Малая октава");
                Console.WriteLine("F5: Первая октава");
                Console.WriteLine("F6: Вторая октава");
                Console.WriteLine("F7: Третья октава");
                Console.WriteLine("F8: Четвёртая октава");
                Console.WriteLine("------------------------");
                Console.WriteLine("F9 для выхода из октавы ");

                ConsoleKeyInfo what_octave = Console.ReadKey();
                if (what_octave.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Ок, я вас понял!");
                    smthng = false;
                }
                
                else if (what_octave.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Большая октава");
                    Player(Big_Octave);
                }
                else if (what_octave.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Малая октава");
                    Player(Small_Octave);
                }
                else if (what_octave.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Первая октава");
                    Player(First_Octave);
                }
                else if (what_octave.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("Вторая октава");
                    Player(Second_Octave);
                }
                else if (what_octave.Key == ConsoleKey.F7)
                {
                    Console.WriteLine("Третья октава");
                    Player(Third_Octave);
                }
                else if ( what_octave.Key == ConsoleKey.F8)
                {
                    Console.WriteLine("Четвёртая октава");
                    Player(Fourth_Octave);
                }
                else 
                {
                    continue;
                    Console.Clear();
                }
            }

        }


        static void Player(int[] sound_list)
        {
            

            while (true)
            {
                ConsoleKeyInfo button = Console.ReadKey(true);
                if (button.Key == ConsoleKey.A)
                {
                    Console.Beep((sound_list[0] / 10), 300);
                }

                else if (button.Key == ConsoleKey.W)
                {
                    Console.Beep((sound_list[1] / 10), 300);
                }

                else if (button.Key == ConsoleKey.S)
                {
                    Console.Beep((sound_list[2] / 10), 300);
                }

                else if (button.Key == ConsoleKey.E)
                {
                    Console.Beep((sound_list[3] / 10), 300);
                }

                else if (button.Key == ConsoleKey.D)
                {
                    Console.Beep((sound_list[4] / 10), 300);
                }

                else if (button.Key == ConsoleKey.F)
                {
                    Console.Beep((sound_list[5] / 10), 300);
                }

                else if (button.Key == ConsoleKey.T)
                {
                    Console.Beep((sound_list[6] / 10), 300);
                }

                else if ( button.Key == ConsoleKey.G)
                {
                    Console.Beep((sound_list[7] / 10), 300);
                }

                else if (button.Key == ConsoleKey.Y)
                {
                    Console.Beep((sound_list[8] / 10), 300);
                }

                else if (button.Key == ConsoleKey.H)
                {
                    Console.Beep((sound_list[9] / 10), 300);
                }

                else if (button.Key == ConsoleKey.U)
                {
                    Console.Beep((sound_list[10] / 10), 300);
                }

                else if (button.Key == ConsoleKey.J)
                {
                    Console.Beep((sound_list[11] / 10), 300);
                }

                else if (button.Key == ConsoleKey.F9)
                {   
                    Console.Clear();
                    break;                    
                }

                else
                {
                    continue;
                }
            }
        }

    
    }
}
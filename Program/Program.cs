using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            User_OutData();
            Console.ReadKey();
        }

        static (string, string, int, int, string[], int, string[]) User_InData()
        {
            (string Name, string Last_Name, int Age, int Pets_Quantity, string[] Pets_Names_Array, int Fav_Colors_Quantity, string[] Fav_Colors_Array) User;

            Console.WriteLine("Введите имя: ");
            string inname = Console.ReadLine();
            while (CheckString(inname) == false)
            {
                Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                inname = Console.ReadLine();
            }
            User.Name = inname;


            Console.WriteLine("Введите фамилию: ");
            string inlastname = Console.ReadLine();
            while (CheckString(inlastname) == false)
            {
                Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                inlastname = Console.ReadLine();
            }
            User.Last_Name = inlastname;


            Console.WriteLine("Введите возраст: ");
            string inage = Console.ReadLine();
            int outage;
            while(CheckNum(inage, out outage) == false)
            {
                Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                inage = Console.ReadLine();
            }
            User.Age = outage;


            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();
            int out_pets_quantity = 0;
            while (result != "Да" && result != "Нет")
            {
                Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                result = Console.ReadLine();
            }
            if (result == "Да")
            {
                Console.WriteLine("Введите количество питомцев: ");
                string pets_quantity = Console.ReadLine();
                while (CheckNum(pets_quantity, out out_pets_quantity) == false)
                {
                    Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                    pets_quantity = Console.ReadLine();
                }
            } else if (result == "Нет")
            {
                out_pets_quantity = 0;
            }
            User.Pets_Quantity = out_pets_quantity;
            User.Pets_Names_Array = Pets_Names(out_pets_quantity);


            Console.WriteLine("Введите количество любимых цветов: ");
            string incolors = Console.ReadLine();
            int outcolors;
            while (CheckNum(incolors, out outcolors) == false)
            {
                Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                incolors = Console.ReadLine();
            }
            User.Fav_Colors_Quantity = outcolors;
            User.Fav_Colors_Array = Fav_Colors(outcolors);


            return User;
        }

        static void User_OutData()
        {
            var (name, last_name, age, pets_quantity, pets_names_array, colors_quantity, colors_array) = User_InData();

            Console.WriteLine("\nВаше имя: {0}", name);
            Console.WriteLine("Ваша фамилия: {0}", last_name);
            Console.WriteLine("Ваш возраст: {0}\n", age);
            if (pets_quantity > 0)
            {
                Console.WriteLine("Количество питомцев: {0}", pets_names_array.Length);
                Console.WriteLine("Клички: ");
                foreach (var item in pets_names_array)
                {
                    Console.WriteLine(item + " ");
                }
            }
            else
            {
                Console.WriteLine(pets_names_array[0]);
            }

            if (colors_quantity > 0)
            {
                Console.WriteLine("\nКоличество любимых цветов: {0}", colors_array.Length);
                foreach (var item in colors_array)
                {
                    switch (item)
                    {
                        case ("Желтый"):
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Белый"):
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Красный"):
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Пурпурный"):
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Зеленый"):
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Серый"):
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Циановый"):
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        case ("Синий"):
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(item);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(item);

                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine(colors_array[0]);
            }

        }

        static string[] Pets_Names(int pets_qnty)
        {
            string[] pets_names = new string[1];
            if (pets_qnty == 0)
            {
                pets_names[0] = "У вас нет питомцев";
            }
            else
            {
                pets_names = new string[pets_qnty];
                for (int i = 0; i < pets_names.Length; i++)
                {
                    Console.WriteLine("Введите кличку питомца №{0}: ", i+1);
                    pets_names[i] = Console.ReadLine();
                }
            }
            return pets_names;
        }

        static string[] Fav_Colors(int colors_qnty)
        {
            string[] color_names = new string[1];
            if (colors_qnty == 0)
            {
                color_names[0] = "У вас нет любимых цветов";
            } 
            else
            {
                color_names = new string[colors_qnty];
                for (int i = 0; i < color_names.Length; i++)
                {
                    Console.WriteLine("Введите цвет №{0} с большой буквы: ", i + 1);
                    color_names[i] = Console.ReadLine();
                    if (CheckString(color_names[i]) == false)
                    {
                        while (CheckString(color_names[i]) == false)
                        {
                            Console.WriteLine("Ввод некорректный, попробуйте еще раз:");
                            color_names[i] = Console.ReadLine();
                        }
                    }
                }
            }

            return color_names;
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum >= 0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            {
                corrnumber = 0;
                return false;
            }
        }

        static bool CheckString(string str)
        {
            foreach(var item in str)
            {
                string ch = item.ToString();
                if (CheckNum(ch, out int _))
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }
    }
}

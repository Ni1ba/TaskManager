namespace TaskManagerConsole
{
    public class Program
    {


        public static void Main()
        {
            // логику добавления, обновления, просмотра
            // храненение данных
            Menu();
        }

        public static void Menu()
        {
            DataTypeConverter converter = new DataTypeConverter();
            int UserChoice;
            Dictionary<int, string> menu = new Dictionary<int, string>();
            menu[1] = "Список задач.";
            menu[2] = "Добавить задачу.";
            menu[3] = "Удалить задачу.";
            menu[4] = "Просмотреть задачу.";
            menu[5] = "Выход.";
            do
            {
                Console.WriteLine("Меню:");
                foreach (var item in menu)
                {
                    Console.WriteLine($"[{item.Key}] {item.Value}");
                }

                UserChoice = converter.ValueNumeric(Console.ReadLine());
                if (UserChoice <= 0 || UserChoice > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите цифру соответствующую пункту в меню.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    switch (UserChoice)
                    {
                        case 1: Console.WriteLine($"Выбрано: [{menu[UserChoice]}] "); Console.WriteLine(); TaskList(); break;
                        case 2: Console.WriteLine($"Выбрано: [{menu[UserChoice]}] "); AddTask(); break;
                        case 3: Console.WriteLine($"Выбрано: [{menu[UserChoice]}] "); Console.WriteLine(); RemoveTask(); break;
                        case 4: Console.WriteLine($"Выбрано: [{menu[UserChoice]}] "); Console.WriteLine(); ReviewTask(); break;
                    }
                }
            }
            while (UserChoice != 5);
        }

        public static void TaskList()
        {
            DataTypeConverter exc = new DataTypeConverter();
            int UserChoice;
            Dictionary<int, string> menu = new Dictionary<int, string>();

            menu[1] = "Вернуться в меню.";
            do
            {
                Console.WriteLine("Меню:");
                foreach (var item in menu)
                {
                    Console.WriteLine($"[{item.Key}] {item.Value}");
                }
                UserChoice = exc.ValueNumeric(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1: break;
                }

            } while (UserChoice != 1);
        }

        public static Task AddTask()
        {
            Task task = new Task();
            DataTypeConverter converter = new DataTypeConverter();
            Console.WriteLine("Введите название задачи: ");

            task.Name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            task.Description = Console.ReadLine();

            task.DateTimesStruct.DateAdd = DateTime.Now;

            Console.WriteLine("Введите дату начала в формате dd-mm-yyyy (Оставить пустым, чтобы по умолчанию был момент добавления):");
            try
            {
                task.DateTimesStruct.DateStart = ReadDateTimeFromConsole();

            }
            catch
            {
                //сюда не попадаем обычно
                Console.WriteLine("Произошла ошибка при чтении даты.");
            }

            do
            {
                Console.WriteLine("Введите дату окончания в формате dd-mm-yyyy (Оставить пустым, чтобы по умолчанию был момент добавления):");
                try
                {
                    DateTime endDate = ReadDateTimeFromConsole();

                    if (endDate < task.DateTimesStruct.DateStart)
                    {
                        Console.WriteLine("Дата окончания не может быть меньше даты начала. Пожалуйста, введите дату еще раз.");
                    }
                    else
                    {
                        task.DateTimesStruct.DateEnd = endDate;
                        break; // Выход из цикла, если дата окончания корректна
                    }
                }
                catch
                {
                    Console.WriteLine("Произошла ошибка при чтении даты.");
                }
            } while (true);

            return task;

        }

        public static void RemoveTask()
        {

        }
        public static void ReviewTask()
        {
            Console.WriteLine("");
        }

        //метод для проверки введенных дат
        private static DateTime ReadDateTimeFromConsole()
        {
            DateTime result = DateTime.MinValue;
            do
            {
                //Console.WriteLine("Введите дату или оставьте поле пустым:");
                string? input = Console.ReadLine();
                //если пустая строка, то текущее время возвращаем
                if (input=="")
                {
                    return DateTime.Now;
                }

                result = string.IsNullOrEmpty(input) ? DateTime.MinValue : DateTime.TryParse(input, out DateTime parsedDate) ? parsedDate : DateTime.MinValue;

                if (result != DateTime.MinValue)
                {
                    break; // Выход из цикла, если дата успешно преобразована
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Некорректный формат введенной даты. Попробуйте еще раз. Ввод:");
                }


            } while (true);

            return result;
        }

    }

}
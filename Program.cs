using System.Threading.Tasks;

namespace TaskManagerConsole
{
    public class Program
    {

        public static void Main()
        {
            // логику добавления, обновления, просмотра
            // храненение данных

            Task task = new Task();
            Menu();

           

        }

        public static void Menu()
        {
            ExceptionHandling exc = new ExceptionHandling();
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

                UserChoice = exc.ValueNumeric(Console.ReadLine());
                if (UserChoice <= 0 || UserChoice > 5 )
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
                        case 3: Console.WriteLine($"Выбрано: [{menu[UserChoice]}] "); Console.WriteLine();RemoveTask(); break;
                        case 4: Console.WriteLine($"Выбрано: [{menu[UserChoice]}] "); Console.WriteLine(); ReviewTask(); break;
                    }
                }
            }
            while (UserChoice!=5);
        }

        public static void TaskList()
        {
            ExceptionHandling exc = new ExceptionHandling();
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

                }

            } while  (UserChoice!=1);
        }

        public static void AddTask() 
        {
            Console.WriteLine("Введите название задачи: " );
            Console.ReadLine();

            Console.WriteLine("Введите описание задачи:");
            Console.ReadLine();

            Console.WriteLine("Введите дату начала (Оставить пустым, чтобы по умолчанию был момент добавления):");
            Console.ReadLine();

            Console.WriteLine("Введите дату окончания (Оставить пустым, чтобы по умолчанию был момент добавления):");
            Console.ReadLine();
        }

        public static void RemoveTask() 
        {
        
        }
        public static void ReviewTask() 
        {
            Console.WriteLine(""); 
        }
    }

}
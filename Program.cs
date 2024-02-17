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
            //task.SetDateAdd(DateTime.Now);
            
            Console.WriteLine("Hi");
            Menu();

           

        }

        public static void Menu()
        {
            ExceptionHandling exc = new ExceptionHandling();
            int UserChoice;

            do
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1.Список задач");
                Console.WriteLine("2.Добавить задачу");
                Console.WriteLine("3.Удалить задачу");
                Console.WriteLine("4.Просмотреть задачу");

                
                 

                UserChoice = exc.ValueNumeric( Console.ReadLine());

            }
            while (UserChoice!=0);
        }

        
    }

}
 
namespace TaskManagerConsole
{
    public class DataTypes
    {
        public class TaskDateTimes
        {
            private DateTime dateAdd { get; set; }
            //public DateTime dateStart;
            //public DateTime dateEnd;
            //public DateTime dateDeadLine;

            //конструктор
            public TaskDateTimes(DateTime dateAdd, DateTime dateStart, DateTime dateEnd, DateTime dateDeadLine)
            {
                this.dateAdd = dateAdd;
                //this.dateStart = dateStart;
                //this.dateEnd = dateEnd;
                //this.dateDeadLine = dateDeadLine;
            }

            public DateTime DateAdd 
            {
                get => dateAdd; 
                set => dateAdd=TypeDateTime(value)  ; 
            }

            private DateTime TypeDateTime(DateTime value)
            {
                return value.GetType() == typeof(DateTime) ? value : DateTime.MinValue;
            }  

        }

    }

    //public enum TaskStatusEnum
    //{
    //    Неопределенный,
    //    Готов,
    //    В_работе,
    //    Брошено
    //}

    //public enum TaskPriorityEnum
    //{
    //    Высокий,
    //    Средний,
    //    Низкий
    //}




}

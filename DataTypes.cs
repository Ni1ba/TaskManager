
namespace TaskManagerConsole
{
    public class DataTypes
    {

        public class TaskDateTimesStruct
        {
            // Поле
            public DateTime _dateAdd;
            public DateTime _dateStart;
            public DateTime _dateEnd;


            // Конструктор
            public TaskDateTimesStruct()
            {
                _dateAdd = DateTime.Now;
                _dateStart = DateTime.Now;
                _dateEnd = DateTime.Now;
            }

            public TaskDateTimesStruct(DateTime dateAdd, DateTime dateStart, DateTime dateEnd)
            {
                _dateAdd = CheckTypeDataTime(dateAdd) ;
                _dateStart = CheckTypeDataTime(dateStart) ;
                _dateEnd = CheckTypeDataTime(dateEnd) ;

            }

            //геттер и сеттер
            public DateTime DateAdd
            {
                get { return _dateAdd; }
                set
                {
                    _dateAdd = CheckTypeDataTime(value);
                }
            }
            public DateTime DateStart
            {
                get { return _dateStart; }
                set { _dateStart = CheckTypeDataTime(value); }
            }

            public DateTime DateEnd
            {
                get { return _dateEnd; }
                set { _dateEnd = CheckTypeDataTime(value); }
            }

            //на кой хер нужна проверка на дату? я хз, пусть будет
            private   DateTime CheckTypeDataTime (DateTime value)
            {
                if (value.GetType() == typeof(DateTime))
                {
                    return value;
                }
                else
                {
                    throw new ArgumentException("Значение должно быть типа DateTime", nameof(value));
                }
            }
        }
        // перечисление статусов 
        public enum TaskStatus
        {
            Неопределенный,
            В_работе,
            Готов,
            Брошено, 
        }
        public enum TaskPriorityEnum
        {
            Высокий,
            Средний,
            Низкий
        }

    }

}

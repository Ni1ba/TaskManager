
namespace TaskManagerConsole
{
    public class DataTypes
    {

        public struct TaskDateTimesStruct
        {
            // Поле
            private DateTime _dateAdd;
            private DateTime _dateStart;
            private DateTime _dateEnd;


            // Конструктор
            public TaskDateTimesStruct() 
            { 
                _dateAdd = DateTime.Now;
                _dateStart = DateTime.Now;
                _dateEnd = DateTime.Now;
            }

            public TaskDateTimesStruct(DateTime dateAdd,DateTime dateStart,DateTime dateEnd)
            {
                _dateAdd = dateAdd;
                _dateStart = dateStart;
                _dateEnd = dateEnd;

            }

            // геттер и сеттер 
            public DateTime DateAdd
            {
                get { return _dateAdd; }
                set { _dateAdd = value; }
            }
            public DateTime DateStart
            {
                get { return _dateStart; }
                set { _dateStart = value; }
            }

            public DateTime DateEnd
            {
                get { return _dateEnd; }
                set { _dateEnd = value; }
            }

        }

    }

}

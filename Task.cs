namespace TaskManagerConsole
{
    // класс задачи, в нем вся инфа о задаче
    public class Task
    {

        //поля

        private string _taskName { get; set; }
        private string _taskDescription { get; set; }
        private DataTypes.TaskDateTimesStruct _taskDateTimesStruct;
        //статус задачи
        //
        private DataTypes.TaskStatus _taskStatus { get; set; }

        //конструктор
        public Task()
        {
            DataTypes.TaskDateTimesStruct localDt = new DataTypes.TaskDateTimesStruct();

            _taskName = null;
            _taskDescription = null;
            _taskDateTimesStruct = localDt;
             
        }

        //геттеры/сеттеры
        public string Name { get => _taskName; set => _taskName = value; }

        public string Description { get => _taskName; set => _taskName = value; }

        public DataTypes.TaskDateTimesStruct DateTimesStruct
        {
            get => _taskDateTimesStruct;
            set
            {
                if (value.GetType() == typeof(DataTypes.TaskDateTimesStruct))
                {
                    _taskDateTimesStruct = value;
                }
                else
                {
                    throw new ArgumentException("Значение должно быть типа DataTypes.TaskDateTimesStruct", nameof(value));
                }
            }

        }

    }

}




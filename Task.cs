namespace TaskManagerConsole
{
    // класс задачи, в нем вся инфа о задаче
    public class Task 
    {

        //поля

        private string _taskName { get; set; }
        private string _taskDescription { get; set; }
        public DataTypes.TaskDateTimesStruct TaskDateTimesStruct;
        
        //внутренние типы данных

        //конструктор
        public Task()
        {
            DataTypes.TaskDateTimesStruct localDt = new DataTypes.TaskDateTimesStruct();

            _taskName = null;
            _taskDescription = null;
            TaskDateTimesStruct = localDt;
        }

        //геттеры/сеттеры
        public string Name { get => _taskName; set => _taskName= value; }

        public string Description { get => _taskName; set => _taskName = value; }

         
    }
}




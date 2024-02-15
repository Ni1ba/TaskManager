namespace TaskManagerConsole
{
    // класс задачи, в нем вся инфа о задаче
    public class Task : DataTypes
    {

        //поля
        DataTypes newTy = new DataTypes();


        private string TaskName { get; set; }
        private string TaskDescription { get; set; }
        private dataTypes.TaskDateTimes DateTimesStruct { get; set; }

        //private DateTimesStruct TaskDateTimes { get; set; }
        //private TaskStatusEnum TaskStatus { get; set; }
        //private TaskPriorityEnum TaskPriority { get; set; }

        //внутренние типы данных

        //конструктор
        public Task()
        {
            this.TaskName = null;
            this.TaskDescription = null;
            //this.DateTimesStruct.DateAdd = DateTime.MinValue;
            //DateTimesStruct = ;

        }

        //геттеры/сеттеры
        public string Name { get => TaskName; set => TaskName = value; }

        public string Description { get => TaskDescription; set => TaskDescription = value; }

    }
}




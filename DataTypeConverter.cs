using Microsoft.VisualBasic;

namespace TaskManagerConsole
{
    public class DataTypeConverter
    {
        public int ValueNumeric(object value)
        {
            int result = 0;
            return (int.TryParse(value.ToString(), out result) ? Convert.ToInt32(value)   : result);
                      
        }

        public DateTime ValueDateTime (object value)
        {
            DateTime result = DateTime.MinValue;
            return (DateTime.TryParse(value.ToString(),out result) ? Convert.ToDateTime(value) : result);
        }
    }
}
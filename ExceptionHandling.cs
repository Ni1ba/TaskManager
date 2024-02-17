using Microsoft.VisualBasic;

namespace TaskManagerConsole
{
    internal class ExceptionHandling
    {
        public int ValueNumeric(object value)
        {
            int result = 0;
            return (int.TryParse(value.ToString(), out result) ? Convert.ToInt32(value)   : result);
                      
        }
    }
}
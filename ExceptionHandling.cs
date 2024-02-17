using Microsoft.VisualBasic;

namespace TaskManagerConsole
{
    internal class ExceptionHandling
    {
        public int ValueNumeric(object value)
        {
            int result = 0;
            try
            {
                value = int.TryParse(value.ToString(), out result);

            }
            catch (Exception)
            {

                throw;
            }
            finally { }

            return 0;
        }
    }
}

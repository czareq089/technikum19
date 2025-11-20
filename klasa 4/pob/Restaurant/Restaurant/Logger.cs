using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public sealed class Logger
    {
        private Logger() { }
        private static Logger _instance;
        
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            
            return _instance;
        }
        public void Log(string message)
        {
            DateTime dateTime = DateTime.Now;
            FileHandler fileHandler = new FileHandler();
            StreamWriter streamWriter = new StreamWriter($"{fileHandler.path}/{fileHandler.filename}", append: true);
            streamWriter.WriteLine("");
            streamWriter.WriteLine($" [{dateTime:HH:mm}] {message}");
            streamWriter.Close();
        }
    }
}

using System;

namespace Singleton
{
    public class Logger
    {
        /// <summary>
        /// 1. Declare static memeber of class
        /// </summary>
        private static Logger logger;
        
        /// <summary>
        /// 2. Private constructor
        /// </summary>
        private Logger()
        {
        }

        /// <summary>
        /// 3. Declare static property to create new object
        /// </summary>
        public static Logger Instance 
        { 
            get
            {
                if (logger == null)
                    logger = new Logger();

                return logger;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine( DateTime.Now.ToString() + " - " + message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExampleApp
{
    static class Training
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string SessionName { get; set; }
        public static int TotalHour { get; set; }
        public static int NumberOfTrainee { get; set; }

        public static string GetInfo(string name, string session)
        {
            return "Name : " + name + "SessionName : " + session;
        }
    }
}

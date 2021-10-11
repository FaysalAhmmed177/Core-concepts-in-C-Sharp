using System;

namespace StaticExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Training.NumberOfTrainee = 30;
            Training.GetInfo("", "");

            //Training training1 = new Training();
            //training1.Id = 1;
            //training1.Name = "35-D";
            //training1.SessionName = "Dot Net";
            //training1.TotalHour = 90;


            //Training training2 = new Training();
            //training2.Id = 2;
            //training2.Name = "35-E";
            //training2.SessionName = "Java";
            //training2.TotalHour = 85;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExpceptions
{
    class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new
                        ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {                   
                    CurrentSpeed = 0;
                    carIsDead = true;
                    CarlsDeadException ex =
                        new CarlsDeadException(string.Format("{0} is overheated!", PetName),
                        "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "https://CarsRus.com";
                    throw ex;
                }
                else
                    Console.WriteLine("-> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}

using System;

namespace Event_Demo
{
    class Car
    {
        #region Property
        private int _fuel;
        public int Fuel
        {
            get { return _fuel; }
            set
            {
                _fuel = value;
                OnFuelEmptyReached();
            }
        }
        #endregion

        #region Constructor
        public Car()
        {
            // _fuel = 100;
        }
        #endregion

        #region Event
        public event Action FuelEmptyReached;
        #endregion

        public void Go(int num)
        {
            Console.WriteLine($"{num}번째 직진");
            Fuel -= 5;
            Console.WriteLine("\n");
        }

        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"남은연료 : {_fuel}");

            if (20 >= _fuel)
            {
                if (null != FuelEmptyReached)
                {
                    FuelEmptyReached?.Invoke();
                }
            }
        }
    }
}





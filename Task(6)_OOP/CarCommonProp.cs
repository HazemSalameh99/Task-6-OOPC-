using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6__OOP
{
    class CarCommonProp
    {
        public string CarMake { get; set; }
        public int CarYear { get; set; }
        public string CarType { get; set; }
        public decimal CarPrice { get; set; }
        private bool IsEngine ;
        public CarCommonProp(string CarMake, int CarYear, string CarType, decimal CarPrice)
        {
            this.CarMake = CarMake;
            this.CarYear = CarYear;
            this.CarType = CarType;
            this.CarPrice=CarPrice;
        }
        public void stopEngine()
        {
            if (IsEngine != false)
            {
                Console.WriteLine("Engine stopped.");
            }
        }
        public void startEngine()
        {
            if (IsEngine == false)
            {
                IsEngine = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("alredy Engine started.");
            }
        }
        public virtual string FullInformation()
        {
            return $"carMake: {CarMake}, carYear: {CarYear}, CarType: {CarType}, CarPrice: {CarPrice}";
        }
    }
}

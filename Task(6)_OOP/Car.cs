using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6__OOP
{
    class Car:CarCommonProp
    {
        public string CarModel { get; set; }
        public string CarPalletNo { get; set; }
        public string CarColor { get; set; }
        public Car(string CarMake, int CarYear, string CarType, decimal CarPrice, string CarModel, string CarPalletNo, string CarColor):base(CarMake,CarYear,CarType,CarPrice)
        {
            this.CarModel = CarModel;
            this.CarPalletNo = CarPalletNo;
            this.CarColor = CarColor;
        }
        public override string FullInformation()
        {
            return $"{base.FullInformation()},CarModel: {CarModel},  CarPalletNo: {CarPalletNo}, CarColor: {CarColor}";
        }
    }
}

using Homework2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List Database
            List<Car> cars = new List<Car>();

            cars.Add(new Car
            {
                City = "Baku",
                Brand = "Lexus",
                Model = "GX460",
                Year = 2021,
                Color = ColorEnum.Black,
                EngineSize = 4500,
                Horsepower = 296,
                Mileage = 15777,
                TransmissionType = TransmissionTypeEnum.Automatic,
                Price = 200000
            });
            cars.Add(new Car
            {
                City = "Baku",
                Brand = "Mercedes-Benz",
                Model = "ML",
                Year = 2015,
                Color = ColorEnum.White,
                EngineSize = 2000,
                Horsepower = 184,
                Mileage = 0,
                TransmissionType = TransmissionTypeEnum.Manual,
                Price = 100000
            });
            cars.Add(new Car
            {
                City = "Sumqayit",
                Brand = "BMW",
                Model = "X5",
                Year = 2020,
                Color = ColorEnum.Gray,
                EngineSize = 3000,
                Horsepower = 280,
                Mileage = 25000,
                TransmissionType = TransmissionTypeEnum.Automatic,
                Price = 150000
            });
            cars.Add(new Car
            {
                City = "Baku",
                Brand = "BMW",
                Model = "X5",
                Year = 2019,
                Color = ColorEnum.Blue,
                EngineSize = 3000,
                Horsepower = 320,
                Mileage = 25000,
                TransmissionType = TransmissionTypeEnum.Automatic,
                Price = 150000
            });

            cars.Add(new Car
            {
                City = "Ganja",
                Brand = "Mercedes-Benz",
                Model = "GLE450",
                Year = 2020,
                Color = ColorEnum.Red,
                EngineSize = 3000,
                Horsepower = 367,
                Mileage = 20000,
                TransmissionType = TransmissionTypeEnum.Robot,
                Price = 180000
            });

            cars.Add(new Car
            {
                City = "Sumqayit",
                Brand = "Audi",
                Model = "Q7",
                Year = 2020,
                Color = ColorEnum.White,
                EngineSize = 4000,
                Horsepower = 435,
                Mileage = 15000,
                TransmissionType = TransmissionTypeEnum.Automatic,
                Price = 220000
            });

            cars.Add(new Car
            {
                City = "Baku",
                Brand = "Toyota",
                Model = "Land Cruiser",
                Year = 2018,
                Color = ColorEnum.Gray,
                EngineSize = 4600,
                Horsepower = 304,
                Mileage = 40000,
                TransmissionType = TransmissionTypeEnum.Automatic,
                Price = 120000
            });

            cars.Add(new Car
            {
                City = "Nakhchivan",
                Brand = "Volvo",
                Model = "XC90",
                Year = 2022,
                Color = ColorEnum.Black,
                EngineSize = 3000,
                Horsepower = 316,
                Mileage = 1000,
                TransmissionType = TransmissionTypeEnum.Robot,
                Price = 250000
            });

            #endregion

            var query1 = cars.Where(m => 
            m.Brand == "Mercedes-Benz" && 
            m.EngineSize <= 4200 &&
            m.City == "Baku")
            .ToList();

            var query2 = cars.Where(m => 
            m.City != "Baku" && 
            m.Year >= 2015 && 
            m.Year <= 2020)
            .ToList();

            var query3 = cars.Where(m => 
            m.Mileage == 0 && 
            m.Model == "ML")
            .ToList();

            var query4 = cars.Where(m =>
            m.TransmissionType == TransmissionTypeEnum.Automatic && 
            m.Price >= 150000 &&
            m.Price < 175000)
            .ToList();

            var query5 = cars.Where(m =>
            m.Color != ColorEnum.Red &&
            m.Color != ColorEnum.Black &&
            m.EngineSize >= 2000 &&
            m.EngineSize <= 5000 &&
            m.TransmissionType != TransmissionTypeEnum.Robot &&
            m.Year >= 2010)
            .ToList();

            var query6 = cars.Where(m =>
            (m.Brand == "Lexus" && m.Price < 300000) ||
            (m.Brand == "Mercedes-Benz" && m.Price < 450000)
            ).ToList();
        }
    }
}

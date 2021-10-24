using System;

namespace FakeDataGenerator.Contracts.Vehicle
{
    public class Car
    {
        public string VinCode { get; set; }

        public string RegistrationNumber { get; set; }

        public ColorEnum Color { get; set; }

        public DateTime Year { get; set; }

        public double Price { get; set; }

        public double EngineVolume { get; set; }

        public VehicleTypeEnum VehicleType { get; set; }

        public BrandEnum Brand { get; set; }

        public bool IsAllWheelDrive { get; set; }

        public Tire Tire { get; set; }

        public Transmission Transmission { get; set; }
    }
}

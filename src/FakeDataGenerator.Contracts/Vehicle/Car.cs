using System;

namespace FakeDataGenerator.Contracts.Vehicle
{
    public class Car
    {
        public Guid VinCode { get; set; }

        public string RegistrationNumber { get; set; }

        public ColorEnum Color { get; set; }

        public DateTime Year { get; set; }

        public double Price { get; set; }

        public double EngineVolume { get; set; }

        public VehicleTypeEnum VehicleType { get; set; }

        public BrandEnum Brand { get; set; }

        public bool IsAllWheelDrive { get; set; }

        public string TransmissionBrand { get; set; }

        public string TransmissionNumber { get; set; }

        public TireBrandEnum TireBrand { get; set; }

        public double TireWidth { get; set; }

        public double TireProfile { get; set; }

        public int TireDiameter { get; set; }
    }
}

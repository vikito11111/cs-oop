using NUnit.Framework;

namespace VehicleGarage.Tests
{
    public class VehicleTests
    {
        [TestCase("VW", "Golf", "CB7777XA")]
        [TestCase("Toyota", "Rav4", "PB0000XA")]
        public void ConstructorShouldInitilizeAllValues(string make, string model, string licensePlate)
        {
            //Arrange
            Vehicle vehicle = new Vehicle(make, model, licensePlate);

            //Assert
            Assert.AreEqual(vehicle.Brand, make);
            Assert.AreEqual(vehicle.Model, model);
            Assert.AreEqual(vehicle.LicensePlateNumber, licensePlate);
            Assert.AreEqual(vehicle.IsDamaged, false);
            Assert.AreEqual(vehicle.BatteryLevel, 100);
        }
    }
}

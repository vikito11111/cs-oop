using NUnit.Framework;

namespace VehicleGarage.Tests
{
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class GarageTestsChatGPT
    {
        [Test]
        public void Constructor_InitializesProperly()
        {
            var garage = new Garage(5);
            Assert.AreEqual(5, garage.Capacity);
            Assert.AreEqual(0, garage.Vehicles.Count);
        }

        [Test]
        public void AddVehicle_ReturnsFalse_WhenGarageFull()
        {
            var garage = new Garage(1);
            var vehicle1 = new Vehicle("Ford", "Fiesta", "123ABC");
            garage.AddVehicle(vehicle1);
            var vehicle2 = new Vehicle("Toyota", "Corolla", "456DEF");
            var result = garage.AddVehicle(vehicle2);
            Assert.IsFalse(result);
            Assert.AreEqual(1, garage.Vehicles.Count);
        }

        [Test]
        public void AddVehicle_ReturnsFalse_WhenLicensePlateExists()
        {
            var garage = new Garage(5);
            var vehicle = new Vehicle("Ford", "Fiesta", "123ABC");
            garage.AddVehicle(vehicle);
            var result = garage.AddVehicle(vehicle);
            Assert.IsFalse(result);
        }

        [Test]
        public void AddVehicle_ReturnsTrue_WhenVehicleAdded()
        {
            var garage = new Garage(5);
            var vehicle = new Vehicle("Ford", "Fiesta", "123ABC");
            var result = garage.AddVehicle(vehicle);
            Assert.IsTrue(result);
            Assert.AreEqual(vehicle, garage.Vehicles.Single());
        }

        [Test]
        public void ChargeVehicles_ChargesAppropriateVehicles()
        {
            var garage = new Garage(2);
            var vehicle1 = new Vehicle("Ford", "Fiesta", "123ABC");
            var vehicle2 = new Vehicle("Toyota", "Corolla", "456DEF");
            vehicle1.BatteryLevel = 50;
            vehicle2.BatteryLevel = 80;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            var vehiclesCharged = garage.ChargeVehicles(60);
            Assert.AreEqual(1, vehiclesCharged);
            Assert.AreEqual(100, vehicle1.BatteryLevel);
            Assert.AreEqual(80, vehicle2.BatteryLevel);
        }

        [Test]
        public void DriveVehicle_HandlesInvalidConditions()
        {
            var garage = new Garage(1);
            var vehicle = new Vehicle("Ford", "Fiesta", "123ABC");
            vehicle.BatteryLevel = 40;
            vehicle.IsDamaged = true;
            garage.AddVehicle(vehicle);
            garage.DriveVehicle("123ABC", 60, false);
            Assert.AreEqual(40, vehicle.BatteryLevel);
            Assert.IsTrue(vehicle.IsDamaged);
        }

        [Test]
        public void DriveVehicle_DrainsBattery()
        {
            var garage = new Garage(1);
            var vehicle = new Vehicle("Ford", "Fiesta", "123ABC");
            garage.AddVehicle(vehicle);
            garage.DriveVehicle("123ABC", 40, false);
            Assert.AreEqual(60, vehicle.BatteryLevel);
        }

        [Test]
        public void DriveVehicle_SetsIsDamaged_WhenAccidentOccurs()
        {
            var garage = new Garage(1);
            var vehicle = new Vehicle("Ford", "Fiesta", "123ABC");
            garage.AddVehicle(vehicle);
            garage.DriveVehicle("123ABC", 40, true);
            Assert.IsTrue(vehicle.IsDamaged);
        }

        [Test]
        public void RepairVehicles_RepairAllDamagedVehicles()
        {
            var garage = new Garage(2);
            var vehicle1 = new Vehicle("Ford", "Fiesta", "123ABC");
            var vehicle2 = new Vehicle("Toyota", "Corolla", "456DEF");
            vehicle1.IsDamaged = true;
            vehicle2.IsDamaged = true;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            var result = garage.RepairVehicles();
            Assert.AreEqual("Vehicles repaired: 2", result);
            Assert.IsFalse(vehicle1.IsDamaged);
            Assert.IsFalse(vehicle2.IsDamaged);
        }
    }
}
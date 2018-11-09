﻿namespace StorageMaster.Models.Storage
{
    using StorageMaster.Models.Products;
    using StorageMaster.Models.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Storage
    {
        // Fields.
        private readonly Vehicle[] garage;
        private readonly List<Product> products;

        // Properties.
        public string Name { get; }
        public int Capacity { get; }
        public int GarageSlots { get; }
        public bool IsFull => this.Products.Sum(c => c.Weight) >= this.Capacity;
        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        // Constructor.
        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.garage = new Vehicle[garageSlots];
            this.products = new List<Product>();

            this.InitializeGarage(vehicles);
        }        

        // Methods.
        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            var vehicle = this.garage[garageSlot];
            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            var deliveryGarageHasFreeSlot = deliveryLocation.Garage.Any(v => v == null);
            if (!deliveryGarageHasFreeSlot)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[garageSlot] = null;

            var addedSlot = deliveryLocation.AddVehicle(vehicle);
            return addedSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            var vehicle = GetVehicle(garageSlot);

            var unloadedProductCount = 0;
            while (!vehicle.IsEmpty && !this.IsFull)
            {
                var crate = vehicle.Unload();
                this.products.Add(crate);

                unloadedProductCount++;
            }

            return unloadedProductCount;
        }

        private void InitializeGarage(IEnumerable<Vehicle> vehicles)
        {
            var garageSlot = 0;
            foreach (var vehicle in vehicles)
            {
                this.garage[garageSlot++] = vehicle;
            }
        }

        private int AddVehicle(Vehicle vehicle)
        {
            var freeGarageSlotIndex = Array.IndexOf(this.garage, null);
            this.garage[freeGarageSlotIndex] = vehicle;

            return freeGarageSlotIndex;
        }
    }
}
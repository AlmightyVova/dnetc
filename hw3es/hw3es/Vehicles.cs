using System;

namespace hw3es
{
    public class Vehicle
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        public double PriceUsd { get; set; }
        public float SpeedKms { get; set; }
        public int Year { get; set; }

        public Vehicle(double coordinateX, double coordinateY, double priceUsd, float speedKms, int year)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            PriceUsd = priceUsd;
            SpeedKms = speedKms;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"CoordinateX: {CoordinateX}\n" +
                              $"CoordinateY: {CoordinateY}\n" +
                              $"PriceUsd: {PriceUsd}\n" +
                              $"SpeedKms: {SpeedKms}\n" +
                              $"Year: {Year}");
        }
    }

    public class Plane : Vehicle
    {
        public int HeightMeters { get; }
        public int PassengerAmount { get; }

        public Plane(int heightMeters, int passengerAmount, double coordinateX, double coordinateY, double priceUsd,
            float speedKms, int year) : base(
            coordinateX, coordinateY, priceUsd, speedKms, year)
        {
            HeightMeters = heightMeters;
            PassengerAmount = passengerAmount;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"HeightMeters: {HeightMeters}\n" +
                              $"PassengerAmount: {PassengerAmount}");
        }
    }

    public class Car : Vehicle
    {
        public string NumberPlate { get; }

        public Car(string numberPlate, double coordinateX, double coordinateY, double priceUsd, float speedKms, int year
        ) : base(
            coordinateX, coordinateY, priceUsd, speedKms, year)
        {
            NumberPlate = numberPlate;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"NumberPlate: {NumberPlate}");
        }
    }

    public class Ship : Vehicle
    {
        public int PassengerAmount { get; }
        public string ShipPort { get; }

        public Ship(int passengerAmount, string shipPort, double coordinateX, double coordinateY, double priceUsd,
            float speedKms, int year) : base(
            coordinateX, coordinateY, priceUsd, speedKms, year)
        {
            PassengerAmount = passengerAmount;
            ShipPort = shipPort;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"PassengerAmount: {PassengerAmount}\n" +
                              $"ShipPort: {ShipPort}");
        }
    }
}
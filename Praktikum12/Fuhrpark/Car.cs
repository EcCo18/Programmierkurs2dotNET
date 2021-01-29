using System;

namespace Praktikum12
{
    public class Car
    {
        private String producer;
        public double BuildingYear { get; set; }

        public Car(string producer, double buildingYear)
        {
            this.producer = producer;
            BuildingYear = buildingYear;
        }

        public String Producer
        {
            set => producer = value;
            get => producer;
        }

        public override string ToString()
        {
            return producer + " " + BuildingYear;
        }
    }
}
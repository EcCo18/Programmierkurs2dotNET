using System;
using Microsoft.VisualBasic.FileIO;

namespace Praktikum12
{
    public class Fuhrpark
    {
        private readonly LinkedList<Car> linkedList;

        public Fuhrpark()
        {
            linkedList = new LinkedList<Car>();
        }

        public void Aufnehmen(Car newCar)
        {
            linkedList.Add(newCar);
        }

        public void Inventur()
        {
            Iterator<Car> iterator = linkedList.GetIterator();

            while (iterator.hasNext())
            {
                Console.WriteLine(iterator.next());
            }
        }

        public double BerechneFlottenalter()
        {
            double summed = 0;
            int counter = 0;
            Iterator<Car> iterator = linkedList.GetIterator();

            while (iterator.hasNext())
            {
                summed += iterator.next().BuildingYear;
                counter++;
            }

            if (counter == 0)
            {
                return 0;
            }
            else
            {
                return (summed / counter);
            }
        }
    }
}
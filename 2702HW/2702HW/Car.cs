using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2702HW
{
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        private int codan = 000;

        protected int numberOfSeats = 4;

        #region Ctor

        public Car()
        {

        }

        public Car(string fileName)
        {
            Car carFromFile = Car.DeserializeACar(fileName);

            this.Model = carFromFile.Model;
            this.Brand = carFromFile.Brand;
            this.Year = carFromFile.Year;
            this.Color = carFromFile.Color;
        }
        public Car(string model, string brand, int year, string color, int codan, int numberOfSeats)
        {
            this.Model = model;
            this.Brand = brand;
            this.Year = year;
            this.Color = color;

            this.codan = codan;
            this.numberOfSeats = numberOfSeats;
        }

        #endregion

        public int GetCodan()
        {
            return this.codan;
        }

        public int GetNumberOfSeats()
        {
            return this.numberOfSeats;
        }

        public void ChangeNumberOfSeats(int newNumberOfSeats)
        {
            if (newNumberOfSeats > 0)
            {
                this.numberOfSeats = newNumberOfSeats;
            }
        }

        public static Car DeserializeACar(string fileName)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car));

            Car result = null;

            using (Stream file = new FileStream(fileName, FileMode.Open)) // creating new file stream
            {
                result = myXmlSerializer.Deserialize(file) as Car;

            } //closing file stream

            Console.WriteLine("Deserialized succeed!");

            return result;
        }

        public static void SerializeACar(string fileName, Car car)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car));

            using (Stream file = new FileStream(fileName, FileMode.Create)) // creating new file stream
            {
                myXmlSerializer.Serialize(file, car);

            } //closing file stream

            Console.WriteLine("Serialized succeed!");
        }

        public static void SerializeACarArray(string fileName, Car[] cars)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car[]));

            using (Stream file = new FileStream(fileName, FileMode.Create)) // creating new file stream
            {
                myXmlSerializer.Serialize(file, cars);

            } //closing file stream

            Console.WriteLine("Serialized succeed!");
        }

        public static Car[] DeserializeACarArray(string fileName)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car[]));

            Car[] result = null;

            using (Stream file = new FileStream(fileName, FileMode.Open)) // creating new file stream
            {
                result = myXmlSerializer.Deserialize(file) as Car[];

            } //closing file stream

            Console.WriteLine("Deserialized succeed!");

            return result;
        }

        public bool CarCompare(string fileName)
        {
            Car carFromFile = Car.DeserializeACar(fileName);
            if (this.Model == carFromFile.Model &&
                this.Brand == carFromFile.Brand &&
                this.Year == carFromFile.Year &&
                this.Color == carFromFile.Color)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Car Modle : {this.Model} Bard : {this.Brand} Year : {this.Year} Color : {this.Color}";
        }
    }
}

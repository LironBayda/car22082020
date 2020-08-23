using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car19082020
{
    public class Car
    {
        public int Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        private int _codan;
        protected int _numberOfSteas;
        public Car()
        {

        }

        public Car(int model, string brand, int year, string color, int codan, int numberOfSteas)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            _codan = codan;
            _numberOfSteas = numberOfSteas;
        }

        public int GetCoden()
        {
            return _codan;
        }

        public int GetNumberOfSeats()
        {
            return _numberOfSteas;
        }

        protected void changeNumberOfSeats(int numberOfSeats)
        {
            _numberOfSteas = numberOfSeats;
        }

        public override string ToString()
        {
            return base.ToString() +$"{ Year} { Brand} { Model} { Color} {_codan} {_numberOfSteas}";
        }


        public Car(string fileName)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car));

            /*   Car c1 = new Car(5564,"kkk",2,"red",6,5);

                 using (Stream file = new FileStream(@"../../xmlfile.xml", FileMode.Create)) // creating new file stream
                 {
                     myXmlSerializer.Serialize(file, c1);

                 } //closing file stream
                */
            Car c;

            //XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"../../xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                c = myXmlSerializer.Deserialize(file) as Car;

            } //closing file stream
        }
    }
}

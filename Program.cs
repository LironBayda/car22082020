using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Car19082020
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car));

            /*   Car c1 = new Car(5564,"kkk",2,"red",6,5);

                 using (Stream file = new FileStream(@"../../xmlfile.xml", FileMode.Create)) // creating new file stream
                 {
                     myXmlSerializer.Serialize(file, c1);

                 } //closing file stream
                */ 
            Car c2;

            //XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"../../xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                c2 = myXmlSerializer.Deserialize(file) as Car;

            } //closing file stream

            //Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.ReadLine();

            // --------------------- Array
            Car[] cArray =
            {
                new Car(5564,"kkk",2,"red",6,58),
            new Car(5564, "vvv", 27, "red", 67, 5),
            new Car(5564, "ddd", 62, "red", 6, 55),
            new Car(5564, "sss", 28, "red", 66, 5),
            };

            XmlSerializer myXmlSerializerArray = new XmlSerializer(typeof(Car[]));
            using (Stream file = new FileStream(@"../../xmlarrayfile.xml", FileMode.Create)) // creating new file stream
            {
                myXmlSerializerArray.Serialize(file, cArray);
            } //closing file stream

            Car[] p2Array;
            using (Stream file = new FileStream(@"../../xmlarrayfile.xml", FileMode.Open)) // creating new file stream
            {
                p2Array = myXmlSerializerArray.Deserialize(file) as Car[];
            } //closing file stream



        }



    }
}

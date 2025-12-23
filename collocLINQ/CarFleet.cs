using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace collocLINQ
{
    public class CarFleet
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarFleet(string name)
        {
            Name = name;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void SaveToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(Name);
                foreach (var c in Cars)
                    sw.WriteLine(c.ToString());
            }
        }

        public static CarFleet LoadFromFile(string path)
        {
            if (!File.Exists(path)) return null;

            var lines = File.ReadAllLines(path);
            var fleet = new CarFleet(lines[0]);

            for (int i = 1; i < lines.Length; i++)
                fleet.Cars.Add(Car.FromString(lines[i]));

            return fleet;
        }
    }
}


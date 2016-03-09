using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NestedTypes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int NumberOfWheels { get; set; }
        public Radio Radio { get; set; }
        public Wheel FrontLeft { get; set; }
        public Wheel FrontRight { get; set; }
        public Wheel RearLeft { get; set; }
        public Wheel ReadRight { get; set; }
    }

    public class Radio
    {
        public bool HasFM { get; set; }
        public RadioStation DefaultStation { get; set; }
        public RadioStation CurrentStation { get; set; }
    }

    public class RadioStation
    {
        public double Frequency { get; set; }
    }

    public class Wheel
    {
        public int ThreadType { get; set; }
        public DateTime ManufatureDate { get; set; }
        public string Material { get; set; }
    }
}

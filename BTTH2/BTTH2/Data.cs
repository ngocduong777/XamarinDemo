using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH2
{
    public class City
    {
        public int citycode { get; set; }
        public string cityimage { get; set; }
        public string cityname { get; set; }

    }
    public class Hotel
    {
        public int hotelcode { get; set; }
        public string hotelimage { get; set; }
        public int citycode { get; set; }
        public int hotelprice { get; set; }
        public string hotellocation { get; set; }
        public string hoteldes { get; set; }
        public string hotelname { get; set; }
    }

    public class Animal
    {
        public String animalimage { get; set; }
        public String animalname { get; set; }
        public int animalcode { get; set; }
        public String animaldes { get; set; }
    }

    public class IndividualAnimal
    {
        public int animalcode { get; set; }
        public String individualname { get; set; }
        public int individualcode { get; set; }
        public String individualimage { get; set; }
        public String individualdes { get; set; }

    }
}

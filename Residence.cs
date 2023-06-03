using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damy__Alan_Major_Assignment_2
{
 /*
 * Alan Damy
 * May 25, 2023
 * Major Assignment 2
 */
    class Residence // the class that holds all residence info for each employee
    {
        private string streetName;
        private string cityName;
        private string zipCode;
        private string province;
        private string country;
        public string StreetName { get => streetName; set => streetName = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string Province { get => province; set => province = value; }
        public string Country { get => country; set => country = value; }

        public Residence(string streetName, string cityName, string zipCode, string province, string country)
        {
            this.StreetName = streetName;
            this.CityName = cityName;
            this.ZipCode = zipCode;
            this.Province = province;
            this.Country = country;
        }

        public override string ToString()
        {
            return $"Street: {StreetName}\n" +
                       $"City: {CityName}\n" +
                       $"Zip Code: {ZipCode}\n" +
                       $"Province: {Province}\n" +
                       $"Country: {Country}" +
                       $"";
        }
    }
}

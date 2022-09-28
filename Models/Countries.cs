using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace countrie.Models
{
    public class Countries
    {
        public List<Countrie> countries { get; set; }
    }
    public class Countrie
    {
        public int population { get; set; }
        public string region { get; set; }
        public List<string> capital { get; set; }
        public name name { get; set; }
        public string subregion { get; set; }
        public List<string> tld { get; set; }
        //  public List<string[]> currencies { get; set; }
        public List<string> borders { get; set; }
        public flags flags { get; set; }
        public Dictionary<string, string> languages { get; set; }
    }

    public class name
    {
        public string common { get; set; }

        public string official { get; set; }

    }

    public class flags
    {
        public string png { get; set; }
        public string svg { get; set; }
    }
    public class Filtro {
    public string filtro { get; set; }
    }

    //public class Countries
    //{
    //    public List<CountryData> countries { get; set; } //not used
    //}

    //public class CountryData
    //{
    //    public string flag { get; set; }
    //    public string name { get; set; }
    //    public string capital { get; set; }
    //    public List<currencies> Currencies { get; set; } //list of official currencies
    //    public int population { get; set; }
    //    public string alpha3Code { get; set; }
    //    public List<languages> Languages { get; set; } //list of official languages
    //}

    //public class currencies
    //{
    //    public string name { get; set; }
    //}

    //public class languages
    //{
    //    public string name { get; set; }
    //}

}

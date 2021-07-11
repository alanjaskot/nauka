using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Resources
{
    public static class VacationDescriptionList
    {
        public static List<string> employeeDescriptions = new List<string>
        {
            "wypoczynkowy", "na żądanie", "za święto", "za sobotę", "za nadgodziny", "urlop okolicznościowy", "opieka nad dzieckiem"
        };
        public static List<string> adminDescriptions = new List<string>
        {
            "zdrowotny", "macierzyński", "wychowawczy"
        };
    }
}

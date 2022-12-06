using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    internal class Volume : AnyValue
    {
        public Volume()
        {
            ValueName = "Объем";
            CoefficientsAndMeasuresList = new Dictionary<string, double>()
            {
                { "Милилитр", 0.000001},
                { "Литр", 0.001},
                { "Кубический сантиметр", 0.000001},
                { "Кубический дециметр", 0.001},
                { "Кубический метр", 1}
            };
        }
    }
}
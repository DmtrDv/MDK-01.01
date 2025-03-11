using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithTrees
{
    public class Plants
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Area { get; set; }
        public string TypeOfPlant { get; set; }

        public static Dictionary<string, string> Aliases = new Dictionary<string, string>()
        {
            { nameof(Name), "Название"},
            { nameof(Height), "Высота"},
            {nameof(Area), "Зона" },
            {nameof(TypeOfPlant), "Тип растения" }
        };
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithTrees;

namespace ClassLib.Model
{
    public class PlantsModel
    {
        public List<Plants> plants { get; }

        public PlantsModel()
        {
            plants = new List<Plants>();

            plants.Add(new Plants
            {
                Name = "шиповник",
                Height = "100см",
                Area = "широкая",
                TypeOfPlant = "куст"
            });
        }
        public Plants getName(string Name)
        {
            return plants.Find(e => e.Name == Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    internal class Описание_товара
    {
        private string Название;
        private double Цена;

        public Описание_товара(string Наименование, double Прайс)
        {
            Название = Наименование;
            Цена = Прайс;            
        }

        public string СкажиНазвание()
        {
            return Название;
        }
        public double СкажиЦену()
        {
            return Цена;
        }
        
    }
}

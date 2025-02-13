using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    public struct записи_о_продажах
    {
        public int количество;
        public int день;
        public string тип_товара;
    }
    
    public void ДобавитьПродажу(string type, int quantiti, int day)
    {
        записи_о_продажах продажа = new записи_о_продажах { тип_товара = type, день = day, количество = quantiti };
    }
}

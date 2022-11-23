using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_19
{
    class PC
    {
        //Модель  компьютера  характеризуется
        // код
        // название  марки компьютера
        // тип  процессора
        // частотf  работы  процессора
        // объем оперативной памяти
        // объем жесткого диска
        // объемом памяти видеокарты
        // стоимость компьютера в условных единицах
        // количеством экземпляров, имеющихся в наличии.
        //
        // Создать список, содержащий 6-10 записей с различным набором значений характеристик.
        public int Num { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public int CPU_frequency { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int GPU { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

    }
}

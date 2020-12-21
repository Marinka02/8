using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_5
{


    public class GeometricProgression:ISeries,ICloneable,IComparable
    {
        int next; // следующее значение

        // зледующее значение
        public int Next
        {
            get
            {
                return GetNext();
            }
        }
        // шаг
        public int Step { get; set; }
        // старт
        public int Start { get; set; }

        // конструктор с параметрами
        public GeometricProgression(int start, int step)
        {
            Start = start;
            Step = step;
            next = start;
        }
        // конструктор без параметров
        public GeometricProgression()
        {
            Start = 2;
            Step = 2;
            next = 2;
        }

        // метод получения следующего значения
        public int GetNext()
        {
            return next *= Step;
        }
        // метод изменения стартового значения
        public void SetStart(int start)
        {
            Start = start;
        }
        // метод начала отсчета заново
        public void Reset()
        {
            next = Start;
        }

        // метод клонирования 
        public object Clone()
        {
            // в примере было через свойства, но наверное и так можно
            GeometricProgression geometricProgression = new GeometricProgression(Start, Step);
            return geometricProgression;
        }
        // метод сравнения
        public int CompareTo(object obj)
        {
            // создаем новый объект
            GeometricProgression geometricProgression = (GeometricProgression)obj; // явное проебразование
            // сравниваем по шагу
            if (Step > geometricProgression.Step) return 1;
            if (Step < geometricProgression.Step) return -1;
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAvaliacao
{
    internal class Globals
    {

        //public static DateTime data;
        //public static string dataNova;


        public static DateTime Data { get; set; }
        public static string DataNova { get; set; }

        public static int rst;

        public static int Rst { get; set; }

        public static  int  resultado (int n1, int n2)
        {
            rst= n1 + n2;
            return rst;
        }


    }
}

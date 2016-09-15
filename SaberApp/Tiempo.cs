using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberApp
{
    class Tiempo
    {
        private static int segundos = 0;
        private static int minutos = 0;

        public static void run() {
            if (segundos >= 59)
            {
                minutos++;
                segundos = 0;
            }
            else
            {
                segundos++;
            }
        }
        public static string getTiempo() {
            string tiempo = "";
            if (segundos >= 10)
            {
                tiempo = minutos + ":" + segundos;
            }
            else {
                tiempo = minutos + ":0" + segundos;
            }
            return tiempo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberApp
{
    class Questions
    {
        public static int correctas = 0;
        public static int incorrectas = 0;
        public static bool[] answer = {
            true,true,true,true,true,
            true,true,true,true,true,
        };

        public static void setAnswer(int i,bool rpt) {
            answer[i] = rpt;
        }
    }
}

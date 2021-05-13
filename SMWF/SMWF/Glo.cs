using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SMWF
{
    
    class Glo
    {
        static public int CountMines = 0;
        static public Str_Geminus<int> GSizes = Func.Set(0, 0);
        static public int LiberumElementis = 0;
        static public int CuDiffe = 0;

        static public void SetDiffi()
        {
            switch (CuDiffe)
            {
                case 0:
                    GSizes.Primis = 10;
                    GSizes.Secundus = 10;
                    CountMines = 10;
                    break;
                case 1:
                    GSizes.Primis = 16;
                    GSizes.Secundus = 16;
                    CountMines = 40;
                    break;
                case 2:
                    GSizes.Primis = 30;
                    GSizes.Secundus = 16;
                    CountMines = 100;
                    break;
                case 3:
                    break;
                default:
                    GSizes.Primis = 10;
                    GSizes.Secundus = 10;
                    CountMines = 10;
                    break;
            }
            LiberumElementis = GSizes.Primis * GSizes.Secundus - CountMines;
        }
    }
}

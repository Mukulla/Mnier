﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMWF
{
    public struct Str_Geminus<T>
    {
        public T Primis, Secundus;
    }
    class Func
    {
        //Привести к границам некое значение        
        static public int IntraAream(ref int Value001, int Min, int Max)
        {
            if (Value001 >= Min)
            {
                if (Value001 <= Max)
                {
                    return 0;
                }
                return 1;
            }
            return -1;
        }
        static public void CheckLimitataAream(ref int Value001, int Min001, int Max001)
        {
            switch (IntraAream(ref Value001, Min001, Max001))
            {
                case -1:
                    Value001 = Min001;
                    break;
                case 0:
                    break;
                case 1:
                    Value001 = Max001;
                    break;
            }
        }
        static public void CheckClausaAream(ref int Value001, int Min001, int Max001)
        {
            switch (IntraAream(ref Value001, Min001, Max001))
            {
                case -1:
                    Value001 = Max001;
                    break;
                case 0:
                    break;
                case 1:
                    Value001 = Min001;
                    break;
            }
            int a = 0;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool IsInBorders(ref int Value001, int Max)
        {
            if (Value001 >= 0)
            {
                if (Value001 < Max)
                {
                    return true;
                }
            }
            return false;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static public Str_Geminus<T> Set<T>(T I001, T J001)
        {
            Str_Geminus<T> Tempo;
            Tempo.Primis = I001;
            Tempo.Secundus = J001;
            return Tempo;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static public void ResizeArray<T>(ref T[,] original, int i001, int j001)
        {
            var newArray = new T[i001, j001];
            /*
            int columnCount = original.GetLength(1);
            int columnCount2 = j001;
            int columns = original.GetUpperBound(0);
            for (int co = 0; co <= columns; co++)
            {
                Array.Copy(original, co * columnCount, newArray, co * columnCount2, columnCount);
            }*/
            original = newArray;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Получение числа из строки с проверками на неверные значения, по умолчанию выдаёт ноль
        static public int GetNumberFromString()
        {
            string TempoString;
            int SomeValue;
            //Получаем символы в строке
            TempoString = Console.ReadLine();
            //Проверяем на соответствие типу int
            if (!int.TryParse(TempoString, out SomeValue))
            {
                SomeValue = 0;
            }
            return SomeValue;
        }
        static public int GetNumberFromString(string SomeString)
        {
            int SomeValue;
            //Проверяем на соответствие типу int
            if (!int.TryParse(SomeString, out SomeValue))
            {
                SomeValue = 0;
            }
            return SomeValue;
        }
    }
}

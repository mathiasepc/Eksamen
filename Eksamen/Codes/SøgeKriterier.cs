using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen.Codes
{
    internal class SøgeKriterier
    {
        public record ElevInfo(object result1, object resultat2);

        public static ElevInfo GetElevInfo(string elevID, object[,] ArrayInfo)
        {
            //box
            List<object> type1 = new List<object>();
            List<object> type2 = new List<object>();

            //rækker
            int personRaws = ArrayInfo.GetLength(0);
            //kolonner
            int personColum = ArrayInfo.GetLength(1);
            for (int raws = 0; raws < personRaws; raws++)
            {
                for (int colum = 0; colum < personColum; colum++)
                {
                    // colum bestemmer hvilken colum vi søger i
                    if (colum == 2)
                    {
                        //unbox ElevModel
                        List<ElevModel> displayList = (List<ElevModel>)ArrayInfo[raws, colum];
                        foreach (ElevModel display in displayList)
                        {
                            if (display.ElevID == elevID)
                            {
                                type1.Add(ArrayInfo[raws, 0]);
                                type2.Add(ArrayInfo[raws, 1]);
                            }
                        }
                    }
                }
            }
            return new ElevInfo(type1, type2);
        }
        public static ElevInfo GetLærerInfo(string lærer, object[,] ArrayInfo)
        {
            //box
            List<object> type1 = new List<object>();
            List<object> type2 = new List<object>();

            //rækker
            int personRaws = ArrayInfo.GetLength(0);
            //kolonner
            int personColum = ArrayInfo.GetLength(1);
            for (int raws = 0; raws < personRaws; raws++)
            {
                for (int colum = 0; colum < personColum; colum++)
                {
                    // colum bestemmer hvilken colum vi søger i
                    if (colum == 1)
                    {
                        //unbox til string
                        string? displayLærer = ArrayInfo[raws, colum].ToString();
                        if (displayLærer == lærer)
                        {
                            type1.Add(ArrayInfo[raws, 0]);
                            type2.Add(ArrayInfo[raws, 2]);
                        }
                    }
                }
            }
            return new ElevInfo(type1, type2);
        }
        public static ElevInfo GetFagInfo(string fag, object[,] ArrayInfo)
        {
            //box
            List<object> type1 = new List<object>();
            List<object> type2 = new List<object>();

            //rækker
            int personRaws = ArrayInfo.GetLength(0);
            //kolonner
            int personColum = ArrayInfo.GetLength(1);
            for (int raws = 0; raws < personRaws; raws++)
            {
                for (int colum = 0; colum < personColum; colum++)
                {
                    // colum bestemmer hvilken colum vi søger i
                    if (colum == 0)
                    {
                        //unbox til string
                        string? displayFag = ArrayInfo[raws, colum].ToString();
                        if (displayFag == fag)
                        {
                            type1.Add(ArrayInfo[raws, 1]);
                            type2.Add(ArrayInfo[raws, 2]);
                        }
                    }
                }
            }
            return new ElevInfo(type1, type2);
        }
    }
}

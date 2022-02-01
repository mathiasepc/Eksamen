using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen.Codes
{
    enum PersonInfo
    {
        Elev,
        Lærer,
        Fag,
        Fejl
    }
    internal class H1 : InterfaceH1
    {

        public static int[] UgeNr = new int[] { 3, 4, 5, 6 };

        public static object[,] ArrayInfo { get; set; }



        static H1()
        {
            //elever
            List<ElevModel> elevGrundlæggende = new List<ElevModel>()
            {
                new ElevModel()
                {
                    ElevID = "111",
                    ForNavn = "Mathias",
                    EfterNavn = "Clausen",
                    TelefonNr = 12345678
                }
            };
            List<ElevModel> elevDatabase = new List<ElevModel>()
            {
                new ElevModel()
                {
                    ElevID = "222",
                    ForNavn = "Martin",
                    EfterNavn = "Nielsen",
                    TelefonNr = 12345678
                }
            };
            List<ElevModel> elevStudie = new List<ElevModel>()
            {
                new ElevModel()
                {
                    ElevID = "333",
                    ForNavn = "Niklas",
                    EfterNavn = "Henriksen",
                    TelefonNr = 12345678
                }
            };

            //array
            ArrayInfo = new object[,]
            {
                {"Grundlæggende programmering",  "Niels", elevGrundlæggende, UgeNr},
                {"Database programmering", "Henrik", elevDatabase, UgeNr },
                {"Studieteknik", "John", elevStudie, UgeNr}
            };
        }
        public static SøgeKriterier.ElevInfo GetElevInfo(string elevID)
        {
            return SøgeKriterier.GetElevInfo(elevID, ArrayInfo);
        }
        public static SøgeKriterier.ElevInfo GetLærerInfo(string lærer)
        {
            return SøgeKriterier.GetLærerInfo(lærer, ArrayInfo);
        }
        public static SøgeKriterier.ElevInfo GetFagInfo(string fag)
        {
            return SøgeKriterier.GetFagInfo(fag, ArrayInfo);
        }
    }

}

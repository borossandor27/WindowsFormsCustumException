using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCustumException
{
    internal class Athaladas
    {
        /*
         * Az ajto.txt fájlban időrendben rögzítették, hogy ki és mikor lépett be vagy ki a társalgó
         * egyetlen ajtaján. A fájl soraiban négy, szóközzel elválasztott érték található. Az első két szám
         * az áthaladás időpontja (óra, perc), a harmadik a személy azonosítója, az utolsó az áthaladás
         * iránya (be/ki). A sorok száma legfeljebb 1000, a személyek azonosítója egy 1 és 100 közötti 
         * egész szám. Biztosan tudjuk, hogy a megfigyelés kezdetén (9 órakor) a társalgó üres volt, de
         * a megfigyelés végén (15 órakor) még lehettek benn a társalgóban.
         */
        int ora;

        public int Ora
        {
            get => this.ora;
            set
            {
                if (value >= 9 && value <= 15)
                {
                    ora = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A belépési idő nem megfelelő");
                };
            }
        }
        int perc;

        public int Perc
        {
            get => this.perc;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    perc = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A belépési idő nem megfelelő");
                };
            }
        }
        int szemelyAzonosito;

        public int SzemelyAzonosito
        {
            get => this.szemelyAzonosito;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    perc = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A személy azonostója a tartományon kívül esik");
                };
            }
        }
        string irany;
        public string Irany
        {
            get => this.irany;
            set
            {
                if (value == "be" || value == "ki")
                {
                    this.irany = value;
                }
                else
                {
                    throw new ArgumentException("Nem megfelelő irányt adott meg!");
                };
            }
        }

        public Athaladas(int ora, int perc, int szemelyAzonosito, string irany)
        {
            Ora = ora;
            Perc = perc;
            SzemelyAzonosito = szemelyAzonosito;
            Irany = irany ?? throw new ArgumentNullException(nameof(irany));
        }
    }
}

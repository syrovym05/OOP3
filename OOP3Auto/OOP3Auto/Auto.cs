using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Auto
{
    internal class Auto
    {
        private string znacka;
        private float spotreba;       //8l/100km
        private float ujetoCelkem;
        private DateTime okamzikRozjezdu;
        private float dobaJizdyCelkem;
        private bool jede;

        public bool Jede { get => jede; }

        public Auto(string znacka, float spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;   //na 100km
            this.ujetoCelkem = 0;
            this.dobaJizdyCelkem = 0;
            jede = false;
        }

        public float VratUjeteKm()
        {
            return ujetoCelkem;
        }

        public void Rozjezd()
        {
            if (!jede)
            {
                jede = true;
                okamzikRozjezdu = DateTime.Now;
            }
        }
        
        public void Zastav(int vzdalenost)
        {
            if (jede)
            {
                jede = false;                
                dobaJizdyCelkem += (DateTime.Now - okamzikRozjezdu).Seconds;            
                ujetoCelkem += vzdalenost;
            }
        }
        
        public float CelkovaSpotreba()
        {
            return ujetoCelkem * spotreba / 100;
        }

        public override string ToString()
        {
            return String.Format("Auto {0} se spotřebou {1} l/100km: \n\nPrávě {2}\nMá ujeto: {3}km\nDoba jízd: {4}\nCelková spotřeba paliva: {5} l",
            znacka, spotreba, jede ? "JEDE" : "NEJEDE",ujetoCelkem ,dobaJizdyCelkem < 60 ? dobaJizdyCelkem + " s" : Math.Round(dobaJizdyCelkem / 60,1) + " min", CelkovaSpotreba());
        }



    }
}

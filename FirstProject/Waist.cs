using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Waist
    {
        public Cart[] tab;
        public Waist(Cart[] tab)
        {
            this.tab = tab;
        }
        public Cart[] Shuffling(Cart[] tab)
        {
            Random losowanie = new Random();
            int r = 0;
            Cart[] shuffledWaist = new Cart[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                r = losowanie.Next(0, tab.Length);
                if (shuffledWaist[r] == null)
                {
                    shuffledWaist[r] = tab[i];
                }                    
                else if (shuffledWaist[r] != null)
                {
                    do
                    {
                        r = losowanie.Next(0, tab.Length);
                    } while (shuffledWaist[r] != null);
                    shuffledWaist[r] = tab[i];
                }                               
            }
            return shuffledWaist;
        }
    }
}

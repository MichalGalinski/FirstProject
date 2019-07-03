using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Cart
    {
        public float Value { get; set; }
        public string Figure { get; set; }
        public Cart(string karta, float wartosc)
        {
            this.Figure = karta;
            this.Value = wartosc;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}",this.Figure,this.Value);
        }
    }
}

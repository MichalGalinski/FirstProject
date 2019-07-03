using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Game
    {
        public Cart[] table;
        public Waist w1;
        public int counter { get; set; } = 0;
        public Game() { }        
        public string play()
        {
            Cart[] tab ={new Cart("2 trefl",2),new Cart("3 trefl",3),new Cart("4 trefl",4),new Cart("5 trefl",5),new Cart("6 trefl",6)
                    ,new Cart("7 trefl",7),new Cart("8 trefl",8),new Cart("9 trefl",9),new Cart("10 trefl",10),new Cart("Walet trefl",2)
                    ,new Cart("Dama trefl",3),new Cart("Król trefl",4),new Cart("As trefl",11)
                    ,new Cart("2 pik",2),new Cart("3 pik",3),new Cart("4 pik",4),new Cart("5 pik",5),new Cart("6 pik",6),new Cart("7 pik",7)
                   ,new Cart("8 pik",8),new Cart("9 pik",9),new Cart("10 pik",10),new Cart("Walet pik",2),new Cart("Dama pik",4),new Cart("Król pik",4),new Cart("As pik",11)
                   ,new Cart("2 karo",2),new Cart("3 karo",3),new Cart("4 karo",4),new Cart("5 karo",5),new Cart("6 karo",6),new Cart("7 karo",7)
                    ,new Cart("8 karo",8),new Cart("9 karo",9),new Cart("10 karo",10),new Cart("Walet karo",2),new Cart("Dama karo",3),new Cart("Król karo",4),new Cart("As karo",11),
                   new Cart("2 kier",2),new Cart("3 kier",3),new Cart("4 kier",4),new Cart("5 kier",5),new Cart("6 kier",6),new Cart("7 kier",7),
                    new Cart("8 kier",8),new Cart("9 kier",9),new Cart("10 kier",10),new Cart("Walet kier",2),new Cart("Dama kier",3),new Cart("Król kier",4),new Cart("As kier",11)};
            Waist t1 = new Waist(tab);
            Cart[] Shuffled = t1.Shuffling(tab);
            string statement;            
            statement = Shuffled[counter].ToString();            
            counter++;
            return statement;
        }        
    }
}

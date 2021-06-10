using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Escenario : Object
    {
        Dictionary<String, Object> L;

        public Escenario()
        {   L = new Dictionary<string, Object>();         }
        public override void draw()
        {
        }
        //-----------------------------------------------------------------------------------------------------
        public override void move()
        {

        }
        //-----------------------------------------------------------------------------------------------------
        public override void rotate()
        {

        }
        //-----------------------------------------------------------------------------------------------------
        public override void climb()
        {

            //-----------------------------------------------------------------------------------------------------
        }
        //-----------------------------------------------------------------------------------------------------
        public override void add(String name, Object x)
        {
            L.Add(name, x);
        }
        //-----------------------------------------------------------------------------------------------------
        public override void dibujar(String name)
        {
            L[name].draw();
        }
        //-----------------------------------------------------------------------------------------------------
        public  void dibujar()
        {
            foreach (KeyValuePair<String, Object> kvp in L)
            {
                kvp.Value.draw();
            }
        }
    }
}

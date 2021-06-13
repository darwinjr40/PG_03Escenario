using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Escenario : Object
    {
        Dictionary<string, Object> L;

        public Escenario()
        { L = new Dictionary<string, Object>(); }
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
        public override void scale()
        {

        }
        //-----------------------------------------------------------------------------------------------------
        public void add(string name, Object x)
        {
            if (L.ContainsKey(name))
                remove(name);   
            
            L.Add(name, x);
        }
        //-----------------------------------------------------------------------------------------------------
        public void remove(string name)
        {
            L.Remove(name);
            L.Count();
        }
        //-----------------------------------------------------------------------------------------------------
        public  void dibujar(string name)
        {
            L[name].draw();
        }
        //-----------------------------------------------------------------------------------------------------
        public  void dibujar()
        {
            foreach (KeyValuePair<string, Object> kvp in L)
            {
                kvp.Value.draw();
            }
        }
    }
}

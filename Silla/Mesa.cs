using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Mesa : Object
    {
        public Mesa(float cx, float cy, float cz, float ancho, float alto, float largo) : base(cx, cy,cz, ancho, alto, largo)
        {
            base.lista.Add("tabla", new Parte(x, y, z, ancho, alto * 0.30f, largo));
            base.lista.Add("pataIzqD", new Parte(x - ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z + (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.lista.Add("pataDerD", new Parte(x + ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z + (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.lista.Add("pataIzqT", new Parte(x - ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.lista.Add("pataDerT", new Parte(x + ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            
        }
        //-----------------------------------------------------------------------------------------------------
        public override void draw()
        {
            base.draw();
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

    }
}

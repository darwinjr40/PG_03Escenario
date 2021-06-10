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
            base.parteObjeto.Add("pataIzqD", new Cubo(x - ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z + (largo * 0.4f), ancho * 0.2f,  alto * 0.7f, largo * 0.2f));
            base.parteObjeto.Add("pataDerD", new Cubo(x + ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z + (largo * 0.4f), ancho * 0.2f,  alto * 0.7f, largo * 0.2f));
            base.parteObjeto.Add("pataIzqT", new Cubo(x - ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f,  alto * 0.7f, largo * 0.2f));
            base.parteObjeto.Add("pataDerT", new Cubo(x + ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.parteObjeto.Add("tabla", new Cubo(x, y, z, ancho, alto * 0.30f, largo));
            //pata1 = new Cubo(x - ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z +(largo *0.4f), ancho * 0.2f,    alto * 0.7f, largo * 0.2f);
            //pata2 = new Cubo(x + ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z+(largo * 0.4f), ancho * 0.2f,    alto * 0.7f, largo * 0.2f);
            //pata3 = new Cubo(x - ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f,  alto * 0.7f, largo * 0.2f);
            //pata4 = new Cubo(x + ((ancho / 2) - (ancho * 0.2f / 2)),   y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f,  alto * 0.7f, largo * 0.2f);
            //tabla = new Cubo(x, y, z, ancho, alto * 0.30f, largo);         
        }

        public override void draw()
        {
            foreach (KeyValuePair<String, Object> kvp in parteObjeto)
            {
                kvp.Value.draw();
            }
        }

        public override void move() 
        { 

        }

        public override void rotate() 
        { 

        }

        public override void climb() 
        {

        }

    }
}

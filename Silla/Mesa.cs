using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Mesa : Object
    {
        Pata  pata1; 
        Pata  pata2;
        Pata  pata3;
        Pata  pata4;
        Pata  tabla;

        public Mesa(float cx, float cy, float cz, float ancho, float alto, float largo)
        {
            base.moverA(cx, cy, cz);
            base.cambiarDimension(ancho, alto, largo);
            pata1 = new Pata(x - ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z +(largo *0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f);
            pata2 = new Pata(x + ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z+(largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f);
            pata3 = new Pata(x - ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f);
            pata4 = new Pata(x + ((ancho / 2) - (ancho * 0.2f / 2)), y - (alto - 1) / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f);
            tabla = new Pata(x, y, z, ancho, alto * 0.30f, largo);         
        }

         public override void draw(){
             pata1.draw();
             pata2.draw();
             pata3.draw();
             pata4.draw();
             tabla.draw();
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

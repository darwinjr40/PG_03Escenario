using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Silla : Object
    {
        public Silla(float cx, float cy, float cz, float ancho, float alto, float largo) : base(cx, cy,cz, ancho, alto, largo)
        {
            base.lista.Add("base", new Parte(x, y, z, ancho, alto * 0.30f, largo));
            base.lista.Add("espalda", new Parte(x + (ancho * 0.4f), y + (alto / 2), z, ancho * 0.2f, alto * 0.7f, largo));
            base.lista.Add("pataIzqD", new Parte(x - ancho *0.4f, y - alto / 2, z + largo * 0.4f, ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.lista.Add("pataDerD", new Parte(x + ancho * 0.4f, y - alto / 2, z + (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.lista.Add("pataIzqT", new Parte(x - ancho * 0.4f, y - alto / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            base.lista.Add("pataDerT", new Parte(x + ancho * 0.4f, y - alto / 2, z - (largo * 0.4f), ancho * 0.2f, alto * 0.7f, largo * 0.2f));
            
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

using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    public abstract class Object  
    {
        public float x = 0;
        public float y = 0;
        public float z = 0;
        
        public float ancho;
        public float largo;
        public float alto;

        public abstract void draw();

        public abstract void move();

        public abstract void rotate();

        public abstract void climb();

        public  virtual void moverA(float cx, float cy, float cz)
        {
            this.x = cx;
            this.y = cy;
            this.z = cz;
        }
        public virtual void cambiarDimension(float nuevoAncho, float nuevoLargo, float nuevoAlto)
        {
            this.ancho = nuevoAncho;
            this.largo = nuevoLargo;
            this.alto = nuevoAlto;
        }

    }
}

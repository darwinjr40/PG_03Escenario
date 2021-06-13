using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    public abstract class Object:IObject   
    {   //punto origen
        protected float x ;
        protected float y ;
        protected float z ;
        protected float ancho;
        protected float alto;
        protected float largo;
        protected Dictionary<string, Parte> lista;
        //------------------------------------------------------------------------------------------------------
        public  Object(float origenX, float origenY, float origenZ, float ancho, float alto, float largo)
        {
            this.mover(origenX, origenY, origenZ);
            this.cambiarDimension(ancho , alto , largo );
            lista = new Dictionary<string, Parte>();
        }
        //------------------------------------------------------------------------------------------------------
        public Object(float origenX, float origenY, float origenZ)
               : this(origenX, origenY, origenZ, 2.0f, 6.0f, 2.0f) { }
        //------------------------------------------------------------------------------------------------------
        public Object() : this(0, 0, 0, 0, 0, -10) { }
        //------------------------------------------------------------------------------------------------------
        public  void mover(float cx, float cy, float cz)
        {
            this.x = cx;
            this.y = cy;
            this.z = cz;
        }
        //------------------------------------------------------------------------------------------------------
        public virtual void cambiarDimension(float nuevoAncho, float nuevoAlto, float nuevoLargo )
        {
            this.ancho = nuevoAncho;
            this.alto = nuevoAlto;
            this.largo = nuevoLargo;
        }
        //------------------------------------------------------------------------------------------------------

        public virtual void draw()
        {
            foreach (Parte p in lista.Values)
            {
                p.draw();
            }
        }
        
        //------------------------------------------------------------------------------------------------------
        public abstract void move();
        //------------------------------------------------------------------------------------------------------
        public abstract void rotate();
        //------------------------------------------------------------------------------------------------------
        public abstract void scale();
        //------------------------------------------------------------------------------------------------------
        
    }
}

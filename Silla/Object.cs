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
        protected float x = 0;
        protected float y = 0;
        protected float z = 0;
        //tamano
        protected float ancho;
        protected float alto;
        protected float largo;
        //partes
        protected Dictionary<String, Object> parteObjeto;
        //constructores
        //------------------------------------------------------------------------------------------------------
        public  Object(float origenX, float origenY, float origenZ, float ancho, float alto, float largo)
        {
            mover(origenX, origenY, origenZ);
            cambiarDimension(ancho , alto , largo );
            parteObjeto = new Dictionary<String, Object>();
        }
        //------------------------------------------------------------------------------------------------------
        public Object(float origenX, float origenY, float origenZ)
            : this(origenX, origenY, origenZ, 2.0f, 6.0f, 2.0f) {
                parteObjeto = new Dictionary<String, Object>();
        }
        //------------------------------------------------------------------------------------------------------
        public Object() : this(0, 0, 0, 0, 0, -100) {
            parteObjeto = new Dictionary<String, Object>(); 
        }
        //------------------------------------------------------------------------------------------------------
        public  virtual void mover(float cx, float cy, float cz)
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
        public virtual void add(String name, Object x)
        {
            parteObjeto.Add(name, x);
        }

        public virtual void dibujar(String name)
        {
            parteObjeto[name].draw();
        }
        //------------------------------------------------------------------------------------------------------

        public abstract void draw();
        //------------------------------------------------------------------------------------------------------
        public abstract void move();
        //------------------------------------------------------------------------------------------------------
        public abstract void rotate();
        //------------------------------------------------------------------------------------------------------
        public abstract void climb();
        //------------------------------------------------------------------------------------------------------
        
    }
}

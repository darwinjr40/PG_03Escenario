using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Pata : Object
    {
        public int c = 0;

        public Pata() : this(0, 0, 0, 2.0f, 6.0f, 2.0f) { }

        public Pata(float origenX, float origenY, float origenZ)
            : this(origenX, origenY, origenZ, 2.0f, 6.0f, 2.0f) {}
        
        public Pata(float origenX, float origenY, float origenZ, float ancho, float alto, float largo)
        {
            this.moverA(origenX, origenY, origenZ);
            base.cambiarDimension(ancho / 2, alto / 2, largo / 2);
        }

        public  override void moverA(float puntoRefx, float puntoRefy, float puntoRefz)
        {
            base.moverA(puntoRefx, puntoRefy, puntoRefz);
        }

        public void cambiarDimensiones(float nuevoAncho, float nuevoLargo, float nuevoAlto)
        {
            base.ancho = nuevoAncho;
            base.largo = nuevoLargo;
            base.alto = nuevoAlto;
        }
        

        public override void draw()
        {
            GL.Begin(PrimitiveType.Quads);
            //frente
            GL.Color3(0, 0, 1);//negro
            GL.Vertex3(x - ancho, y - largo, z + alto);
            GL.Vertex3(x + ancho, y - largo, z + alto);
            GL.Vertex3(x + ancho, y + largo, z + alto);
            GL.Vertex3(x - ancho, y + largo, z + alto);
            
            //parte izquierdo
            GL.Color3(1.0, 0.0, 0.0);//rojo
            GL.Vertex3(x - ancho, y + largo, z + alto);
            GL.Vertex3(x - ancho, y + largo, z - alto);
            GL.Vertex3(x - ancho, y - largo, z - alto);
            GL.Vertex3(x - ancho, y - largo, z + alto);

            //parte derecha
            GL.Color3(0.0, 1.0, 0.0);//verde lechuga
            GL.Vertex3(x + ancho, y + largo, z + alto);
            GL.Vertex3(x + ancho, y + largo, z - alto);
            GL.Vertex3(x + ancho, y - largo, z - alto);
            GL.Vertex3(x + ancho, y - largo, z + alto);

            //parte inferior
            GL.Color3(0.91, 0.76, 0.65);//crema
            GL.Vertex3(x - ancho, y - largo, z + alto);
            GL.Vertex3(x + ancho, y - largo, z + alto);
            GL.Vertex3(x + ancho, y - largo, z - alto);
            GL.Vertex3(x - ancho, y - largo, z - alto);
            

            //parte superior;
            GL.Color3(0.0, 1.0, 1.0);//celeste
            GL.Vertex3(x + ancho, y + largo, z + alto);
            GL.Vertex3(x + ancho, y + largo, z - alto);
            GL.Vertex3(x - ancho, y + largo, z - alto);
            GL.Vertex3(x - ancho, y + largo, z + alto);
            
            //espalda
            GL.Color3(1.0, 1.0, 0.0);//amarillo
            GL.Vertex3(x + ancho, y + largo, z - alto);
            GL.Vertex3(x + ancho, y - largo, z - alto);
            GL.Vertex3(x - ancho, y - largo, z - alto);
            GL.Vertex3(x - ancho, y + largo, z - alto);

            GL.End();
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

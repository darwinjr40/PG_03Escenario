using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Cubo : Object
    {
        public Cubo() : this(0, 0, 0, 4.0f, 4.0f, 4.0f) { }
        //------------------------------------------------------------------------------------------------------
        public Cubo(float origenX, float origenY, float origenZ)
            : this(origenX, origenY, origenZ, 4.0f, 4.0f, 4.0f) { }
        //-----------------------------------------------------------------------------------------------------
        public  Cubo (float origenX, float origenY, float origenZ, float ancho, float alto, float largo) 
             // : base (origenX, origenY, origenZ, ancho / 2, alto / 2, largo / 2)
        {
            base.mover(origenX, origenY, origenZ);
            base.cambiarDimension(ancho / 2, alto / 2, largo / 2);
        }
        //-----------------------------------------------------------------------------------------------------
        public  override void mover(float puntoRefx, float puntoRefy, float puntoRefz)
        {
            base.mover(puntoRefx, puntoRefy, puntoRefz);
        }
        //-----------------------------------------------------------------------------------------------------
        public  override void cambiarDimension(float nuevoAncho, float nuevoLargo, float nuevoAlto)
        {
            base.ancho = nuevoAncho;
            base.largo = nuevoLargo;
            base.alto = nuevoAlto;
        }
        //-----------------------------------------------------------------------------------------------------
        public override void draw()
        {
            caraDelantera();
            caraIzquierda();
            caraDerecha();
            carainferior();
            caraSuperior();
            caraEspaldar();
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

        }
        //-----------------------------------------------------------------------------------------------------
        public  void draw1()
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
        //-----------------------------------------------------------------------------------------------------
        private void caraDelantera()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0, 0, 1);//negro
            GL.Vertex3(x - ancho, y - alto, z + largo);
            GL.Vertex3(x + ancho, y - alto, z + largo);
            GL.Vertex3(x + ancho, y + alto, z + largo);
            GL.Vertex3(x - ancho, y + alto, z + largo);
            GL.End();
        }
        //-----------------------------------------------------------------------------------------------------
        private void caraIzquierda()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 0.0, 0.0);//rojo
            GL.Vertex3(x - ancho, y + alto, z + largo);
            GL.Vertex3(x - ancho, y + alto, z - largo);
            GL.Vertex3(x - ancho, y - alto, z - largo);
            GL.Vertex3(x - ancho, y - alto, z + largo);
            GL.End();

        }
        //------------------------------------------------------------------------------------------------------
        private void caraDerecha()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.0, 1.0, 0.0);//verde lechuga
            GL.Vertex3(x + ancho, y + alto, z + largo);
            GL.Vertex3(x + ancho, y + alto, z - largo);
            GL.Vertex3(x + ancho, y - alto, z - largo);
            GL.Vertex3(x + ancho, y - alto, z + largo);
            GL.End();
        }
        //------------------------------------------------------------------------------------------------------
        private void caraSuperior()
        {
            GL.Begin(PrimitiveType.Quads);    
            GL.Color3(0.0, 1.0, 1.0);//celeste
            GL.Vertex3(x + ancho, y + alto, z + largo);
            GL.Vertex3(x + ancho, y + alto, z - largo);
            GL.Vertex3(x - ancho, y + alto, z - largo);
            GL.Vertex3(x - ancho, y + alto, z + largo);
            GL.End();
        }
        //------------------------------------------------------------------------------------------------------
        private void carainferior()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.91, 0.76, 0.65);//crema
            GL.Vertex3(x - ancho, y - alto, z + largo);
            GL.Vertex3(x + ancho, y - alto, z + largo);
            GL.Vertex3(x + ancho, y - alto, z - largo);
            GL.Vertex3(x - ancho, y - alto, z - largo);
            GL.End();
        }
        //------------------------------------------------------------------------------------------------------
        private void caraEspaldar()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 1.0, 0.0);//amarillo
            GL.Vertex3(x + ancho, y + alto, z - largo);
            GL.Vertex3(x + ancho, y - alto, z - largo);
            GL.Vertex3(x - ancho, y - alto, z - largo);
            GL.Vertex3(x - ancho, y + alto, z - largo);
            GL.End();
        }
        
        

    }
}

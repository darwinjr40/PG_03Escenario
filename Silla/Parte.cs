using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    public class Parte : IObject
    {
        private Vector3 origen;
        private float ancho;
        private float alto;
        private float largo;
        public Parte(float x, float y, float z, float ancho, float alto, float largo)             
        {
            origen = new Vector3();
            mover(x, y, z);
            cambiarDimension(ancho / 2, alto / 2, largo / 2);
        }
        //-----------------------------------------------------------------------------------------------------
        public Parte(float origenX, float origenY, float origenZ)
            : this(origenX, origenY, origenZ, 1, 1, 1) { }
        //-----------------------------------------------------------------------------------------------------
        public Parte() : this(0, 0, 0, 1, 1, 1) { }
        //------------------------------------------------------------------------------------------------------
       
        public  void mover(float x, float y, float z)
        {
            origen.X = x;
            origen.Y = y;
            origen.Z = z;
        }
        //-----------------------------------------------------------------------------------------------------
        public  void cambiarDimension(float nuevoAncho, float nuevoAlto, float nuevoLargo)
        {
            this.ancho = nuevoAncho;
            this.alto = nuevoAlto;
            this.largo = nuevoLargo;

        }
        //-----------------------------------------------------------------------------------------------------
        public void draw()
        {
            caraDelantera();
            caraIzquierda();
            caraDerecha();
            carainferior();
            caraSuperior();
            caraEspaldar();
        }
        //-----------------------------------------------------------------------------------------------------
        public  void move()
        {

        }
        //-----------------------------------------------------------------------------------------------------
        public  void rotate()
        {

        }
        //-----------------------------------------------------------------------------------------------------
        public  void scale()
        {

        }
        //-----------------------------------------------------------------------------------------------------
        private void caraDelantera()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0, 0, 1);//negro
            GL.Vertex3(origen.X - ancho, origen.Y - alto, origen.Z + largo);
            GL.Vertex3(origen.X + ancho, origen.Y - alto, origen.Z + largo);
            GL.Vertex3(origen.X + ancho, origen.Y + alto, origen.Z + largo);
            GL.Vertex3(origen.X - ancho, origen.Y + alto, origen.Z + largo);
            GL.End();
        }
        //-----------------------------------------------------------------------------------------------------
        private void caraIzquierda()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 0.0, 0.0);//rojo
            GL.Vertex3(origen.X - ancho, origen.Y + alto, origen.Z + largo);
            GL.Vertex3(origen.X - ancho, origen.Y + alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y - alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y - alto, origen.Z + largo);
            GL.End();

        }
        //------------------------------------------------------------------------------------------------------
        private void caraDerecha()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.0, 1.0, 0.0);//verde lechuga
            GL.Vertex3(origen.X + ancho, origen.Y + alto, origen.Z + largo);
            GL.Vertex3(origen.X + ancho, origen.Y + alto, origen.Z - largo);
            GL.Vertex3(origen.X + ancho, origen.Y - alto, origen.Z - largo);
            GL.Vertex3(origen.X + ancho, origen.Y - alto, origen.Z + largo);
            GL.End();
        }
        //------------------------------------------------------------------------------------------------------
        private void caraSuperior()
        {
            GL.Begin(PrimitiveType.Quads);    
            GL.Color3(0.0, 1.0, 1.0);//celeste
            GL.Vertex3(origen.X + ancho, origen.Y + alto, origen.Z + largo);
            GL.Vertex3(origen.X + ancho, origen.Y + alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y + alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y + alto, origen.Z + largo);
            GL.End();
        }
        //------------------------------------------------------------------------------------------------------
        private void carainferior()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.91, 0.76, 0.65);//crema
            GL.Vertex3(origen.X - ancho, origen.Y - alto, origen.Z + largo);
            GL.Vertex3(origen.X + ancho, origen.Y - alto, origen.Z + largo);
            GL.Vertex3(origen.X + ancho, origen.Y - alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y - alto, origen.Z - largo);
            GL.End();
        }
        //------------------------------------------------------------------------------------------------------
        private void caraEspaldar()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 1.0, 0.0);//amarillo
            GL.Vertex3(origen.X + ancho, origen.Y + alto, origen.Z - largo);
            GL.Vertex3(origen.X + ancho, origen.Y - alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y - alto, origen.Z - largo);
            GL.Vertex3(origen.X - ancho, origen.Y + alto, origen.Z - largo);
            GL.End();
        }
        
        

    }
}

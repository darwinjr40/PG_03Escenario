
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Silla
{
    class Game
    {
        GameWindow window;
        public Game(GameWindow window)
        {
            this.window = window;
            Start();
        }
        public Game(int x, int y)
        {
            this.window = new GameWindow(x, y);
            Start();
        }

        void Start() 
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0 / 60.0);
        }

        void resize(object o, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, 50, 0, 50, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Lines);
            //--------------------------------
            GL.Vertex2(15, 4);  GL.Vertex2(15, 16);
            GL.Vertex2(16, 4);  GL.Vertex2(16, 16);
            GL.Vertex2(15, 4);  GL.Vertex2(16, 4);
            //---------------------------------
            GL.Vertex2(30, 2); GL.Vertex2(30, 13);
            GL.Vertex2(31, 2); GL.Vertex2(31, 13);
            GL.Vertex2(30, 2);  GL.Vertex2(31, 2);
            //---------------------------------
            GL.Vertex2(39, 10); GL.Vertex2(39, 22);
            GL.Vertex2(38, 10); GL.Vertex2(38, 20.9);
            GL.Vertex2(38, 10); GL.Vertex2(39, 10);
            //---------------------------------
            GL.Vertex2(24, 10); GL.Vertex2(24, 14.3);
            GL.Vertex2(25, 10); GL.Vertex2(25, 14.2);
            GL.Vertex2(24, 10); GL.Vertex2(25, 10);
            //--------------------------------
            GL.Vertex2(15, 16); GL.Vertex2(31, 13);
            GL.Vertex2(31, 13); GL.Vertex2(39, 22);


            GL.Vertex2(15, 20); GL.Vertex2(15, 16);

            GL.Vertex2(15, 20); GL.Vertex2(24, 27);
            GL.Vertex2(15, 20); GL.Vertex2(30, 17);
            GL.Vertex2(30, 17); GL.Vertex2(37, 25);
            GL.Vertex2(24, 27); GL.Vertex2(37, 25);

            GL.Vertex2(24, 27); GL.Vertex2(24, 45);
            
            GL.Vertex2(37, 25); GL.Vertex2(37, 44);

            GL.Vertex2(24, 45); GL.Vertex2(37, 44);
             
            
            GL.Vertex2(26, 46); GL.Vertex2(39, 45);
            GL.Vertex2(26, 46); GL.Vertex2(24, 45);
            //------------
            GL.Vertex2(37, 44); GL.Vertex2(39, 45);
            
            GL.Vertex2(39, 22); GL.Vertex2(39, 45);
            GL.End();
            window.SwapBuffers(); 
        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(0.0f, 0, 0, 0);
        }
    }
}

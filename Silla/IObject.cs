using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    public interface IObject
    {
        void draw();

        void move();

        void rotate();

        void climb();
    }
}

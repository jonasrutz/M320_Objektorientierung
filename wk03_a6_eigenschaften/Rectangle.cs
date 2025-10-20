using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk03_a6_eigenschaften
{
    public class Rectangle
    {

        private int height;
        private int width;
        private Color color;

        public Color Color //Nr1
        {
            get { return color; }
        }
        public int Width //Nr2
        {
            get { return width; }
            set { width = value; }
        }
        public int Heigth //Nr3
        {
            set { height = value; }
        }

        public int white_5 { get; } // nr4

        public int white_6 { get; set; } //nr5

        public int white_7 { private get; set; } //nr6 (mehr fanfrage weil nicht setz bar ohne lessbar)

        public int ID => 1; //nr7
    }
}

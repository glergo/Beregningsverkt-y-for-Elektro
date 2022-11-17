using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beregningsverktøy_for_Elektro
{
    public partial class ImageViewer : Form
    {
        public int[] readExif (string imagePath)
        {
            int[] pixels = new int[2];
            Bitmap getExif = new Bitmap(imagePath);
            pixels[0] = getExif.Width;
            pixels[1] = getExif.Height; 
            return pixels;
        }
        public ImageViewer()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CFria_HorasExtra
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 35; // Tamaño del radio de los bordes
            using (Pen borderPen = new Pen(Color.Gray, 2))
            {
                Rectangle rect = new Rectangle(0, 0, txtNombre.Width - 1, txtNombre.Height - 1);
                int radius = borderRadius;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Width - radius * 2, rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                txtNombre.Region = new Region(path);
                e.Graphics.DrawPath(borderPen, path);
            }
        }
    }
}

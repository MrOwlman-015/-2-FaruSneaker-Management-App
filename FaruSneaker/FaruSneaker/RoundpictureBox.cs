using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker
{
    public class RoundpictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, Width - 1, Height - 1);
            Region = new Region(gp);
            base.OnPaint(e);
        }

    }
}

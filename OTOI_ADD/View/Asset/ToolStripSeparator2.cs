using Google.Apis.Util;
using Microsoft.Office.Interop.Excel;
using OTOI_ADD.Code.Module.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOI_ADD.View.Asset
{
    internal class ToolStripSeparator2 : ToolStripSeparator
    {
        public ToolStripSeparator2() : base()
        {
            this.Paint += ExtendedToolStripSeparator_Paint;
        }

        private void ExtendedToolStripSeparator_Paint(object? sender, PaintEventArgs e)
        {
            // Get the separator's width and height.
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;


            Color foreColor, backColor;
            if (Styler.MODE)
            {
                foreColor = ColorScheme.TSMI_TEXT_D;
                backColor = ColorScheme.TSMI_BACK_D;
            }
            else
            {
                foreColor = ColorScheme.TSMI_TEXT_L;
                backColor = ColorScheme.TSMI_BACK_L;
            }

            // Fill the background.
            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

            // Draw the line.
            e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
        }
    }
}

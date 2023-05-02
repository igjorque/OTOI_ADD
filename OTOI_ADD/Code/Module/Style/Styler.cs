using OTOI_ADD.View.Asset;
using OTOI_ADD.View.Asset.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOI_ADD.Code.Module.Style
{
    internal class Styler
    {
        // Current Styler MODE - by default, false (light theme)
        /// <summary>
        /// False: light - True: dark
        /// </summary>
        internal static bool MODE = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controls"></param>
        internal static void SetStyle(List<Object> controls)
        {
            foreach (Object c in controls)
            {
                // Main form
                if (c is MenuStrip)
                {
                    MenuStrip ms;
                    ms = (MenuStrip)c;
                    SetMS(ms);
                } 
                else if (c is ToolStripMenuItem)
                {
                    ToolStripMenuItem tsmi;
                    tsmi = (ToolStripMenuItem)c;
                    SetTSMI(tsmi);
                }
                else if (c is Label2)
                {
                    Label2 lb2;
                    lb2 = (Label2)c;
                    SetLB2(lb2);
                }
                else if (c is Label && c is not Label2 && c is not LinkLabel)
                {
                    Label lb;
                    lb = (Label)c;
                    SetLB(lb);
                }
                else if (c is Button2)
                {
                    Button2 bt2;
                    bt2 = (Button2)c;
                    SetBT2(bt2);
                }
                else if (c is Button && c is not Button2)
                {
                    Button bt;
                    bt = (Button)c;
                    SetBT(bt);
                }
                else if (c is CheckBox)
                {
                    CheckBox cb;
                    cb = (CheckBox)c;
                    SetCB(cb);
                }
                else if (c is LinkLabel)
                {
                    LinkLabel ll;
                    ll = (LinkLabel)c;
                    SetLL(ll);
                }
                else if (c is ProgressBar)
                {
                    ProgressBar pb;
                    pb = (ProgressBar)c;
                    SetPB(pb);
                }
                else if (c is UserControl)
                {
                    UserControl uc;
                    uc = (UserControl)c;
                    SetUC(uc);
                }
                else if (c is ToolStripSeparator)
                {
                    ToolStripSeparator tss;
                    tss = (ToolStripSeparator)c;
                    SetTSS(tss);
                }
                else if (c is LinkLabel)
                {
                    LinkLabel ll;
                    ll = (LinkLabel)c;
                    SetLL(ll);
                }
                else if (c is Form)
                {
                    Form f;
                    f = (Form)c;
                    SetF(f);
                }
            }
        }

        // MenuStrip
        private static void SetMS(MenuStrip ms)
        {
            if (MODE) // dark
            {
                ms.BackColor = ColorScheme.MS_BACK_D;
                ms.ForeColor = ColorScheme.TSMI_TEXT_D;
            } 
            else // light
            {
                ms.BackColor = ColorScheme.MS_BACK_L;
                ms.ForeColor = ColorScheme.TSMI_TEXT_L;
            }
        }

        // ToolStripMenuItem
        private static void SetTSMI(ToolStripMenuItem tsmi)
        {
            if (MODE)
            {
                tsmi.BackColor = ColorScheme.TSMI_BACK_D;
                tsmi.ForeColor = ColorScheme.TSMI_TEXT_D;

            } else
            {
                tsmi.BackColor = ColorScheme.TSMI_BACK_L;
                tsmi.ForeColor = ColorScheme.TSMI_TEXT_L;
            }
        }

        // Label2
        private static void SetLB2(Label2 lb2)
        {
            if (MODE)
            {
                lb2.BackColor = ColorScheme.LB2_BACK_D;
                lb2.ForeColor = ColorScheme.LB2_TEXT_D;
            }
            else
            {
                lb2.BackColor = ColorScheme.LB2_BACK_L;
                lb2.ForeColor = ColorScheme.LB2_TEXT_L;
            }
        }

        // Label
        private static void SetLB(Label lb)
        {
            if (MODE)
            {
                lb.BackColor = ColorScheme.LB_BACK_D;
                lb.ForeColor = ColorScheme.LB_TEXT_D;
            }
            else
            {
                lb.BackColor = ColorScheme.LB_BACK_L;
                lb.ForeColor = ColorScheme.LB_TEXT_L;
            }
        }

        // Button2
        private static void SetBT2(Button2 bt2)
        {
            if (MODE)
            {
                bt2.ForeColor = ColorScheme.BT_TEXT_L;
            }
            else
            {
                bt2.ForeColor = ColorScheme.BT_TEXT_L;
            }
        }

        // Button
        private static void SetBT(Button bt)
        {
            if (MODE)
            {
                bt.BackColor = ColorScheme.BT_BACK_D;
                bt.ForeColor = ColorScheme.BT_TEXT_D;
            }
            else
            {
                bt.BackColor = ColorScheme.BT_BACK_L;
                bt.ForeColor = ColorScheme.BT_TEXT_L;
            }
        }

        // CheckBox
        private static void SetCB(CheckBox cb)
        {
            if (MODE)
            {
                cb.BackColor = ColorScheme.CB_BACK_D;
                cb.ForeColor = ColorScheme.CB_TEXT_D;
            }
            else
            {
                cb.BackColor = ColorScheme.CB_BACK_L;
                cb.ForeColor = ColorScheme.CB_TEXT_L;
            }
        }

        // LinkLabel
        private static void SetLL(LinkLabel ll)
        {
            if (MODE)
            {
                ll.BackColor = ColorScheme.LL_BACK_D;
                ll.LinkColor = ColorScheme.LL_UNUSED_D;
                ll.VisitedLinkColor = ColorScheme.LL_USED_D;
            } 
            else
            {
                ll.BackColor = ColorScheme.LL_BACK_L;
                ll.LinkColor = ColorScheme.LL_UNUSED_L;
                ll.VisitedLinkColor = ColorScheme.LL_USED_L;
            }
        }

        // ProgressBar
        private static void SetPB(ProgressBar pb)
        {
            if (MODE)
            {
                pb.BackColor = ColorScheme.PB_BACK_D;
            }
            else
            {
                pb.BackColor = ColorScheme.PB_BACK_L;
            }
        }

        // UserControl
        private static void SetUC(UserControl uc)
        {
            if (MODE)
            {
                uc.BackColor = ColorScheme.FORM_BACK_D;
                uc.ForeColor = Color.White;
            }
            else
            {
                uc.BackColor = ColorScheme.FORM_BACK_L;
                uc.ForeColor = Color.Black;
            }
        }

        // ToolStripSeparator
        private static void SetTSS(ToolStripSeparator tss)
        {
            /*
            if (MODE)
            {
                tss.Visible = false;
            }
            else
            {
                tss.Visible = true;
            }
            */
        }
        private static void SetF(Form f)
        {
            if (MODE)
            {
                f.BackColor = ColorScheme.FORM_BACK_D;
            }
            else
            {
                f.BackColor = ColorScheme.FORM_BACK_L;
            }
        }
    }
}

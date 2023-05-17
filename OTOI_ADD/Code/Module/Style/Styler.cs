using OTOI_ADD.View.Asset;

namespace OTOI_ADD.Code.Module.Style
{
    /// <summary>
    /// Styler class
    /// </summary>
    internal static class Styler
    {
        // Current Styler MODE - by default, false (light theme)
        /// <summary>
        /// False: light - True: dark
        /// </summary>
        internal static bool MODE = false;

        // Styler main function / entry point
        /// <summary>
        /// Sets the current theme mode (light/dark) to every received control
        /// </summary>
        /// <param name="controls">List of controls to modify</param>
        internal static void SetStyle(List<Object> controls)
        {
            foreach (Object c in controls)
            {
                if (c is MenuStrip strip)
                {
                    SetMS(strip);
                } 
                else if (c is ToolStripMenuItem item)
                {
                    SetTSMI(item);
                }
                else if (c is Label2 label2)
                {
                    SetLB2(label2);
                }
                else if (c is Label label1 and not Label2 and not LinkLabel)
                {
                    SetLB(label1);
                }
                else if (c is Button2 button2)
                {
                    SetBT2(button2);
                }
                else if (c is Button button1 && c is not Button2)
                {
                    SetBT(button1);
                }
                else if (c is CheckBox checkbox)
                {
                    SetCB(checkbox);
                }
                else if (c is LinkLabel link)
                {
                    SetLL(link);
                }
                else if (c is ProgressBar bar)
                {
                    SetPB(bar);
                }
                else if (c is UserControl user)
                {
                    SetUC(user);
                }
                else if (c is Form form)
                {
                    SetF(form);
                }
                else if (c is ComboBox box)
                {
                    SetCOB(box);
                }
                else if (c is RadioButton radio)
                {
                    SetRB(radio);
                }
            }
        }

        // MenuStrip
        /// <summary>
        /// Sets a MenuStrip theme mode.
        /// </summary>
        /// <param name="ms">MenuStrip control</param>
        private static void SetMS(MenuStrip ms)
        {
            if (Styler.MODE) // dark
            {
                ms.BackColor = ColorScheme.MS_BACK_D;
                ms.ForeColor = ColorScheme.TSMI_FORE_D;
            } 
            else // light
            {
                ms.BackColor = ColorScheme.MS_BACK_L;
                ms.ForeColor = ColorScheme.TSMI_FORE_L;
            }
        }

        // ToolStripMenuItem
        /// <summary>
        /// Sets a ToolStripMenuItem theme mode.
        /// </summary>
        /// <param name="tsmi">ToolStripMenuItem control</param>
        private static void SetTSMI(ToolStripMenuItem tsmi)
        {
            if (Styler.MODE)
            {
                tsmi.BackColor = ColorScheme.TSMI_BACK_D;
                tsmi.ForeColor = ColorScheme.TSMI_FORE_D;

            } else
            {
                tsmi.BackColor = ColorScheme.TSMI_BACK_L;
                tsmi.ForeColor = ColorScheme.TSMI_FORE_L;
            }
        }

        // Label2
        /// <summary>
        /// Sets a Label2 theme mode.
        /// </summary>
        /// <param name="lb2">Label2 custom control</param>
        private static void SetLB2(Label2 lb2)
        {
            if (Styler.MODE)
            {
                lb2.BackColor = ColorScheme.LB2_BACK_D;
                lb2.ForeColor = ColorScheme.LB2_FORE_D;
            }
            else
            {
                lb2.BackColor = ColorScheme.LB2_BACK_L;
                lb2.ForeColor = ColorScheme.LB2_FORE_L;
            }
        }

        // Label
        /// <summary>
        /// Sets a Label theme mode.
        /// </summary>
        /// <param name="lb">Label control</param>
        private static void SetLB(Label lb)
        {
            if (Styler.MODE)
            {
                lb.BackColor = ColorScheme.LB_BACK_D;
                lb.ForeColor = ColorScheme.LB_FORE_D;
            }
            else
            {
                lb.BackColor = ColorScheme.LB_BACK_L;
                lb.ForeColor = ColorScheme.LB_FORE_L;
            }
        }

        // Button2
        /// <summary>
        /// Sets a Button2 theme mode.
        /// </summary>
        /// <param name="bt2">Button2 custom control</param>
        private static void SetBT2(Button2 bt2)
        {
            if (Styler.MODE)
            {
                bt2.ForeColor = ColorScheme.BT_FORE_L;
            }
            else
            {
                bt2.ForeColor = ColorScheme.BT_FORE_L;
            }
        }

        // Button
        /// <summary>
        /// Sets a Button theme mode.
        /// </summary>
        /// <param name="bt">Button control</param>
        private static void SetBT(Button bt)
        {
            if (Styler.MODE)
            {
                bt.BackColor = ColorScheme.BT_BACK_D;
                bt.ForeColor = ColorScheme.BT_FORE_D;
            }
            else
            {
                bt.BackColor = ColorScheme.BT_BACK_L;
                bt.ForeColor = ColorScheme.BT_FORE_L;
            }
        }

        // CheckBox
        /// <summary>
        /// Sets a CheckBox theme mode.
        /// </summary>
        /// <param name="cb">CheckBox control</param>
        private static void SetCB(CheckBox cb)
        {
            if (Styler.MODE)
            {
                cb.BackColor = ColorScheme.CHB_BACK_D;
                cb.ForeColor = ColorScheme.CHB_FORE_D;
            }
            else
            {
                cb.BackColor = ColorScheme.CHB_BACK_L;
                cb.ForeColor = ColorScheme.CHB_FORE_L;
            }
        }

        // LinkLabel
        /// <summary>
        /// Sets a LinkLabel theme mode.
        /// </summary>
        /// <param name="ll">LinkLabel control</param>
        private static void SetLL(LinkLabel ll)
        {
            if (Styler.MODE)
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
        /// <summary>
        /// Sets a ProgressBar theme mode.
        /// </summary>
        /// <param name="pb">ProgressBar control</param>
        private static void SetPB(ProgressBar pb)
        {
            if (Styler.MODE)
            {
                pb.BackColor = ColorScheme.PB_BACK_D;
            }
            else
            {
                pb.BackColor = ColorScheme.PB_BACK_L;
            }
        }

        // UserControl
        /// <summary>
        /// Sets a UserControl theme mode.
        /// </summary>
        /// <param name="uc">UserControl custom control</param>
        private static void SetUC(UserControl uc)
        {
            if (Styler.MODE)
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

        // Form
        /// <summary>
        /// Sets a Form theme mode.
        /// </summary>
        /// <param name="f">Form control</param>
        private static void SetF(Form f)
        {
            if (Styler.MODE)
            {
                f.BackColor = ColorScheme.FORM_BACK_D;
            }
            else
            {
                f.BackColor = ColorScheme.FORM_BACK_L;
            }
        }

        // ComboBox
        /// <summary>
        /// Sets a ComboBox theme mode.
        /// </summary>
        /// <param name="cob">ComboBox control</param>
        private static void SetCOB(ComboBox cob)
        {
            if (Styler.MODE)
            {
                cob.BackColor = ColorScheme.COB_BACK_D;
                cob.ForeColor = ColorScheme.COB_FORE_D;
            }
            else
            {
                cob.BackColor = ColorScheme.COB_BACK_L;
                cob.ForeColor = ColorScheme.COB_FORE_L;
            }
        }

        // RadioButton
        /// <summary>
        /// Sets a RadioButton theme mode.
        /// </summary>
        /// <param name="rb">RadioButton control</param>
        private static void SetRB(RadioButton rb)
        {
            if (Styler.MODE)
            {
                rb.ForeColor = ColorScheme.RB_FORE_D;
            }
            else
            {
                rb.ForeColor = ColorScheme.RB_FORE_L;
            }
        }
    }
}

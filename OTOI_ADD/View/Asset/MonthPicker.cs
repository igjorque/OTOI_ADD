using System.ComponentModel;
using System.Runtime.InteropServices;

namespace OTOI_ADD.View.Asset.Control
{
    /// <summary>
    /// MonthPicker
    /// </summary>
    public class MonthPicker : DateTimePicker
    {
        /// <summary>
        /// Empty MonthPicker control constructor. 
        /// Initialize Format/CustomFormat to display only month and year.
        /// </summary>
        public MonthPicker() : base()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "MMMM yyyy";
        }

        /// <summary>
        /// Overrides Format to redefine default value (used by designer)
        /// </summary>
        [DefaultValue(DateTimePickerFormat.Custom)]
        public new DateTimePickerFormat Format
        {
            get => base.Format;
            set => base.Format = value;
        }

        /// <summary>
        /// Overrides CustomFormat to redefine default value (used by designer)
        /// </summary>
        [DefaultValue("MMM yyyy")]
        public new string CustomFormat
        {
            get => base.CustomFormat;
            set => base.CustomFormat = value;
        }

        /// <summary>
        /// Undefined.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NOFITY)
            {
                var nmhdr = (NMHDR)(Marshal.PtrToStructure(m.LParam, typeof(NMHDR)) ?? new());
                switch (nmhdr.code)
                {
                    // detect pop-up display and switch view to month selection
                    case -950:
                        {
                            var cal = SendMessage(Handle, DTM_GETMONTHCAL, IntPtr.Zero, IntPtr.Zero);
                            SendMessage(cal, MCM_SETCURRENTVIEW, IntPtr.Zero, (IntPtr)1);
                            break;
                        }

                    // detect month selection and close the pop-up
                    case MCN_VIEWCHANGE:
                        {
                            var nmviewchange = (NMVIEWCHANGE)(Marshal.PtrToStructure(m.LParam, typeof(NMVIEWCHANGE)) ?? new());
                            if (nmviewchange.dwOldView == 1 && nmviewchange.dwNewView == 0)
                            {
                                SendMessage(Handle, DTM_CLOSEMONTHCAL, IntPtr.Zero, IntPtr.Zero);
                            }

                            break;
                        }
                }
            }
            base.WndProc(ref m);
        }

        private const int WM_NOFITY = 0x004e;
        private const int DTM_CLOSEMONTHCAL = 0x1000 + 13;
        private const int DTM_GETMONTHCAL = 0x1000 + 8;
        private const int MCM_SETCURRENTVIEW = 0x1000 + 32;
        private const int MCN_VIEWCHANGE = -750;

        /// <summary>
        /// Undefined.
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="wMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct NMVIEWCHANGE
        {
            public NMHDR nmhdr;
            public uint dwOldView;
            public uint dwNewView;
        }
    }
}

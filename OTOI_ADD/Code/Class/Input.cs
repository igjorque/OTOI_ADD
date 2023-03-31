namespace OTOI_ADD.Code.Class
{
    internal abstract class Input
    {
        private int fid;
        private DateTime date_start;
        private DateTime date_end;
        private string destDL;
        private bool keepDL;
        private bool process;

        public int FID { get => fid; set => fid = value; }

        public DateTime DateStart { get => date_start; set => date_start = value; }

        public DateTime DateEnd { get => date_end; set => date_end = value; }

        public string DestDL { get => destDL; set => destDL = value; }

        public bool KeepDL { get => keepDL; set => keepDL = value; }

        public bool Process { get => process; set => process = value; }

        /// <summary>
        /// Void base constructor for the [Input] object.
        /// </summary>
        internal Input()
        {
            this.fid = 0;
            this.date_start = DateTime.Today.AddDays(-2);
            this.date_end = DateTime.Today.AddDays(-1);
            this.destDL = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.keepDL = true;
            this.process = true;
        }

        /// <summary>
        /// Parameterized base constructor for the [Input] object.
        /// </summary>
        /// <param name="FID">Unique form ID</param>
        /// <param name="start">Querys start time</param>
        /// <param name="end">Querys end time</param>
        /// <param name="dest">Downloaded resources destination folder URI</param>
        /// <param name="keep">Keep (true) or delete (false) the downloaded resources</param>
        /// <param name="process">Process (true) or not (false) the downloaded resources</param>
        internal Input(int FID, DateTime start, DateTime end, string dest, bool keep, bool process)
        {
            this.fid = FID;
            this.date_start = start;
            this.date_end = end;
            this.destDL = dest;
            this.keepDL = keep;
            this.process = process;
        }

        /// <summary>
        /// Parameterized base constructor for the [Input] object.
        /// </summary>
        /// <param name="FID">Unique form ID</param>
        /// <param name="month">Querys month</param>
        /// <param name="dest">Downloaded resources destination folder URI</param>
        /// <param name="keep">Keep (true) or delete (false) the downloaded resources</param>
        /// <param name="process">Process (true) or not (false) the downloaded resources</param>
        internal Input(int FID, DateTime month, string dest, bool keep, bool process)
        {
            this.fid = FID;
            this.date_start = new DateTime(month.Year, month.Month, 1);
            this.date_end = new DateTime(month.Year, month.Month, DateTime.DaysInMonth(month.Year, month.Month));
            this.destDL = dest;
            this.keepDL = keep;
            this.process = process;
        }
    }
}

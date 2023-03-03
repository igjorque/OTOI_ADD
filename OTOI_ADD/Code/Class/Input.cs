namespace OTOI_ADD.Code.Class
{
    internal abstract class Input
    {
        private int fid;
        private DateTime date_start;
        private DateTime date_end;
        private string destDL;
        private bool keepDL;

        internal Input() 
        {
            this.fid = 0;
            this.date_start = DateTime.Today.AddDays(-2);
            this.date_end = DateTime.Today.AddDays(-1);
            this.destDL = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.keepDL = true;
        }

        internal Input(int FID, DateTime start, DateTime end, string dest, bool keep)
        {
            this.fid = FID;
            this.date_start = start;
            this.date_end = end;
            this.destDL = dest;
            this.keepDL = keep;
        }

        public int FID { get => fid; set => fid = value; }

        public DateTime DateStart { get => date_start; set => date_start = value; }

        public DateTime DateEnd { get => date_end; set => date_end = value; }

        public string DestDL { get => destDL; set => destDL = value; }

        public bool KeepDL { get => keepDL; set => keepDL = value; }
    }
}

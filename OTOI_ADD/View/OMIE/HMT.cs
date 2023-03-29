using log4net.Repository.Hierarchy;
using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Asset;
using OTOI_ADD.View.Asset.Control;
using OTOI_ADD.View.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HMT : MonthGeneric
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        public HMT() : base(6)
        {
            logger.Info("HMT - Constructor");
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        /// <summary>
        /// Auxiliary - Loads predefined values into this form's fields
        /// </summary>
        private void LoadFields()
        {
            this.FormName = "OMIE";
            this.Title = "Precio horario del mercado";
        }

        /// <summary>
        /// Auxiliary - Loads predefined events
        /// </summary>
        private void LoadEvents()
        {

        }
    }
}
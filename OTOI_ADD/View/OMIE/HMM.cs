﻿using OTOI_ADD.Code.Function;
using OTOI_ADD.View.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOI_ADD.View.OMIE
{
    /// <summary>
    /// Hourly Market Multiple
    /// </summary>
    public partial class HMM : MultiGeneric
    {
        public HMM() : base(4)
        {
            InitializeComponent();
            LoadFields();
            LoadEvents();
        }

        private void LoadFields()
        {
            this.FormName = "OMIE";
            this.Title = "Precio horario del mercado";
        }

        private void LoadEvents()
        {

        }
    }
}

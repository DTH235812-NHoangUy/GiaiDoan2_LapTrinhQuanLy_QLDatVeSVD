using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Forms // Fix namespace to avoid conflict with System.Windows.Forms
{
    public partial class frmSuKien : System.Windows.Forms.Form // Use fully qualified name and PascalCase class name
    {
        public frmSuKien()
        {
            InitializeComponent();
        }

        // Add this method if the designer file is missing or incomplete.
        private void InitializeComponent()
        {
            // Initialize your form controls here if not using a designer file.
            this.Text = "frmSuKien";
            this.ClientSize = new System.Drawing.Size(800, 450);
        }
    }
}

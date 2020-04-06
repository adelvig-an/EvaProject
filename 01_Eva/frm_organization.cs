using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Eva
{
    public partial class frm_organization : Form
    {
        public frm_organization()
        {
            InitializeComponent();
            chbx_compareAddresses.CheckedChanged += Chbx_compareAddresses_CheckedChanged;
        }

        private void Chbx_compareAddresses_CheckedChanged(object sender, EventArgs e)
        {
            txb_addressActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_indexActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_countryActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_regionActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_districtActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_cityActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_streetActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_houseNumberActually.ReadOnly = chbx_compareAddresses.Checked;
            txb_apartmentNumberActually.ReadOnly = chbx_compareAddresses.Checked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ObjectOfEvaluation next_form = new frm_ObjectOfEvaluation();
            next_form.Show();
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHane1._4
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (RdAdmin.Checked == true)
            {
                FrmAdmin adm = new FrmAdmin();
                adm.Show();
                this.Hide();
            }
            else if (RdOgrenci.Checked == true)
            {
                FrmOgrenci ogr = new FrmOgrenci();
                ogr.Show();
                this.Hide();
            }
            else if (RdSorumlu.Checked == true)
            {
                FrmSorumlu Srm = new FrmSorumlu();
                Srm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kullanıcı Tipi Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayit Kyt = new FrmKayit();
            Kyt.Show();
            this.Hide();
        }
    }
}
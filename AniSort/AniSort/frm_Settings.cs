using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniSort
{
    public partial class frm_Settings : Form
    {
        public frm_Settings()
        {
            InitializeComponent();
        }

        private void bnt_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = txt_default_location.Text;
            Properties.Settings.Default.FileType = txt_file_type.Text;
            Properties.Settings.Default.Coloring = check_coloring.Checked;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_default_location_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog chose_location = new FolderBrowserDialog();

            chose_location.Description = "Chose the location of your anime files";

            if (chose_location.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_default_location.Text = chose_location.SelectedPath;
            }
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            txt_default_location.Text = Properties.Settings.Default.Location;
            txt_file_type.Text = Properties.Settings.Default.FileType;
            check_coloring.Checked = Properties.Settings.Default.Coloring;
        }

        private void frm_Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AniSort
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        public string location;
        public List<string> animelist;
        public List<string> folderlist;
        public List<Color> colorlist;

        private void frm_main_Load(object sender, EventArgs e)
        {
            colorlist = new List<Color>();
            colorlist.Add(Color.Blue);
            colorlist.Add(Color.Red);
            colorlist.Add(Color.Green);
            colorlist.Add(Color.Yellow);
            colorlist.Add(Color.Violet);
            colorlist.Add(Color.Pink);
            colorlist.Add(Color.Orange);
            colorlist.Add(Color.Brown);
            colorlist.Add(Color.AliceBlue);
            colorlist.Add(Color.Beige);
            colorlist.Add(Color.Coral);
            colorlist.Add(Color.Cyan);
            colorlist.Add(Color.DarkSalmon);
            colorlist.Add(Color.DimGray);
            colorlist.Add(Color.Firebrick);
            colorlist.Add(Color.ForestGreen);
            colorlist.Add(Color.Fuchsia);
            colorlist.Add(Color.GreenYellow);
            colorlist.Add(Color.Khaki);
            colorlist.Add(Color.LemonChiffon);
            colorlist.Add(Color.LightGoldenrodYellow);
            colorlist.Add(Color.Lime);
            colorlist.Add(Color.Magenta);
            colorlist.Add(Color.MediumTurquoise);
            colorlist.Add(Color.MintCream);
            colorlist.Add(Color.OldLace);
            colorlist.Add(Color.PapayaWhip);
            colorlist.Add(Color.Peru);
            colorlist.Add(Color.RosyBrown);
            colorlist.Add(Color.Sienna);
            colorlist.Add(Color.Teal);
        }

        private void txt_profile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog chose_location = new FolderBrowserDialog();

            chose_location.Description = "Chose the location of your anime files";

            if(chose_location.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                location = chose_location.SelectedPath;
                txt_location.Text = location;

                folderlist = new List<string>();

                foreach (string folders in Directory.GetDirectories(location))
                {
                    folderlist.Add(folders);
                    lst_folders.Items.Add(folders);
                }
                for(int i = 0; i < folderlist.Count(); i++)
                {
                    lst_folders.Items[i].BackColor = colorlist[i];
                }
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            if (location != null)
            {
                animelist = new List<string>();

                foreach(string animefiles in Directory.GetFiles(location, "*.txt"))
                {
                    animelist.Add(animefiles);
                    lst_animefiles.Items.Add(animefiles);
                }
            }
            else
            {
                MessageBox.Show("Please chose a location");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destinationfile;
            string filename;
            string searchname;
            int counter = 0;
            int halflength;

            for(int i = 0; i < animelist.Count(); i++)
            {
                filename = animelist[i];
                filename = filename.Remove(0, filename.LastIndexOf("\\") + 1);
                searchname  = filename.Remove(filename.LastIndexOf("."), 4);
                halflength = searchname.Count() / 2;
                if(searchname.Count() % 2 != 0)
                    searchname = searchname.Remove(halflength, halflength + 1);
                else
                    searchname = searchname.Remove(halflength, halflength);

                for (int j = 0; j < folderlist.Count(); j++)
                {
                    if (folderlist[j].Contains(searchname))
                    {
                        destinationfile = folderlist[j] + "\\"+ filename;
                        File.Move(animelist[i], destinationfile);
                        lst_animefiles.Items[i].BackColor = colorlist[j];
                        counter++;
                    }
                }             
            }

            if (counter == 0)
                MessageBox.Show("No files moved");
            else if (counter == 1)
                MessageBox.Show("1 file succesfully moved into folder");
            else
                MessageBox.Show(counter + " files moved into folders");
        }

 
    }
}

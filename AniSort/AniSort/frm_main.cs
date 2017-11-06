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
        public string filetype;
        public bool coloring;

        private void frm_main_Load(object sender, EventArgs e)
        {
            

            button1.Enabled = false;

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

            set_data();
        }

        private void delete_data(bool folders, bool files)
        {
            if(folders && folderlist != null)
            {              
                lst_folders.Items.Clear();
                folderlist.Clear();
            }
            if(files && animelist != null)
            {
                lst_animefiles.Items.Clear();
                //lst_animefiles.Clear();
                animelist.Clear();
            }
        }

        private void txt_location_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            FolderBrowserDialog chose_location = new FolderBrowserDialog();

            chose_location.Description = "Chose the location of your anime files";

            delete_data(true, true);

            if(chose_location.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                location = chose_location.SelectedPath;
                txt_location.Text = location;

                search_folders(true, true);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string destinationfile;
            string filename;
            string searchname;
            int counter = 0;
            int halflength;

            try
            {
                for (int i = 0; i < animelist.Count(); i++)
                {
                    filename = animelist[i];
                    filename = filename.Remove(0, filename.LastIndexOf("\\") + 1);
                    searchname = filename.Remove(filename.LastIndexOf("."), 4);
                    if (searchname.Contains("[") && searchname.Contains("]"))
                    {
                        searchname = searchname.Remove(searchname.IndexOf("["), searchname.IndexOf("]") + 1);
                    }
                    while (searchname.IndexOf(" ") == 0)
                    {
                        searchname = searchname.Remove(0, 1);
                    }
                    halflength = searchname.Count() / 2;
                    if (searchname.Count() % 2 != 0)
                        searchname = searchname.Remove(halflength, halflength + 1);
                    else
                        searchname = searchname.Remove(halflength, halflength);

                    for (int j = 0; j < folderlist.Count(); j++)
                    {
                        if (folderlist[j].Contains(searchname))
                        {
                            destinationfile = folderlist[j] + "\\" + filename;
                            File.Move(animelist[i], destinationfile);
                            /*if (coloring)
                                lst_animefiles.Items[i].BackColor = colorlist[j];
                            */
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
            catch(Exception ex)
            {
                MessageBox.Show("Error while trying to move a file: \n " + ex.Message);
            }


            delete_data(false, true);
            search_folders(false, true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Settings settings_window = new frm_Settings();
            settings_window.ShowDialog();

            set_data();
        }

        private void set_data()
        {
            delete_data(true, true);
            
            txt_location.Text = Properties.Settings.Default.Location;
            location = Properties.Settings.Default.Location;
            filetype = Properties.Settings.Default.FileType;
            coloring = Properties.Settings.Default.Coloring;

            search_folders(true, true);
        }

        private void search_folders(bool foldersearch, bool filesearch)
        {
            if (foldersearch)
            {
                folderlist = new List<string>();

                foreach (string folders in Directory.GetDirectories(location))
                {
                    string foldername;
                    foldername = folders.Remove(0, folders.LastIndexOf("\\") + 1);
                    folderlist.Add(folders);
                    lst_folders.Items.Add(foldername);
                }
            }
            /* if (coloring)
             {
                 for (int i = 0; i < folderlist.Count(); i++)
                 {
                     lst_folders.Items[i].BackColor = colorlist[i];
                 }
             }
             */
            if (filesearch)
            {
                if (location != null)
                {
                    animelist = new List<string>();

                    foreach (string animefiles in Directory.GetFiles(location, "*" + filetype))
                    {
                        string addfile;
                        addfile = animefiles.Remove(0, animefiles.LastIndexOf("\\") + 1);
                        animelist.Add(animefiles);
                        lst_animefiles.Items.Add(addfile);
                    }

                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please chose a location");
                }
            }
        }

        private void pic_neuladen_Click(object sender, EventArgs e)
        {
            set_data();
        }

        private void lst_animefiles_MouseDown(object sender, MouseEventArgs e)
        {
            lst_animefiles.SelectedIndex = lst_animefiles.IndexFromPoint(e.X, e.Y);
        }

        private void AusListeEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lst_animefiles.SelectedIndex != -1)
            {
                int animeindex = lst_animefiles.SelectedIndex;

                animelist.RemoveAt(animeindex);
                lst_animefiles.Items.RemoveAt(animeindex);
            }
        }

        private void manuellZuordnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lst_animefiles.SelectedIndex != -1)
            {
                int animeindex = lst_animefiles.SelectedIndex;

                FolderBrowserDialog chose_location = new FolderBrowserDialog();

                chose_location.Description = "Chose the location for " + animelist[animeindex].ToString();

                if (chose_location.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = chose_location.SelectedPath;
                    string filename = chose_location.SelectedPath;

                    filename = animelist[animeindex].Remove(0, animelist[animeindex].LastIndexOf("\\") + 1);

                    string destinationfile = path + "\\" + filename;

                    MessageBox.Show(destinationfile);

                    try
                    {
                        File.Move(animelist[animeindex], destinationfile);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error while trying to move file: " + ex.Message);
                    }
                }

                delete_data(false, true);
                search_folders(false, true);
                
            }
        }

        private void inMarkiertenOrdnerVerschiebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lst_folders.SelectedIndex != -1 && lst_animefiles.SelectedIndex != -1)
            {
                string destinationfile;
                int folderindex = lst_folders.SelectedIndex;
                int animeindex = lst_animefiles.SelectedIndex;

                string filename = animelist[animeindex].Remove(0, animelist[animeindex].LastIndexOf("\\") + 1);


                destinationfile = folderlist[folderindex] + "\\" + filename;
                try
                {
                    File.Move(animelist[animeindex], destinationfile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while trying to move file: " + ex.Message);
                }
            }

            delete_data(false, true);
            search_folders(false, true);
        }

        private void namenÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lst_animefiles.SelectedIndex != -1)
            {
                int animeindex = lst_animefiles.SelectedIndex;

                string filename = animelist[animeindex];

                string destinationfile = animelist[animeindex].Remove(0, animelist[animeindex].LastIndexOf("\\") + 1);
                string path = animelist[animeindex].Remove(animelist[animeindex].LastIndexOf("\\") + 1);

                DialogResult inputchange = ShowInputDialog(ref destinationfile);               

                try
                {        
                    if(inputchange == DialogResult.OK)
                        File.Move(filename, path + destinationfile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                delete_data(false, true);
                search_folders(false, true);
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.StartPosition = FormStartPosition.Manual;

            inputBox.Location = new Point(MousePosition.X, MousePosition.Y);

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.ClientSize = size;
            inputBox.Text = "";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void lst_folders_MouseDown(object sender, MouseEventArgs e)
        {
            lst_folders.SelectedIndex = lst_folders.IndexFromPoint(e.X, e.Y);
        }

        private void toolStripMenuItemEntfernen_Click(object sender, EventArgs e)
        {
            if (lst_folders.SelectedIndex != -1)
            {
                int folderindex = lst_folders.SelectedIndex;

                folderlist.RemoveAt(folderindex);
                lst_folders.Items.RemoveAt(folderindex);
            }
        }

        private void toolStripMenuItemÄndern_Click(object sender, EventArgs e)
        {
            if (lst_folders.SelectedIndex != -1)
            {
                int folderindex = lst_folders.SelectedIndex;

                string foldername = folderlist[folderindex];

                string destinationfolder = folderlist[folderindex].Remove(0, folderlist[folderindex].LastIndexOf("\\") + 1);
                string path = folderlist[folderindex].Remove(folderlist[folderindex].LastIndexOf("\\") + 1);
                ShowInputDialog(ref destinationfolder);

                try
                {
                    Directory.Move(foldername, path + destinationfolder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                delete_data(true, false);
                search_folders(true, false);
            }
        }
    }
}

namespace AniSort
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_neuladen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lst_animefiles = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AusListeEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuellZuordnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filler = new System.Windows.Forms.Panel();
            this.lst_folders = new System.Windows.Forms.ListBox();
            this.inMarkiertenOrdnerVerschiebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_neuladen)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStripFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_location);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pic_neuladen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel1.Size = new System.Drawing.Size(569, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(518, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 25);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::AniSort.Properties.Resources.settings_512;
            this.pictureBox1.InitialImage = global::AniSort.Properties.Resources.settings_512;
            this.pictureBox1.Location = new System.Drawing.Point(531, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_location
            // 
            this.txt_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(106, 5);
            this.txt_location.Name = "txt_location";
            this.txt_location.ReadOnly = true;
            this.txt_location.Size = new System.Drawing.Size(412, 24);
            this.txt_location.TabIndex = 1;
            this.txt_location.Click += new System.EventHandler(this.txt_location_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_neuladen
            // 
            this.pic_neuladen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_neuladen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_neuladen.Image = ((System.Drawing.Image)(resources.GetObject("pic_neuladen.Image")));
            this.pic_neuladen.InitialImage = global::AniSort.Properties.Resources.settings_512;
            this.pic_neuladen.Location = new System.Drawing.Point(5, 5);
            this.pic_neuladen.Name = "pic_neuladen";
            this.pic_neuladen.Size = new System.Drawing.Size(36, 25);
            this.pic_neuladen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_neuladen.TabIndex = 4;
            this.pic_neuladen.TabStop = false;
            this.pic_neuladen.Click += new System.EventHandler(this.pic_neuladen_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(569, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Place files into folders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lst_folders);
            this.panel2.Controls.Add(this.lst_animefiles);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 369);
            this.panel2.TabIndex = 4;
            // 
            // lst_animefiles
            // 
            this.lst_animefiles.ContextMenuStrip = this.contextMenuStripFiles;
            this.lst_animefiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.lst_animefiles.FormattingEnabled = true;
            this.lst_animefiles.Location = new System.Drawing.Point(280, 28);
            this.lst_animefiles.Name = "lst_animefiles";
            this.lst_animefiles.Size = new System.Drawing.Size(289, 341);
            this.lst_animefiles.TabIndex = 6;
            this.lst_animefiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_animefiles_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 28);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Files";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStripFiles
            // 
            this.contextMenuStripFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AusListeEntfernenToolStripMenuItem,
            this.inMarkiertenOrdnerVerschiebenToolStripMenuItem,
            this.manuellZuordnenToolStripMenuItem});
            this.contextMenuStripFiles.Name = "contextMenuStripFiles";
            this.contextMenuStripFiles.Size = new System.Drawing.Size(251, 92);
            // 
            // AusListeEntfernenToolStripMenuItem
            // 
            this.AusListeEntfernenToolStripMenuItem.Name = "AusListeEntfernenToolStripMenuItem";
            this.AusListeEntfernenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AusListeEntfernenToolStripMenuItem.Text = "Aus Liste entfernen";
            this.AusListeEntfernenToolStripMenuItem.Click += new System.EventHandler(this.AusListeEntfernenToolStripMenuItem_Click);
            // 
            // manuellZuordnenToolStripMenuItem
            // 
            this.manuellZuordnenToolStripMenuItem.Name = "manuellZuordnenToolStripMenuItem";
            this.manuellZuordnenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manuellZuordnenToolStripMenuItem.Text = "Manuell zuordnen";
            this.manuellZuordnenToolStripMenuItem.Click += new System.EventHandler(this.manuellZuordnenToolStripMenuItem_Click);
            // 
            // filler
            // 
            this.filler.Dock = System.Windows.Forms.DockStyle.Top;
            this.filler.Location = new System.Drawing.Point(0, 30);
            this.filler.Name = "filler";
            this.filler.Size = new System.Drawing.Size(569, 5);
            this.filler.TabIndex = 6;
            // 
            // lst_folders
            // 
            this.lst_folders.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_folders.FormattingEnabled = true;
            this.lst_folders.Location = new System.Drawing.Point(0, 28);
            this.lst_folders.Name = "lst_folders";
            this.lst_folders.Size = new System.Drawing.Size(281, 341);
            this.lst_folders.TabIndex = 7;
            // 
            // inMarkiertenOrdnerVerschiebenToolStripMenuItem
            // 
            this.inMarkiertenOrdnerVerschiebenToolStripMenuItem.Name = "inMarkiertenOrdnerVerschiebenToolStripMenuItem";
            this.inMarkiertenOrdnerVerschiebenToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.inMarkiertenOrdnerVerschiebenToolStripMenuItem.Text = "In markierten Ordner verschieben";
            this.inMarkiertenOrdnerVerschiebenToolStripMenuItem.Click += new System.EventHandler(this.inMarkiertenOrdnerVerschiebenToolStripMenuItem_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "AniSort";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_neuladen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStripFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_neuladen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFiles;
        private System.Windows.Forms.ToolStripMenuItem AusListeEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuellZuordnenToolStripMenuItem;
        private System.Windows.Forms.ListBox lst_animefiles;
        private System.Windows.Forms.Panel filler;
        private System.Windows.Forms.ListBox lst_folders;
        private System.Windows.Forms.ToolStripMenuItem inMarkiertenOrdnerVerschiebenToolStripMenuItem;
    }
}


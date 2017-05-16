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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lst_animefiles = new System.Windows.Forms.ListView();
            this.lst_folders = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_location);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(569, 30);
            this.panel1.TabIndex = 0;
            // 
            // txt_location
            // 
            this.txt_location.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_location.Location = new System.Drawing.Point(70, 5);
            this.txt_location.Name = "txt_location";
            this.txt_location.ReadOnly = true;
            this.txt_location.Size = new System.Drawing.Size(487, 20);
            this.txt_location.TabIndex = 1;
            this.txt_location.Click += new System.EventHandler(this.txt_location_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_read
            // 
            this.btn_read.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(0, 30);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(569, 40);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Search for files";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
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
            this.panel2.Controls.Add(this.lst_animefiles);
            this.panel2.Controls.Add(this.lst_folders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 334);
            this.panel2.TabIndex = 4;
            // 
            // lst_animefiles
            // 
            this.lst_animefiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.lst_animefiles.Location = new System.Drawing.Point(271, 0);
            this.lst_animefiles.Name = "lst_animefiles";
            this.lst_animefiles.Size = new System.Drawing.Size(298, 334);
            this.lst_animefiles.TabIndex = 5;
            this.lst_animefiles.UseCompatibleStateImageBehavior = false;
            this.lst_animefiles.View = System.Windows.Forms.View.List;
            // 
            // lst_folders
            // 
            this.lst_folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_folders.Location = new System.Drawing.Point(0, 0);
            this.lst_folders.Name = "lst_folders";
            this.lst_folders.Size = new System.Drawing.Size(569, 334);
            this.lst_folders.TabIndex = 4;
            this.lst_folders.UseCompatibleStateImageBehavior = false;
            this.lst_folders.View = System.Windows.Forms.View.List;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "AniSort";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lst_folders;
        private System.Windows.Forms.ListView lst_animefiles;
    }
}


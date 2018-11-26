namespace Backup_GK
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Choose_Folder = new System.Windows.Forms.Button();
            this.Path_Desplay = new System.Windows.Forms.TextBox();
            this.Text_info_1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_Backup = new System.Windows.Forms.Button();
            this.Text_info_2 = new System.Windows.Forms.Label();
            this.button_Ping = new System.Windows.Forms.Button();
            this.Selected_HMI_1 = new System.Windows.Forms.CheckBox();
            this.Selected_HMI_2 = new System.Windows.Forms.CheckBox();
            this.Selected_HMI_3 = new System.Windows.Forms.CheckBox();
            this.PanelInfoBox = new System.Windows.Forms.TextBox();
            this.Selected_HMI_4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Choose_Folder
            // 
            this.Choose_Folder.Location = new System.Drawing.Point(428, 42);
            this.Choose_Folder.Name = "Choose_Folder";
            this.Choose_Folder.Size = new System.Drawing.Size(25, 20);
            this.Choose_Folder.TabIndex = 0;
            this.Choose_Folder.Text = "...";
            this.Choose_Folder.UseVisualStyleBackColor = true;
            this.Choose_Folder.Click += new System.EventHandler(this.Choose_Folder_Click);
            // 
            // Path_Desplay
            // 
            this.Path_Desplay.Location = new System.Drawing.Point(96, 42);
            this.Path_Desplay.Name = "Path_Desplay";
            this.Path_Desplay.ReadOnly = true;
            this.Path_Desplay.Size = new System.Drawing.Size(327, 20);
            this.Path_Desplay.TabIndex = 1;
            this.Path_Desplay.TextChanged += new System.EventHandler(this.Path_Desplay_TextChanged);
            // 
            // Text_info_1
            // 
            this.Text_info_1.AutoSize = true;
            this.Text_info_1.Location = new System.Drawing.Point(34, 45);
            this.Text_info_1.Name = "Text_info_1";
            this.Text_info_1.Size = new System.Drawing.Size(56, 13);
            this.Text_info_1.TabIndex = 2;
            this.Text_info_1.Text = "Zapisz do:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(301, 241);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 13);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button_Backup
            // 
            this.button_Backup.Location = new System.Drawing.Point(312, 68);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(111, 41);
            this.button_Backup.TabIndex = 4;
            this.button_Backup.Text = "Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // Text_info_2
            // 
            this.Text_info_2.AutoSize = true;
            this.Text_info_2.Location = new System.Drawing.Point(198, 241);
            this.Text_info_2.Name = "Text_info_2";
            this.Text_info_2.Size = new System.Drawing.Size(97, 13);
            this.Text_info_2.TabIndex = 5;
            this.Text_info_2.Text = "Postęp archiwizacji";
            this.Text_info_2.Click += new System.EventHandler(this.Text_info_2_Click);
            // 
            // button_Ping
            // 
            this.button_Ping.Location = new System.Drawing.Point(96, 68);
            this.button_Ping.Name = "button_Ping";
            this.button_Ping.Size = new System.Drawing.Size(111, 40);
            this.button_Ping.TabIndex = 7;
            this.button_Ping.Text = "Ping Panel";
            this.button_Ping.UseVisualStyleBackColor = true;
            this.button_Ping.Click += new System.EventHandler(this.button_Ping_Click);
            // 
            // Selected_HMI_1
            // 
            this.Selected_HMI_1.AutoSize = true;
            this.Selected_HMI_1.Location = new System.Drawing.Point(37, 133);
            this.Selected_HMI_1.Name = "Selected_HMI_1";
            this.Selected_HMI_1.Size = new System.Drawing.Size(67, 17);
            this.Selected_HMI_1.TabIndex = 8;
            this.Selected_HMI_1.Text = "HMI 1 ...";
            this.Selected_HMI_1.UseVisualStyleBackColor = true;
            this.Selected_HMI_1.CheckedChanged += new System.EventHandler(this.Selected_HMI_1_CheckedChanged);
            // 
            // Selected_HMI_2
            // 
            this.Selected_HMI_2.AutoSize = true;
            this.Selected_HMI_2.Location = new System.Drawing.Point(37, 156);
            this.Selected_HMI_2.Name = "Selected_HMI_2";
            this.Selected_HMI_2.Size = new System.Drawing.Size(67, 17);
            this.Selected_HMI_2.TabIndex = 9;
            this.Selected_HMI_2.Text = "HMI 2 ...";
            this.Selected_HMI_2.UseVisualStyleBackColor = true;
            this.Selected_HMI_2.CheckedChanged += new System.EventHandler(this.Selected_HMI_2_CheckedChanged);
            // 
            // Selected_HMI_3
            // 
            this.Selected_HMI_3.AutoSize = true;
            this.Selected_HMI_3.Location = new System.Drawing.Point(37, 179);
            this.Selected_HMI_3.Name = "Selected_HMI_3";
            this.Selected_HMI_3.Size = new System.Drawing.Size(67, 17);
            this.Selected_HMI_3.TabIndex = 10;
            this.Selected_HMI_3.Text = "HMI 3 ...";
            this.Selected_HMI_3.UseVisualStyleBackColor = true;
            this.Selected_HMI_3.CheckedChanged += new System.EventHandler(this.Selected_HMI_3_CheckedChanged);
            // 
            // PanelInfoBox
            // 
            this.PanelInfoBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PanelInfoBox.Location = new System.Drawing.Point(195, 133);
            this.PanelInfoBox.Multiline = true;
            this.PanelInfoBox.Name = "PanelInfoBox";
            this.PanelInfoBox.ReadOnly = true;
            this.PanelInfoBox.Size = new System.Drawing.Size(309, 86);
            this.PanelInfoBox.TabIndex = 11;
            this.PanelInfoBox.TextChanged += new System.EventHandler(this.PanelInfoBox_TextChanged);
            // 
            // Selected_HMI_4
            // 
            this.Selected_HMI_4.AutoSize = true;
            this.Selected_HMI_4.Location = new System.Drawing.Point(37, 202);
            this.Selected_HMI_4.Name = "Selected_HMI_4";
            this.Selected_HMI_4.Size = new System.Drawing.Size(67, 17);
            this.Selected_HMI_4.TabIndex = 12;
            this.Selected_HMI_4.Text = "HMI 4 ...";
            this.Selected_HMI_4.UseVisualStyleBackColor = true;
            this.Selected_HMI_4.CheckedChanged += new System.EventHandler(this.Selected_HMI_4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(516, 255);
            this.Controls.Add(this.Selected_HMI_4);
            this.Controls.Add(this.PanelInfoBox);
            this.Controls.Add(this.Selected_HMI_3);
            this.Controls.Add(this.Selected_HMI_2);
            this.Controls.Add(this.Selected_HMI_1);
            this.Controls.Add(this.button_Ping);
            this.Controls.Add(this.Text_info_2);
            this.Controls.Add(this.button_Backup);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Text_info_1);
            this.Controls.Add(this.Path_Desplay);
            this.Controls.Add(this.Choose_Folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMI Archive via LAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Choose_Folder;
        private System.Windows.Forms.TextBox Path_Desplay;
        private System.Windows.Forms.Label Text_info_1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Label Text_info_2;
        private System.Windows.Forms.Button button_Ping;
        private System.Windows.Forms.CheckBox Selected_HMI_1;
        private System.Windows.Forms.CheckBox Selected_HMI_2;
        private System.Windows.Forms.CheckBox Selected_HMI_3;
        private System.Windows.Forms.TextBox PanelInfoBox;
        private System.Windows.Forms.CheckBox Selected_HMI_4;
    }
}


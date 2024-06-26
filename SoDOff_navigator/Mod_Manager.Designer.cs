﻿namespace SoDOff_navigator
{
    partial class Mod_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mod_Manager));
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_mod_author = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.listBox_mods = new System.Windows.Forms.ListBox();
            this.label_mods_list = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_direct_dl = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_install = new System.Windows.Forms.Button();
            this.label_dependency = new System.Windows.Forms.Label();
            this.label_install_path = new System.Windows.Forms.Label();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.label_mod_name = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.btn_update_mods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_author
            // 
            this.comboBox_author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_author.FormattingEnabled = true;
            this.comboBox_author.Location = new System.Drawing.Point(21, 37);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(124, 21);
            this.comboBox_author.TabIndex = 0;
            this.comboBox_author.SelectedIndexChanged += new System.EventHandler(this.comboBox_author_SelectedIndexChanged);
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(21, 85);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(124, 21);
            this.comboBox_category.TabIndex = 1;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label_mod_author
            // 
            this.label_mod_author.AutoSize = true;
            this.label_mod_author.Location = new System.Drawing.Point(21, 18);
            this.label_mod_author.Name = "label_mod_author";
            this.label_mod_author.Size = new System.Drawing.Size(62, 13);
            this.label_mod_author.TabIndex = 2;
            this.label_mod_author.Text = "Mod Author";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Location = new System.Drawing.Point(21, 66);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(49, 13);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            // 
            // listBox_mods
            // 
            this.listBox_mods.FormattingEnabled = true;
            this.listBox_mods.Location = new System.Drawing.Point(24, 139);
            this.listBox_mods.Name = "listBox_mods";
            this.listBox_mods.Size = new System.Drawing.Size(292, 147);
            this.listBox_mods.TabIndex = 4;
            this.listBox_mods.SelectedIndexChanged += new System.EventHandler(this.listBox_mods_SelectedIndexChanged);
            // 
            // label_mods_list
            // 
            this.label_mods_list.AutoSize = true;
            this.label_mods_list.Location = new System.Drawing.Point(24, 120);
            this.label_mods_list.Name = "label_mods_list";
            this.label_mods_list.Size = new System.Drawing.Size(51, 13);
            this.label_mods_list.TabIndex = 5;
            this.label_mods_list.Text = "Mods list:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(19, 337);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(63, 13);
            this.label_description.TabIndex = 6;
            this.label_description.Text = "Description:";
            // 
            // label_direct_dl
            // 
            this.label_direct_dl.AutoSize = true;
            this.label_direct_dl.Location = new System.Drawing.Point(19, 373);
            this.label_direct_dl.Name = "label_direct_dl";
            this.label_direct_dl.Size = new System.Drawing.Size(87, 13);
            this.label_direct_dl.TabIndex = 7;
            this.label_direct_dl.Text = "Direct download:";
            // 
            // btn_download
            // 
            this.btn_download.Enabled = false;
            this.btn_download.Location = new System.Drawing.Point(58, 408);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(75, 35);
            this.btn_download.TabIndex = 8;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Visible = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(195, 408);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(75, 35);
            this.btn_install.TabIndex = 9;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // label_dependency
            // 
            this.label_dependency.AutoSize = true;
            this.label_dependency.Location = new System.Drawing.Point(19, 355);
            this.label_dependency.Name = "label_dependency";
            this.label_dependency.Size = new System.Drawing.Size(71, 13);
            this.label_dependency.TabIndex = 10;
            this.label_dependency.Text = "Depencendy:";
            // 
            // label_install_path
            // 
            this.label_install_path.AutoSize = true;
            this.label_install_path.Location = new System.Drawing.Point(196, 18);
            this.label_install_path.Name = "label_install_path";
            this.label_install_path.Size = new System.Drawing.Size(115, 13);
            this.label_install_path.TabIndex = 11;
            this.label_install_path.Text = "Choose client to install:";
            // 
            // comboBox_client
            // 
            this.comboBox_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(195, 37);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(124, 21);
            this.comboBox_client.TabIndex = 12;
            // 
            // label_mod_name
            // 
            this.label_mod_name.AutoSize = true;
            this.label_mod_name.Location = new System.Drawing.Point(19, 301);
            this.label_mod_name.Name = "label_mod_name";
            this.label_mod_name.Size = new System.Drawing.Size(60, 13);
            this.label_mod_name.TabIndex = 13;
            this.label_mod_name.Text = "Mod name:";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(19, 319);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(41, 13);
            this.label_author.TabIndex = 14;
            this.label_author.Text = "Author:";
            // 
            // btn_update_mods
            // 
            this.btn_update_mods.Location = new System.Drawing.Point(58, 408);
            this.btn_update_mods.Name = "btn_update_mods";
            this.btn_update_mods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_mods.Size = new System.Drawing.Size(87, 35);
            this.btn_update_mods.TabIndex = 15;
            this.btn_update_mods.Text = "Update-Mods";
            this.btn_update_mods.UseVisualStyleBackColor = true;
            this.btn_update_mods.Click += new System.EventHandler(this.btn_update_mods_Click);
            // 
            // Mod_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 462);
            this.Controls.Add(this.btn_update_mods);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_mod_name);
            this.Controls.Add(this.comboBox_client);
            this.Controls.Add(this.label_install_path);
            this.Controls.Add(this.label_dependency);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.label_direct_dl);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_mods_list);
            this.Controls.Add(this.listBox_mods);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_mod_author);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.comboBox_author);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mod_Manager";
            this.Text = "ModManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_mod_author;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ListBox listBox_mods;
        private System.Windows.Forms.Label label_mods_list;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_direct_dl;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Label label_dependency;
        private System.Windows.Forms.Label label_install_path;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.Label label_mod_name;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Button btn_update_mods;
    }
}
﻿namespace SuperShopMainV1._00
{
    partial class Confirmpay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmpay));
            this.listBoxitem = new System.Windows.Forms.ListBox();
            this.Login_PictureBox = new System.Windows.Forms.PictureBox();
            this.payconfirmpanel = new System.Windows.Forms.Panel();
            this.totalpayconfirmlable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recieved = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.paymentmethodselector = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RoleSelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).BeginInit();
            this.payconfirmpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxitem
            // 
            this.listBoxitem.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.listBoxitem, "listBoxitem");
            this.listBoxitem.FormattingEnabled = true;
            this.listBoxitem.Name = "listBoxitem";
            // 
            // Login_PictureBox
            // 
            this.Login_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_PictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Login_PictureBox, "Login_PictureBox");
            this.Login_PictureBox.Name = "Login_PictureBox";
            this.Login_PictureBox.TabStop = false;
            // 
            // payconfirmpanel
            // 
            this.payconfirmpanel.BackColor = System.Drawing.SystemColors.Info;
            this.payconfirmpanel.Controls.Add(this.button1);
            this.payconfirmpanel.Controls.Add(this.RoleSelect);
            this.payconfirmpanel.Controls.Add(this.paymentmethodselector);
            this.payconfirmpanel.Controls.Add(this.textBox2);
            this.payconfirmpanel.Controls.Add(this.recieved);
            this.payconfirmpanel.Controls.Add(this.textBox1);
            this.payconfirmpanel.Controls.Add(this.totalpayconfirmlable);
            resources.ApplyResources(this.payconfirmpanel, "payconfirmpanel");
            this.payconfirmpanel.Name = "payconfirmpanel";
            this.payconfirmpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // totalpayconfirmlable
            // 
            resources.ApplyResources(this.totalpayconfirmlable, "totalpayconfirmlable");
            this.totalpayconfirmlable.Name = "totalpayconfirmlable";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // recieved
            // 
            resources.ApplyResources(this.recieved, "recieved");
            this.recieved.Name = "recieved";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // paymentmethodselector
            // 
            resources.ApplyResources(this.paymentmethodselector, "paymentmethodselector");
            this.paymentmethodselector.Name = "paymentmethodselector";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // RoleSelect
            // 
            resources.ApplyResources(this.RoleSelect, "RoleSelect");
            this.RoleSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.RoleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleSelect.FormattingEnabled = true;
            this.RoleSelect.Items.AddRange(new object[] {
            resources.GetString("RoleSelect.Items"),
            resources.GetString("RoleSelect.Items1"),
            resources.GetString("RoleSelect.Items2"),
            resources.GetString("RoleSelect.Items3"),
            resources.GetString("RoleSelect.Items4")});
            this.RoleSelect.Name = "RoleSelect";
            this.RoleSelect.SelectedIndexChanged += new System.EventHandler(this.RoleSelect_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Confirmpay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperShopMainV1._00.Properties.Resources.background1;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.payconfirmpanel);
            this.Controls.Add(this.Login_PictureBox);
            this.Controls.Add(this.listBoxitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmpay";
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).EndInit();
            this.payconfirmpanel.ResumeLayout(false);
            this.payconfirmpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxitem;
        private System.Windows.Forms.PictureBox Login_PictureBox;
        private System.Windows.Forms.Panel payconfirmpanel;
        private System.Windows.Forms.Label totalpayconfirmlable;
        private System.Windows.Forms.Label recieved;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label paymentmethodselector;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox RoleSelect;
    }
}
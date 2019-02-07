namespace OOCA2
{
    partial class Form1
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
            this.lstbx_inventory = new System.Windows.Forms.ListBox();
            this.lbl_listbx = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobtn_yellow = new System.Windows.Forms.RadioButton();
            this.rdobtn_Blue = new System.Windows.Forms.RadioButton();
            this.rdobtn_red = new System.Windows.Forms.RadioButton();
            this.grpbx_details = new System.Windows.Forms.GroupBox();
            this.chbx_date = new System.Windows.Forms.CheckBox();
            this.chbx_name = new System.Windows.Forms.CheckBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.picbx_yellowShirt = new System.Windows.Forms.PictureBox();
            this.picbx_yellowCar = new System.Windows.Forms.PictureBox();
            this.picbx_yellowShoe = new System.Windows.Forms.PictureBox();
            this.picbx_blueShirt = new System.Windows.Forms.PictureBox();
            this.picbx_blueCar = new System.Windows.Forms.PictureBox();
            this.picbx_blueShoe = new System.Windows.Forms.PictureBox();
            this.picBx_redShoe = new System.Windows.Forms.PictureBox();
            this.picbx_redShirt = new System.Windows.Forms.PictureBox();
            this.picbx_redCar = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbx_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_yellowShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_yellowCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_yellowShoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_blueShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_blueCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_blueShoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_redShoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_redShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_redCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbx_inventory
            // 
            this.lstbx_inventory.FormattingEnabled = true;
            this.lstbx_inventory.ItemHeight = 31;
            this.lstbx_inventory.Items.AddRange(new object[] {
            "Shoe",
            "T-Shirt",
            "Car"});
            this.lstbx_inventory.Location = new System.Drawing.Point(112, 119);
            this.lstbx_inventory.Name = "lstbx_inventory";
            this.lstbx_inventory.Size = new System.Drawing.Size(158, 97);
            this.lstbx_inventory.TabIndex = 0;
            // 
            // lbl_listbx
            // 
            this.lbl_listbx.AutoSize = true;
            this.lbl_listbx.Location = new System.Drawing.Point(102, 50);
            this.lbl_listbx.Name = "lbl_listbx";
            this.lbl_listbx.Size = new System.Drawing.Size(168, 32);
            this.lbl_listbx.TabIndex = 1;
            this.lbl_listbx.Text = "Choose one";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_yellow);
            this.groupBox1.Controls.Add(this.rdobtn_Blue);
            this.groupBox1.Controls.Add(this.rdobtn_red);
            this.groupBox1.Location = new System.Drawing.Point(112, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a color";
            // 
            // rdobtn_yellow
            // 
            this.rdobtn_yellow.AutoSize = true;
            this.rdobtn_yellow.Location = new System.Drawing.Point(26, 196);
            this.rdobtn_yellow.Name = "rdobtn_yellow";
            this.rdobtn_yellow.Size = new System.Drawing.Size(137, 36);
            this.rdobtn_yellow.TabIndex = 2;
            this.rdobtn_yellow.TabStop = true;
            this.rdobtn_yellow.Text = "Yellow";
            this.rdobtn_yellow.UseVisualStyleBackColor = true;
            // 
            // rdobtn_Blue
            // 
            this.rdobtn_Blue.AutoSize = true;
            this.rdobtn_Blue.Location = new System.Drawing.Point(26, 125);
            this.rdobtn_Blue.Name = "rdobtn_Blue";
            this.rdobtn_Blue.Size = new System.Drawing.Size(110, 36);
            this.rdobtn_Blue.TabIndex = 1;
            this.rdobtn_Blue.TabStop = true;
            this.rdobtn_Blue.Text = "Blue";
            this.rdobtn_Blue.UseVisualStyleBackColor = true;
            // 
            // rdobtn_red
            // 
            this.rdobtn_red.AutoSize = true;
            this.rdobtn_red.Location = new System.Drawing.Point(26, 54);
            this.rdobtn_red.Name = "rdobtn_red";
            this.rdobtn_red.Size = new System.Drawing.Size(104, 36);
            this.rdobtn_red.TabIndex = 0;
            this.rdobtn_red.TabStop = true;
            this.rdobtn_red.Text = "Red";
            this.rdobtn_red.UseVisualStyleBackColor = true;
            // 
            // grpbx_details
            // 
            this.grpbx_details.Controls.Add(this.chbx_date);
            this.grpbx_details.Controls.Add(this.chbx_name);
            this.grpbx_details.Location = new System.Drawing.Point(112, 564);
            this.grpbx_details.Name = "grpbx_details";
            this.grpbx_details.Size = new System.Drawing.Size(337, 149);
            this.grpbx_details.TabIndex = 3;
            this.grpbx_details.TabStop = false;
            this.grpbx_details.Text = "Select details";
            // 
            // chbx_date
            // 
            this.chbx_date.AutoSize = true;
            this.chbx_date.Location = new System.Drawing.Point(26, 107);
            this.chbx_date.Name = "chbx_date";
            this.chbx_date.Size = new System.Drawing.Size(113, 36);
            this.chbx_date.TabIndex = 1;
            this.chbx_date.Text = "Date";
            this.chbx_date.UseVisualStyleBackColor = true;
            // 
            // chbx_name
            // 
            this.chbx_name.AutoSize = true;
            this.chbx_name.Location = new System.Drawing.Point(26, 38);
            this.chbx_name.Name = "chbx_name";
            this.chbx_name.Size = new System.Drawing.Size(128, 36);
            this.chbx_name.TabIndex = 0;
            this.chbx_name.Text = "Name";
            this.chbx_name.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(697, 683);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(154, 90);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(975, 683);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(154, 90);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // picbx_yellowShirt
            // 
            this.picbx_yellowShirt.Image = global::OOCA2.Properties.Resources.yellowShirt;
            this.picbx_yellowShirt.Location = new System.Drawing.Point(697, 119);
            this.picbx_yellowShirt.Name = "picbx_yellowShirt";
            this.picbx_yellowShirt.Size = new System.Drawing.Size(432, 391);
            this.picbx_yellowShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_yellowShirt.TabIndex = 14;
            this.picbx_yellowShirt.TabStop = false;
            // 
            // picbx_yellowCar
            // 
            this.picbx_yellowCar.Image = global::OOCA2.Properties.Resources.yellowCar;
            this.picbx_yellowCar.Location = new System.Drawing.Point(697, 119);
            this.picbx_yellowCar.Name = "picbx_yellowCar";
            this.picbx_yellowCar.Size = new System.Drawing.Size(432, 391);
            this.picbx_yellowCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_yellowCar.TabIndex = 13;
            this.picbx_yellowCar.TabStop = false;
            // 
            // picbx_yellowShoe
            // 
            this.picbx_yellowShoe.Image = global::OOCA2.Properties.Resources.yellowShoe;
            this.picbx_yellowShoe.Location = new System.Drawing.Point(697, 119);
            this.picbx_yellowShoe.Name = "picbx_yellowShoe";
            this.picbx_yellowShoe.Size = new System.Drawing.Size(432, 391);
            this.picbx_yellowShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_yellowShoe.TabIndex = 12;
            this.picbx_yellowShoe.TabStop = false;
            // 
            // picbx_blueShirt
            // 
            this.picbx_blueShirt.Image = global::OOCA2.Properties.Resources.blueShirt;
            this.picbx_blueShirt.Location = new System.Drawing.Point(697, 119);
            this.picbx_blueShirt.Name = "picbx_blueShirt";
            this.picbx_blueShirt.Size = new System.Drawing.Size(432, 391);
            this.picbx_blueShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_blueShirt.TabIndex = 11;
            this.picbx_blueShirt.TabStop = false;
            // 
            // picbx_blueCar
            // 
            this.picbx_blueCar.Image = global::OOCA2.Properties.Resources.blueCar2;
            this.picbx_blueCar.Location = new System.Drawing.Point(697, 119);
            this.picbx_blueCar.Name = "picbx_blueCar";
            this.picbx_blueCar.Size = new System.Drawing.Size(432, 391);
            this.picbx_blueCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_blueCar.TabIndex = 10;
            this.picbx_blueCar.TabStop = false;
            // 
            // picbx_blueShoe
            // 
            this.picbx_blueShoe.Image = global::OOCA2.Properties.Resources.BlueShoe;
            this.picbx_blueShoe.Location = new System.Drawing.Point(697, 119);
            this.picbx_blueShoe.Name = "picbx_blueShoe";
            this.picbx_blueShoe.Size = new System.Drawing.Size(432, 391);
            this.picbx_blueShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_blueShoe.TabIndex = 9;
            this.picbx_blueShoe.TabStop = false;
            // 
            // picBx_redShoe
            // 
            this.picBx_redShoe.Image = global::OOCA2.Properties.Resources.RedVans;
            this.picBx_redShoe.Location = new System.Drawing.Point(697, 119);
            this.picBx_redShoe.Name = "picBx_redShoe";
            this.picBx_redShoe.Size = new System.Drawing.Size(432, 391);
            this.picBx_redShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx_redShoe.TabIndex = 6;
            this.picBx_redShoe.TabStop = false;
            // 
            // picbx_redShirt
            // 
            this.picbx_redShirt.Image = global::OOCA2.Properties.Resources.RedShirt;
            this.picbx_redShirt.Location = new System.Drawing.Point(697, 119);
            this.picbx_redShirt.Name = "picbx_redShirt";
            this.picbx_redShirt.Size = new System.Drawing.Size(432, 391);
            this.picbx_redShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_redShirt.TabIndex = 8;
            this.picbx_redShirt.TabStop = false;
            // 
            // picbx_redCar
            // 
            this.picbx_redCar.Image = global::OOCA2.Properties.Resources.RedCar;
            this.picbx_redCar.Location = new System.Drawing.Point(697, 119);
            this.picbx_redCar.Name = "picbx_redCar";
            this.picbx_redCar.Size = new System.Drawing.Size(432, 391);
            this.picbx_redCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_redCar.TabIndex = 7;
            this.picbx_redCar.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(697, 527);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 32);
            this.lbl_name.TabIndex = 15;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(697, 564);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(127, 32);
            this.lbl_date.TabIndex = 16;
            this.lbl_date.Text = "2/6/2019";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 828);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.picbx_yellowCar);
            this.Controls.Add(this.picbx_yellowShoe);
            this.Controls.Add(this.picbx_blueShirt);
            this.Controls.Add(this.picbx_blueCar);
            this.Controls.Add(this.picbx_blueShoe);
            this.Controls.Add(this.picBx_redShoe);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.grpbx_details);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_listbx);
            this.Controls.Add(this.lstbx_inventory);
            this.Controls.Add(this.picbx_redShirt);
            this.Controls.Add(this.picbx_redCar);
            this.Controls.Add(this.picbx_yellowShirt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbx_details.ResumeLayout(false);
            this.grpbx_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_yellowShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_yellowCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_yellowShoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_blueShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_blueCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_blueShoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_redShoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_redShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_redCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_inventory;
        private System.Windows.Forms.Label lbl_listbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtn_yellow;
        private System.Windows.Forms.RadioButton rdobtn_Blue;
        private System.Windows.Forms.RadioButton rdobtn_red;
        private System.Windows.Forms.GroupBox grpbx_details;
        private System.Windows.Forms.CheckBox chbx_date;
        private System.Windows.Forms.CheckBox chbx_name;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox picBx_redShoe;
        private System.Windows.Forms.PictureBox picbx_redCar;
        private System.Windows.Forms.PictureBox picbx_redShirt;
        private System.Windows.Forms.PictureBox picbx_blueShoe;
        private System.Windows.Forms.PictureBox picbx_blueCar;
        private System.Windows.Forms.PictureBox picbx_blueShirt;
        private System.Windows.Forms.PictureBox picbx_yellowShoe;
        private System.Windows.Forms.PictureBox picbx_yellowCar;
        private System.Windows.Forms.PictureBox picbx_yellowShirt;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
    }
}


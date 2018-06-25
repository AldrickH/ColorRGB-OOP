namespace ColorRGB
{
    partial class FrmColor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pBox_Color = new System.Windows.Forms.PictureBox();
            this.txtLbl_Blue = new System.Windows.Forms.Label();
            this.txtLbl_Green = new System.Windows.Forms.Label();
            this.txtLbl_Red = new System.Windows.Forms.Label();
            this.txtName_Blue = new System.Windows.Forms.Label();
            this.txtName_Green = new System.Windows.Forms.Label();
            this.txtName_Red = new System.Windows.Forms.Label();
            this.scrlBar_Blue = new System.Windows.Forms.HScrollBar();
            this.scrlBar_Green = new System.Windows.Forms.HScrollBar();
            this.scrlBar_Red = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pBox_Color);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLbl_Blue);
            this.splitContainer1.Panel2.Controls.Add(this.txtLbl_Green);
            this.splitContainer1.Panel2.Controls.Add(this.txtLbl_Red);
            this.splitContainer1.Panel2.Controls.Add(this.txtName_Blue);
            this.splitContainer1.Panel2.Controls.Add(this.txtName_Green);
            this.splitContainer1.Panel2.Controls.Add(this.txtName_Red);
            this.splitContainer1.Panel2.Controls.Add(this.scrlBar_Blue);
            this.splitContainer1.Panel2.Controls.Add(this.scrlBar_Green);
            this.splitContainer1.Panel2.Controls.Add(this.scrlBar_Red);
            this.splitContainer1.Size = new System.Drawing.Size(779, 450);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // pBox_Color
            // 
            this.pBox_Color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBox_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_Color.Location = new System.Drawing.Point(0, 0);
            this.pBox_Color.Name = "pBox_Color";
            this.pBox_Color.Size = new System.Drawing.Size(779, 185);
            this.pBox_Color.TabIndex = 0;
            this.pBox_Color.TabStop = false;
            // 
            // txtLbl_Blue
            // 
            this.txtLbl_Blue.AutoSize = true;
            this.txtLbl_Blue.Location = new System.Drawing.Point(725, 175);
            this.txtLbl_Blue.Name = "txtLbl_Blue";
            this.txtLbl_Blue.Size = new System.Drawing.Size(16, 17);
            this.txtLbl_Blue.TabIndex = 2;
            this.txtLbl_Blue.Text = "0";
            // 
            // txtLbl_Green
            // 
            this.txtLbl_Green.AutoSize = true;
            this.txtLbl_Green.Location = new System.Drawing.Point(725, 102);
            this.txtLbl_Green.Name = "txtLbl_Green";
            this.txtLbl_Green.Size = new System.Drawing.Size(16, 17);
            this.txtLbl_Green.TabIndex = 2;
            this.txtLbl_Green.Text = "0";
            // 
            // txtLbl_Red
            // 
            this.txtLbl_Red.AutoSize = true;
            this.txtLbl_Red.Location = new System.Drawing.Point(725, 19);
            this.txtLbl_Red.Name = "txtLbl_Red";
            this.txtLbl_Red.Size = new System.Drawing.Size(16, 17);
            this.txtLbl_Red.TabIndex = 2;
            this.txtLbl_Red.Text = "0";
            // 
            // txtName_Blue
            // 
            this.txtName_Blue.AutoSize = true;
            this.txtName_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Blue.Location = new System.Drawing.Point(12, 209);
            this.txtName_Blue.Name = "txtName_Blue";
            this.txtName_Blue.Size = new System.Drawing.Size(62, 24);
            this.txtName_Blue.TabIndex = 1;
            this.txtName_Blue.Text = "BLUE";
            // 
            // txtName_Green
            // 
            this.txtName_Green.AutoSize = true;
            this.txtName_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Green.Location = new System.Drawing.Point(12, 136);
            this.txtName_Green.Name = "txtName_Green";
            this.txtName_Green.Size = new System.Drawing.Size(82, 24);
            this.txtName_Green.TabIndex = 1;
            this.txtName_Green.Text = "GREEN";
            // 
            // txtName_Red
            // 
            this.txtName_Red.AutoSize = true;
            this.txtName_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Red.Location = new System.Drawing.Point(12, 62);
            this.txtName_Red.Name = "txtName_Red";
            this.txtName_Red.Size = new System.Drawing.Size(52, 24);
            this.txtName_Red.TabIndex = 1;
            this.txtName_Red.Text = "RED";
            // 
            // scrlBar_Blue
            // 
            this.scrlBar_Blue.LargeChange = 0;
            this.scrlBar_Blue.Location = new System.Drawing.Point(97, 192);
            this.scrlBar_Blue.Maximum = 255;
            this.scrlBar_Blue.Name = "scrlBar_Blue";
            this.scrlBar_Blue.Size = new System.Drawing.Size(644, 41);
            this.scrlBar_Blue.SmallChange = 0;
            this.scrlBar_Blue.TabIndex = 0;
            this.scrlBar_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorChange);
            // 
            // scrlBar_Green
            // 
            this.scrlBar_Green.LargeChange = 0;
            this.scrlBar_Green.Location = new System.Drawing.Point(97, 119);
            this.scrlBar_Green.Maximum = 255;
            this.scrlBar_Green.Name = "scrlBar_Green";
            this.scrlBar_Green.Size = new System.Drawing.Size(644, 41);
            this.scrlBar_Green.SmallChange = 0;
            this.scrlBar_Green.TabIndex = 0;
            this.scrlBar_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorChange);
            // 
            // scrlBar_Red
            // 
            this.scrlBar_Red.LargeChange = 0;
            this.scrlBar_Red.Location = new System.Drawing.Point(97, 45);
            this.scrlBar_Red.Maximum = 255;
            this.scrlBar_Red.Name = "scrlBar_Red";
            this.scrlBar_Red.Size = new System.Drawing.Size(644, 41);
            this.scrlBar_Red.SmallChange = 0;
            this.scrlBar_Red.TabIndex = 0;
            this.scrlBar_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorChange);
            // 
            // FrmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pBox_Color;
        private System.Windows.Forms.HScrollBar scrlBar_Red;
        private System.Windows.Forms.Label txtName_Red;
        private System.Windows.Forms.HScrollBar scrlBar_Blue;
        private System.Windows.Forms.HScrollBar scrlBar_Green;
        private System.Windows.Forms.Label txtLbl_Blue;
        private System.Windows.Forms.Label txtLbl_Green;
        private System.Windows.Forms.Label txtLbl_Red;
        private System.Windows.Forms.Label txtName_Blue;
        private System.Windows.Forms.Label txtName_Green;
    }
}


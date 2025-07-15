namespace Figure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnSizeMinus = new System.Windows.Forms.Button();
            this.BtnSizePlus = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.pictureBoxParalelogram = new System.Windows.Forms.PictureBox();
            this.pictureBoxCube = new System.Windows.Forms.PictureBox();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommonTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxEquilTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrapeze = new System.Windows.Forms.PictureBox();
            this.pictureBoxRomb = new System.Windows.Forms.PictureBox();
            this.pictureBoxRctngl = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParalelogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquilTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrapeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRctngl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnSquare);
            this.panel1.Controls.Add(this.BtnSizeMinus);
            this.panel1.Controls.Add(this.BtnSizePlus);
            this.panel1.Controls.Add(this.BtnDown);
            this.panel1.Controls.Add(this.BtnRight);
            this.panel1.Controls.Add(this.BtnLeft);
            this.panel1.Controls.Add(this.BtnUp);
            this.panel1.Controls.Add(this.pictureBoxParalelogram);
            this.panel1.Controls.Add(this.pictureBoxCube);
            this.panel1.Controls.Add(this.pictureBoxEllipse);
            this.panel1.Controls.Add(this.pictureBoxCommonTriangle);
            this.panel1.Controls.Add(this.pictureBoxEquilTriangle);
            this.panel1.Controls.Add(this.pictureBoxRectTriangle);
            this.panel1.Controls.Add(this.pictureBoxTrapeze);
            this.panel1.Controls.Add(this.pictureBoxRomb);
            this.panel1.Controls.Add(this.pictureBoxRctngl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 142);
            this.panel1.TabIndex = 1;
            // 
            // BtnSquare
            // 
            this.BtnSquare.Location = new System.Drawing.Point(284, 77);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(116, 37);
            this.BtnSquare.TabIndex = 17;
            this.BtnSquare.Text = "Total Square";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSizeMinus
            // 
            this.BtnSizeMinus.Location = new System.Drawing.Point(144, 77);
            this.BtnSizeMinus.Name = "BtnSizeMinus";
            this.BtnSizeMinus.Size = new System.Drawing.Size(123, 37);
            this.BtnSizeMinus.TabIndex = 16;
            this.BtnSizeMinus.Text = "-Size";
            this.BtnSizeMinus.UseVisualStyleBackColor = true;
            this.BtnSizeMinus.Click += new System.EventHandler(this.BtnSizeMinus_Click);
            // 
            // BtnSizePlus
            // 
            this.BtnSizePlus.Location = new System.Drawing.Point(12, 77);
            this.BtnSizePlus.Name = "BtnSizePlus";
            this.BtnSizePlus.Size = new System.Drawing.Size(116, 37);
            this.BtnSizePlus.TabIndex = 15;
            this.BtnSizePlus.Text = "+Size";
            this.BtnSizePlus.UseVisualStyleBackColor = true;
            this.BtnSizePlus.Click += new System.EventHandler(this.BtnSizePlus_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(816, 96);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(106, 43);
            this.BtnDown.TabIndex = 14;
            this.BtnDown.Text = "v";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(928, 47);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(106, 43);
            this.BtnRight.TabIndex = 13;
            this.BtnRight.Text = ">";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(704, 47);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(106, 43);
            this.BtnLeft.TabIndex = 12;
            this.BtnLeft.Text = "<";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(816, 4);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(106, 43);
            this.BtnUp.TabIndex = 11;
            this.BtnUp.Text = "^";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // pictureBoxParalelogram
            // 
            this.pictureBoxParalelogram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxParalelogram.Image")));
            this.pictureBoxParalelogram.Location = new System.Drawing.Point(504, 3);
            this.pictureBoxParalelogram.Name = "pictureBoxParalelogram";
            this.pictureBoxParalelogram.Size = new System.Drawing.Size(58, 44);
            this.pictureBoxParalelogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxParalelogram.TabIndex = 3;
            this.pictureBoxParalelogram.TabStop = false;
            this.pictureBoxParalelogram.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxCube
            // 
            this.pictureBoxCube.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCube.Image")));
            this.pictureBoxCube.Location = new System.Drawing.Point(413, 3);
            this.pictureBoxCube.Name = "pictureBoxCube";
            this.pictureBoxCube.Size = new System.Drawing.Size(64, 44);
            this.pictureBoxCube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCube.TabIndex = 10;
            this.pictureBoxCube.TabStop = false;
            this.pictureBoxCube.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEllipse.Image")));
            this.pictureBoxEllipse.Location = new System.Drawing.Point(342, 3);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(50, 44);
            this.pictureBoxEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEllipse.TabIndex = 9;
            this.pictureBoxEllipse.TabStop = false;
            this.pictureBoxEllipse.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxCommonTriangle
            // 
            this.pictureBoxCommonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCommonTriangle.Image")));
            this.pictureBoxCommonTriangle.Location = new System.Drawing.Point(284, 3);
            this.pictureBoxCommonTriangle.Name = "pictureBoxCommonTriangle";
            this.pictureBoxCommonTriangle.Size = new System.Drawing.Size(39, 44);
            this.pictureBoxCommonTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCommonTriangle.TabIndex = 7;
            this.pictureBoxCommonTriangle.TabStop = false;
            this.pictureBoxCommonTriangle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxEquilTriangle
            // 
            this.pictureBoxEquilTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEquilTriangle.Image")));
            this.pictureBoxEquilTriangle.Location = new System.Drawing.Point(229, 3);
            this.pictureBoxEquilTriangle.Name = "pictureBoxEquilTriangle";
            this.pictureBoxEquilTriangle.Size = new System.Drawing.Size(38, 44);
            this.pictureBoxEquilTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEquilTriangle.TabIndex = 6;
            this.pictureBoxEquilTriangle.TabStop = false;
            this.pictureBoxEquilTriangle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxRectTriangle
            // 
            this.pictureBoxRectTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRectTriangle.Image")));
            this.pictureBoxRectTriangle.Location = new System.Drawing.Point(175, 3);
            this.pictureBoxRectTriangle.Name = "pictureBoxRectTriangle";
            this.pictureBoxRectTriangle.Size = new System.Drawing.Size(48, 44);
            this.pictureBoxRectTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRectTriangle.TabIndex = 5;
            this.pictureBoxRectTriangle.TabStop = false;
            this.pictureBoxRectTriangle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxTrapeze
            // 
            this.pictureBoxTrapeze.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrapeze.Image")));
            this.pictureBoxTrapeze.Location = new System.Drawing.Point(109, 3);
            this.pictureBoxTrapeze.Name = "pictureBoxTrapeze";
            this.pictureBoxTrapeze.Size = new System.Drawing.Size(60, 44);
            this.pictureBoxTrapeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrapeze.TabIndex = 4;
            this.pictureBoxTrapeze.TabStop = false;
            this.pictureBoxTrapeze.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxRomb
            // 
            this.pictureBoxRomb.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRomb.Image")));
            this.pictureBoxRomb.Location = new System.Drawing.Point(54, 3);
            this.pictureBoxRomb.Name = "pictureBoxRomb";
            this.pictureBoxRomb.Size = new System.Drawing.Size(39, 44);
            this.pictureBoxRomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRomb.TabIndex = 3;
            this.pictureBoxRomb.TabStop = false;
            this.pictureBoxRomb.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxRctngl
            // 
            this.pictureBoxRctngl.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRctngl.Image")));
            this.pictureBoxRctngl.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRctngl.Name = "pictureBoxRctngl";
            this.pictureBoxRctngl.Size = new System.Drawing.Size(45, 44);
            this.pictureBoxRctngl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRctngl.TabIndex = 2;
            this.pictureBoxRctngl.TabStop = false;
            this.pictureBoxRctngl.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 492);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(422, 77);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 37);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(539, 77);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(91, 37);
            this.BtnLoad.TabIndex = 19;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParalelogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquilTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrapeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRctngl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxRctngl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxRomb;
        private System.Windows.Forms.PictureBox pictureBoxTrapeze;
        private System.Windows.Forms.PictureBox pictureBoxRectTriangle;
        private System.Windows.Forms.PictureBox pictureBoxEquilTriangle;
        private System.Windows.Forms.PictureBox pictureBoxCommonTriangle;
        private System.Windows.Forms.PictureBox pictureBoxEllipse;
        private System.Windows.Forms.PictureBox pictureBoxCube;
        private System.Windows.Forms.PictureBox pictureBoxParalelogram;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnSizeMinus;
        private System.Windows.Forms.Button BtnSizePlus;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
    }
}


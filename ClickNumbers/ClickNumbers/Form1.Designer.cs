namespace ClickNumbers
{
    partial class ClickNumbers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickNumbers));
            PBS1 = new PictureBox();
            PBS2 = new PictureBox();
            PBS3 = new PictureBox();
            PBS4 = new PictureBox();
            PBS5 = new PictureBox();
            LabTXt = new Label();
            ExitAll = new Button();
            ((System.ComponentModel.ISupportInitialize)PBS1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBS2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBS3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBS4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBS5).BeginInit();
            SuspendLayout();
            // 
            // PBS1
            // 
            PBS1.Image = (Image)resources.GetObject("PBS1.Image");
            PBS1.Location = new Point(237, 135);
            PBS1.Name = "PBS1";
            PBS1.Size = new Size(150, 309);
            PBS1.SizeMode = PictureBoxSizeMode.StretchImage;
            PBS1.TabIndex = 1;
            PBS1.TabStop = false;
            PBS1.Click += PBS1_Click;
            // 
            // PBS2
            // 
            PBS2.Image = (Image)resources.GetObject("PBS2.Image");
            PBS2.Location = new Point(454, 243);
            PBS2.Name = "PBS2";
            PBS2.Size = new Size(150, 310);
            PBS2.SizeMode = PictureBoxSizeMode.StretchImage;
            PBS2.TabIndex = 2;
            PBS2.TabStop = false;
            PBS2.Click += PBS2_Click;
            // 
            // PBS3
            // 
            PBS3.Image = (Image)resources.GetObject("PBS3.Image");
            PBS3.Location = new Point(698, 135);
            PBS3.Name = "PBS3";
            PBS3.Size = new Size(150, 295);
            PBS3.SizeMode = PictureBoxSizeMode.StretchImage;
            PBS3.TabIndex = 3;
            PBS3.TabStop = false;
            PBS3.Click += PBS3_Click;
            // 
            // PBS4
            // 
            PBS4.Image = (Image)resources.GetObject("PBS4.Image");
            PBS4.Location = new Point(910, 339);
            PBS4.Name = "PBS4";
            PBS4.Size = new Size(150, 295);
            PBS4.SizeMode = PictureBoxSizeMode.StretchImage;
            PBS4.TabIndex = 4;
            PBS4.TabStop = false;
            PBS4.Click += PBS4_Click;
            // 
            // PBS5
            // 
            PBS5.Image = (Image)resources.GetObject("PBS5.Image");
            PBS5.Location = new Point(1125, 116);
            PBS5.Name = "PBS5";
            PBS5.Size = new Size(150, 295);
            PBS5.SizeMode = PictureBoxSizeMode.StretchImage;
            PBS5.TabIndex = 5;
            PBS5.TabStop = false;
            PBS5.Click += PBS5_Click;
            // 
            // LabTXt
            // 
            LabTXt.AutoSize = true;
            LabTXt.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabTXt.Location = new Point(598, 66);
            LabTXt.Name = "LabTXt";
            LabTXt.Size = new Size(378, 35);
            LabTXt.TabIndex = 6;
            LabTXt.Text = "Click each number at a time!";
            // 
            // ExitAll
            // 
            ExitAll.BackColor = Color.Chartreuse;
            ExitAll.Font = new Font("Sitka Banner", 22F, FontStyle.Bold, GraphicsUnit.Point);
            ExitAll.ForeColor = SystemColors.ControlText;
            ExitAll.Location = new Point(600, 847);
            ExitAll.Name = "ExitAll";
            ExitAll.Size = new Size(370, 132);
            ExitAll.TabIndex = 7;
            ExitAll.Text = "Exit";
            ExitAll.UseVisualStyleBackColor = false;
            ExitAll.Click += ExitAll_Click_1;
            // 
            // ClickNumbers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 1028);
            Controls.Add(ExitAll);
            Controls.Add(LabTXt);
            Controls.Add(PBS5);
            Controls.Add(PBS4);
            Controls.Add(PBS3);
            Controls.Add(PBS2);
            Controls.Add(PBS1);
            Name = "ClickNumbers";
            Text = "Tap Numbers";
            ((System.ComponentModel.ISupportInitialize)PBS1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBS2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBS3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBS4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBS5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ExitAll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private PictureBox PBS1;
        private PictureBox PBS2;
        private PictureBox PBS3;
        private PictureBox PBS4;
        private PictureBox PBS5;
        private Label LabTXt;
        private Button ExitAll;
    }
}
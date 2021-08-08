
namespace Kopalnia
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ryl = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy6 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Over = new System.Windows.Forms.Label();
            this.coal1 = new System.Windows.Forms.PictureBox();
            this.coal5 = new System.Windows.Forms.PictureBox();
            this.coal4 = new System.Windows.Forms.PictureBox();
            this.coal3 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.coal2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ryl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal2)).BeginInit();
            this.SuspendLayout();
            // 
            // ryl
            // 
            this.ryl.Image = ((System.Drawing.Image)(resources.GetObject("ryl.Image")));
            this.ryl.Location = new System.Drawing.Point(365, 263);
            this.ryl.Name = "ryl";
            this.ryl.Size = new System.Drawing.Size(68, 89);
            this.ryl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ryl.TabIndex = 0;
            this.ryl.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "WYDOBYCIE";
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(26, 119);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(39, 48);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 0;
            this.enemy1.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(479, 74);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(39, 41);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 0;
            this.enemy4.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.Image = ((System.Drawing.Image)(resources.GetObject("enemy5.Image")));
            this.enemy5.Location = new System.Drawing.Point(630, 24);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(35, 43);
            this.enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy5.TabIndex = 0;
            this.enemy5.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(164, -10);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(68, 89);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 0;
            this.enemy2.TabStop = false;
            // 
            // enemy6
            // 
            this.enemy6.Image = ((System.Drawing.Image)(resources.GetObject("enemy6.Image")));
            this.enemy6.Location = new System.Drawing.Point(691, 119);
            this.enemy6.Name = "enemy6";
            this.enemy6.Size = new System.Drawing.Size(56, 76);
            this.enemy6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy6.TabIndex = 0;
            this.enemy6.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(241, 119);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(89, 87);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 0;
            this.enemy3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Over
            // 
            this.Over.AutoSize = true;
            this.Over.BackColor = System.Drawing.Color.Black;
            this.Over.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Over.ForeColor = System.Drawing.Color.Red;
            this.Over.Location = new System.Drawing.Point(277, 127);
            this.Over.Name = "Over";
            this.Over.Size = new System.Drawing.Size(241, 54);
            this.Over.TabIndex = 2;
            this.Over.Text = "Game Over";
            this.Over.Click += new System.EventHandler(this.label2_Click);
            // 
            // coal1
            // 
            this.coal1.Image = ((System.Drawing.Image)(resources.GetObject("coal1.Image")));
            this.coal1.Location = new System.Drawing.Point(99, 127);
            this.coal1.Name = "coal1";
            this.coal1.Size = new System.Drawing.Size(39, 48);
            this.coal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coal1.TabIndex = 0;
            this.coal1.TabStop = false;
            // 
            // coal5
            // 
            this.coal5.Image = ((System.Drawing.Image)(resources.GetObject("coal5.Image")));
            this.coal5.Location = new System.Drawing.Point(652, 213);
            this.coal5.Name = "coal5";
            this.coal5.Size = new System.Drawing.Size(39, 48);
            this.coal5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coal5.TabIndex = 0;
            this.coal5.TabStop = false;
            // 
            // coal4
            // 
            this.coal4.Image = ((System.Drawing.Image)(resources.GetObject("coal4.Image")));
            this.coal4.Location = new System.Drawing.Point(475, 22);
            this.coal4.Name = "coal4";
            this.coal4.Size = new System.Drawing.Size(39, 48);
            this.coal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coal4.TabIndex = 0;
            this.coal4.TabStop = false;
            // 
            // coal3
            // 
            this.coal3.Image = ((System.Drawing.Image)(resources.GetObject("coal3.Image")));
            this.coal3.Location = new System.Drawing.Point(427, 174);
            this.coal3.Name = "coal3";
            this.coal3.Size = new System.Drawing.Size(39, 48);
            this.coal3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coal3.TabIndex = 0;
            this.coal3.TabStop = false;
            this.coal3.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(-66, 17);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(39, 48);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // coal2
            // 
            this.coal2.Image = ((System.Drawing.Image)(resources.GetObject("coal2.Image")));
            this.coal2.Location = new System.Drawing.Point(305, 31);
            this.coal2.Name = "coal2";
            this.coal2.Size = new System.Drawing.Size(39, 48);
            this.coal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coal2.TabIndex = 0;
            this.coal2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coals=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Over);
            this.Controls.Add(this.enemy6);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.coal2);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.coal4);
            this.Controls.Add(this.coal3);
            this.Controls.Add(this.coal5);
            this.Controls.Add(this.coal1);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.ryl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ryl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coal2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ryl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy6;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Over;
        private System.Windows.Forms.PictureBox coal1;
        private System.Windows.Forms.PictureBox coal5;
        private System.Windows.Forms.PictureBox coal4;
        private System.Windows.Forms.PictureBox coal3;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox coal2;
        private System.Windows.Forms.Label label2;
    }
}


namespace Assignment_game
{
    partial class Form1
    {
        /// <summary>l
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
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.ShootaHead = new System.Windows.Forms.Button();
            this.shootAway = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Points = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 200);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(107, 84);
            this.Load.TabIndex = 0;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click_2);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(181, 200);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(108, 84);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // ShootaHead
            // 
            this.ShootaHead.Location = new System.Drawing.Point(396, 281);
            this.ShootaHead.Name = "ShootaHead";
            this.ShootaHead.Size = new System.Drawing.Size(103, 84);
            this.ShootaHead.TabIndex = 2;
            this.ShootaHead.Text = "Shoot ahead";
            this.ShootaHead.UseVisualStyleBackColor = true;
            this.ShootaHead.Click += new System.EventHandler(this.ShootaHead_Click);
            // 
            // shootAway
            // 
            this.shootAway.Location = new System.Drawing.Point(391, 111);
            this.shootAway.Name = "shootAway";
            this.shootAway.Size = new System.Drawing.Size(108, 84);
            this.shootAway.TabIndex = 3;
            this.shootAway.Text = "Shoot away";
            this.shootAway.UseVisualStyleBackColor = true;
            this.shootAway.Click += new System.EventHandler(this.shootAway_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(371, 18);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(47, 17);
            this.Points.TabIndex = 5;
            this.Points.Text = "Points";
            this.Points.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(620, 12);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(107, 78);
            this.PlayAgain.TabIndex = 6;
            this.PlayAgain.Text = "PlayAgain";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.ShootaHead;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shootAway);
            this.Controls.Add(this.ShootaHead);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button ShootaHead;
        private System.Windows.Forms.Button shootAway;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


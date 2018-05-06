namespace FoolGame
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.ExitBtn2 = new System.Windows.Forms.Button();
            this.ReplayBtn2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn2
            // 
            this.ExitBtn2.AccessibleName = "exit";
            this.ExitBtn2.BackColor = System.Drawing.Color.Black;
            this.ExitBtn2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn2.ForeColor = System.Drawing.Color.White;
            this.ExitBtn2.Location = new System.Drawing.Point(446, 355);
            this.ExitBtn2.Name = "ExitBtn2";
            this.ExitBtn2.Size = new System.Drawing.Size(99, 40);
            this.ExitBtn2.TabIndex = 4;
            this.ExitBtn2.Text = "Exit";
            this.ExitBtn2.UseVisualStyleBackColor = false;
            this.ExitBtn2.Click += new System.EventHandler(this.ExitBtn2_Click);
            // 
            // ReplayBtn2
            // 
            this.ReplayBtn2.AccessibleName = "replay";
            this.ReplayBtn2.BackColor = System.Drawing.Color.Black;
            this.ReplayBtn2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayBtn2.ForeColor = System.Drawing.Color.White;
            this.ReplayBtn2.Location = new System.Drawing.Point(157, 355);
            this.ReplayBtn2.Name = "ReplayBtn2";
            this.ReplayBtn2.Size = new System.Drawing.Size(101, 40);
            this.ReplayBtn2.TabIndex = 3;
            this.ReplayBtn2.Text = "Replay";
            this.ReplayBtn2.UseVisualStyleBackColor = false;
            this.ReplayBtn2.Click += new System.EventHandler(this.ReplayBtn2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "pictureBox1";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 247);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(733, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn2);
            this.Controls.Add(this.ReplayBtn2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn2;
        private System.Windows.Forms.Button ReplayBtn2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
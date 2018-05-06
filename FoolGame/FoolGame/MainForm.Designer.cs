namespace FoolGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.ExtBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.AccessibleName = "yesButton";
            this.yesButton.BackColor = System.Drawing.Color.Black;
            this.yesButton.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.Color.White;
            this.yesButton.Location = new System.Drawing.Point(208, 283);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(90, 37);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.ClickedYes);
            // 
            // noButton
            // 
            this.noButton.AccessibleName = "noButton";
            this.noButton.BackColor = System.Drawing.Color.Black;
            this.noButton.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.Color.White;
            this.noButton.Location = new System.Drawing.Point(440, 283);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(90, 37);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.ClickedNo);
            this.noButton.MouseEnter += new System.EventHandler(this.ButtonRun);
            // 
            // question
            // 
            this.question.AccessibleName = "question";
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.question.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(218, 64);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(359, 84);
            this.question.TabIndex = 2;
            this.question.Text = "Are you a fool?";
            this.question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExtBtn1
            // 
            this.ExtBtn1.BackColor = System.Drawing.Color.Black;
            this.ExtBtn1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtBtn1.ForeColor = System.Drawing.Color.White;
            this.ExtBtn1.Location = new System.Drawing.Point(325, 356);
            this.ExtBtn1.Name = "ExtBtn1";
            this.ExtBtn1.Size = new System.Drawing.Size(90, 37);
            this.ExtBtn1.TabIndex = 3;
            this.ExtBtn1.Text = "Exit";
            this.ExtBtn1.UseVisualStyleBackColor = false;
            this.ExtBtn1.Click += new System.EventHandler(this.ExtBtn1_Click);
            this.ExtBtn1.MouseEnter += new System.EventHandler(this.ExitBtnRun);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.ExtBtn1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.noButton);
            this.Name = "MainForm";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button ExtBtn1;
    }
}


namespace EconGame
{
    partial class War
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
            this.btnInstruction = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblHaechan = new System.Windows.Forms.Label();
            this.btnRome = new System.Windows.Forms.Button();
            this.btnGreece = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.picWin = new System.Windows.Forms.PictureBox();
            this.picLose = new System.Windows.Forms.PictureBox();
            this.pnlWin = new System.Windows.Forms.Panel();
            this.pnlLose = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).BeginInit();
            this.pnlWin.SuspendLayout();
            this.pnlLose.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstruction
            // 
            this.btnInstruction.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruction.Location = new System.Drawing.Point(30, 535);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(120, 41);
            this.btnInstruction.TabIndex = 0;
            this.btnInstruction.Text = "Instructions";
            this.btnInstruction.UseVisualStyleBackColor = true;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(30, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(336, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(337, 34);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "So thou hath chosen violence...";
            // 
            // lblHaechan
            // 
            this.lblHaechan.AutoSize = true;
            this.lblHaechan.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaechan.Location = new System.Drawing.Point(61, 45);
            this.lblHaechan.Name = "lblHaechan";
            this.lblHaechan.Size = new System.Drawing.Size(526, 34);
            this.lblHaechan.TabIndex = 3;
            this.lblHaechan.Text = "Something smells rotten in  the land of Denmark...";
            // 
            // btnRome
            // 
            this.btnRome.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRome.Location = new System.Drawing.Point(369, 206);
            this.btnRome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRome.Name = "btnRome";
            this.btnRome.Size = new System.Drawing.Size(144, 36);
            this.btnRome.TabIndex = 4;
            this.btnRome.Text = "Rome";
            this.btnRome.UseVisualStyleBackColor = true;
            this.btnRome.Click += new System.EventHandler(this.btnRome_Click);
            // 
            // btnGreece
            // 
            this.btnGreece.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreece.Location = new System.Drawing.Point(555, 206);
            this.btnGreece.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGreece.Name = "btnGreece";
            this.btnGreece.Size = new System.Drawing.Size(144, 36);
            this.btnGreece.TabIndex = 5;
            this.btnGreece.Text = "Greece";
            this.btnGreece.UseVisualStyleBackColor = true;
            this.btnGreece.Click += new System.EventHandler(this.btnGreece_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(365, 129);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(355, 38);
            this.lblChoose.TabIndex = 6;
            this.lblChoose.Text = "Which country are you invading?";
            // 
            // picWin
            // 
            this.picWin.Image = global::EconGame.Properties.Resources.win;
            this.picWin.Location = new System.Drawing.Point(85, 64);
            this.picWin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picWin.Name = "picWin";
            this.picWin.Size = new System.Drawing.Size(190, 112);
            this.picWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWin.TabIndex = 7;
            this.picWin.TabStop = false;
            // 
            // picLose
            // 
            this.picLose.Image = global::EconGame.Properties.Resources.lose;
            this.picLose.Location = new System.Drawing.Point(108, 64);
            this.picLose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLose.Name = "picLose";
            this.picLose.Size = new System.Drawing.Size(175, 107);
            this.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLose.TabIndex = 8;
            this.picLose.TabStop = false;
            // 
            // pnlWin
            // 
            this.pnlWin.Controls.Add(this.picWin);
            this.pnlWin.Location = new System.Drawing.Point(80, 265);
            this.pnlWin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlWin.Name = "pnlWin";
            this.pnlWin.Size = new System.Drawing.Size(363, 241);
            this.pnlWin.TabIndex = 11;
            this.pnlWin.Visible = false;
            // 
            // pnlLose
            // 
            this.pnlLose.Controls.Add(this.picLose);
            this.pnlLose.Location = new System.Drawing.Point(634, 265);
            this.pnlLose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLose.Name = "pnlLose";
            this.pnlLose.Size = new System.Drawing.Size(363, 241);
            this.pnlLose.TabIndex = 12;
            this.pnlLose.Visible = false;
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EconGame.Properties.Resources.a1ffa46a2b3c9fce54c54b94805b6257;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 682);
            this.Controls.Add(this.pnlLose);
            this.Controls.Add(this.pnlWin);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnGreece);
            this.Controls.Add(this.btnRome);
            this.Controls.Add(this.lblHaechan);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInstruction);
            this.Name = "War";
            this.Text = "War";
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).EndInit();
            this.pnlWin.ResumeLayout(false);
            this.pnlLose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHaechan;
        private System.Windows.Forms.Button btnRome;
        private System.Windows.Forms.Button btnGreece;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.PictureBox picWin;
        private System.Windows.Forms.PictureBox picLose;
        private System.Windows.Forms.Panel pnlWin;
        private System.Windows.Forms.Panel pnlLose;
    }
}
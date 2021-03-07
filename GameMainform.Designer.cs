namespace EconGame
{
    partial class gameForm
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
            this.components = new System.ComponentModel.Container();
            this.picRome = new System.Windows.Forms.PictureBox();
            this.picYourCountry = new System.Windows.Forms.PictureBox();
            this.picGreece = new System.Windows.Forms.PictureBox();
            this.btnWar = new System.Windows.Forms.Button();
            this.lblRome = new System.Windows.Forms.Label();
            this.lblGreece = new System.Windows.Forms.Label();
            this.lblYourCountry = new System.Windows.Forms.Label();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlQuit = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnCountry = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreece)).BeginInit();
            this.pnlQuit.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRome
            // 
            this.picRome.Image = global::EconGame.Properties.Resources.rome;
            this.picRome.Location = new System.Drawing.Point(138, 70);
            this.picRome.Name = "picRome";
            this.picRome.Size = new System.Drawing.Size(300, 200);
            this.picRome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRome.TabIndex = 0;
            this.picRome.TabStop = false;
            // 
            // picYourCountry
            // 
            this.picYourCountry.Image = global::EconGame.Properties.Resources.egypt;
            this.picYourCountry.Location = new System.Drawing.Point(481, 375);
            this.picYourCountry.Name = "picYourCountry";
            this.picYourCountry.Size = new System.Drawing.Size(300, 200);
            this.picYourCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYourCountry.TabIndex = 1;
            this.picYourCountry.TabStop = false;
            // 
            // picGreece
            // 
            this.picGreece.Image = global::EconGame.Properties.Resources.greece;
            this.picGreece.Location = new System.Drawing.Point(798, 70);
            this.picGreece.Name = "picGreece";
            this.picGreece.Size = new System.Drawing.Size(300, 200);
            this.picGreece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreece.TabIndex = 2;
            this.picGreece.TabStop = false;
            // 
            // btnWar
            // 
            this.btnWar.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWar.Location = new System.Drawing.Point(787, 489);
            this.btnWar.Name = "btnWar";
            this.btnWar.Size = new System.Drawing.Size(147, 40);
            this.btnWar.TabIndex = 3;
            this.btnWar.Text = "War";
            this.btnWar.UseVisualStyleBackColor = true;
            this.btnWar.Click += new System.EventHandler(this.btnWar_Click);
            // 
            // lblRome
            // 
            this.lblRome.AutoSize = true;
            this.lblRome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRome.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRome.Location = new System.Drawing.Point(251, 280);
            this.lblRome.Name = "lblRome";
            this.lblRome.Size = new System.Drawing.Size(55, 24);
            this.lblRome.TabIndex = 4;
            this.lblRome.Text = "label1";
            // 
            // lblGreece
            // 
            this.lblGreece.AutoSize = true;
            this.lblGreece.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreece.Location = new System.Drawing.Point(933, 285);
            this.lblGreece.Name = "lblGreece";
            this.lblGreece.Size = new System.Drawing.Size(55, 24);
            this.lblGreece.TabIndex = 5;
            this.lblGreece.Text = "label2";
            // 
            // lblYourCountry
            // 
            this.lblYourCountry.AutoSize = true;
            this.lblYourCountry.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCountry.Location = new System.Drawing.Point(596, 600);
            this.lblYourCountry.Name = "lblYourCountry";
            this.lblYourCountry.Size = new System.Drawing.Size(55, 24);
            this.lblYourCountry.TabIndex = 6;
            this.lblYourCountry.Text = "label3";
            // 
            // btnMarket
            // 
            this.btnMarket.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarket.Location = new System.Drawing.Point(787, 535);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(147, 40);
            this.btnMarket.TabIndex = 7;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnInstruction
            // 
            this.btnInstruction.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruction.Location = new System.Drawing.Point(27, 526);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(126, 40);
            this.btnInstruction.TabIndex = 8;
            this.btnInstruction.Text = "button1";
            this.btnInstruction.UseVisualStyleBackColor = true;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(27, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlQuit
            // 
            this.pnlQuit.Controls.Add(this.btnNo);
            this.pnlQuit.Controls.Add(this.btnYes);
            this.pnlQuit.Controls.Add(this.lblQuit);
            this.pnlQuit.Location = new System.Drawing.Point(481, 280);
            this.pnlQuit.Name = "pnlQuit";
            this.pnlQuit.Size = new System.Drawing.Size(300, 173);
            this.pnlQuit.TabIndex = 10;
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(179, 125);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(59, 30);
            this.btnNo.TabIndex = 12;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(66, 125);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(59, 30);
            this.btnYes.TabIndex = 11;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit.Location = new System.Drawing.Point(26, 30);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(59, 25);
            this.lblQuit.TabIndex = 0;
            this.lblQuit.Text = "label1";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(574, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(47, 25);
            this.lblDay.TabIndex = 13;
            this.lblDay.Text = "Day";
            // 
            // btnCountry
            // 
            this.btnCountry.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountry.Location = new System.Drawing.Point(787, 443);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(147, 40);
            this.btnCountry.TabIndex = 14;
            this.btnCountry.Text = "My Country";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(574, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 25);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EconGame.Properties.Resources._4397501ae0f33eb77a2292b5535321ee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 673);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.pnlQuit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInstruction);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.lblYourCountry);
            this.Controls.Add(this.lblGreece);
            this.Controls.Add(this.lblRome);
            this.Controls.Add(this.btnWar);
            this.Controls.Add(this.picGreece);
            this.Controls.Add(this.picYourCountry);
            this.Controls.Add(this.picRome);
            this.Name = "gameForm";
            this.Text = "Game Form";
            ((System.ComponentModel.ISupportInitialize)(this.picRome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreece)).EndInit();
            this.pnlQuit.ResumeLayout(false);
            this.pnlQuit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRome;
        private System.Windows.Forms.PictureBox picYourCountry;
        private System.Windows.Forms.PictureBox picGreece;
        private System.Windows.Forms.Button btnWar;
        private System.Windows.Forms.Label lblRome;
        private System.Windows.Forms.Label lblGreece;
        private System.Windows.Forms.Label lblYourCountry;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlQuit;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
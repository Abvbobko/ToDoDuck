namespace ToDoDuck
{
    partial class fHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHelp));
            this.bBack = new System.Windows.Forms.Button();
            this.bNextPic = new System.Windows.Forms.Button();
            this.bPrevPic = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Orange;
            this.bBack.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bBack.FlatAppearance.BorderSize = 0;
            this.bBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.Color.Black;
            this.bBack.Location = new System.Drawing.Point(566, 436);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(126, 39);
            this.bBack.TabIndex = 20;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNextPic
            // 
            this.bNextPic.BackColor = System.Drawing.Color.Orange;
            this.bNextPic.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bNextPic.FlatAppearance.BorderSize = 0;
            this.bNextPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bNextPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bNextPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNextPic.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNextPic.ForeColor = System.Drawing.Color.Black;
            this.bNextPic.Location = new System.Drawing.Point(632, 393);
            this.bNextPic.Name = "bNextPic";
            this.bNextPic.Size = new System.Drawing.Size(60, 37);
            this.bNextPic.TabIndex = 19;
            this.bNextPic.Text = ">";
            this.bNextPic.UseVisualStyleBackColor = false;
            this.bNextPic.Click += new System.EventHandler(this.bNextPic_Click);
            // 
            // bPrevPic
            // 
            this.bPrevPic.BackColor = System.Drawing.Color.Orange;
            this.bPrevPic.Enabled = false;
            this.bPrevPic.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bPrevPic.FlatAppearance.BorderSize = 0;
            this.bPrevPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bPrevPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bPrevPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevPic.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPrevPic.ForeColor = System.Drawing.Color.Black;
            this.bPrevPic.Location = new System.Drawing.Point(566, 393);
            this.bPrevPic.Name = "bPrevPic";
            this.bPrevPic.Size = new System.Drawing.Size(60, 37);
            this.bPrevPic.TabIndex = 18;
            this.bPrevPic.Text = "<";
            this.bPrevPic.UseVisualStyleBackColor = false;
            this.bPrevPic.Click += new System.EventHandler(this.bPrevPic_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbPicture.Image")));
            this.pbPicture.Location = new System.Drawing.Point(12, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(548, 418);
            this.pbPicture.TabIndex = 21;
            this.pbPicture.TabStop = false;
            // 
            // fHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bNextPic);
            this.Controls.Add(this.bPrevPic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 480);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "fHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHelp";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bNextPic;
        private System.Windows.Forms.Button bPrevPic;
        private System.Windows.Forms.PictureBox pbPicture;
    }
}
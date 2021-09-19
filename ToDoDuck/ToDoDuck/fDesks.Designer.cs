namespace ToDoDuck
{
    partial class fDesks
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
            this.bPrevDesk = new System.Windows.Forms.Button();
            this.bNextDesk = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bCreateDesk = new System.Windows.Forms.Button();
            this.bDeleteDesk = new System.Windows.Forms.Button();
            this.lYouHaventDesks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bPrevDesk
            // 
            this.bPrevDesk.BackColor = System.Drawing.Color.Orange;
            this.bPrevDesk.Enabled = false;
            this.bPrevDesk.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bPrevDesk.FlatAppearance.BorderSize = 0;
            this.bPrevDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bPrevDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bPrevDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevDesk.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPrevDesk.ForeColor = System.Drawing.Color.Black;
            this.bPrevDesk.Location = new System.Drawing.Point(562, 316);
            this.bPrevDesk.Name = "bPrevDesk";
            this.bPrevDesk.Size = new System.Drawing.Size(60, 110);
            this.bPrevDesk.TabIndex = 15;
            this.bPrevDesk.Text = "<";
            this.bPrevDesk.UseVisualStyleBackColor = false;
            this.bPrevDesk.Click += new System.EventHandler(this.bPrevDesk_Click);
            // 
            // bNextDesk
            // 
            this.bNextDesk.BackColor = System.Drawing.Color.Orange;
            this.bNextDesk.Enabled = false;
            this.bNextDesk.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bNextDesk.FlatAppearance.BorderSize = 0;
            this.bNextDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bNextDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bNextDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNextDesk.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNextDesk.ForeColor = System.Drawing.Color.Black;
            this.bNextDesk.Location = new System.Drawing.Point(628, 316);
            this.bNextDesk.Name = "bNextDesk";
            this.bNextDesk.Size = new System.Drawing.Size(60, 110);
            this.bNextDesk.TabIndex = 16;
            this.bNextDesk.Text = ">";
            this.bNextDesk.UseVisualStyleBackColor = false;
            this.bNextDesk.Click += new System.EventHandler(this.bNextDesk_Click);
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
            this.bBack.Location = new System.Drawing.Point(562, 432);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(126, 39);
            this.bBack.TabIndex = 17;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bCreateDesk
            // 
            this.bCreateDesk.BackColor = System.Drawing.Color.Orange;
            this.bCreateDesk.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bCreateDesk.FlatAppearance.BorderSize = 0;
            this.bCreateDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bCreateDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCreateDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateDesk.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateDesk.ForeColor = System.Drawing.Color.Black;
            this.bCreateDesk.Location = new System.Drawing.Point(562, 12);
            this.bCreateDesk.Name = "bCreateDesk";
            this.bCreateDesk.Size = new System.Drawing.Size(126, 39);
            this.bCreateDesk.TabIndex = 19;
            this.bCreateDesk.Text = "Создать";
            this.bCreateDesk.UseVisualStyleBackColor = false;
            this.bCreateDesk.Click += new System.EventHandler(this.bCreateDesk_Click);
            // 
            // bDeleteDesk
            // 
            this.bDeleteDesk.BackColor = System.Drawing.Color.Orange;
            this.bDeleteDesk.Enabled = false;
            this.bDeleteDesk.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bDeleteDesk.FlatAppearance.BorderSize = 0;
            this.bDeleteDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bDeleteDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDeleteDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteDesk.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDeleteDesk.ForeColor = System.Drawing.Color.Black;
            this.bDeleteDesk.Location = new System.Drawing.Point(562, 57);
            this.bDeleteDesk.Name = "bDeleteDesk";
            this.bDeleteDesk.Size = new System.Drawing.Size(126, 39);
            this.bDeleteDesk.TabIndex = 20;
            this.bDeleteDesk.Text = "Удалить";
            this.bDeleteDesk.UseVisualStyleBackColor = false;
            this.bDeleteDesk.Click += new System.EventHandler(this.bDeleteDesk_Click);
            // 
            // lYouHaventDesks
            // 
            this.lYouHaventDesks.AutoSize = true;
            this.lYouHaventDesks.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lYouHaventDesks.Location = new System.Drawing.Point(140, 199);
            this.lYouHaventDesks.Name = "lYouHaventDesks";
            this.lYouHaventDesks.Size = new System.Drawing.Size(240, 25);
            this.lYouHaventDesks.TabIndex = 21;
            this.lYouHaventDesks.Text = "У Вас пока нет досок";
            // 
            // fDesks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.lYouHaventDesks);
            this.Controls.Add(this.bDeleteDesk);
            this.Controls.Add(this.bCreateDesk);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bNextDesk);
            this.Controls.Add(this.bPrevDesk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 480);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "fDesks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bPrevDesk;
        private System.Windows.Forms.Button bNextDesk;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bCreateDesk;
        private System.Windows.Forms.Button bDeleteDesk;
        private System.Windows.Forms.Label lYouHaventDesks;
    }
}
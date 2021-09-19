namespace ToDoDuck
{
    partial class fMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.lSubTitle = new System.Windows.Forms.Label();
            this.bCalendar = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.bDesk = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Elephant", 54.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Black;
            this.lTitle.Location = new System.Drawing.Point(122, 3);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(454, 94);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "ToDoDuck";
            // 
            // lSubTitle
            // 
            this.lSubTitle.AutoSize = true;
            this.lSubTitle.Font = new System.Drawing.Font("High Tower Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubTitle.ForeColor = System.Drawing.Color.Black;
            this.lSubTitle.Location = new System.Drawing.Point(133, 80);
            this.lSubTitle.Name = "lSubTitle";
            this.lSubTitle.Size = new System.Drawing.Size(440, 27);
            this.lSubTitle.TabIndex = 1;
            this.lSubTitle.Text = "Мечты — это планы, реализовавшиеся в срок.";
            // 
            // bCalendar
            // 
            this.bCalendar.BackColor = System.Drawing.Color.Orange;
            this.bCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalendar.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalendar.ForeColor = System.Drawing.Color.Black;
            this.bCalendar.Location = new System.Drawing.Point(12, 128);
            this.bCalendar.Name = "bCalendar";
            this.bCalendar.Size = new System.Drawing.Size(333, 164);
            this.bCalendar.TabIndex = 8;
            this.bCalendar.Text = "Календарь";
            this.bCalendar.UseVisualStyleBackColor = false;
            this.bCalendar.Click += new System.EventHandler(this.bCalendar_Click);
            // 
            // bHelp
            // 
            this.bHelp.BackColor = System.Drawing.Color.Orange;
            this.bHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bHelp.FlatAppearance.BorderSize = 0;
            this.bHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHelp.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bHelp.ForeColor = System.Drawing.Color.Black;
            this.bHelp.Location = new System.Drawing.Point(12, 302);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(333, 164);
            this.bHelp.TabIndex = 9;
            this.bHelp.Text = "Справка";
            this.bHelp.UseVisualStyleBackColor = false;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // bDesk
            // 
            this.bDesk.BackColor = System.Drawing.Color.Orange;
            this.bDesk.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bDesk.FlatAppearance.BorderSize = 0;
            this.bDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDesk.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDesk.ForeColor = System.Drawing.Color.Black;
            this.bDesk.Location = new System.Drawing.Point(355, 128);
            this.bDesk.Name = "bDesk";
            this.bDesk.Size = new System.Drawing.Size(333, 164);
            this.bDesk.TabIndex = 10;
            this.bDesk.Text = "Доски";
            this.bDesk.UseVisualStyleBackColor = false;
            this.bDesk.Click += new System.EventHandler(this.bDesk_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Orange;
            this.bExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.bExit.ForeColor = System.Drawing.Color.Black;
            this.bExit.Location = new System.Drawing.Point(355, 302);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(333, 164);
            this.bExit.TabIndex = 11;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // fMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDesk);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.bCalendar);
            this.Controls.Add(this.lSubTitle);
            this.Controls.Add(this.lTitle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 480);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "fMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoDuck";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lSubTitle;
        private System.Windows.Forms.Button bCalendar;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bDesk;
        private System.Windows.Forms.Button bExit;
    }
}


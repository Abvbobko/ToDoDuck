namespace ToDoDuck
{
    partial class fCalendar
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
            this.pane = new System.Windows.Forms.Panel();
            this.lMonth = new System.Windows.Forms.Label();
            this.lSun = new System.Windows.Forms.Label();
            this.lSat = new System.Windows.Forms.Label();
            this.lFri = new System.Windows.Forms.Label();
            this.lThu = new System.Windows.Forms.Label();
            this.lWen = new System.Windows.Forms.Label();
            this.lTue = new System.Windows.Forms.Label();
            this.lMon = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bNextMonth = new System.Windows.Forms.Button();
            this.bPrevMonth = new System.Windows.Forms.Button();
            this.lYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pane
            // 
            this.pane.Location = new System.Drawing.Point(17, 27);
            this.pane.Name = "pane";
            this.pane.Size = new System.Drawing.Size(671, 450);
            this.pane.TabIndex = 0;
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMonth.Location = new System.Drawing.Point(557, 9);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(81, 26);
            this.lMonth.TabIndex = 0;
            this.lMonth.Text = "Month";
            // 
            // lSun
            // 
            this.lSun.AutoSize = true;
            this.lSun.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSun.Location = new System.Drawing.Point(284, -3);
            this.lSun.Name = "lSun";
            this.lSun.Size = new System.Drawing.Size(30, 18);
            this.lSun.TabIndex = 2;
            this.lSun.Text = "ВС";
            // 
            // lSat
            // 
            this.lSat.AutoSize = true;
            this.lSat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSat.Location = new System.Drawing.Point(248, -3);
            this.lSat.Name = "lSat";
            this.lSat.Size = new System.Drawing.Size(30, 18);
            this.lSat.TabIndex = 3;
            this.lSat.Text = "СБ";
            // 
            // lFri
            // 
            this.lFri.AutoSize = true;
            this.lFri.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFri.Location = new System.Drawing.Point(212, -3);
            this.lFri.Name = "lFri";
            this.lFri.Size = new System.Drawing.Size(30, 18);
            this.lFri.TabIndex = 4;
            this.lFri.Text = "ПТ";
            // 
            // lThu
            // 
            this.lThu.AutoSize = true;
            this.lThu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lThu.Location = new System.Drawing.Point(176, -3);
            this.lThu.Name = "lThu";
            this.lThu.Size = new System.Drawing.Size(30, 18);
            this.lThu.TabIndex = 5;
            this.lThu.Text = "ЧТ";
            // 
            // lWen
            // 
            this.lWen.AutoSize = true;
            this.lWen.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWen.Location = new System.Drawing.Point(140, -3);
            this.lWen.Name = "lWen";
            this.lWen.Size = new System.Drawing.Size(30, 18);
            this.lWen.TabIndex = 6;
            this.lWen.Text = "СР";
            // 
            // lTue
            // 
            this.lTue.AutoSize = true;
            this.lTue.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTue.Location = new System.Drawing.Point(105, -3);
            this.lTue.Name = "lTue";
            this.lTue.Size = new System.Drawing.Size(29, 18);
            this.lTue.TabIndex = 7;
            this.lTue.Text = "ВТ";
            // 
            // lMon
            // 
            this.lMon.AutoSize = true;
            this.lMon.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMon.Location = new System.Drawing.Point(70, -3);
            this.lMon.Name = "lMon";
            this.lMon.Size = new System.Drawing.Size(32, 18);
            this.lMon.TabIndex = 8;
            this.lMon.Text = "ПН";
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
            this.bBack.Location = new System.Drawing.Point(550, 430);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(126, 39);
            this.bBack.TabIndex = 12;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNextMonth
            // 
            this.bNextMonth.BackColor = System.Drawing.Color.Orange;
            this.bNextMonth.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bNextMonth.FlatAppearance.BorderSize = 0;
            this.bNextMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bNextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNextMonth.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNextMonth.ForeColor = System.Drawing.Color.Black;
            this.bNextMonth.Location = new System.Drawing.Point(616, 313);
            this.bNextMonth.Name = "bNextMonth";
            this.bNextMonth.Size = new System.Drawing.Size(60, 110);
            this.bNextMonth.TabIndex = 13;
            this.bNextMonth.Text = ">";
            this.bNextMonth.UseVisualStyleBackColor = false;
            this.bNextMonth.Click += new System.EventHandler(this.bNextMonth_Click);
            // 
            // bPrevMonth
            // 
            this.bPrevMonth.BackColor = System.Drawing.Color.Orange;
            this.bPrevMonth.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bPrevMonth.FlatAppearance.BorderSize = 0;
            this.bPrevMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bPrevMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevMonth.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPrevMonth.ForeColor = System.Drawing.Color.Black;
            this.bPrevMonth.Location = new System.Drawing.Point(550, 313);
            this.bPrevMonth.Name = "bPrevMonth";
            this.bPrevMonth.Size = new System.Drawing.Size(60, 110);
            this.bPrevMonth.TabIndex = 14;
            this.bPrevMonth.Text = "<";
            this.bPrevMonth.UseVisualStyleBackColor = false;
            this.bPrevMonth.Click += new System.EventHandler(this.bPrevMonth_Click);
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lYear.Location = new System.Drawing.Point(559, 37);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(60, 26);
            this.lYear.TabIndex = 1;
            this.lYear.Text = "Year";
            // 
            // fCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.bNextMonth);
            this.Controls.Add(this.bPrevMonth);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lMon);
            this.Controls.Add(this.lMonth);
            this.Controls.Add(this.lSun);
            this.Controls.Add(this.lSat);
            this.Controls.Add(this.lFri);
            this.Controls.Add(this.lThu);
            this.Controls.Add(this.lWen);
            this.Controls.Add(this.lTue);
            this.Controls.Add(this.pane);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(700, 480);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "fCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCalendar";
            this.Shown += new System.EventHandler(this.fCalendar_Shown);
            this.EnabledChanged += new System.EventHandler(this.fCalendar_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pane;
        private System.Windows.Forms.Label lMonth;
        private System.Windows.Forms.Label lTue;
        private System.Windows.Forms.Label lWen;
        private System.Windows.Forms.Label lThu;
        private System.Windows.Forms.Label lFri;
        private System.Windows.Forms.Label lSat;
        private System.Windows.Forms.Label lSun;
        private System.Windows.Forms.Label lMon;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bPrevMonth;
        private System.Windows.Forms.Button bNextMonth;
        private System.Windows.Forms.Label lYear;
    }
}
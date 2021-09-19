namespace ToDoDuck
{
    partial class fToDoDayList
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
            this.components = new System.ComponentModel.Container();
            this.bClose = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.lbToDoList = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.toolTipAllStringInToDoList = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Orange;
            this.bClose.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.bClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Location = new System.Drawing.Point(7, 7);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(34, 34);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "X";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(98, 8);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(135, 25);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Список дел";
            // 
            // lbToDoList
            // 
            this.lbToDoList.BackColor = System.Drawing.Color.Orange;
            this.lbToDoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbToDoList.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 23;
            this.lbToDoList.Location = new System.Drawing.Point(7, 47);
            this.lbToDoList.MaximumSize = new System.Drawing.Size(285, 323);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(285, 23);
            this.lbToDoList.TabIndex = 2;
            this.lbToDoList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbToDoList_MouseClick);
            this.lbToDoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbToDoList_MouseDoubleClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Brown;
            this.panel.Controls.Add(this.lbToDoList);
            this.panel.Controls.Add(this.tbEnter);
            this.panel.Controls.Add(this.bClose);
            this.panel.Controls.Add(this.lTitle);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 450);
            this.panel.TabIndex = 3;
            // 
            // tbEnter
            // 
            this.tbEnter.BackColor = System.Drawing.Color.Orange;
            this.tbEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEnter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnter.Location = new System.Drawing.Point(10, 418);
            this.tbEnter.MaxLength = 256;
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(281, 24);
            this.tbEnter.TabIndex = 2;
            this.tbEnter.Enter += new System.EventHandler(this.tbEnter_Enter);
            this.tbEnter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEnter_KeyUp);
            // 
            // fToDoDayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fToDoDayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Shown += new System.EventHandler(this.fToDoDayList_Shown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ListBox lbToDoList;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.ToolTip toolTipAllStringInToDoList;
    }
}
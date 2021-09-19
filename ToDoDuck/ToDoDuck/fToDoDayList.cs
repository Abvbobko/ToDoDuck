using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoDuck
{
    public partial class fToDoDayList : Form
    {
        const int ADD_HEIGHT = 25;
        int currentNum;
        public fToDoDayList(DateTime titleDate, int num, List<string> toDo) {
            InitializeComponent();
            currentNum = num;
            lTitle.Text = titleDate.Day.ToString() + '/' + titleDate.Month.ToString() + '/' + titleDate.Year.ToString();
            tbEnter.Text = "Новое дело...";//подсказка
            tbEnter.ForeColor = Color.Brown;
            if (toDo != null) {
                for (int i  = 0; i < toDo.Count; i++) {                    
                    lbToDoList.Items.Add(toDo[i]);
                    if (lbToDoList.Items.Count != 1) {
                        lbToDoList.Height = lbToDoList.Height + ADD_HEIGHT;
                        lbToDoList.SetSelected(lbToDoList.Items.Count - 1, true);
                    }
                }
            }
        }

        private void bClose_Click(object sender, EventArgs e) {
            Form fCalendar = Application.OpenForms[1];
            List<string> tasks = new List<string>();
            int i = 0;
            foreach (object item in lbToDoList.Items) {
                tasks.Add(item.ToString());
            }
            using (StreamWriter tmpFile = File.CreateText("tmpFile.txt")) {
                if (tasks.Count > 0) {
                    for (i = 0; i < tasks.Count; i++) {
                        tmpFile.WriteLine(tasks[i]);
                    }
                }
            }            
            fCalendar.Enabled = true;
            this.Close();
        }

        private void fToDoDayList_Shown(object sender, EventArgs e) {
            Graphics pane = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black, 5);
            pane.DrawRectangle(pen, new Rectangle(0, 0, this.Width, this.Height));        
        }

        

        private void tbEnter_KeyUp(object sender, KeyEventArgs e) { 
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return)) {                
                if (tbEnter.Text.Length > 0) {
                    //проверка, чтобы строка была непустой
                    string tmpS1 = tbEnter.Text;
                    tmpS1 = tmpS1.Trim(' ');
                    if (tmpS1.Length > 0) {
                        string tmpS2 = tbEnter.Text;
                        tmpS2 = tmpS2.TrimStart(' ');                        
                        lbToDoList.Items.Add(tmpS2);
                        //удаление пробелов вначале и добавление строки
                        tbEnter.Clear();
                        if (lbToDoList.Items.Count != 1) {
                            lbToDoList.Height = lbToDoList.Height + ADD_HEIGHT;
                            lbToDoList.SetSelected(lbToDoList.Items.Count - 1, true);
                        }                        
                    }
                    else
                        tbEnter.Clear();
                }
            }
        }

        private void lbToDoList_MouseClick(object sender, MouseEventArgs e) {
            if (lbToDoList.Items.Count > 0) {
                toolTipAllStringInToDoList.SetToolTip(lbToDoList, lbToDoList.SelectedItem.ToString());                
            }
        }

        private void tbEnter_Enter(object sender, EventArgs e) {
            tbEnter.Text = null;
            tbEnter.ForeColor = Color.Black;
        }

        const int SUB_HEIGHT = 15;
        
        private void lbToDoList_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbToDoList.Items.Count > 0) {
                lbToDoList.Items.RemoveAt(lbToDoList.SelectedIndex);
                //удаление элемента
                if (lbToDoList.Items.Count > 0) {
                    lbToDoList.Height = lbToDoList.Height - SUB_HEIGHT;
                    lbToDoList.SetSelected(lbToDoList.Items.Count - 1, true);
                    //выравнивение ListBox
                }
            }
        }
    }
}

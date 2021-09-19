using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoDuck
{
    public partial class fMainMenu : Form
    {
        public fMainMenu()
        {
            InitializeComponent();
        }

        private void bCalendar_Click(object sender, EventArgs e)
        {
            Form fCalendar = new fCalendar();
            //создаем новую форму календарь  
            fCalendar.Left = this.Left;
            fCalendar.Top = this.Top;
            //устанавливаем такие же координаты
            //как у родительской формы
            fCalendar.Show();
            //показываем форму календарь
            this.Hide();            
            //скрываем родительскую форму
        }

        private void bDesk_Click(object sender, EventArgs e)
        {
            Form fDesks = new fDesks();
            fDesks.Left = this.Left;
            fDesks.Top = this.Top;
            fDesks.Show();
            this.Hide();
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            Form fHelp = new fHelp();
            fHelp.Left = this.Left;
            fHelp.Top = this.Top;
            fHelp.Show();
            this.Hide();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

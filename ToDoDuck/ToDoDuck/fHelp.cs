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
    public partial class fHelp : Form
    {
        int displayedPic = 0;

        List<Bitmap> pic = new List<Bitmap>();

        public fHelp() {
            InitializeComponent();
            for (int i = 0; i < 5; i++) {
                pic.Add(new Bitmap("Help\\" + i.ToString() + ".png"));
            }            
            pbPicture.Image = (Image) pic[0];
        }
        
        private void bBack_Click(object sender, EventArgs e) {
            Form fMainMenu = Application.OpenForms[0];
            fMainMenu.StartPosition = FormStartPosition.Manual;
            fMainMenu.Left = this.Left;
            fMainMenu.Top = this.Top;
            fDesks.ActiveForm.Close();
            fMainMenu.Show();
        }

        private void bNextPic_Click(object sender, EventArgs e) {
            if (displayedPic != pic.Count - 1) {
                pbPicture.Image = (Image)pic[++displayedPic];
            }
            bPrevPic.Enabled = true;
            if (displayedPic == pic.Count - 1) {
                bNextPic.Enabled = false;
            }
        }

        private void bPrevPic_Click(object sender, EventArgs e) {
            if (displayedPic != 0) {
                pbPicture.Image = (Image)pic[--displayedPic];
            }
            bNextPic.Enabled = true;
            if (displayedPic == 0) {
                bPrevPic.Enabled = false;
            }
        }
    }
}

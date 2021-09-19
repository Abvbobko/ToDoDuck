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
    public partial class fDesks : Form
    {
        int openDeskIndex = -1;
        const string NAME_OF_DIRECTOTY = "Desks Data";

        List<TextBox> desks = new List<TextBox>();
        const string FONT_IN_DESKS = "Veranda";
        const int SIZE_OF_CHARS_IN_DESKS = 15;
        const int POSITION_OF_DESK_X = 12;
        const int POSITION_OF_DESK_Y = 12;
        const int HEIGHT_OF_DESK = 460;
        const int WIDTH_OF_DESK = 540;

        private void DeskCreate() {
            desks.Add(new TextBox());
            //добавление новой доски в список досок
            desks.Last().Font = new Font(FONT_IN_DESKS, SIZE_OF_CHARS_IN_DESKS);
            desks.Last().Multiline = true;
            desks.Last().BackColor = Color.Orange;
            desks.Last().BorderStyle = BorderStyle.FixedSingle;
            desks.Last().Location = new Point(POSITION_OF_DESK_X, POSITION_OF_DESK_Y); 
            desks.Last().Height = HEIGHT_OF_DESK;
            desks.Last().Width = WIDTH_OF_DESK;
            //задание параметров доски
            this.Controls.Add(desks.Last());
            //добавление доски на основную панель
        }

        public fDesks() {
            InitializeComponent();
            bNextDesk.Enabled = bPrevDesk.Enabled = false;
            if (!Directory.Exists(NAME_OF_DIRECTOTY)) {
                openDeskIndex = -1;
            }
            else {
                int i = 0;
                string deskFileLocation = NAME_OF_DIRECTOTY + "\\desk_" + i.ToString() + ".txt";
                //путь к первому файлу
                while (File.Exists(deskFileLocation)) {
                    //цикл выполняется до тех пор, пока есть нжные файлы
                    DeskCreate();
                    //метод, создающий доску
                    using (StreamReader desk = File.OpenText(deskFileLocation)) {                     
                        desks.Last().Text = desk.ReadToEnd();
                        //чтение из файла
                    }
                    desks.Last().Visible = false;
                    i++;
                    openDeskIndex++;
                    deskFileLocation = NAME_OF_DIRECTOTY + "\\desk_" + i.ToString() + ".txt";
                    //переход к следующему файлу
                }
                DeleteDirectory(NAME_OF_DIRECTOTY);
                if (desks.Count > 0) {
                    openDeskIndex = 0;
                    desks[0].Visible = true;
                    if (desks.Count > 1) {
                        bNextDesk.Enabled = true;
                    }
                }
            }

            if (openDeskIndex < 0) {
                bDeleteDesk.Enabled = false;
                lYouHaventDesks.Visible = true;
            }
            else {
                lYouHaventDesks.Visible = false;
                bDeleteDesk.Enabled = true;
            }
           
        }

        private void DeleteDirectory(string target_dir) {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files) {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs) {
                DeleteDirectory(dir);
            }
            Directory.Delete(target_dir, false);
        }

        private void SaveDesksInFile() {
            if (Directory.Exists(NAME_OF_DIRECTOTY)) {
                DeleteDirectory(NAME_OF_DIRECTOTY);
                //удаляем старую папку с досками
            }
            if (desks.Count > 0) {
                Directory.CreateDirectory(NAME_OF_DIRECTOTY);
                //создаем новую папку для досок
                for (int i = 0; i < desks.Count; i++) {
                    using (StreamWriter desk = File.CreateText(NAME_OF_DIRECTOTY + "\\desk_" + i.ToString() + ".txt")) {
                        desk.Write(desks[i].Text);
                        //записываем данные в файл
                    }
                }
            }
        }  

        private void bBack_Click(object sender, EventArgs e) {
            if (desks.Count > 0) {
                SaveDesksInFile();
            }
            Form fMainMenu = Application.OpenForms[0];
            fMainMenu.StartPosition = FormStartPosition.Manual;
            fMainMenu.Left = this.Left;
            fMainMenu.Top = this.Top;            
            fDesks.ActiveForm.Close();
            fMainMenu.Show();
        }        

        private void bCreateDesk_Click(object sender, EventArgs e) {
            lYouHaventDesks.Visible = false;
            if (desks.Count > 0) {                
                for (int i = 0; i < desks.Count; i++) {
                    desks[i].Visible = false;
                }                 
            }

            DeskCreate();           
            openDeskIndex = desks.Count - 1;
            bNextDesk.Enabled = false;
            if (openDeskIndex != 0) {
                bPrevDesk.Enabled = true;
            }
            bDeleteDesk.Enabled = true;
        }

        private void bDeleteDesk_Click(object sender, EventArgs e) {
            desks[openDeskIndex].Visible = false;
            if (desks.Count - 1 > openDeskIndex) {               
                desks[openDeskIndex + 1].Visible = true;
                desks.Remove(desks[openDeskIndex]);
            }
            else if (openDeskIndex > 0) {                
                desks[openDeskIndex - 1].Visible = true;
                desks.Remove(desks[openDeskIndex]);
                openDeskIndex--;
            } 
            else {
                desks.Remove(desks[openDeskIndex]);
                lYouHaventDesks.Visible = true;
                openDeskIndex = -1;                
            }
            
            if (openDeskIndex == -1) {
                bDeleteDesk.Enabled = false;
                bNextDesk.Enabled = bPrevDesk.Enabled = false;
            }
            else if (desks.Count == 1) {
                bNextDesk.Enabled = bPrevDesk.Enabled = false;
            }
            else if (openDeskIndex == desks.Count - 1) {
                bNextDesk.Enabled = false;
            }
            else if (openDeskIndex == 0) {
                bPrevDesk.Enabled = false;
            }               
        }

        private void bNextDesk_Click(object sender, EventArgs e) {
            bPrevDesk.Enabled = true;
            desks[openDeskIndex].Visible = false;
            openDeskIndex++;
            desks[openDeskIndex].Visible = true;
            if (openDeskIndex == desks.Count - 1) {
                bNextDesk.Enabled = false;
            }
        }

        private void bPrevDesk_Click(object sender, EventArgs e) {
            bNextDesk.Enabled = true;
            desks[openDeskIndex].Visible = false;
            openDeskIndex--;
            desks[openDeskIndex].Visible = true;
            if (openDeskIndex == 0) {
                bPrevDesk.Enabled = false;
            }
        }
    }
}

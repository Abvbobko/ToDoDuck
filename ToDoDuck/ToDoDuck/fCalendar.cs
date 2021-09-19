using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoDuck
{
    public partial class fCalendar : Form
    {
        private class DateButton : Button
        {
            public List<string> toDo = new List<string>();
        }

        DateTime displayedDate = new DateTime();
        Boolean childWinIsOpen = false;
        const int SIZE_OF_CELL = 60;
        const int CELL_DISTANCE = 10;
        const int DAYS_IN_WEEK = 7;
        const int START_Y_FOR_MONTH_TABLE = 20;
        int lastClicked = 0; 

        int[] posOfNameOfDayOfWeek = new int[DAYS_IN_WEEK];
        List<DateButton> numbersOfMonth = new List<DateButton>();

        public class TtoDo
        {
            public DateTime date;
            public List<string> tasks;
        }

        private List<TtoDo> allTasks = new List<TtoDo>();
        
        const string TASKS_FILE_LOCATION = "tasks.txt";

        public fCalendar()
        {
            InitializeComponent();          
        }   

        private string GetMonthName(int month) 
        {
            string[] months = {
                "Январь", "Февраль",
                "Март", "Апрель", "Май",
                "Июнь", "Июль", "Август",
                "Сентябрь", "Октябрь", "Ноябрь",
                "Декабрь"
            };
            return months[month - 1];
        }

        private int DayOfWeekInRussianStyle(DayOfWeek dayOfWeekInEnglishStyle)
        {
            const int FIRST_INDEX = 0;
            int numOfDayInWeek;
            switch (dayOfWeekInEnglishStyle) {
                case DayOfWeek.Monday:
                    numOfDayInWeek = FIRST_INDEX + 1;
                    break;
                case DayOfWeek.Tuesday:
                    numOfDayInWeek = FIRST_INDEX + 2;
                    break;
                case DayOfWeek.Wednesday:
                    numOfDayInWeek = FIRST_INDEX + 3;
                    break;
                case DayOfWeek.Thursday:
                    numOfDayInWeek = FIRST_INDEX + 4;
                    break;
                case DayOfWeek.Friday:
                    numOfDayInWeek = FIRST_INDEX + 5;
                    break;
                case DayOfWeek.Saturday:
                    numOfDayInWeek = FIRST_INDEX + 6;
                    break;
                default:
                    numOfDayInWeek = FIRST_INDEX + 7;
                    break;
            }
            return numOfDayInWeek;
        }

        const string FONT_OF_NUM_OF_MONTH = "Veranda";
        const int SIZE_OF_NUM_OF_MONTH = 20;

        private void CreateNewButton(int numOfDayInWeek, int daysCnt, int y) {
            int x = (numOfDayInWeek - 1) * (SIZE_OF_CELL + CELL_DISTANCE) + SIZE_OF_CELL / 2;
            numbersOfMonth.Add(new DateButton());
            numbersOfMonth.Last().Text = daysCnt.ToString();
            numbersOfMonth.Last().Font = new Font(FONT_OF_NUM_OF_MONTH, SIZE_OF_NUM_OF_MONTH);
            numbersOfMonth.Last().Width = numbersOfMonth.Last().Height = SIZE_OF_CELL;
            numbersOfMonth.Last().BackColor = Color.Orange;
            numbersOfMonth.Last().FlatAppearance.BorderSize = 2;
            numbersOfMonth.Last().FlatAppearance.BorderColor = Color.Orange;
            numbersOfMonth.Last().FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            numbersOfMonth.Last().FlatStyle = FlatStyle.Flat;
            numbersOfMonth.Last().Location = new Point(x, y);
            pane.Controls.Add(numbersOfMonth.Last());
        }

        delegate void SomeFunc();
        private void CreateCalendar(DateTime dateForDisplay, SomeFunc InitializeNumbers)
        {
            lMonth.Text = GetMonthName(dateForDisplay.Month);
            lYear.Text = dateForDisplay.Year.ToString(); 
            int daysCnt = 1;
            DateTime firstDayOfMonth = new DateTime(dateForDisplay.Year, dateForDisplay.Month, 1, 0, 0, 0);
            int numOfDayInWeek = DayOfWeekInRussianStyle(firstDayOfMonth.DayOfWeek);

            int y = START_Y_FOR_MONTH_TABLE;
            int DaysInMonth = DateTime.DaysInMonth(dateForDisplay.Year, dateForDisplay.Month);  

            while (daysCnt <= DaysInMonth) {
                while ((numOfDayInWeek != (DAYS_IN_WEEK + 1)) && (daysCnt <= DaysInMonth)) {
                    CreateNewButton(numOfDayInWeek, daysCnt, y);
                    numOfDayInWeek++;                
                    daysCnt++;    
                }
                y += SIZE_OF_CELL + CELL_DISTANCE;                
                numOfDayInWeek = 1;
            }
            InitializeNumbers();

            if ( (displayedDate.Month == DateTime.Now.Month) && (displayedDate.Year == DateTime.Now.Year) ) {
                numbersOfMonth[displayedDate.Day - 1].BackColor = Color.Green;
            }

            for (int i = 0; i < numbersOfMonth.Count; i++) {
                numbersOfMonth[i].Click += numbersOfMonth_Click;
            }
        }

        private void EmptyFunc() {}

        private void InitializeToDoListOfDaysOfMonth() {
            DateTime thisMonth = new DateTime(displayedDate.Year, displayedDate.Month, 
                DateTime.DaysInMonth(displayedDate.Year, displayedDate.Month));

            for (int i = 0; i < allTasks.Count; i++) {
                if (allTasks[i].date > thisMonth) {
                    break;
                }
                if ((allTasks[i].date.Month == displayedDate.Month) && (allTasks[i].date.Year == displayedDate.Year)) {
                    numbersOfMonth[allTasks[i].date.Day - 1].toDo = allTasks[i].tasks;
                    numbersOfMonth[allTasks[i].date.Day - 1].FlatAppearance.BorderColor = Color.AliceBlue;
                }      
            }
        }

        private void fCalendar_Shown(object sender, EventArgs e)
        {
            if (File.Exists(TASKS_FILE_LOCATION)) {
                using (StreamReader taskFile = File.OpenText(TASKS_FILE_LOCATION)) {
                    while (!taskFile.EndOfStream) {

                        allTasks.Add(new TtoDo());
                        allTasks.Last().date = DateTime.Parse(taskFile.ReadLine());
                        allTasks.Last().tasks = new List<string>();
                        string tmp = taskFile.ReadLine();
                        while (tmp != "") {
                            allTasks.Last().tasks.Add(tmp);
                            if (taskFile.EndOfStream) {
                                tmp = "";
                            }
                            else {
                                tmp = taskFile.ReadLine();
                            }
                        }
                    }
                }
            }

            displayedDate = DateTime.Now;
            if (allTasks.Count == 0) {
                CreateCalendar(displayedDate, EmptyFunc);
            }
            else {
                CreateCalendar(displayedDate, InitializeToDoListOfDaysOfMonth);
            }
                       
            LabelOfNameOfDaysOfWeekLocation();
            if (displayedDate.AddMonths(-1).Year != DateTime.Now.Year) {
                bPrevMonth.Enabled = false;
            }
            else {
                bPrevMonth.Enabled = true;
            }
        }

        const int OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK = 5;

        private void LabelOfNameOfDaysOfWeekLocation() {

            for (int i = 0; i < DAYS_IN_WEEK; i++) {
                posOfNameOfDayOfWeek[i] = i * (SIZE_OF_CELL + CELL_DISTANCE) + 3 * SIZE_OF_CELL / 4 + pane.Location.X ;
            }

            lMon.Location = new Point(posOfNameOfDayOfWeek[0], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
            lTue.Location = new Point(posOfNameOfDayOfWeek[1], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
            lWen.Location = new Point(posOfNameOfDayOfWeek[2], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
            lThu.Location = new Point(posOfNameOfDayOfWeek[3], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
            lFri.Location = new Point(posOfNameOfDayOfWeek[4], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
            lSat.Location = new Point(posOfNameOfDayOfWeek[5], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
            lSun.Location = new Point(posOfNameOfDayOfWeek[6], lMonth.Location.Y + OFFSET_Y_FOR_NAME_OF_DAYS_OF_WEEK);
        }

        private void bBack_Click(object sender, EventArgs e) {
            using (StreamWriter tmpFile = File.CreateText(TASKS_FILE_LOCATION)) {
                for (int i = 0; i < allTasks.Count; i++) {
                    tmpFile.WriteLine(allTasks[i].date.ToString());
                    for (int j = 0; j < allTasks[i].tasks.Count; j++) {
                        tmpFile.WriteLine(allTasks[i].tasks[j]);
                    }
                    tmpFile.WriteLine();
                }
            }
                Form fMainMenu = Application.OpenForms[0];            
            fMainMenu.StartPosition = FormStartPosition.Manual;
            fMainMenu.Left = this.Left;
            fMainMenu.Top = this.Top;
            //устанавливаем стартовую позицию родительской формы
            fCalendar.ActiveForm.Close();
            //закрываем форму календарь
            fMainMenu.Show();        
            //отображаем родительскую форму
        }

        const int OFFSET_OF_WINDOW_WITH_TO_DO_LIST_X = 10;
        const int OFFSET_OF_WINDOW_WITH_TO_DO_LIST_Y = 15;
        
        private void numbersOfMonth_Click(object sender, EventArgs e) {               
            if (!childWinIsOpen) {
                this.Enabled = false;
                lastClicked = int.Parse((sender as Button).Text);
                fToDoDayList fToDoDayList = new fToDoDayList(
                    new DateTime(displayedDate.Year, displayedDate.Month, int.Parse((sender as Button).Text)),
                    int.Parse((sender as Button).Text),
                    (sender as DateButton).toDo
                );
                fToDoDayList.Show();

                fToDoDayList.Left = this.Left + (this.Width - fToDoDayList.Width) - OFFSET_OF_WINDOW_WITH_TO_DO_LIST_X;
                fToDoDayList.Top = this.Top + OFFSET_OF_WINDOW_WITH_TO_DO_LIST_Y;
            }            
        }

        private void bNextMonth_Click(object sender, EventArgs e) {
            pane.Controls.Clear();
            numbersOfMonth.Clear();
            displayedDate = displayedDate.AddMonths(1);
            if (allTasks.Count == 0) {
                CreateCalendar(displayedDate, EmptyFunc);
            }
            else {
                CreateCalendar(displayedDate, InitializeToDoListOfDaysOfMonth);
            }
            if (displayedDate.AddMonths(-1).Year < DateTime.Now.Year) {
                bPrevMonth.Enabled = false;
            }
            else {
                bPrevMonth.Enabled = true;
            }
        }

        private void bPrevMonth_Click(object sender, EventArgs e) {
            pane.Controls.Clear();
            numbersOfMonth.Clear();
            displayedDate = displayedDate.AddMonths(-1);
            if (allTasks.Count == 0) {
                CreateCalendar(displayedDate, EmptyFunc);
            }
            else {
                CreateCalendar(displayedDate, InitializeToDoListOfDaysOfMonth);
            }
            if (displayedDate.AddMonths(-1).Year < DateTime.Now.Year) {
                bPrevMonth.Enabled = false;
            }
            else {
                bPrevMonth.Enabled = true;
            }
                   
            
        }

        private void AddToListOfTasks(DateButton checkedNum) {
            allTasks.Add(new TtoDo());
            allTasks.Last().date = new DateTime(displayedDate.Year, displayedDate.Month, int.Parse(checkedNum.Text));
            allTasks.Last().tasks = checkedNum.toDo;
        }

        private void SortListOfTastks() {
            
            for (int i = 0; i < allTasks.Count; i++)
                for (int j = 0; j < allTasks.Count - 1; j++) {
                    if (allTasks[j].date > allTasks[j + 1].date) {
                        TtoDo tmp = allTasks[j];
                        allTasks[j] = allTasks[j + 1];
                        allTasks[j + 1] = tmp;
                    }
                }            
        }      

        private void DeleteFromListOfTasks(DateTime findDate) {
            for (int i = 0; i < allTasks.Count; i++) {
                if (allTasks[i].date == findDate) {
                    allTasks.RemoveAt(i);
                    break;
                }
            }
        }

        private void FindAndCorrectInListOfTasks(DateButton checkedNum) {
            DateTime nesDate = new DateTime(displayedDate.Year, displayedDate.Month, int.Parse(checkedNum.Text));
            for (int i = 0; i < allTasks.Count; i++) {
                if (allTasks[i].date == nesDate) {
                    allTasks[i].tasks = checkedNum.toDo;
                }
            }
        }

        private void fCalendar_EnabledChanged(object sender, EventArgs e) {
            if (this.Enabled) {
                using (StreamReader tmpFile = File.OpenText("tmpFile.txt")) {
                    numbersOfMonth[lastClicked - 1].toDo.Clear();
                    while (!tmpFile.EndOfStream) {
                        numbersOfMonth[lastClicked - 1].toDo.Add(tmpFile.ReadLine());
                        
                    }

                    if (numbersOfMonth[lastClicked - 1].toDo.Count == 0) {
                        if (numbersOfMonth[lastClicked - 1].FlatAppearance.BorderColor == Color.AliceBlue) {
                            DeleteFromListOfTasks(new DateTime(displayedDate.Year, displayedDate.Month, int.Parse(numbersOfMonth[lastClicked - 1].Text)));
                           
                        }
                        numbersOfMonth[lastClicked - 1].FlatAppearance.BorderColor = Color.Orange;
                    }
                    else {
                        if (numbersOfMonth[lastClicked - 1].FlatAppearance.BorderColor == Color.Orange) {
                            AddToListOfTasks(numbersOfMonth[lastClicked - 1]);
                           
                        }
                        else {
                            FindAndCorrectInListOfTasks(numbersOfMonth[lastClicked - 1]);
                        }

                        numbersOfMonth[lastClicked - 1].FlatAppearance.BorderColor = Color.AliceBlue;
                            
                    }
                    SortListOfTastks();
                    //чтение из файла
                }
            }
        }
    }
}

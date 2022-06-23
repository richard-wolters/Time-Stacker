using System;
using System.IO;
using System.Windows.Forms;

namespace TimeStackerForms
{
    public partial class TimeStackerUI : Form
    {
        int weekHours;
        int allTimeHours;
        int todayHours;
        int bonusHours = 0;
        string output;
        string output2;
        int weekSoll = 10;
        string depositLoc = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/stackDeposit.txt";
        string stackHistoryLoc = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/stackHistory.txt";
        string lastStackTime;


        public TimeStackerUI()
        {
            InitializeComponent();

            DateTime stackDepositWriteTime = File.GetLastWriteTime(depositLoc);
            DateTime timeNow = DateTime.Now;
            string textDateiImport = System.IO.File.ReadAllText(depositLoc);
            string textDateiImport2 = System.IO.File.ReadAllText(stackHistoryLoc);
            string[] stundenImport = textDateiImport.Split('#');
            this.lastStackTime = textDateiImport2;
            this.allTimeHours = Convert.ToInt32(stundenImport[0]);
            this.weekHours  = Convert.ToInt32(stundenImport[1]);
            this.bonusHours     = Convert.ToInt32(stundenImport[2]);
            bool weekEvaluation = DatesAreInTheSameWeek(timeNow, stackDepositWriteTime);
            if (weekEvaluation == false)
            {
                this.weekHours = 0;
            }
            this.lbl_allTime.Text = "Gesamte Stunden 2022:    " + allTimeHours.ToString();
            pBar_weeklyProgressBar.Maximum = weekSoll;
            if (this.weekHours > pBar_weeklyProgressBar.Maximum) 
            {
                pBar_weeklyProgressBar.Value = pBar_weeklyProgressBar.Maximum;
            }
            else
            {
                pBar_weeklyProgressBar.Value = this.weekHours;
            }
            lbl_weeklyEvaluation.Text = $@"{weekHours} / {weekSoll}";
            lbl_stackHistory.Text = "Letzter Stack: " + textDateiImport2;
            DateTime eventDay   = new DateTime(2022, 8, 1);
            DateTime currentDay = DateTime.Today;
            TimeSpan daysTillEvent = eventDay - currentDay;
            var daysTillEventString = daysTillEvent.ToString("%d");
            lbl_restTageBisEvent.Text = "Tage bis zur Bewerbungsphase: "+ daysTillEventString;
            lbl_bonusHours.Text = "Bonus-Stunden: " + this.bonusHours.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stundenHeuteBar_Scroll(object sender, EventArgs e)
        {
            this.todayHours = this.tBar_stundenHeute.Value;
            this.lbl_counter.Text = todayHours.ToString() + " Stunden";            // ToString() nicht unbedingt notwendig, aber korrekt.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.allTimeHours = this.allTimeHours + this.todayHours;
            this.weekHours = this.weekHours + this.todayHours;
            this.lbl_allTime.Text = "Gesamte Stunden 2022:    " + allTimeHours.ToString();
            if (this.weekHours >= 10)
            {
                bonusHours += todayHours;
            }

            this.output = allTimeHours.ToString() + "#" + weekHours.ToString() + "#" + bonusHours.ToString();
            System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/stackDeposit.txt", output);
           

            lbl_weeklyEvaluation.Text = $@"{weekHours} / {weekSoll}";
            if (this.weekHours > pBar_weeklyProgressBar.Maximum)
            {
                pBar_weeklyProgressBar.Value = pBar_weeklyProgressBar.Maximum;
            }
            else
            {
                pBar_weeklyProgressBar.Value = this.weekHours;
            }


            DateTime lastStackTemp = DateTime.Now;
            this.lastStackTime = lastStackTemp.ToString();
            
            lbl_stackHistory.Text = "Stack-History: \n" + lastStackTime + "     Anzahl der Stunden: " + todayHours.ToString();

            this.output2 = lastStackTime + "\nAnzahl der Stunden: " + todayHours;
            System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/stackHistory.txt", output2);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pBar_weeklyProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_counter_Click(object sender, EventArgs e)
        {

        }

        private void tBar_stundenHeute_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_allTime_Click(object sender, EventArgs e)
        {

        }

        private bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var dayOfWeek =     (int)cal.GetDayOfWeek(date1);
            var dayOfWeek2 =    (int)cal.GetDayOfWeek(date2);
            if (dayOfWeek == 0)
            {
                dayOfWeek += 7;
            }

            if (dayOfWeek2 == 0)
            {
                dayOfWeek2  += 7;
            }
            var d1 = date1.Date.AddDays(-1 * dayOfWeek);
            var d2 = date2.Date.AddDays(-1 * dayOfWeek2); 

            return d1 == d2;
        }
        public static void BonusHours(int a, int b)
        {

        }
    }
}

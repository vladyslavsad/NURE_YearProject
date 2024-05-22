using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nure
{
    public partial class introduceForm : Form
    {
        private string CurrentUnikUserID;
        public introduceForm(string unikUserID) // передаємо unikUserID з форми до форми тим сами забеспечуэмо інкапсуляцію
        {
            CurrentUnikUserID = unikUserID;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Відключення кнопок максимізації та мінімізації
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(818, 497);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void createAnceteButton_Click(object sender, EventArgs e)
        {
            ancetCompilation AncetCompilation = new ancetCompilation(CurrentUnikUserID);
            AncetCompilation.Show();
            this.Close();
        }

        private void ShowMyAncete_Click(object sender, EventArgs e)
        {
            int tabPageIndex = 0; // передаємо таб індекс для автомаичного відкривання певного пейджу в контролі
            myVacanciesAncetsTab vacanciesAncetsTab = new myVacanciesAncetsTab(CurrentUnikUserID, tabPageIndex);
            vacanciesAncetsTab.Show();

        }

        private void createVacanciButton_Click(object sender, EventArgs e)
        {
            vacanciCompilation vacanciCompilationForm = new vacanciCompilation(CurrentUnikUserID);
            vacanciCompilationForm.Show();
            this.Close();
        }

        private void ShowMyVacanciButton_Click(object sender, EventArgs e)
        {
            int tabPageIndex = 1;
            myVacanciesAncetsTab vacanciesAncetsTab = new myVacanciesAncetsTab(CurrentUnikUserID, tabPageIndex);
            vacanciesAncetsTab.Show();

        }

        private void ShowVacanciesButton_Click(object sender, EventArgs e)
        {
            searchOfVacancy searchOfVacancy = new searchOfVacancy(CurrentUnikUserID);
            searchOfVacancy.Show();
            this.Close();
        }

        private void ShowWorkersButton_Click(object sender, EventArgs e)
        {
            searchOfWorkers searchOfWorkers = new searchOfWorkers(CurrentUnikUserID);
            searchOfWorkers.Show();
            this.Close();
        }



  
    }
}

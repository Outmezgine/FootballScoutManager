using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballScoutManager.Code_Classes;
using FootballScoutManager.Forms;


namespace FootballScoutManager
{
    public partial class Form1 : Form
    {
        public static string managerName;
        public static string managerPhilosophy;
        public static string managerPurchingPurpose;

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            int requirements = 0;

            // Check the manager name.
            if (UserNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please enter name!");
            }
            else
            {
                manager.Name = UserNameTextbox.Text;
                managerName = manager.Name;
                requirements++;
            }

            // Check the manager age.
            if (UserAgeTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please enter age!");
            }
            else
            {
                manager.Age = Int32.Parse(UserAgeTextbox.Text);
                requirements++;

            }


            manager.FootballPhilosophy = GamePhilosophyComboBox.SelectedIndex;
            managerPhilosophy = GamePhilosophyComboBox.Text;

            manager.PurchasingPurpose = PurchasingPurposeComboBox.SelectedIndex;
            managerPurchingPurpose = PurchasingPurposeComboBox.Text;



            // Check if the user fill the Game Philosophy / Purchasing Purpose.
            if (GamePhilosophyComboBox.Text.Length == 0 || PurchasingPurposeComboBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter Game Philosophy / Purchasing Purpose ");
            } else
            {
                requirements += 2;
            }



            //PlayerScoutForm playerScoutForm = new PlayerScoutForm();
            //this.Hide();
            //playerScoutForm.Show();


            //   Check if the manager fill all the fields he required.
            if (requirements == 4)
            {
                PlayerScoutForm playerScoutForm = new PlayerScoutForm();
                this.Hide();
                playerScoutForm.Show();
            }


        }



        private void UserAgeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; 

            if (!Char.IsDigit(ch) && ch != 8  )
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }

        }

        private void GamePhilosophyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GamePhilosophyComboBox.Text)
            {
                case "High Pressuere":
                    Manager.managerPhilosophy = 1;
                    break;
                case "Possesion":
                    Manager.managerPhilosophy = 2;
                    break;
                case "Long Ball":
                    Manager.managerPhilosophy = 3;
                    break;
                default: throw new Exception("Not a valid manager philosophy.");
            }
        }

        private void PurchasingPurposeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PurchasingPurposeComboBox.Text)
            {
                case "Star Player":
                    Manager.overallRating = 16;
                    Manager.specificRoleStandart = 14;
                    break;
                case "Rotation Player":
                    Manager.overallRating = 13;
                    Manager.specificRoleStandart = 11;
                    break;
                case "Young Player":
                    Manager.overallRating = 10;
                    Manager.specificRoleStandart = 8;
                    break;
                default: throw new Exception("Not a valid manager standard.");
            }
        }
    }
}

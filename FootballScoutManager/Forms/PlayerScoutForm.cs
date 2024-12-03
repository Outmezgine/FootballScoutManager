using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using FootballScoutManager.Code_Classes;
using FootballScoutManager;
using System.Windows.Forms;

namespace FootballScoutManager.Forms
{

    [Serializable]

    public partial class PlayerScoutForm : Form
    {
        PlayerManager playerManager = new PlayerManager();

        int inListPlayerId = 0;

        public PlayerScoutForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayerScoutForm_Load(object sender, EventArgs e)
        {
            ManagerNameTitle.Text = Form1.managerName + "'s List";
            ManagerPhilosophyAndPurching.Text = "Game Philosophy: " + Form1.managerPhilosophy + " | Purching Purpose: " + Form1.managerPurchingPurpose;
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            inListPlayerId++;

            if (GoalkeeperRadioBtn.Checked)
            {
                if (PlayerAgeTextBox.Text.Length == 0 || PlayerNameTextBox.Text.Length == 0 || SpeedTextBox.Text.Length == 0 || JumpTextBox.Text.Length == 0
                 || StaminaTextBox.Text.Length == 0 || SalaryComboBox.Text.Length == 0 || ReflexTextBox.Text.Length == 0 || OneOnOneTextBox.Text.Length == 0
                 || FootGameTextBox.Text.Length == 0 || ThrowingTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {

                    // Create the player we want to add.
                    GoalKeeper goalKeeper = new GoalKeeper(Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                        Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(ReflexTextBox.Text),
                        Int32.Parse(OneOnOneTextBox.Text), Int32.Parse(FootGameTextBox.Text), Int32.Parse(ThrowingTextBox.Text));
                    goalKeeper.Id = inListPlayerId;
                    // Scout the player
                    int goalkeeperFitPhylosopy = goalKeeper.isPlayerFitPhilosophy(Manager.managerPhilosophy);
                    int goalKeeperScouted = goalKeeper.Scout();
                    bool isTotalFit = goalKeeper.FinalCheck(goalKeeperScouted, goalkeeperFitPhylosopy);
                    if (isTotalFit)
                    {
                        // Add the new player to our Dictionary.
                        playerManager.addPlayer(goalKeeper,
                            Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                             Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(ReflexTextBox.Text),
                             Int32.Parse(OneOnOneTextBox.Text), Int32.Parse(FootGameTextBox.Text), Int32.Parse(ThrowingTextBox.Text));

                        // Add our player to our winform list.
                        GoodPlayersListBox.Items.Add("Position: Goalkeeper |" + " Age: " + goalKeeper.Age + " | Name:" + goalKeeper.Name + " | OverAll Rating:" + goalKeeper.Scout() + " | -> Is fit.");

                    }
                    else
                    {
                        MessageBox.Show(goalKeeper.Name + " not fit to your need");

                    }
                }




            }
            else if (DefenderRadioBtn.Checked)
            {
                if (PlayerAgeTextBox.Text.Length == 0 || PlayerNameTextBox.Text.Length == 0 || SpeedTextBox.Text.Length == 0 || JumpTextBox.Text.Length == 0
                || StaminaTextBox.Text.Length == 0 || SalaryComboBox.Text.Length == 0 || DefenderSavingTextBox.Text.Length == 0 || DefenderPowerTextBox.Text.Length == 0
                || DefenderBraveTextBox.Text.Length == 0 || DefenderTacklesTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {
                    // Create the player we want to add.
                    Defender defender = new Defender(Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                       Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(DefenderPowerTextBox.Text),
                       Int32.Parse(DefenderTacklesTextBox.Text), Int32.Parse(DefenderSavingTextBox.Text), Int32.Parse(DefenderBraveTextBox.Text));
                    defender.Id = inListPlayerId;


                    // Scout the player
                    int defenderFitPhylosopy = defender.isPlayerFitPhilosophy(Manager.managerPhilosophy);
                    int defenderScouted = defender.Scout();
                    bool isTotalFit = defender.FinalCheck(defenderScouted, defenderFitPhylosopy);
                    if (isTotalFit)
                    {
                        // Add the new player to our Dictionary.
                        playerManager.addPlayer(defender,
                          Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                           Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(DefenderPowerTextBox.Text),
                           Int32.Parse(DefenderTacklesTextBox.Text), Int32.Parse(DefenderSavingTextBox.Text), Int32.Parse(DefenderBraveTextBox.Text));

                        // Add our player to our winform list.
                        GoodPlayersListBox.Items.Add("Position: Defender |" + " Age: " + defender.Age + " | Name:" + defender.Name + " | OverAll Rating:" + defender.Scout() + " | -> Is fit.");

                    }
                    else
                    {
                        MessageBox.Show(defender.Name + " not fit to your need");
                    }
                }

            }
            else if (MidfielderRadioBtn.Checked)
            {
                if (PlayerAgeTextBox.Text.Length == 0 || PlayerNameTextBox.Text.Length == 0 || SpeedTextBox.Text.Length == 0 || JumpTextBox.Text.Length == 0
               || StaminaTextBox.Text.Length == 0 || SalaryComboBox.Text.Length == 0 || MidLongPassTextBox.Text.Length == 0 || MidLongShootTextBox.Text.Length == 0
               || MidPowerTextBox.Text.Length == 0 || PassingTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {
                    // Create the player we want to add.
                    MidFielder midFielder = new MidFielder(Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                       Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(PassingTextBox.Text),
                       Int32.Parse(MidPowerTextBox.Text), Int32.Parse(MidLongShootTextBox.Text), Int32.Parse(MidLongPassTextBox.Text));
                    midFielder.Id = inListPlayerId;



                    // Scout the player
                    int midfielderFitPhylosopy = midFielder.isPlayerFitPhilosophy(Manager.managerPhilosophy);
                    int midfielderScouted = midFielder.Scout();
                    bool isTotalFit = midFielder.FinalCheck(midfielderScouted, midfielderFitPhylosopy);
                    if (isTotalFit)
                    {
                        // Add the new player to our Dictionary.
                        playerManager.addPlayer(midFielder,
                         Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                           Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(PassingTextBox.Text),
                           Int32.Parse(MidPowerTextBox.Text), Int32.Parse(MidLongShootTextBox.Text), Int32.Parse(MidLongPassTextBox.Text));

                        // Add our player to our winform list.
                        GoodPlayersListBox.Items.Add("Position: MidFielder |" + " Age: " + midFielder.Age + " | Name:" + midFielder.Name + " | OverAll Rating:" + midFielder.Scout() + " | -> Is fit.");
                    }
                    else
                    {
                        MessageBox.Show(midFielder.Name + " not fit to your need");
                        //  MessageBox.Show(midFielder.Scout().ToString() + " | manager pholosphy:" + Manager.managerPhilosophy + " | overall rating" + Manager.overallRating + " | Specific role stantard:" + Manager.specificRoleStandart + " | isFit:" + midfielderFitPhylosopy + " | total fit: " + isTotalFit + " | scout:" + midfielderScouted);

                    }
                }
          

            }
            else if (AttackerRadioBtn.Checked)
            {
                if (PlayerAgeTextBox.Text.Length == 0 || PlayerNameTextBox.Text.Length == 0 || SpeedTextBox.Text.Length == 0 || JumpTextBox.Text.Length == 0
              || StaminaTextBox.Text.Length == 0 || SalaryComboBox.Text.Length == 0 || AttackerFinishTextBox.Text.Length == 0 || AttackerHeadingTextBox.Text.Length == 0
              || AttackerPassTextBox.Text.Length == 0 || AttackerShootTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {

                    // Create the player we want to add.
                    Attacker attacker = new Attacker(Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                       Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(AttackerFinishTextBox.Text),
                       Int32.Parse(AttackerShootTextBox.Text), Int32.Parse(AttackerPassTextBox.Text), Int32.Parse(AttackerHeadingTextBox.Text));
                    attacker.Id = inListPlayerId;



                    // Scout the player
                    int attackerFitPhylosopy = attacker.isPlayerFitPhilosophy(Manager.managerPhilosophy);
                    int attackerScouted = attacker.Scout();
                    bool isTotalFit = attacker.FinalCheck(attackerScouted, attackerFitPhylosopy);
                    if (isTotalFit)
                    {
                        // Add the new player to our Dictionary.
                        playerManager.addPlayer(attacker,
                        Int32.Parse(PlayerAgeTextBox.Text), PlayerNameTextBox.Text, Int32.Parse(SpeedTextBox.Text),
                           Int32.Parse(JumpTextBox.Text), Int32.Parse(StaminaTextBox.Text), SalaryComboBox.Text, Int32.Parse(AttackerFinishTextBox.Text),
                           Int32.Parse(AttackerShootTextBox.Text), Int32.Parse(AttackerPassTextBox.Text), Int32.Parse(AttackerHeadingTextBox.Text));

                        // Add our player to our winform list.
                        GoodPlayersListBox.Items.Add("Position: Attacker |" + " Age: " + attacker.Age + " | Name:" + attacker.Name + " | OverAll Rating:" + attacker.Scout() + " | -> Is fit.");

                    }
                    else
                    {
                        MessageBox.Show(attacker.Name + " not fit to your need");
                    }
                }

            }
            


        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (GoodPlayersListBox.Items.Count > 0)
            {
                GoodPlayersListBox.Items.RemoveAt(GoodPlayersListBox.SelectedIndex);
                playerManager.removePlayer(GoodPlayersListBox.SelectedIndex);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "Football Manager Scout files (*.fms)|*.fms|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, playerManager);
                }
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            int listSize;
            GoodPlayersListBox.Items.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Football Manager Scout files (*.fms)|*.fms|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new BinaryFormatter();
                playerManager = (PlayerManager)binaryFormatter.Deserialize(stream);


                // Show the list to the user;
                listSize = playerManager.getListSize();

                for (int i = 1; i <= listSize; i++)
                {
                    GoodPlayersListBox.Items.Add(playerManager.getInfoAboutPlayer(playerManager.getPlayer(i)));
                }

                //GoodPlayersListBox.Items.Add(playerManager.getInfoAboutPlayer(playerManager.getPlayer(1)));
                //GoodPlayersListBox.Items.Add(playerManager.getInfoAboutPlayer(playerManager.getPlayer(2)));
                //GoodPlayersListBox.Items.Add(playerManager.getInfoAboutPlayer(playerManager.getPlayer(3)));

                inListPlayerId = listSize;

            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            GoodPlayersListBox.Items.Clear();
            playerManager.removeAllPlayers();
            AddBtn.Enabled = true;

        }

        private void GoalkeeperRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            GoalkeeperGroupBox.Enabled = true;
            DefenderGroupBox.Enabled = false;
            MidfielderGroupBox.Enabled = false;
            AttackerGroupBox.Enabled = false;
        }

        private void DefenderRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            GoalkeeperGroupBox.Enabled = false;
            DefenderGroupBox.Enabled = true;
            MidfielderGroupBox.Enabled = false;
            AttackerGroupBox.Enabled = false;
        }

        private void MidfielderRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            GoalkeeperGroupBox.Enabled = false;
            DefenderGroupBox.Enabled = false;
            MidfielderGroupBox.Enabled = true;
            AttackerGroupBox.Enabled = false;
        }

        private void AttackerRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            GoalkeeperGroupBox.Enabled = false;
            DefenderGroupBox.Enabled = false;
            MidfielderGroupBox.Enabled = false;
            AttackerGroupBox.Enabled = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int editedIndex = GoodPlayersListBox.SelectedIndex;
            int previusIs = GoodPlayersListBox.SelectedIndex;

            GoodPlayersListBox.Items.Insert(editedIndex +1 , "ID: " + playerManager.getInfoAboutPlayer(playerManager.getPlayer(editedIndex)) +
            "|" + " Position: Attacker |" + " Age: " + PlayerAgeTextBox.Text + "| Name:" + PlayerNameTextBox.Text + " | -> Is fit to your needs.");
            GoodPlayersListBox.Items.RemoveAt(editedIndex);

        }


        private void ClearFieldsBtn_Click(object sender, EventArgs e)
        {
            // Personal Info
            PlayerAgeTextBox.Clear();
            PlayerNameTextBox.Clear();
            // Physical Info
            SpeedTextBox.Clear();
            JumpTextBox.Clear();
            StaminaTextBox.Clear();
            // Salary Info
            SalaryComboBox.SelectedIndex = -1;
            // Goalkeeper Info
            ReflexTextBox.Clear();
            OneOnOneTextBox.Clear();
            FootGameTextBox.Clear();
            ThrowingTextBox.Clear();
            // Defender Info
            DefenderPowerTextBox.Clear();
            DefenderTacklesTextBox.Clear();
            DefenderSavingTextBox.Clear();
            DefenderBraveTextBox.Clear();
            // Midfielder Info
            MidLongPassTextBox.Clear();
            MidLongShootTextBox.Clear();
            MidPowerTextBox.Clear();
            PassingTextBox.Clear();
            // Attacker Info
            AttackerFinishTextBox.Clear();
            AttackerHeadingTextBox.Clear();
            AttackerPassTextBox.Clear();
            AttackerShootTextBox.Clear();


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void PlayerAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }


        private void ReflexTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(ReflexTextBox.Text, out box_int);
            if (box_int < 0 && ReflexTextBox.Text != "")
            {
                ReflexTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && ReflexTextBox.Text != "")
            {
                ReflexTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void ReflexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void OneOnOneTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(OneOnOneTextBox.Text, out box_int);
            if (box_int < 0 && OneOnOneTextBox.Text != "")
            {
                OneOnOneTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && OneOnOneTextBox.Text != "")
            {
                OneOnOneTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void FootGameTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(FootGameTextBox.Text, out box_int);
            if (box_int < 0 && FootGameTextBox.Text != "")
            {
                FootGameTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && FootGameTextBox.Text != "")
            {
                FootGameTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void ThrowingTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(ThrowingTextBox.Text, out box_int);
            if (box_int < 0 && ThrowingTextBox.Text != "")
            {
                ThrowingTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && ThrowingTextBox.Text != "")
            {
                ThrowingTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void DefenderPowerTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(DefenderPowerTextBox.Text, out box_int);
            if (box_int < 0 && DefenderPowerTextBox.Text != "")
            {
                DefenderPowerTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && DefenderPowerTextBox.Text != "")
            {
                DefenderPowerTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void DefenderTacklesTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(DefenderTacklesTextBox.Text, out box_int);
            if (box_int < 0 && DefenderTacklesTextBox.Text != "")
            {
                DefenderTacklesTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && DefenderTacklesTextBox.Text != "")
            {
                DefenderTacklesTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void DefenderSavingTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(DefenderSavingTextBox.Text, out box_int);
            if (box_int < 0 && DefenderSavingTextBox.Text != "")
            {
                DefenderSavingTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && DefenderSavingTextBox.Text != "")
            {
                DefenderSavingTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void DefenderBraveTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(DefenderBraveTextBox.Text, out box_int);
            if (box_int < 0 && DefenderBraveTextBox.Text != "")
            {
                DefenderBraveTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && DefenderBraveTextBox.Text != "")
            {
                DefenderBraveTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void PassingTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(PassingTextBox.Text, out box_int);
            if (box_int < 0 && PassingTextBox.Text != "")
            {
                PassingTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && PassingTextBox.Text != "")
            {
                PassingTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void MidPowerTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(MidPowerTextBox.Text, out box_int);
            if (box_int < 0 && MidPowerTextBox.Text != "")
            {
                MidPowerTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && MidPowerTextBox.Text != "")
            {
                MidPowerTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void MidLongShootTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(MidLongShootTextBox.Text, out box_int);
            if (box_int < 0 && MidLongShootTextBox.Text != "")
            {
                MidLongShootTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && MidLongShootTextBox.Text != "")
            {
                MidLongShootTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void MidLongPassTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(MidLongPassTextBox.Text, out box_int);
            if (box_int < 0 && MidLongPassTextBox.Text != "")
            {
                MidLongPassTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && MidLongPassTextBox.Text != "")
            {
                MidLongPassTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void AttackerFinishTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(AttackerFinishTextBox.Text, out box_int);
            if (box_int < 0 && AttackerFinishTextBox.Text != "")
            {
                AttackerFinishTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && AttackerFinishTextBox.Text != "")
            {
                AttackerFinishTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void AttackerShootTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(AttackerShootTextBox.Text, out box_int);
            if (box_int < 0 && AttackerShootTextBox.Text != "")
            {
                AttackerShootTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && AttackerShootTextBox.Text != "")
            {
                AttackerShootTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void AttackerPassTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(AttackerPassTextBox.Text, out box_int);
            if (box_int < 0 && AttackerPassTextBox.Text != "")
            {
                AttackerPassTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && AttackerPassTextBox.Text != "")
            {
                AttackerPassTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void AttackerHeadingTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(AttackerHeadingTextBox.Text, out box_int);
            if (box_int < 0 && AttackerHeadingTextBox.Text != "")
            {
                AttackerHeadingTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && AttackerHeadingTextBox.Text != "")
            {
                AttackerHeadingTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void SpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(SpeedTextBox.Text, out box_int);
            if (box_int < 0 && SpeedTextBox.Text != "")
            {
                SpeedTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && SpeedTextBox.Text != "")
            {
                SpeedTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void StaminaTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(StaminaTextBox.Text, out box_int);
            if (box_int < 0 && StaminaTextBox.Text != "")
            {
                StaminaTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && StaminaTextBox.Text != "")
            {
                StaminaTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void JumpTextBox_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(JumpTextBox.Text, out box_int);
            if (box_int < 0 && JumpTextBox.Text != "")
            {
                JumpTextBox.Text = "0";
                MessageBox.Show("Minimum 0");
            }
            else if (box_int > 20 && JumpTextBox.Text != "")
            {
                JumpTextBox.Text = "20";
                MessageBox.Show("Maximum 20");
            }
        }

        private void OneOnOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void FootGameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void ThrowingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void SpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void StaminaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void JumpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void DefenderPowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void DefenderTacklesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void DefenderSavingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void DefenderBraveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void PassingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void MidPowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void MidLongShootTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void MidLongPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void AttackerFinishTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void AttackerShootTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void AttackerPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }
        }

        private void AttackerHeadingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Please enter only numbers!");
                e.Handled = true;
            }   
        }
    }
}

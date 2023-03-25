using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeADW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        public List<Team> teams = new List<Team>();
        


        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxplayer.Sorted = true;
            Team team1 = new Team();
            team1.teamname = "Manchester Utd";
            team1.teamcountry = "England";
            team1.teamcity = "Manchester";
            Team tambah = team1;
            team1.addplayer("08", " Fernandes", "MF");
            team1.addplayer("23", " Shaw", "DF");
            team1.addplayer("10", " Rashford", "FW");
            team1.addplayer("14", " Eriksen", "MF");
            team1.addplayer("09", " Martial", "FW");
            team1.addplayer("21", " Antony", "FW");
            team1.addplayer("06", " Martinez", "DF");
            team1.addplayer("19", " Varane", "DF");
            team1.addplayer("18", " Casemiro", "MF");
            team1.addplayer("20", " Dalot", "DF");
            team1.addplayer("01", " De Gea", "GK");
            teams.Add(tambah);

            Team team2 = new Team();
            team2.teamname = "Liverpool";
            team2.teamcountry = "England";
            team2.teamcity = "Liverpool";
            tambah = team2;
            team2.addplayer("11", " Mohamed Salah", "FW");
            team2.addplayer("10", " Sadio Mane", "FW");
            team2.addplayer("09", " Roberto Firmino", "FW");
            team2.addplayer("04", " Virgil van Dijk", "DF");
            team2.addplayer("26", " Andrew Robertson", "DF");
            team2.addplayer("66", " Trent Alexander-Arnold", "DF");
            team2.addplayer("03", " Fabinho", "MF");
            team2.addplayer("14", " Jordan Henderson", "MF");
            team2.addplayer("06", " Thiago Alcantara", "MF");
            team2.addplayer("01", " Alisson Becker", "GK");
            team2.addplayer("20", " Diogo Jota", "FW");
            teams.Add(tambah);

            Team team3 = new Team();
            team3.teamname = "PSG";
            team3.teamcountry = "France";
            team3.teamcity = "Paris";
            tambah = team3;
            team3.addplayer("07", " Kylian Mbappe", "FW");
            team3.addplayer("10", " Neymar Jr", "FW");
            team3.addplayer("11", " Angel Di Maria", "FW");
            team3.addplayer("06", " Marco Verratti", "MF");
            team3.addplayer("02", " Achraf Hakimi", "DF");
            team3.addplayer("05", " Marquinhos", "DF");
            team3.addplayer("03", " Presnel Kimpembe", "DF");
            team3.addplayer("27", " Idrissa Gueye", "MF");
            team3.addplayer("18", " Georginio Wijnaldum", "MF");
            team3.addplayer("01", " Keylor Navas", "GK");
            team3.addplayer("14", " Juan Bernat", "DF");
            teams.Add(tambah);

            comboBoxChooseCountry.Items.Clear();
            foreach (Team team in teams)
            {
                if (comboBoxChooseCountry.Items.Contains(team.teamcountry) == false)
                {
                    comboBoxChooseCountry.Items.Add(team.teamcountry);
                }
            }
        }

        private void comboBoxChooseCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChooseTeam.Items.Clear();
            string tim = comboBoxChooseCountry.SelectedItem.ToString();
            foreach (Team team in teams)
            {
                if (team.teamcountry == tim)
                {
                    comboBoxChooseTeam.Items.Add(team.teamname);
                }
            }
        }

        private void comboBoxChooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxplayer.Items.Clear();
            string pemain = comboBoxChooseTeam.SelectedItem.ToString();
            Team team = null;
            foreach (Team p in teams)
            {
                if (p.teamname == pemain)
                {
                    team = p;
                }
            }
            foreach (Player player in team.Players)
            {

                string output = "(" + player.playernum + ")" + player.playername + ", " + player.playerpos;
                listBoxplayer.Items.Add(output);
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            if (textBoxTeamCountry.Text == "" || textBoxTeamName.Text == "" || textBoxTeamCity.Text == "")
            {
                MessageBox.Show("All Fields Need to be Filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nama = textBoxTeamName.Text;
                string kota = textBoxTeamCity.Text;
                string negara = textBoxTeamCountry.Text;
                bool cektim = false;
                foreach (Team team in teams)
                {
                    if (team.teamname == nama)
                    {
                        cektim = true;
                        break;
                    }
                }
                if (!cektim)
                {
                    Team item = new Team();
                    item.teamname = nama;
                    item.teamcity = kota;
                    item.teamcountry = negara;
                    teams.Add(item);
                }
                comboBoxChooseCountry.Items.Clear();
                foreach (Team team in teams)
                {
                    if (comboBoxChooseCountry.Items.Contains(team.teamcountry) == false)
                    {
                        comboBoxChooseCountry.Items.Add(team.teamcountry);
                    }
                }
                textBoxTeamCity.Clear();
                textBoxTeamCountry.Clear();
                textBoxTeamName.Clear();
            }
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text == "" || textBoxPlayerNumber.Text == "" || comboBoxChooseCountry.SelectedIndex == -1)
            {
                MessageBox.Show("All Fields Need to be Filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                string selectedteam = comboBoxChooseTeam.SelectedItem.ToString();
                foreach (Team teamm in teams)
                {
                    bool cekpemain = false;
                    foreach (Player player in teamm.Players)
                    {
                        if (player.playernum == textBoxPlayerNumber.Text)
                        {
                            cekpemain = true;
                            break;
                        }
                    }
                    if (cekpemain == false)
                    {
                        teamm.addplayer(textBoxPlayerNumber.Text, textBoxPlayerName.Text, comboBoxPlayerpos.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Player with Same Number is found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                listBoxplayer.Items.Clear();
                string nama = comboBoxChooseTeam.SelectedItem.ToString();
                Team team = new Team();
                foreach (Team i in teams)
                {
                    if (i.teamname == nama)
                    {
                        team = i;
                    }
                }
                foreach (Player player in team.Players)
                {

                    string output = "(" + player.playernum + ")" + player.playername + ", " + player.playerpos;
                    listBoxplayer.Items.Add(output);
                }
            }
            textBoxPlayerName.Clear();
            textBoxPlayerNumber.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string remove = this.comboBoxChooseTeam.SelectedItem.ToString();
            foreach (Team team in this.teams)
            {
                if (team.teamname == comboBoxChooseTeam.SelectedItem.ToString())
                {
                    string SelectedPlayer = listBoxplayer.SelectedItem.ToString();
                    foreach (Player player in team.Players)
                    {
                        if ("(" + player.playernum + ")" + player.playername + ", " + player.playerpos == SelectedPlayer)
                        {
                            team.Players.Remove(player);
                            listBoxplayer.Items.Clear();
                            foreach (Player player2 in team.Players)
                            {

                                string output = "(" + player2.playernum + ")" + player2.playername + ", " + player2.playerpos;
                                listBoxplayer.Items.Add(output);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}

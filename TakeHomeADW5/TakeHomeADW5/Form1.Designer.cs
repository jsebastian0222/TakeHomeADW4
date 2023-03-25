namespace TakeHomeADW5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChooseCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseTeam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxTeamCountry = new System.Windows.Forms.TextBox();
            this.textBoxTeamCity = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerNumber = new System.Windows.Forms.TextBox();
            this.comboBoxPlayerpos = new System.Windows.Forms.ComboBox();
            this.listBoxplayer = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Team";
            // 
            // comboBoxChooseCountry
            // 
            this.comboBoxChooseCountry.FormattingEnabled = true;
            this.comboBoxChooseCountry.Location = new System.Drawing.Point(208, 104);
            this.comboBoxChooseCountry.Name = "comboBoxChooseCountry";
            this.comboBoxChooseCountry.Size = new System.Drawing.Size(217, 33);
            this.comboBoxChooseCountry.TabIndex = 3;
            this.comboBoxChooseCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCountry_SelectedIndexChanged);
            // 
            // comboBoxChooseTeam
            // 
            this.comboBoxChooseTeam.FormattingEnabled = true;
            this.comboBoxChooseTeam.Location = new System.Drawing.Point(208, 155);
            this.comboBoxChooseTeam.Name = "comboBoxChooseTeam";
            this.comboBoxChooseTeam.Size = new System.Drawing.Size(217, 33);
            this.comboBoxChooseTeam.TabIndex = 4;
            this.comboBoxChooseTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseTeam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adding Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Team Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Team Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Team City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1227, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Adding Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1087, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Player Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1087, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Player Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1087, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Player Position";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTeamName.Location = new System.Drawing.Point(679, 104);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(221, 31);
            this.textBoxTeamName.TabIndex = 16;
            // 
            // textBoxTeamCountry
            // 
            this.textBoxTeamCountry.Location = new System.Drawing.Point(679, 149);
            this.textBoxTeamCountry.Name = "textBoxTeamCountry";
            this.textBoxTeamCountry.Size = new System.Drawing.Size(221, 31);
            this.textBoxTeamCountry.TabIndex = 17;
            // 
            // textBoxTeamCity
            // 
            this.textBoxTeamCity.Location = new System.Drawing.Point(679, 201);
            this.textBoxTeamCity.Name = "textBoxTeamCity";
            this.textBoxTeamCity.Size = new System.Drawing.Size(221, 31);
            this.textBoxTeamCity.TabIndex = 18;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(1264, 98);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(221, 31);
            this.textBoxPlayerName.TabIndex = 19;
            // 
            // textBoxPlayerNumber
            // 
            this.textBoxPlayerNumber.Location = new System.Drawing.Point(1264, 152);
            this.textBoxPlayerNumber.Name = "textBoxPlayerNumber";
            this.textBoxPlayerNumber.Size = new System.Drawing.Size(221, 31);
            this.textBoxPlayerNumber.TabIndex = 20;
            // 
            // comboBoxPlayerpos
            // 
            this.comboBoxPlayerpos.FormattingEnabled = true;
            this.comboBoxPlayerpos.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBoxPlayerpos.Location = new System.Drawing.Point(1264, 204);
            this.comboBoxPlayerpos.Name = "comboBoxPlayerpos";
            this.comboBoxPlayerpos.Size = new System.Drawing.Size(221, 33);
            this.comboBoxPlayerpos.TabIndex = 21;
            // 
            // listBoxplayer
            // 
            this.listBoxplayer.FormattingEnabled = true;
            this.listBoxplayer.ItemHeight = 25;
            this.listBoxplayer.Location = new System.Drawing.Point(548, 398);
            this.listBoxplayer.Name = "listBoxplayer";
            this.listBoxplayer.Size = new System.Drawing.Size(407, 229);
            this.listBoxplayer.TabIndex = 22;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(689, 653);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(124, 58);
            this.buttonRemove.TabIndex = 23;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(679, 279);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(124, 58);
            this.buttonAddTeam.TabIndex = 24;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(1232, 279);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(124, 58);
            this.buttonAddPlayer.TabIndex = 25;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 821);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxplayer);
            this.Controls.Add(this.comboBoxPlayerpos);
            this.Controls.Add(this.textBoxPlayerNumber);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.textBoxTeamCity);
            this.Controls.Add(this.textBoxTeamCountry);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxChooseTeam);
            this.Controls.Add(this.comboBoxChooseCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChooseCountry;
        private System.Windows.Forms.ComboBox comboBoxChooseTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBoxTeamCountry;
        private System.Windows.Forms.TextBox textBoxTeamCity;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerNumber;
        private System.Windows.Forms.ComboBox comboBoxPlayerpos;
        private System.Windows.Forms.ListBox listBoxplayer;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddPlayer;
    }
}


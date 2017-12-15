using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamrOfUniverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int a;
        private void StartGame_Click(object sender, EventArgs e)
        {
            Number_Lable_Set(10000,10000,0,0,0,0);
            ++a;
            if(a == 10)
            {
                MessageBox.Show("We gave up. You win the game.");
                StartGame.Visible = false;
                BackgroundImage = Properties.Resources.You_won;
            }
            else
            {
                MessageBox.Show("We have NOT finished the game yet. Please try it later");
            }
        }
        private void Number_Lable_Set(int army, int econamic
                                    , int budge, int population
                                    , int polution, int technology)
        {
            Label Army = new Label();
            Label Econamic = new Label();
            Label Budge = new Label();
            Label Population = new Label();
            Label Polution = new Label();
            Label Technology = new Label();
            Army.Text = army.ToString();
            labelAdd(Army, 0, 32);
            Econamic.Text = econamic.ToString();
            labelAdd(Econamic, 192, 32);
            Budge.Text = budge.ToString();
            labelAdd(Budge, 384, 32);
            Population.Text = population.ToString();
            labelAdd(Population, 576, 32);
            Polution.Text = polution.ToString();
            labelAdd(Polution, 768, 32);
            Technology.Text = technology.ToString();
            labelAdd(Technology, 960, 32);
        }
        private void labelAdd(Label a, int x, int y)
        {
            a.Visible = true;
            a.AutoSize = true;
            a.BackColor = System.Drawing.Color.Transparent;
            a.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            a.ForeColor = System.Drawing.SystemColors.Menu;
            a.Location = new System.Drawing.Point(x, y);
            a.Size = new System.Drawing.Size(106, 27);
            a.TabIndex = 2;
            Controls.Add(a);
        }
    }
}

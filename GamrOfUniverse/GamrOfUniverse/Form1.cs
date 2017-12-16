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
        bool gameIsStart = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            gameIsStart = true;
            Number_Lable_Set(10000,10000,0,0,0,0);
            this.BackgroundImage = GamrOfUniverse.Properties.Resources.MapOfChinaTaiwanFull;
            StartGame.Visible = false;
            QuitGame.Visible = false;
            MessageBox.Show("We have NOT finished the game yet. Please try it later");
   
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
            Army.Text = "ARMY\n" + army.ToString();
            labelAdd(Army, 0, 20);
            Econamic.Text = "ECONAMIC\n" + econamic.ToString();
            labelAdd(Econamic, 192, 20);
            Budge.Text = "BUDGE\n" + budge.ToString();
            labelAdd(Budge, 384, 20);
            Population.Text = "POPULATION\n" + population.ToString();
            labelAdd(Population, 576, 20);
            Polution.Text = "POLUTION\n" + polution.ToString();
            labelAdd(Polution, 768, 20);
            Technology.Text = "TECHNOLOGY\n" + technology.ToString();
            labelAdd(Technology, 960, 20);
            Army.MouseHover += new EventHandler(Army_MouseHoverLeave);
        }
        private void Army_MouseHoverLeave(object sender, EventArgs e)
        {          
            Label tmp = new Label();
            tmp.Text = "Army: Your Army numbers";
            tmp.Visible = true;
            labelAdd(tmp, 0, 30);
            Controls.Add(tmp);
            System.Threading.Thread.Sleep(100000);
            Controls.Remove(tmp);
            tmp.Dispose();
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
            a.ForeColor = System.Drawing.Color.Black;
            Controls.Add(a);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            button_size_define(StartGame);
            button_size_define(QuitGame);
            QuitGame.Location = new Point(StartGame.Location.X, StartGame.Location.Y + StartGame.Height + 5);
        }
        private void button_size_define(Button a)
        {
            
            a.Width = (int)(this.Width / 3.3);
            a.Height = (int)(this.Height / 6.3);
            a.Font = new System.Drawing.Font("微軟正黑體", (Width>=1256&&Height>=720?48F:24F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && gameIsStart)
            {               
                QuitGame.Location = new Point((this.Width - QuitGame.Width) / 2, (this.Height - QuitGame.Height) / 2);
                QuitGame.Visible = !QuitGame.Visible;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

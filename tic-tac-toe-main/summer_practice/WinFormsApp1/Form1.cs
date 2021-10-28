using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        StreamWriter SW = new StreamWriter(new FileStream("score.txt", FileMode.Open, FileAccess.Write)); //Создаём файл (если его нет) и открываем
        string x_win = "Победили X";
        string o_win = "Победили O";

        string X = "";
        Random rnd = new Random();
        int[] Arr_1 = new int[9];
        Button[] btn = new Button[9];
        public Form1()
        {
            InitializeComponent();

            if (rnd.Next(1, 10) <= 5)
            {
                X = "Крестики";
                label1.Text = "Ходят X";
            }

            else
            {
                X = "Нолики";
                label1.Text = "Ходят O";
            }

            btn[0] = button1;

            btn[1] = button2;

            btn[2] = button3;

            btn[3] = button4;

            btn[4] = button5;

            btn[5] = button6;

            btn[6] = button7;

            btn[7] = button8;

            btn[8] = button9;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (X == "Крестики")
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label1.Text = "Ходят O";
                        X = "Нолики";
                        btn[i].Enabled = false;
                        Arr_1[i] = 2;
                        break;
                    }
                }
            }
            else    //Нолики
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "O";
                        label1.Text = "Ходят X";
                        X = "Крестики";
                        btn[i].Enabled = false;
                        Arr_1[i] = 1;
                        break;
                    }
                }
            }

            //Условия для крестиков
            if ((Arr_1[0] == 2) && (Arr_1[1] == 2) && (Arr_1[2] == 2))
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[3] == 2) && (Arr_1[4] == 2) && (Arr_1[5] == 2))
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[6] == 2) && (Arr_1[7] == 2) && (Arr_1[8] == 2))
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[0] == 2) && (Arr_1[3] == 2) && (Arr_1[6] == 2))
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[1] == 2) && (Arr_1[4] == 2) && (Arr_1[7] == 2))
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[2] == 2) && (Arr_1[5] == 2) && (Arr_1[8] == 2))
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[0] == 2) && (Arr_1[4] == 2) && (Arr_1[8] == 2))
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            else if ((Arr_1[2] == 2) && (Arr_1[4] == 2) && (Arr_1[6] == 2))
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили X";
                SW.WriteLine(x_win);
            }

            //Нолики

            else if ((Arr_1[0] == 1) && (Arr_1[1] == 1) && (Arr_1[2] == 1))
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
            }

            else if ((Arr_1[3] == 1) && (Arr_1[4] == 1) && (Arr_1[5] == 1))
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

            else if ((Arr_1[6] == 1) && (Arr_1[7] == 1) && (Arr_1[8] == 1))
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

            else if ((Arr_1[0] == 1) && (Arr_1[3] == 1) && (Arr_1[6] == 1))
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

            else if ((Arr_1[1] == 1) && (Arr_1[4] == 1) && (Arr_1[7] == 1))
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

            else if ((Arr_1[2] == 1) && (Arr_1[5] == 1) && (Arr_1[8] == 1))
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

            else if ((Arr_1[0] == 1) && (Arr_1[4] == 1) && (Arr_1[8] == 1))
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

            else if ((Arr_1[2] == 1) && (Arr_1[4] == 1) && (Arr_1[6] == 1))
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победили O";
                SW.WriteLine(o_win);
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                Arr_1[i] = 0;
                btn[i].Text = "";
                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
            }
            if (rnd.Next(1, 10) <= 5)
            {
                X = "Крестики";
                label1.Text = "Ходят X";
            }
            else
            {
                X = "Нолики";
                label1.Text = "Ходят O";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SW.Close();
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SW.Close();
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _17605096_Task2_GADE6112
{   [Serializable]
        public partial class Form1 : Form
        {
            Map map = new Map(20, 20, 20);
            const int START_X = 20;
            const int START_Y = 20;
            const int SPACING = 10;
            const int SIZE = 20;
            Random r = new Random();
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                DisplayMap();
            }

            private void DisplayMap()
            {
                groupBox1.Controls.Clear();
                foreach (Unit u in map.Units)
                {
                    if (u.GetType() == typeof(MeleeUnit))
                    {
                        int start_x, start_y;
                        start_x = groupBox1.Location.X;
                        start_y = groupBox1.Location.Y;
                        MeleeUnit m = (MeleeUnit)u;
                        Button b = new Button();
                        b.Size = new Size(SIZE, SIZE);
                        b.Location = new Point(start_x + (m.xPos * SIZE), start_y + (m.yPos * SIZE));
                        b.Text = m.image;
                        if (m.faction == 1)
                        {
                            b.ForeColor = Color.Red;
                        }
                        else
                        {
                            b.ForeColor = Color.Green;
                        }
                        b.Click += new EventHandler(Start1_Click);
                        groupBox1.Controls.Add(b);
                    }
                }
            }

            private void UpdateMap()
            {
                foreach (Unit u in map.Units)
                {
                    if (u.GetType() == typeof(MeleeUnit))
                    {
                        MeleeUnit m = (MeleeUnit)u;
                        if (m.health < 25)
                        {
                            switch (r.Next(0, 4))
                            {
                                case 0: m.Move(Direction.North); break;
                                case 1: m.Move(Direction.East); break;
                                case 2: m.Move(Direction.South); break;
                                case 3: m.Move(Direction.West); break;
                            }
                        }
                        else
                        {
                            bool InCombat = false;
                            foreach (Unit e in map.Units)
                            {
                                if (u.InRange(e))
                                {
                                    u.Combat(e);
                                }
                            }
                            if (!InCombat)
                            {
                                Unit c = m.Closest(map.Units);
                                m.Move(m.DirectionTo(c));
                            }
                        }
                    }
                }
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                UpdateMap();
                DisplayMap();
                txt.Text = (++turn).ToString();
            }

            private void Start1_Click(object sender, EventArgs e)
            {
                timer1.Enabled = true;
            }

            private void Stop1_Click(object sender, EventArgs e)
            {
                timer1.Enabled = false;
            }

            private void button_click(object sender, EventArgs e)
            {
                int X = (((Button)sender).Location.X - groupBox1.Location.X) / SIZE;
                int Y = (((Button)sender).Location.Y - groupBox1.Location.Y) / SIZE;
                foreach (Unit u in map.Units)
                {
                    if (u.GetType() == typeof(MeleeUnit))
                    {
                        MeleeUnit m = (MeleeUnit)u;
                        if (m.xPos == X && m.yPos == Y)
                        {
                            txt.Text = "Button clicked at: " + map.ToString();
                        }
                    }
                }
            }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Unit u = new Unit();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("GlobalUnits.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, u);
                    MessageBox.Show("info saved");
                }
            }
            catch
            {
                MessageBox.Show("Error occured");
            }
        }
    }
    }

        static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Unit u = new Unit();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("Unit.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, u);
                    MessageBox.Show("Info saved");
                }
            }
            catch
            {
                MessageBox.Show("Error occured");
            }

            Building b = new Building();
            BinaryFormatter bf2 = new BinaryFormatter();
            FileStream fsout2 = new FileStream("Building.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout2)
                {
                    bf2.Serialize(fsout2, b);
                    MessageBox.Show("Info saved");
                }
            }
            catch
            {
                MessageBox.Show("Error occured");
            }

                Building bu = new Building();
            BinaryFormatter bf1 = new BinaryFormatter();
            FileStream fsout1 = new FileStream("GlobalBuildings.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout1)
                {
                    bf1.Serialize(fsout, bu);
                    MessageBox.Show("Info saved");
                }
            }
            catch
            {
                MessageBox.Show("Error occured");
            }

            Building b = new Building();
            BinaryFormatter bf2 = new BinaryFormatter();
            FileStream fsout2 = new FileStream("Building.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout2)
                {
                    bf2.Serialize(fsout2, b);
                    MessageBox.Show("Info saved");
                }
            }
            catch
            {
                MessageBox.Show("Error occured");
            }


        }
    }
}

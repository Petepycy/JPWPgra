using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRAG
{
    public partial class Form1 : Form
    {
        public bool level1 = true;
        public bool level2 = false;
        public bool level3 = false;
        private int time;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = Properties.Resources.tło;
            pictureBox7.BackColor = Color.White;
            pictureBox8.BackColor = Color.White;
            pictureBox9.BackColor = Color.White;
            pictureBox10.BackColor = Color.White;
            pictureBox11.BackColor = Color.White;
            pictureBox12.BackColor = Color.White;
            pictureBox13.BackColor = Color.White;
            pictureBox14.BackColor = Color.White;
            pictureBox15.BackColor = Color.White;
            pictureBox16.BackColor = Color.White;
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            Gamemode();
        }

        private void Fact1()
        {
                pictureBox11.Visible = false;
                pictureBox16.Image = Properties.Resources.rowerinfo;
                pictureBox16.Location = new Point(16, 15);
                pictureBox16.Size = new System.Drawing.Size(457, 428);   
        }
        private void afterFact1()
        {
            pictureBox11.Visible = true;
            pictureBox16.Image = null;
            pictureBox16.Location = new Point(3, 439);
            pictureBox16.Size = new System.Drawing.Size(22, 18);
        }
        private void Fact2()
        {
            pictureBox11.Visible = false;
            pictureBox16.Image = Properties.Resources.komp;
            pictureBox16.Location = new Point(16, 15);
            pictureBox16.Size = new System.Drawing.Size(457, 428);
        }
        private void afterFact2()
        {
            pictureBox11.Visible = true;
            pictureBox16.Image = null;
            pictureBox16.Location = new Point(3, 439);
            pictureBox16.Size = new System.Drawing.Size(22, 18);
        }
        private void Gamemode()
        {
            timer1.Start();
            
            if (level1 == true)
            {
                pictureBox7.Visible = false;
                pictureBox13.Visible = false;
                pictureBox15.Visible = false;
                
                panel3.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Properties.Resources.kołoprz;
                label1.Text = "koło przednie";
                pictureBox2.Image = Properties.Resources.siadełko1;
                label2.Text = "siadełko";
                pictureBox3.Image = Properties.Resources.kierownica1;
                label5.Text = "kierownica";
                pictureBox4.Image = Properties.Resources.rama2;
                label6.Text = "rama";
                pictureBox5.Image = Properties.Resources.zębatka1;
                label7.Text = "zębatka";
                pictureBox6.Image = Properties.Resources.kołotylne1;
                label8.Text = "koło tylne";
                
                label4.Text = "Level 1";
            
            }
            if (level2 == true)
            {
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox7.Location = new Point(257, 394);
                pictureBox7.Size = new System.Drawing.Size(110, 28);

                pictureBox8.Location = new Point(217, 69);
                pictureBox8.Size = new System.Drawing.Size(34, 113);

                pictureBox9.Location = new Point(133, 208);
                pictureBox9.Size = new System.Drawing.Size(147, 10);

                pictureBox10.Location = new Point(47, 243);
                pictureBox10.Size = new System.Drawing.Size(241, 56);

                pictureBox11.Location = new Point(22, 341);
                pictureBox11.Size = new System.Drawing.Size(131, 81);

                pictureBox12.Location = new Point(47, 61);
                pictureBox12.Size = new System.Drawing.Size(241, 185);

                pictureBox13.Location = new Point(257, 351);
                pictureBox13.Size = new System.Drawing.Size(110, 28);

                pictureBox14.Location = new Point(127, 90);
                pictureBox14.Size = new System.Drawing.Size(63, 58);

                panel3.BackgroundImage = Properties.Resources.obudowa;
                panel3.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Properties.Resources.płyta;
                label1.Text = "płyta główna";
                pictureBox2.Image = Properties.Resources.wentylator;
                label2.Text = "procesor z wentylatorem";
                pictureBox3.Image = Properties.Resources.kartagraficzna;
                label5.Text = "karta graficzna";
                pictureBox4.Image = Properties.Resources.ram;
                label6.Text = "koło przednie";
                //pictureBox5.Image = Properties.Resources.siadełko1;
                //pictureBox6.Image = Properties.Resources.rama;
                pictureBox5.Image = Properties.Resources.zasilacz;
                label7.Text = "zasilacz";
                //pictureBox18.Image = Properties.Resources.koło2;
                label4.Text = "Level 2";
            }

            if (level3 == true)
            {

            }
        }

        private bool CheckForWinLevel1()
        {
            if ((pictureBox10.Image == pictureBox1.Image || pictureBox10.Image == pictureBox6.Image) && pictureBox12.Image == pictureBox4.Image && (pictureBox6.Image == pictureBox11.Image || pictureBox1.Image == pictureBox11.Image) && pictureBox5.Image == pictureBox14.Image && pictureBox2.Image == pictureBox8.Image && pictureBox9.Image == pictureBox3.Image)
            {
                MessageBox.Show("Congratulations");
                return true;

            }
            else
            {
                MessageBox.Show("Try again");
                return false;
            }

        }

        private bool CheckForWinLevel2()
        {
            if (pictureBox10.Image == pictureBox1.Image && pictureBox11.Image == pictureBox4.Image && pictureBox6.Image == pictureBox12.Image && pictureBox5.Image == pictureBox14.Image && pictureBox2.Image == pictureBox8.Image && pictureBox9.Image == pictureBox3.Image)
            {
                MessageBox.Show("Congratulations");
                return true;

            }
            else
            {
                MessageBox.Show("Try again");
                return false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
               
        }

       public  void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox7.Image = getPicture;
        }
        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox8.Image = getPicture;
        }
        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox9.Image = getPicture;
        }
        private void pictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox10.Image = getPicture;
        }
        private void pictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
           
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox11.Image = getPicture;
        }
        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
           
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox12.Image = getPicture;
        }
        private void pictureBox13_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox13.Image = getPicture;
        }
        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox14.Image = getPicture;
        }
        private void pictureBox15_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox15_DragDrop(object sender, DragEventArgs e)
        {
            
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox15.Image = getPicture;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            
            if (CheckForWinLevel1() == true)
            {
                
                level1 = false;
                level2 = true;
                Gamemode();
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time<10 && level1==true)
            {
                Fact1();
            }
            else if (time>10 && level1==true)
            {
                timer1.Stop();   
                time = 0;
                afterFact1();
            }
            if (time < 10 && level2 == true)
            {
                Fact2();
            }
            else if (time > 10 && level2 == true)
            {
                timer1.Stop();
                time = 0;
                afterFact2();
            }
        }
    }
}

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
            Gamemode();
        }

        private void Fact1()
        {
            pictureBox11.Visible = false;
            pictureBox16.Image = Properties.Resources.kontur;
            pictureBox16.Location = new Point(16, 15);
            pictureBox16.Size = new System.Drawing.Size(457, 428);
        }
        private void Gamemode()
        {

            if (level1 == true)
            {
                pictureBox7.Visible = false;
                pictureBox13.Visible = false;
                pictureBox15.Visible = false;
                
                panel3.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Properties.Resources.kołoprz;
                pictureBox2.Image = Properties.Resources.siadełko1;
                pictureBox3.Image = Properties.Resources.kierownica1;
                pictureBox4.Image = Properties.Resources.rama2;
                pictureBox5.Image = Properties.Resources.zębatka1;
                pictureBox6.Image = Properties.Resources.kołotylne1;
                
                label4.Text = "Level 1";
            
            }
            if (level2 == true)
            {
                pictureBox16.Visible = false;
                panel3.BackgroundImage = Properties.Resources.obudowa;
                panel3.BackgroundImageLayout = ImageLayout.Stretch;
                //pictureBox1.Image = Properties.Resources.pedały;
                //pictureBox2.Image = Properties.Resources.kiero;
                //pictureBox3.Image = Properties.Resources.koło1;
                // pictureBox4.Image = Properties.Resources.koło2;
                // pictureBox5.Image = Properties.Resources.siadełko1;
                //pictureBox6.Image = Properties.Resources.rama;
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
            pictureBox7.Visible = false;
            pictureBox13.Visible = false;
            pictureBox15.Visible = false;

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
        private void pictureBox7_DragLeave(object sender, EventArgs e)
        {
            
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
        private void pictureBox8_DragLeave(object sender, EventArgs e)
        {
            
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
        private void pictureBox9_DragLeave(object sender, EventArgs e)
        {
            
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
        private void pictureBox10_DragLeave(object sender, EventArgs e)
        {
            
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
        private void pictureBox11_DragLeave(object sender, EventArgs e)
        {
           
        }
        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
           
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox11.Image = getPicture;
        }
        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere12.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox12_DragLeave(object sender, EventArgs e)
        {
            lblDropHere12.Visible = false;
        }
        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere12.Visible = false;
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
        private void pictureBox13_DragLeave(object sender, EventArgs e)
        {
            
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
        private void pictureBox14_DragLeave(object sender, EventArgs e)
        {
            
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
        private void pictureBox15_DragLeave(object sender, EventArgs e)
        {
            
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
                Fact1();
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

    }
}

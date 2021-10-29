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
        public bool lvl = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
            
        }

        private void Gamemode()
        {
            timer1.Start();
            
            if (level1==true)
            {
                
                if (CheckForWinLevel1(level1) == false)
                {
                    level1 = false;
                    level2 = true;
                    
                }
               
            }
            if (level2==true)
            {
                MessageBox.Show("2 poziom");
                level2 = false;
                timer1.Stop();
            }
           /* if (level2 == true)
            {
                CheckForWinLevel1();
            }
            if (level3 == true)
            {
                CheckForWinLevel1();
            }*/
        }

        private bool CheckForWinLevel1(bool level1)
        {
            if (pictureBox10.Image == pictureBox1.Image && pictureBox11.Image == pictureBox4.Image && pictureBox6.Image == pictureBox12.Image && pictureBox5.Image == pictureBox14.Image && pictureBox2.Image == pictureBox8.Image && pictureBox9.Image == pictureBox3.Image)
            {
                MessageBox.Show("Congratulations");
                return false;

            }
            else return true;
            
            
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
            Gamemode();
            lblDropHere7.Visible = false;
            lblDropHere8.Visible = false;
            lblDropHere9.Visible = false;
            lblDropHere10.Visible = false;
            lblDropHere11.Visible = false;
            lblDropHere12.Visible = false;
            lblDropHere13.Visible = false;
            lblDropHere14.Visible = false;
            lblDropHere15.Visible = false;
        }

       private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere7.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox7_DragLeave(object sender, EventArgs e)
        {
            lblDropHere7.Visible = false;
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere7.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox7.Image = getPicture;
        }
        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere7.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox8_DragLeave(object sender, EventArgs e)
        {
            lblDropHere7.Visible = false;
        }
        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere7.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox8.Image = getPicture;
        }
        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere9.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox9_DragLeave(object sender, EventArgs e)
        {
            lblDropHere9.Visible = false;
        }
        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere9.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox9.Image = getPicture;
        }
        private void pictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere10.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox10_DragLeave(object sender, EventArgs e)
        {
            lblDropHere10.Visible = false;
        }
        private void pictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere10.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox10.Image = getPicture;
        }
        private void pictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere11.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox11_DragLeave(object sender, EventArgs e)
        {
            lblDropHere11.Visible = false;
        }
        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere11.Visible = false;
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
            lblDropHere13.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox13_DragLeave(object sender, EventArgs e)
        {
            lblDropHere13.Visible = false;
        }
        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere13.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox13.Image = getPicture;
        }
        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere14.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox14_DragLeave(object sender, EventArgs e)
        {
            lblDropHere14.Visible = false;
        }
        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere14.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox14.Image = getPicture;
        }
        private void pictureBox15_DragEnter(object sender, DragEventArgs e)
        {
            lblDropHere15.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void pictureBox15_DragLeave(object sender, EventArgs e)
        {
            lblDropHere15.Visible = false;
        }
        private void pictureBox15_DragDrop(object sender, DragEventArgs e)
        {
            lblDropHere15.Visible = false;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox15.Image = getPicture;
        }

       

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Gamemode();
            
            /*if (level1 == true)
            {
                timer1.Start();
            }
            else if (level1 == false) timer1.Stop(); */
        }
    }
}

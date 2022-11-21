using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Odtwarzacz
{
    public partial class Odtwarzacz : Form
    {
        public Odtwarzacz()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        int i = 0;
        public bool czyToPierwszyRaz = true;
        private void button1_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(czyToPierwszyRaz)
                {
                    ofd.Filter = "Mp3 Files|*.mp3";
                    ofd.Multiselect = true;

                    czyToPierwszyRaz=true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        foreach (var x in ofd.FileNames)
                        {
                            list.Add(x);
                        }
                        Eksplorator.open(list[i]);
                    }
                    czyToPierwszyRaz = false;
                }
                else
                {
                    
                    Eksplorator.open(list[i]);
                }

            }
        }

        private void test(object sender, EventArgs e)
        {
            
        }
        //private void test(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog ofd = new OpenFileDialog())
        //    {
        //        if (czyToPierwszyRaz)
        //        {
        //            ofd.Filter = "Mp3 Files|*.mp3";
        //            ofd.Multiselect = true;

        //            czyToPierwszyRaz = true;

        //            if (ofd.ShowDialog() == DialogResult.OK)
        //            {

        //                foreach (var x in ofd.FileNames)
        //                {
        //                    list.Add(x);
        //                }
        //                Eksplorator.open(list[i]);
        //            }
        //            czyToPierwszyRaz = false;



        //    }
        //}





        private OdtwarzanieClass odtwarzanie = new OdtwarzanieClass();

        private void button2_Click(object sender, EventArgs e)
        {
            
            odtwarzanie.play();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odtwarzanie.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            if (i<list.Count)
            {
                odtwarzanie.czysc();
                button1_Click(sender, e);//znajdz
                button2_Click(sender, e);//play
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            i--;
            if (i >=0)
            {
                odtwarzanie.czysc();
                button1_Click(sender, e);//znajdz
                button2_Click(sender, e);//play
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            
            i=random.Next(list.Count);
            if (i >= 0)
            {
                odtwarzanie.czysc();
                button1_Click(sender, e);//znajdz
                button2_Click(sender, e);//play
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            odtwarzanie.stop();
            odtwarzanie.play();
        }

        private void Odtwarzacz_Load(object sender, EventArgs e)
        {

        }
    }
}

using FoolGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolGame
{
    public partial class Form2 : Form
    {
        private static Form2 form2Ref;
        //public static Form2 Form2Ref {
        //    get
        //    {
        //        if (form2Ref == null) form2Ref = new Form2();
        //        return form2Ref;
        //    }           
        //}
        public Form2()
        {
           
            InitializeComponent();
            //this.pictureBox1.Image
        }

        private void ReplayBtnClicked(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainForm.MainformRef.Show();
        }

        private void ExitBtnClicked(object sender, EventArgs e)
        {
            Application.Exit();
            //MainForm.MainformRef.Dispose();
           // this.Dispose();


        }
    }
}

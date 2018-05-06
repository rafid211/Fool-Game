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
    public partial class Form3 : Form
    {
        private static Form3 form3Ref;
        //public static Form3 Form3Ref
        //{
        //    get
        //    {
        //        if (form3Ref == null) form3Ref = new Form3();
        //        return form3Ref;
        //    }
        //}
        public Form3()
        {
            InitializeComponent();
        }

        private void ReplayBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainformRef.Show();
        }
        private void ExitBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}

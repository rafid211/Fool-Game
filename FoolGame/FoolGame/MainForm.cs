using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace FoolGame
{
    public partial class MainForm : Form
    {
        const int MINX = 1, MINY = 1, MAXX=700, MAXY = 340;
        Random rnum;
        SoundPlayer player;
        private static MainForm mainformRef;

        public static MainForm MainformRef
        {
            get
            {
                if (mainformRef == null) mainformRef = new MainForm();
                return mainformRef;
            }
        }
        public MainForm()
        {

            InitializeComponent();
            this.player = new SoundPlayer(FoolGame.Properties.Resources.blp);
        }
       

        private void ButtonRun(object sender, EventArgs e)
        {

            this.player = new SoundPlayer(FoolGame.Properties.Resources.blp);
           
            rnum = new Random();

            while (true)
            {
                int x = rnum.Next(MINX,MAXX);
                int y = rnum.Next(MINY,MAXY);
                Rectangle r = new Rectangle(x, y, noButton.Width, noButton.Height);
                if(yesButton.Bounds.IntersectsWith(r))
                {
                    //yesButton.BackColor = Color.Red;
                    continue;
                }
                else if (question.Bounds.IntersectsWith(r))
                {
                   // yesButton.BackColor = Color.Green;
                    continue;
                }
                else if(ExtBtn1.Bounds.IntersectsWith(r))
                {
                    continue;
                }
                else
                {
                    
                    this.noButton.Location = new Point(x, y);
                    this.player.Play();
                    //yesButton.BackColor = Color.Yellow;
                    break;
                }
            }

        }

        private void ExtBtn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U Have To Paly..","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void ExitBtnRun(object sender, EventArgs e)
        {

            Random rand = new Random();
            while (true)
            {
                int x = rand.Next(MINX, MAXX);
                int y = rand.Next(MINY, MAXY);
                Rectangle r = new Rectangle(x, y, ExtBtn1.Width, ExtBtn1.Height);
                if (yesButton.Bounds.IntersectsWith(r))
                {
                    //yesButton.BackColor = Color.Red;
                    continue;
                }
                else if (question.Bounds.IntersectsWith(r))
                {
                    // yesButton.BackColor = Color.Green;
                    continue;
                }
                else if(noButton.Bounds.IntersectsWith(r))
                {
                    continue;
                }
                else
                {
                    this.ExtBtn1.Location = new Point(x, y);
                    this.player.Play();
                    // yesButton.BackColor = Color.Yellow;
                    break;
                }
            }
        }

        private void ClickedYes(object sender, EventArgs e)
        {

            this.Hide();
            using (Form2 f2 = new Form2())
            {
                f2.ShowDialog();
                
            }
            
            
        }

        private void ClickedNo(object sender, EventArgs e)
        {
            this.Hide();
            using (Form3 f3 = new Form3())
            {
                f3.ShowDialog();

            }
        }

    }
}

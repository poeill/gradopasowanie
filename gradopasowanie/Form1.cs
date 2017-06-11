using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradopasowanie
{
    public partial class Form1 : Form
    {

        Label firstClicked = null;

        Label secondClicked = null;


        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!", "!", "o", "o", "%", "%", "$", "$",
            "^", "^", "b", "b", "*", "*", "j", "j"
        };
       

        private void AssignIconsToSquares()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    //iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {

            if (czasomierz1.Enabled == true)
                return;
                Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                
                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    firstClicked.Visible = true;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                czasomierz1.Start();
            }

        }

        private void czasomierz1_Tick(object sender, EventArgs e)
        {
            czasomierz1.Stop();

            
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            
            firstClicked = null;
            secondClicked = null;
        }
    }







}
 
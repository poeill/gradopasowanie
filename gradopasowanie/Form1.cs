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
    }
}

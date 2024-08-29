using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game_Code
{
    public partial class Matching_Game : Form
    {
        List<string> numbers = new() { "1", "1", "2", "2", "3", "3", "4", "4", "5", "5", "6", "6", "7", "7", "8", "8", "9", "9", "10", "10", "11", "11", "12", "12", "13", "13", "14", "14", "15", "15" };
        Random rnd = new();
        Label firstClicked = null;
        Label secondClicked = null;

        public Matching_Game()
        {
            InitializeComponent();
            SetNumberToButton();
            lbl1.Click += Lbl_Click;
            lbl2.Click += Lbl_Click;
            lbl3.Click += Lbl_Click;
            lbl4.Click += Lbl_Click;
            lbl5.Click += Lbl_Click;
            lbl6.Click += Lbl_Click;
            lbl7.Click += Lbl_Click;
            lbl8.Click += Lbl_Click;
            lbl9.Click += Lbl_Click;
            lbl10.Click += Lbl_Click;
            lbl11.Click += Lbl_Click;
            lbl12.Click += Lbl_Click;
            lbl13.Click += Lbl_Click;
            lbl14.Click += Lbl_Click;
            lbl15.Click += Lbl_Click;
            lbl16.Click += Lbl_Click;
            lbl17.Click += Lbl_Click;
            lbl18.Click += Lbl_Click;
            lbl19.Click += Lbl_Click;
            lbl20.Click += Lbl_Click;
            lbl21.Click += Lbl_Click;
            lbl22.Click += Lbl_Click;
            lbl23.Click += Lbl_Click;
            lbl24.Click += Lbl_Click;
            lbl25.Click += Lbl_Click;
            lbl26.Click += Lbl_Click;
            lbl27.Click += Lbl_Click;
            lbl28.Click += Lbl_Click;
            lbl29.Click += Lbl_Click;
            lbl30.Click += Lbl_Click;
        }



        private void SetNumberToButton()
        {

            foreach (Control control in tblCards.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = rnd.Next(numbers.Count);
                    iconLabel.Text = numbers[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    numbers.RemoveAt(randomNumber);
                }
            }

        }


        private void Lbl_Click(object? sender, EventArgs e)
        {

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

               
            }

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;

                return;
            }

        }
    }
}

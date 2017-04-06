using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Font> fonts = new Dictionary<string, Font>();
        private Dictionary<string, List<string>> labels = new Dictionary<string, List<string>>();
        Button[] colorButtons = new Button[6];


        public Form1()
        {
            InitializeComponent();
            button1.Tag = Color.Green;
            button2.Tag = Color.Red;
            button3.Tag = Color.Blue;
            button4.Tag = Color.Violet;
            button5.Tag = Color.Yellow;
            button6.Tag = Color.Black;

            button7.Tag = "English";
            button8.Tag = "Polski";
            button9.Tag = "Spain";

            fonts["English"] = new Font("Arial", 18,FontStyle.Regular);
            fonts["Polski"] = new Font("TimesNewRoman", 18,FontStyle.Bold);
            fonts["Spain"] =  new Font("Arial", 18,FontStyle.Italic);

            colorButtons[0] = button1;
            colorButtons[1] = button2;
            colorButtons[2] = button3;
            colorButtons[3] = button4;
            colorButtons[4] = button5;
            colorButtons[5] = button6;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // смотрим, какая кнопка нажата
            var control = (Control)sender;
            // берём её тэг как строку
            var tagString = (Color)control.Tag;
            // используем нулевой символ
            panel1.BackColor = tagString;
        }



        private void button7_Click(object sender, EventArgs e)
        {
            var lang = (string)((Control)sender).Tag;
            for (int i = 0; i < 6; i++)
                colorButtons[i].Font = fonts[lang];
            button1.Text = "Green";
            button2.Text = "Red";
            button3.Text = "Blue";
            button4.Text = "Violet";
            button5.Text = "Yellow";
            button6.Text = "Black";
        }


    }
}

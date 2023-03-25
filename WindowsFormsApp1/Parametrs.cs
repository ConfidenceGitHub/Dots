using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Parametrs : Form
    {
        public float LineThickness { get; private set; } = 1;
        public float DotSize { get; private set; } = 2;
        public Color DotColor { get; private set; }
        public Color LineColor { get; private set; }

        public Parametrs()
        {
            InitializeComponent();
            ControlBox = false;
            DotColor = Color.Black;
            LineColor = Color.Black;
            saveBtn.Enabled = false;
        }

        private void colorChangeDoteBtn_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog();
            myDialog.ShowDialog();
            DotColor = myDialog.Color;
        }

        private void colorChangeLineBtn_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog();
            myDialog.ShowDialog();
            LineColor = myDialog.Color;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void escapeBtn_Click(object sender, EventArgs e)
        {
            LineThickness = 1;
            DotSize = 2;
            Close();
        }

        private void lineThicknessTb_TextChanged(object sender, EventArgs e)
        {      
            if (float.TryParse(lineThicknessTb.Text, out float f))
            {
                LineThickness = f;
                saveBtn.Enabled = true;
            }
            else
            {
                lineThicknessTb.Text = lineThicknessTb.Text.Remove(lineThicknessTb.Text.Length - 1, 1);
                saveBtn.Enabled = false;
            }
        }

        private void dotSizeTb_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(dotSizeTb.Text, out float f))
            {
                DotSize = f;
                saveBtn.Enabled = true;
            }
            else 
            {
                lineThicknessTb.Text = lineThicknessTb.Text.Remove(lineThicknessTb.Text.Length - 1, 1);
                saveBtn.Enabled = false;
            }
        }
    }
}

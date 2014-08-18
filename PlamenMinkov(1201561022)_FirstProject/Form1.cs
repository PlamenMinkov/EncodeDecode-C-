using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlamenMinkov_1201561022__FirstProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == false) length.Visible = false;
        }

        private void length_TextChanged(object sender, EventArgs e)
        {
            length.Text =Convert.ToString(Text.Text.Length);
        }
        
        private void encode_Click(object sender, EventArgs e)
        {
            string text = Text.Text;
            Encod obj = new Encod(text);
            string res = obj.ToUTF();
            obj.text = res;
            string finalResult = obj.Enc();
            result.Text = finalResult;
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            length.Text = Convert.ToString(Text.Text.Length);
            hesh.Text = "";
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(Text.Text);
            foreach (var item in ASCIIValues)
            {                
                hesh.Text += item;
            }
        }
        
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            
            string text = Text.Text;
            byte[] bas=System.Text.Encoding.Unicode.GetBytes(text);
            string result = System.Convert.ToBase64String(bas);
            hesh.Text =result;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                length.Visible = true;
                label3.Visible = true;
                length.Text = Convert.ToString(Text.Text.Length);
                hesh.Visible = true;
                label4.Visible = true;
                rb1.Visible = true;
                rb2.Visible = true;
            }
            else if (checkBox.Checked == false)
            {
                length.Visible = false;
                label3.Visible = false;
                hesh.Visible = false;
                label4.Visible = false;
                rb1.Visible = false;
                rb2.Visible = false;
            }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            string text = result.Text;
            Encod obj = new Encod(text);
            //string res = obj.ToUTF();
            //obj.text = res;
            string finalResult = obj.Decode();
            result.Text = finalResult;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Text.Text = result.Text;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }     
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListToEnums_Typescript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_runGenerator_Click(object sender, EventArgs e)
        {
            if(textItems.Text == string.Empty) return;
            textCode.Text = "";
            string item_ = "";
            string txt = textItems.Text;
            string nameEnums = "test";
            string[] lst = txt.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (textNameEnum.Text.Trim() != "") nameEnums = textNameEnum.Text.Trim();
            textCode.AppendText("export enum " + nameEnums + "_enum {" + Environment.NewLine);
            foreach (var item in lst)
            {
                item_ = item.Trim();
                if (checkBoxLowercase.Checked) item_ = item_.ToLower();
                if (checkBoxSlugify.Checked) item_ = item_.Replace(" ", "_");
                if (checkBox_i18n.Checked)
                {
                    textCode.AppendText(item_ + " = \"" + item_ + "\", //t(\"" + textBoxi18n.Text + item_ + "\")" + Environment.NewLine);
                }
                else
                {
                     textCode.AppendText(item_ + " = \"" + item_ + "\"," + Environment.NewLine);
                }
               
                
            }
            textCode.AppendText("}");
            Clipboard.SetText(textCode.Text);
        }

        private void checkBox_i18n_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_i18n.Checked)
            {
                textBoxi18n.Visible = true;
            }
            else
            {
                textBoxi18n.Visible = false;
            }
        }
    }
}

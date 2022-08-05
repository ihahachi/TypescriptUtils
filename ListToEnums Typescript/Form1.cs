using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        static string RemoveDiacritics(string stIn)
        {
            string stFormD = stIn.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }

            return (sb.ToString().Normalize(NormalizationForm.FormC));
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

        private void btn_copy_slugify_Click(object sender, EventArgs e)
        {
            if (textFromSlugify.Text == string.Empty) return;
            textToSlugify.Text = "";
            string txt = textFromSlugify.Text;
            string item_ = "";
            string delimiter = textDelimiter.Text.Trim();
            string[] lst = txt.Split(new Char[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in lst)
            {
                item_ = item.Trim();
                item_ = item_.ToLower();
                item_ = item_.Replace(" ", delimiter);
                textToSlugify.AppendText(item_ + Environment.NewLine);
            }

            textToSlugify.Text = RemoveDiacritics(textToSlugify.Text);

            Clipboard.SetText(textToSlugify.Text);
        }

        private void textItems_DoubleClick(object sender, EventArgs e)
        {
            textItems.Text = "";
        }

        private void textCode_DoubleClick(object sender, EventArgs e)
        {
            textCode.Text = "";
        }

        private void textFromSlugify_DoubleClick(object sender, EventArgs e)
        {
            textFromSlugify.Text = "";
        }

        private void textToSlugify_DoubleClick(object sender, EventArgs e)
        {
            textToSlugify.Text = "";
        }
    }
}

namespace ListToEnums_Typescript
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textNameEnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.btn_copy_enums = new System.Windows.Forms.Button();
            this.textItems = new System.Windows.Forms.TextBox();
            this.checkBoxLowercase = new System.Windows.Forms.CheckBox();
            this.checkBoxSlugify = new System.Windows.Forms.CheckBox();
            this.checkBox_i18n = new System.Windows.Forms.CheckBox();
            this.textBoxi18n = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textFromSlugify = new System.Windows.Forms.TextBox();
            this.btn_copy_slugify = new System.Windows.Forms.Button();
            this.textToSlugify = new System.Windows.Forms.TextBox();
            this.textDelimiter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNameEnum
            // 
            this.textNameEnum.Location = new System.Drawing.Point(3, 20);
            this.textNameEnum.Name = "textNameEnum";
            this.textNameEnum.Size = new System.Drawing.Size(234, 26);
            this.textNameEnum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of enum :";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(243, 49);
            this.textCode.Multiline = true;
            this.textCode.Name = "textCode";
            this.textCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCode.Size = new System.Drawing.Size(375, 417);
            this.textCode.TabIndex = 3;
            // 
            // btn_copy_enums
            // 
            this.btn_copy_enums.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy_enums.Location = new System.Drawing.Point(3, 473);
            this.btn_copy_enums.Name = "btn_copy_enums";
            this.btn_copy_enums.Size = new System.Drawing.Size(615, 58);
            this.btn_copy_enums.TabIndex = 4;
            this.btn_copy_enums.Text = "Copy Enums";
            this.btn_copy_enums.UseVisualStyleBackColor = true;
            this.btn_copy_enums.Click += new System.EventHandler(this.btn_runGenerator_Click);
            // 
            // textItems
            // 
            this.textItems.Location = new System.Drawing.Point(3, 49);
            this.textItems.Multiline = true;
            this.textItems.Name = "textItems";
            this.textItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textItems.Size = new System.Drawing.Size(234, 417);
            this.textItems.TabIndex = 5;
            // 
            // checkBoxLowercase
            // 
            this.checkBoxLowercase.AutoSize = true;
            this.checkBoxLowercase.Location = new System.Drawing.Point(243, 22);
            this.checkBoxLowercase.Name = "checkBoxLowercase";
            this.checkBoxLowercase.Size = new System.Drawing.Size(113, 22);
            this.checkBoxLowercase.TabIndex = 6;
            this.checkBoxLowercase.Text = "Items lowercase";
            this.checkBoxLowercase.UseVisualStyleBackColor = true;
            // 
            // checkBoxSlugify
            // 
            this.checkBoxSlugify.AutoSize = true;
            this.checkBoxSlugify.Location = new System.Drawing.Point(362, 22);
            this.checkBoxSlugify.Name = "checkBoxSlugify";
            this.checkBoxSlugify.Size = new System.Drawing.Size(64, 22);
            this.checkBoxSlugify.TabIndex = 7;
            this.checkBoxSlugify.Text = "Slugify";
            this.checkBoxSlugify.UseVisualStyleBackColor = true;
            // 
            // checkBox_i18n
            // 
            this.checkBox_i18n.AutoSize = true;
            this.checkBox_i18n.Location = new System.Drawing.Point(432, 22);
            this.checkBox_i18n.Name = "checkBox_i18n";
            this.checkBox_i18n.Size = new System.Drawing.Size(49, 22);
            this.checkBox_i18n.TabIndex = 8;
            this.checkBox_i18n.Text = "i18n";
            this.checkBox_i18n.UseVisualStyleBackColor = true;
            this.checkBox_i18n.CheckedChanged += new System.EventHandler(this.checkBox_i18n_CheckedChanged);
            // 
            // textBoxi18n
            // 
            this.textBoxi18n.Location = new System.Drawing.Point(487, 20);
            this.textBoxi18n.Name = "textBoxi18n";
            this.textBoxi18n.Size = new System.Drawing.Size(131, 26);
            this.textBoxi18n.TabIndex = 9;
            this.textBoxi18n.Text = "tashdjir.";
            this.textBoxi18n.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 563);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_copy_enums);
            this.tabPage1.Controls.Add(this.textItems);
            this.tabPage1.Controls.Add(this.textBoxi18n);
            this.tabPage1.Controls.Add(this.checkBox_i18n);
            this.tabPage1.Controls.Add(this.textNameEnum);
            this.tabPage1.Controls.Add(this.checkBoxSlugify);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textCode);
            this.tabPage1.Controls.Add(this.checkBoxLowercase);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textDelimiter);
            this.tabPage2.Controls.Add(this.textToSlugify);
            this.tabPage2.Controls.Add(this.btn_copy_slugify);
            this.tabPage2.Controls.Add(this.textFromSlugify);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Slugify";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textFromSlugify
            // 
            this.textFromSlugify.Location = new System.Drawing.Point(3, 33);
            this.textFromSlugify.Multiline = true;
            this.textFromSlugify.Name = "textFromSlugify";
            this.textFromSlugify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textFromSlugify.Size = new System.Drawing.Size(295, 434);
            this.textFromSlugify.TabIndex = 0;
            // 
            // btn_copy_slugify
            // 
            this.btn_copy_slugify.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy_slugify.Location = new System.Drawing.Point(3, 473);
            this.btn_copy_slugify.Name = "btn_copy_slugify";
            this.btn_copy_slugify.Size = new System.Drawing.Size(615, 58);
            this.btn_copy_slugify.TabIndex = 5;
            this.btn_copy_slugify.Text = "Copy Slugify";
            this.btn_copy_slugify.UseVisualStyleBackColor = true;
            this.btn_copy_slugify.Click += new System.EventHandler(this.btn_copy_slugify_Click);
            // 
            // textToSlugify
            // 
            this.textToSlugify.Location = new System.Drawing.Point(304, 33);
            this.textToSlugify.Multiline = true;
            this.textToSlugify.Name = "textToSlugify";
            this.textToSlugify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToSlugify.Size = new System.Drawing.Size(315, 434);
            this.textToSlugify.TabIndex = 6;
            // 
            // textDelimiter
            // 
            this.textDelimiter.Location = new System.Drawing.Point(78, 3);
            this.textDelimiter.Name = "textDelimiter";
            this.textDelimiter.Size = new System.Drawing.Size(131, 26);
            this.textDelimiter.TabIndex = 10;
            this.textDelimiter.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Delimiter :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListToEunms TypeScript v0.1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textNameEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button btn_copy_enums;
        private System.Windows.Forms.TextBox textItems;
        private System.Windows.Forms.CheckBox checkBoxLowercase;
        private System.Windows.Forms.CheckBox checkBoxSlugify;
        private System.Windows.Forms.CheckBox checkBox_i18n;
        private System.Windows.Forms.TextBox textBoxi18n;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textToSlugify;
        private System.Windows.Forms.Button btn_copy_slugify;
        private System.Windows.Forms.TextBox textFromSlugify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDelimiter;
    }
}


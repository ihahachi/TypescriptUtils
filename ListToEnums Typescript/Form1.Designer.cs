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
            this.btn_runGenerator = new System.Windows.Forms.Button();
            this.textItems = new System.Windows.Forms.TextBox();
            this.checkBoxLowercase = new System.Windows.Forms.CheckBox();
            this.checkBoxSlugify = new System.Windows.Forms.CheckBox();
            this.checkBox_i18n = new System.Windows.Forms.CheckBox();
            this.textBoxi18n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNameEnum
            // 
            this.textNameEnum.Location = new System.Drawing.Point(6, 31);
            this.textNameEnum.Name = "textNameEnum";
            this.textNameEnum.Size = new System.Drawing.Size(234, 26);
            this.textNameEnum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of enum :";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(246, 60);
            this.textCode.Multiline = true;
            this.textCode.Name = "textCode";
            this.textCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCode.Size = new System.Drawing.Size(375, 418);
            this.textCode.TabIndex = 3;
            // 
            // btn_runGenerator
            // 
            this.btn_runGenerator.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_runGenerator.Location = new System.Drawing.Point(6, 483);
            this.btn_runGenerator.Name = "btn_runGenerator";
            this.btn_runGenerator.Size = new System.Drawing.Size(615, 58);
            this.btn_runGenerator.TabIndex = 4;
            this.btn_runGenerator.Text = "Run Generator And Copy to Clippord";
            this.btn_runGenerator.UseVisualStyleBackColor = true;
            this.btn_runGenerator.Click += new System.EventHandler(this.btn_runGenerator_Click);
            // 
            // textItems
            // 
            this.textItems.Location = new System.Drawing.Point(6, 60);
            this.textItems.Multiline = true;
            this.textItems.Name = "textItems";
            this.textItems.Size = new System.Drawing.Size(234, 417);
            this.textItems.TabIndex = 5;
            // 
            // checkBoxLowercase
            // 
            this.checkBoxLowercase.AutoSize = true;
            this.checkBoxLowercase.Location = new System.Drawing.Point(246, 33);
            this.checkBoxLowercase.Name = "checkBoxLowercase";
            this.checkBoxLowercase.Size = new System.Drawing.Size(113, 22);
            this.checkBoxLowercase.TabIndex = 6;
            this.checkBoxLowercase.Text = "Items lowercase";
            this.checkBoxLowercase.UseVisualStyleBackColor = true;
            // 
            // checkBoxSlugify
            // 
            this.checkBoxSlugify.AutoSize = true;
            this.checkBoxSlugify.Location = new System.Drawing.Point(365, 32);
            this.checkBoxSlugify.Name = "checkBoxSlugify";
            this.checkBoxSlugify.Size = new System.Drawing.Size(64, 22);
            this.checkBoxSlugify.TabIndex = 7;
            this.checkBoxSlugify.Text = "Slugify";
            this.checkBoxSlugify.UseVisualStyleBackColor = true;
            // 
            // checkBox_i18n
            // 
            this.checkBox_i18n.AutoSize = true;
            this.checkBox_i18n.Location = new System.Drawing.Point(435, 33);
            this.checkBox_i18n.Name = "checkBox_i18n";
            this.checkBox_i18n.Size = new System.Drawing.Size(49, 22);
            this.checkBox_i18n.TabIndex = 8;
            this.checkBox_i18n.Text = "i18n";
            this.checkBox_i18n.UseVisualStyleBackColor = true;
            this.checkBox_i18n.CheckedChanged += new System.EventHandler(this.checkBox_i18n_CheckedChanged);
            // 
            // textBoxi18n
            // 
            this.textBoxi18n.Location = new System.Drawing.Point(490, 30);
            this.textBoxi18n.Name = "textBoxi18n";
            this.textBoxi18n.Size = new System.Drawing.Size(131, 26);
            this.textBoxi18n.TabIndex = 9;
            this.textBoxi18n.Text = "tashdjir.";
            this.textBoxi18n.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 544);
            this.Controls.Add(this.textBoxi18n);
            this.Controls.Add(this.checkBox_i18n);
            this.Controls.Add(this.checkBoxSlugify);
            this.Controls.Add(this.checkBoxLowercase);
            this.Controls.Add(this.textItems);
            this.Controls.Add(this.btn_runGenerator);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNameEnum);
            this.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListToEunms TypeScript v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNameEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button btn_runGenerator;
        private System.Windows.Forms.TextBox textItems;
        private System.Windows.Forms.CheckBox checkBoxLowercase;
        private System.Windows.Forms.CheckBox checkBoxSlugify;
        private System.Windows.Forms.CheckBox checkBox_i18n;
        private System.Windows.Forms.TextBox textBoxi18n;
    }
}


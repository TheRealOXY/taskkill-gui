﻿namespace taskkill_gui
{
    partial class GUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIForm));
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.SendButtonIM = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenTM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PIDBox
            // 
            this.PIDBox.BackColor = System.Drawing.Color.DimGray;
            this.PIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PIDBox.ForeColor = System.Drawing.Color.White;
            this.PIDBox.Location = new System.Drawing.Point(233, 281);
            this.PIDBox.MaxLength = 7;
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(94, 31);
            this.PIDBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DimGray;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(248, 318);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(61, 28);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "process identifier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoText
            // 
            this.LogoText.BackColor = System.Drawing.Color.Transparent;
            this.LogoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoText.ForeColor = System.Drawing.Color.White;
            this.LogoText.Location = new System.Drawing.Point(281, 29);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(282, 43);
            this.LogoText.TabIndex = 4;
            this.LogoText.Text = "taskkill gui";
            this.LogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButtonIM
            // 
            this.SendButtonIM.BackColor = System.Drawing.Color.DimGray;
            this.SendButtonIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButtonIM.ForeColor = System.Drawing.Color.White;
            this.SendButtonIM.Location = new System.Drawing.Point(544, 318);
            this.SendButtonIM.Name = "SendButtonIM";
            this.SendButtonIM.Size = new System.Drawing.Size(61, 28);
            this.SendButtonIM.TabIndex = 6;
            this.SendButtonIM.Text = "Send";
            this.SendButtonIM.UseVisualStyleBackColor = false;
            this.SendButtonIM.Click += new System.EventHandler(this.SendButtonIM_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(505, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 31);
            this.textBox1.TabIndex = 5;
            // 
            // OpenTM
            // 
            this.OpenTM.BackColor = System.Drawing.Color.DimGray;
            this.OpenTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenTM.ForeColor = System.Drawing.Color.White;
            this.OpenTM.Location = new System.Drawing.Point(12, 421);
            this.OpenTM.Name = "OpenTM";
            this.OpenTM.Size = new System.Drawing.Size(43, 28);
            this.OpenTM.TabIndex = 8;
            this.OpenTM.Text = "help";
            this.OpenTM.UseVisualStyleBackColor = false;
            this.OpenTM.Click += new System.EventHandler(this.OpenTM_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "taskkill with";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "image name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenTM);
            this.Controls.Add(this.SendButtonIM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.PIDBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIForm";
            this.Text = "taskkill";
            this.Load += new System.EventHandler(this.GUIForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PIDBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Button SendButtonIM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpenTM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

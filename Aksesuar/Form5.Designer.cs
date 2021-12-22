
namespace Aksesuar
{
    partial class Form5
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
            this.addorupdbtn = new System.Windows.Forms.Button();
            this.alisidtxt = new System.Windows.Forms.TextBox();
            this.sayitxt = new System.Windows.Forms.TextBox();
            this.qiymetitxt = new System.Windows.Forms.TextBox();
            this.tarixitxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addorupdbtn
            // 
            this.addorupdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addorupdbtn.Location = new System.Drawing.Point(110, 239);
            this.addorupdbtn.Name = "addorupdbtn";
            this.addorupdbtn.Size = new System.Drawing.Size(105, 45);
            this.addorupdbtn.TabIndex = 0;
            this.addorupdbtn.Text = "Düymə";
            this.addorupdbtn.UseVisualStyleBackColor = true;
            this.addorupdbtn.Click += new System.EventHandler(this.addorupdbtn_Click);
            // 
            // alisidtxt
            // 
            this.alisidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alisidtxt.Location = new System.Drawing.Point(165, 50);
            this.alisidtxt.Name = "alisidtxt";
            this.alisidtxt.Size = new System.Drawing.Size(100, 26);
            this.alisidtxt.TabIndex = 1;
            // 
            // sayitxt
            // 
            this.sayitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayitxt.Location = new System.Drawing.Point(165, 96);
            this.sayitxt.Name = "sayitxt";
            this.sayitxt.Size = new System.Drawing.Size(100, 26);
            this.sayitxt.TabIndex = 2;
            // 
            // qiymetitxt
            // 
            this.qiymetitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qiymetitxt.Location = new System.Drawing.Point(165, 143);
            this.qiymetitxt.Name = "qiymetitxt";
            this.qiymetitxt.Size = new System.Drawing.Size(100, 26);
            this.qiymetitxt.TabIndex = 3;
            // 
            // tarixitxt
            // 
            this.tarixitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarixitxt.Location = new System.Drawing.Point(165, 188);
            this.tarixitxt.Name = "tarixitxt";
            this.tarixitxt.Size = new System.Drawing.Size(100, 26);
            this.tarixitxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "alisid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "sayı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "qiyməti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "tarixi:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 316);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarixitxt);
            this.Controls.Add(this.qiymetitxt);
            this.Controls.Add(this.sayitxt);
            this.Controls.Add(this.alisidtxt);
            this.Controls.Add(this.addorupdbtn);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addorupdbtn;
        private System.Windows.Forms.TextBox alisidtxt;
        private System.Windows.Forms.TextBox sayitxt;
        private System.Windows.Forms.TextBox qiymetitxt;
        private System.Windows.Forms.TextBox tarixitxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
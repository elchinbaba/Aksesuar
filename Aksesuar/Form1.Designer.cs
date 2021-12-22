
namespace Aksesuar
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
            this.alisdGV = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.srchbtn = new System.Windows.Forms.Button();
            this.srchtxt = new System.Windows.Forms.TextBox();
            this.shwbtn = new System.Windows.Forms.Button();
            this.sellwdwbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FunksiyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.alisdGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alisdGV
            // 
            this.alisdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alisdGV.Location = new System.Drawing.Point(40, 288);
            this.alisdGV.Name = "alisdGV";
            this.alisdGV.Size = new System.Drawing.Size(861, 235);
            this.alisdGV.TabIndex = 0;
            this.alisdGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.anbardGV_CellDoubleClick);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(82, 162);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(183, 55);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Yeni mal əlavə et";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(672, 162);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(183, 55);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "Sil";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // srchbtn
            // 
            this.srchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.Location = new System.Drawing.Point(520, 25);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(143, 43);
            this.srchbtn.TabIndex = 4;
            this.srchbtn.Text = "Axtar";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // srchtxt
            // 
            this.srchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchtxt.Location = new System.Drawing.Point(216, 33);
            this.srchtxt.Name = "srchtxt";
            this.srchtxt.Size = new System.Drawing.Size(248, 26);
            this.srchtxt.TabIndex = 5;
            // 
            // shwbtn
            // 
            this.shwbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shwbtn.Location = new System.Drawing.Point(380, 162);
            this.shwbtn.Name = "shwbtn";
            this.shwbtn.Size = new System.Drawing.Size(183, 55);
            this.shwbtn.TabIndex = 6;
            this.shwbtn.Text = "Göstər";
            this.shwbtn.UseVisualStyleBackColor = true;
            this.shwbtn.Click += new System.EventHandler(this.shwbtn_Click);
            // 
            // sellwdwbtn
            // 
            this.sellwdwbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellwdwbtn.Location = new System.Drawing.Point(771, 73);
            this.sellwdwbtn.Name = "sellwdwbtn";
            this.sellwdwbtn.Size = new System.Drawing.Size(143, 43);
            this.sellwdwbtn.TabIndex = 7;
            this.sellwdwbtn.Text = "Satış pəncərəsi";
            this.sellwdwbtn.UseVisualStyleBackColor = true;
            this.sellwdwbtn.Click += new System.EventHandler(this.sellwdwbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FunksiyalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FunksiyalarToolStripMenuItem
            // 
            this.FunksiyalarToolStripMenuItem.Name = "FunksiyalarToolStripMenuItem";
            this.FunksiyalarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.FunksiyalarToolStripMenuItem.Text = "Funksiyalar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 535);
            this.Controls.Add(this.sellwdwbtn);
            this.Controls.Add(this.shwbtn);
            this.Controls.Add(this.srchtxt);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.alisdGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.alisdGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView alisdGV;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox srchtxt;
        private System.Windows.Forms.Button shwbtn;
        private System.Windows.Forms.Button sellwdwbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FunksiyalarToolStripMenuItem;
    }
}



namespace Aksesuar
{
    partial class Form4
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
            this.satisdGV = new System.Windows.Forms.DataGridView();
            this.shwbtn = new System.Windows.Forms.Button();
            this.srchtxt = new System.Windows.Forms.TextBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funksiyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qruplaşdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.satisdGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // satisdGV
            // 
            this.satisdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisdGV.Location = new System.Drawing.Point(77, 249);
            this.satisdGV.Name = "satisdGV";
            this.satisdGV.Size = new System.Drawing.Size(560, 150);
            this.satisdGV.TabIndex = 0;
            this.satisdGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.satisdGV_CellDoubleClick);
            // 
            // shwbtn
            // 
            this.shwbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shwbtn.Location = new System.Drawing.Point(280, 141);
            this.shwbtn.Name = "shwbtn";
            this.shwbtn.Size = new System.Drawing.Size(131, 55);
            this.shwbtn.TabIndex = 11;
            this.shwbtn.Text = "Göstər";
            this.shwbtn.UseVisualStyleBackColor = true;
            this.shwbtn.Click += new System.EventHandler(this.shwbtn_Click);
            // 
            // srchtxt
            // 
            this.srchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchtxt.Location = new System.Drawing.Point(105, 46);
            this.srchtxt.Name = "srchtxt";
            this.srchtxt.Size = new System.Drawing.Size(248, 26);
            this.srchtxt.TabIndex = 10;
            // 
            // srchbtn
            // 
            this.srchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.Location = new System.Drawing.Point(410, 38);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(143, 43);
            this.srchbtn.TabIndex = 9;
            this.srchbtn.Text = "Axtar";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(518, 141);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(136, 55);
            this.delbtn.TabIndex = 8;
            this.delbtn.Text = "Sil";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(46, 141);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(116, 55);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Əlavə et";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funksiyalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funksiyalarToolStripMenuItem
            // 
            this.funksiyalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qruplaşdırToolStripMenuItem});
            this.funksiyalarToolStripMenuItem.Name = "funksiyalarToolStripMenuItem";
            this.funksiyalarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.funksiyalarToolStripMenuItem.Text = "Funksiyalar";
            // 
            // qruplaşdırToolStripMenuItem
            // 
            this.qruplaşdırToolStripMenuItem.Name = "qruplaşdırToolStripMenuItem";
            this.qruplaşdırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qruplaşdırToolStripMenuItem.Text = "Qruplaşdır";
            this.qruplaşdırToolStripMenuItem.Click += new System.EventHandler(this.qruplaşdırToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 427);
            this.Controls.Add(this.shwbtn);
            this.Controls.Add(this.srchtxt);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.satisdGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.satisdGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView satisdGV;
        private System.Windows.Forms.Button shwbtn;
        private System.Windows.Forms.TextBox srchtxt;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funksiyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qruplaşdırToolStripMenuItem;
    }
}
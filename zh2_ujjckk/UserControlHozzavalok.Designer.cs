namespace zh2_ujjckk
{
    partial class UserControlHozzavalok
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHozzavalok = new System.Windows.Forms.ListBox();
            this.textBoxHozzavalok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxHozzavalok
            // 
            this.listBoxHozzavalok.FormattingEnabled = true;
            this.listBoxHozzavalok.ItemHeight = 15;
            this.listBoxHozzavalok.Location = new System.Drawing.Point(172, 47);
            this.listBoxHozzavalok.Name = "listBoxHozzavalok";
            this.listBoxHozzavalok.Size = new System.Drawing.Size(184, 274);
            this.listBoxHozzavalok.TabIndex = 0;
            // 
            // textBoxHozzavalok
            // 
            this.textBoxHozzavalok.Location = new System.Drawing.Point(172, 18);
            this.textBoxHozzavalok.Name = "textBoxHozzavalok";
            this.textBoxHozzavalok.Size = new System.Drawing.Size(184, 23);
            this.textBoxHozzavalok.TabIndex = 1;
            this.textBoxHozzavalok.TextChanged += new System.EventHandler(this.textBoxHozzavalok_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Itt szűrhet az adatbázisban található hozzávalókra.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControlHozzavalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHozzavalok);
            this.Controls.Add(this.listBoxHozzavalok);
            this.Name = "UserControlHozzavalok";
            this.Size = new System.Drawing.Size(584, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxHozzavalok;
        private TextBox textBoxHozzavalok;
        private Label label1;
    }
}

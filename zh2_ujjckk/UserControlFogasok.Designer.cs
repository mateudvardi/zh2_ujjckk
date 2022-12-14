namespace zh2_ujjckk
{
    partial class UserControlFogasok
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
            this.listBoxFogasok = new System.Windows.Forms.ListBox();
            this.textBoxFogasok = new System.Windows.Forms.TextBox();
            this.dataGridViewFogasok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFogasok)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFogasok
            // 
            this.listBoxFogasok.FormattingEnabled = true;
            this.listBoxFogasok.ItemHeight = 15;
            this.listBoxFogasok.Location = new System.Drawing.Point(24, 47);
            this.listBoxFogasok.Name = "listBoxFogasok";
            this.listBoxFogasok.Size = new System.Drawing.Size(120, 259);
            this.listBoxFogasok.TabIndex = 0;
            this.listBoxFogasok.SelectedIndexChanged += new System.EventHandler(this.listBoxFogasok_SelectedIndexChanged);
            // 
            // textBoxFogasok
            // 
            this.textBoxFogasok.Location = new System.Drawing.Point(24, 18);
            this.textBoxFogasok.Name = "textBoxFogasok";
            this.textBoxFogasok.Size = new System.Drawing.Size(121, 23);
            this.textBoxFogasok.TabIndex = 1;
            this.textBoxFogasok.TextChanged += new System.EventHandler(this.textBoxFogasok_TextChanged);
            // 
            // dataGridViewFogasok
            // 
            this.dataGridViewFogasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFogasok.Location = new System.Drawing.Point(164, 47);
            this.dataGridViewFogasok.Name = "dataGridViewFogasok";
            this.dataGridViewFogasok.RowTemplate.Height = 25;
            this.dataGridViewFogasok.Size = new System.Drawing.Size(519, 259);
            this.dataGridViewFogasok.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Itt szűrhet a fogásokra és megtekintheti a 4 főre szükséges hozzávalókat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControlFogasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFogasok);
            this.Controls.Add(this.textBoxFogasok);
            this.Controls.Add(this.listBoxFogasok);
            this.Name = "UserControlFogasok";
            this.Size = new System.Drawing.Size(794, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFogasok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxFogasok;
        private TextBox textBoxFogasok;
        private DataGridView dataGridViewFogasok;
        private Label label1;
    }
}

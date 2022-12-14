namespace zh2_ujjckk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.megnyitas = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // megnyitas
            // 
            this.megnyitas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.megnyitas.Location = new System.Drawing.Point(35, 44);
            this.megnyitas.Name = "megnyitas";
            this.megnyitas.Size = new System.Drawing.Size(114, 80);
            this.megnyitas.TabIndex = 0;
            this.megnyitas.Text = "Alkalmazás megnyitása";
            this.megnyitas.UseVisualStyleBackColor = true;
            this.megnyitas.Click += new System.EventHandler(this.megnyitas_Click);
            // 
            // kilepes
            // 
            this.kilepes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kilepes.Location = new System.Drawing.Point(177, 44);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(114, 80);
            this.kilepes.TabIndex = 1;
            this.kilepes.Text = "Kilépés az alkalmazásból";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 175);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.megnyitas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button megnyitas;
        private Button kilepes;
    }
}
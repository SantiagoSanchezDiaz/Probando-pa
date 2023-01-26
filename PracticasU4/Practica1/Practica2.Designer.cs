namespace Practica1
{
    partial class f2
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrueba.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPrueba.FlatAppearance.BorderSize = 4;
            this.btnPrueba.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrueba.Image = global::Practica1.Properties.Resources._03_CABALGATA___7_;
            this.btnPrueba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrueba.Location = new System.Drawing.Point(265, 159);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(231, 113);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Sos Botón?";
            this.btnPrueba.UseVisualStyleBackColor = false;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // f2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba);
            this.Name = "f2";
            this.Text = "LaQuinela";
            this.Click += new System.EventHandler(this.f2_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
    }
}
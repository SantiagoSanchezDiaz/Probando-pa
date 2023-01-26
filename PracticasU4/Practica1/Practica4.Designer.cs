namespace Practica1
{
    partial class f4
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(230, 51);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(266, 20);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(76, 51);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(102, 64);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "AYO";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(230, 94);
            this.txtPrueba.Multiline = true;
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrueba.Size = new System.Drawing.Size(266, 47);
            this.txtPrueba.TabIndex = 2;
            this.txtPrueba.Leave += new System.EventHandler(this.txtPrueba_Leave);
            // 
            // f4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txtApellido);
            this.Name = "f4";
            this.Text = "A Horse With No Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox txtPrueba;
    }
}
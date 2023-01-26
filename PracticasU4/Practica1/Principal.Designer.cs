namespace Practica1
{
    partial class Datos
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.lw1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Location = new System.Drawing.Point(58, 51);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(59, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "APELLIDO";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb2.Location = new System.Drawing.Point(58, 80);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(54, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "NOMBRE";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb3.Location = new System.Drawing.Point(58, 110);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(37, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "EDAD";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb4.Location = new System.Drawing.Point(58, 141);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(66, 13);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "DIRECCION";
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellido.Location = new System.Drawing.Point(139, 48);
            this.tbApellido.MaxLength = 30;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(252, 20);
            this.tbApellido.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(139, 77);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(252, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.Location = new System.Drawing.Point(140, 141);
            this.tbDireccion.MaxLength = 30;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(251, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // ckb1
            // 
            this.ckb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckb1.AutoSize = true;
            this.ckb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckb1.Location = new System.Drawing.Point(191, 176);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(80, 17);
            this.ckb1.TabIndex = 9;
            this.ckb1.Text = "Sos boton?";
            this.ckb1.UseVisualStyleBackColor = true;
            this.ckb1.UseWaitCursor = true;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb5.Location = new System.Drawing.Point(58, 204);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(73, 13);
            this.lb5.TabIndex = 11;
            this.lb5.Text = "RESULTADO";
            // 
            // bt1
            // 
            this.bt1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt1.Location = new System.Drawing.Point(101, 389);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "Aceptar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt2.Location = new System.Drawing.Point(254, 389);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "Aborten";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(139, 107);
            this.tbEdad.MaxLength = 3;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(37, 20);
            this.tbEdad.TabIndex = 14;
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb6.Location = new System.Drawing.Point(136, 9);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(179, 23);
            this.lb6.TabIndex = 15;
            this.lb6.Text = "INGRESE SUS DATOS";
            // 
            // lw1
            // 
            this.lw1.HideSelection = false;
            this.lw1.Location = new System.Drawing.Point(55, 229);
            this.lw1.Name = "lw1";
            this.lw1.Size = new System.Drawing.Size(336, 144);
            this.lw1.TabIndex = 16;
            this.lw1.UseCompatibleStateImageBehavior = false;
            this.lw1.View = System.Windows.Forms.View.List;
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(440, 434);
            this.Controls.Add(this.lw1);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.ckb1);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 477);
            this.MinimumSize = new System.Drawing.Size(460, 477);
            this.Name = "Datos";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.ListView lw1;
    }
}
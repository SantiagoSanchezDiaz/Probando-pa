namespace Practica1
{
    partial class f3
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
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb1.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb1.Location = new System.Drawing.Point(130, 52);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(546, 24);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mejora los momentos de bocadillos con el sabor escandalosamente delicioso ";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb1.MouseLeave += new System.EventHandler(this.lb1_MouseLeave);
            this.lb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseMove);
            // 
            // f3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb1);
            this.Name = "f3";
            this.Text = "Do the Walk Of Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
    }
}
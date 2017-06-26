namespace Proyecto26_WindowsForm
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
            this.btn_saludar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtCaja1 = new System.Windows.Forms.TextBox();
            this.txtCaja2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(44, 187);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(75, 23);
            this.btn_saludar.TabIndex = 0;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(360, 187);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 1;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // txtCaja1
            // 
            this.txtCaja1.Location = new System.Drawing.Point(360, 92);
            this.txtCaja1.Name = "txtCaja1";
            this.txtCaja1.Size = new System.Drawing.Size(74, 20);
            this.txtCaja1.TabIndex = 2;
            // 
            // txtCaja2
            // 
            this.txtCaja2.Location = new System.Drawing.Point(361, 128);
            this.txtCaja2.Name = "txtCaja2";
            this.txtCaja2.Size = new System.Drawing.Size(74, 20);
            this.txtCaja2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(361, 159);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "label3";
            this.lblResultado.Visible = false;
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Location = new System.Drawing.Point(46, 99);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje1.TabIndex = 7;
            this.lblMensaje1.Text = "label3";
            this.lblMensaje1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(715, 484);
            this.Controls.Add(this.lblMensaje1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaja2);
            this.Controls.Add(this.txtCaja1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btn_saludar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtCaja1;
        private System.Windows.Forms.TextBox txtCaja2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMensaje1;
    }
}


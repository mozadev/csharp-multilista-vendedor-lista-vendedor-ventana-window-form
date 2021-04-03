namespace EjmMultiLista
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
            this.txtCodigoAgregar = new System.Windows.Forms.TextBox();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigoAgregar
            // 
            this.txtCodigoAgregar.Location = new System.Drawing.Point(65, 12);
            this.txtCodigoAgregar.Name = "txtCodigoAgregar";
            this.txtCodigoAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAgregar.TabIndex = 0;
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(65, 38);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAgregar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Location = new System.Drawing.Point(65, 128);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEliminar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(204, 12);
            this.txtElementos.Multiline = true;
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(247, 238);
            this.txtElementos.TabIndex = 8;
            this.txtElementos.Text = "Esto es un Textbox y tiene la propiedad Multi Line en true";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 262);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreAgregar);
            this.Controls.Add(this.txtCodigoAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoAgregar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtElementos;
    }
}


namespace Memoria_Dinamica_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt = new System.Windows.Forms.TextBox();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPila = new System.Windows.Forms.TextBox();
            this.btnPila = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnArray = new System.Windows.Forms.Button();
            this.txtConsult = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(24, 29);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 26);
            this.txt.TabIndex = 0;
            this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrar.Location = new System.Drawing.Point(24, 213);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ReadOnly = true;
            this.txtMostrar.Size = new System.Drawing.Size(764, 225);
            this.txtMostrar.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(143, 29);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Aceptar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introducir texto vacio para devolver la cola";
            // 
            // txtPila
            // 
            this.txtPila.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPila.Location = new System.Drawing.Point(24, 77);
            this.txtPila.Name = "txtPila";
            this.txtPila.Size = new System.Drawing.Size(100, 26);
            this.txtPila.TabIndex = 4;
            this.txtPila.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPila_KeyDown);
            // 
            // btnPila
            // 
            this.btnPila.Location = new System.Drawing.Point(143, 80);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(75, 23);
            this.btnPila.TabIndex = 5;
            this.btnPila.Text = "Aceptar";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introducir texto vacio para devolver la pila";
            // 
            // txtArray
            // 
            this.txtArray.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArray.Location = new System.Drawing.Point(24, 122);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(100, 26);
            this.txtArray.TabIndex = 7;
            this.txtArray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArray_KeyDown);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(143, 125);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 8;
            this.btnArray.Text = "Aceptar";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // txtConsult
            // 
            this.txtConsult.Enabled = false;
            this.txtConsult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsult.Location = new System.Drawing.Point(24, 154);
            this.txtConsult.Name = "txtConsult";
            this.txtConsult.Size = new System.Drawing.Size(100, 26);
            this.txtConsult.TabIndex = 9;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(143, 156);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 10;
            this.btnCon.Text = "Aceptar";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtConsult);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.txtPila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPila;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.TextBox txtConsult;
        private System.Windows.Forms.Button btnCon;
    }
}


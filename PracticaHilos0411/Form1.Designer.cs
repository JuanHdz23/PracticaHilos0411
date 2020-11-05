namespace PracticaHilos0411
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
            this.components = new System.ComponentModel.Container();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.btn_contar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_contar = new System.Windows.Forms.Label();
            this.btn_formParalelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.Location = new System.Drawing.Point(97, 51);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(109, 25);
            this.lb_resultado.TabIndex = 0;
            this.lb_resultado.Text = "Resultado";
            // 
            // btn_contar
            // 
            this.btn_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contar.Location = new System.Drawing.Point(62, 129);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(120, 47);
            this.btn_contar.TabIndex = 1;
            this.btn_contar.Text = "Contar";
            this.btn_contar.UseVisualStyleBackColor = true;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(236, 129);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(120, 47);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_contar
            // 
            this.lb_contar.AutoSize = true;
            this.lb_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contar.Location = new System.Drawing.Point(338, 22);
            this.lb_contar.Name = "lb_contar";
            this.lb_contar.Size = new System.Drawing.Size(18, 20);
            this.lb_contar.TabIndex = 3;
            this.lb_contar.Text = "0";
            // 
            // btn_formParalelo
            // 
            this.btn_formParalelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formParalelo.Location = new System.Drawing.Point(62, 219);
            this.btn_formParalelo.Name = "btn_formParalelo";
            this.btn_formParalelo.Size = new System.Drawing.Size(120, 47);
            this.btn_formParalelo.TabIndex = 4;
            this.btn_formParalelo.Text = "Paralelo";
            this.btn_formParalelo.UseVisualStyleBackColor = true;
            this.btn_formParalelo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.btn_formParalelo);
            this.Controls.Add(this.lb_contar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_contar);
            this.Controls.Add(this.lb_resultado);
            this.Name = "Form1";
            this.Text = "Programacion Concurrente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_contar;
        private System.Windows.Forms.Button btn_formParalelo;
    }
}


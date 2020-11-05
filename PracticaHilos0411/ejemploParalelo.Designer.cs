namespace PracticaHilos0411
{
    partial class ejemploParalelo
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
            this.components = new System.ComponentModel.Container();
            this.lb_contar = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_contar = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_contar
            // 
            this.lb_contar.AutoSize = true;
            this.lb_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contar.Location = new System.Drawing.Point(345, 19);
            this.lb_contar.Name = "lb_contar";
            this.lb_contar.Size = new System.Drawing.Size(18, 20);
            this.lb_contar.TabIndex = 7;
            this.lb_contar.Text = "0";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(243, 126);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(120, 47);
            this.btn_imprimir.TabIndex = 6;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_contar
            // 
            this.btn_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contar.Location = new System.Drawing.Point(69, 126);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(120, 47);
            this.btn_contar.TabIndex = 5;
            this.btn_contar.Text = "Contar";
            this.btn_contar.UseVisualStyleBackColor = true;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.Location = new System.Drawing.Point(104, 48);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(109, 25);
            this.lb_resultado.TabIndex = 4;
            this.lb_resultado.Text = "Resultado";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ejemploParalelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.lb_contar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_contar);
            this.Controls.Add(this.lb_resultado);
            this.Name = "ejemploParalelo";
            this.Text = "ejemploParalelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_contar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Timer timer1;
    }
}
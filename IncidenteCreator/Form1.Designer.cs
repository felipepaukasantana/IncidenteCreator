namespace IncidenteCreator
{
    partial class IncidenteCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidenteCreator));
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSolicitatante = new System.Windows.Forms.TextBox();
            this.btnGerarInc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOcorrencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Enter += new System.EventHandler(this.TxtNumero_Enter);
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(118, 36);
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(299, 20);
            this.txtResumo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 118);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(405, 159);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtSolicitatante
            // 
            this.txtSolicitatante.Location = new System.Drawing.Point(11, 77);
            this.txtSolicitatante.Name = "txtSolicitatante";
            this.txtSolicitatante.Size = new System.Drawing.Size(405, 20);
            this.txtSolicitatante.TabIndex = 3;
            // 
            // btnGerarInc
            // 
            this.btnGerarInc.Location = new System.Drawing.Point(342, 294);
            this.btnGerarInc.Name = "btnGerarInc";
            this.btnGerarInc.Size = new System.Drawing.Size(75, 23);
            this.btnGerarInc.TabIndex = 4;
            this.btnGerarInc.Text = "Gerar";
            this.btnGerarInc.UseVisualStyleBackColor = true;
            this.btnGerarInc.Click += new System.EventHandler(this.btnGerarInc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solicitante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resumo";
            // 
            // lbOcorrencia
            // 
            this.lbOcorrencia.AutoSize = true;
            this.lbOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOcorrencia.Location = new System.Drawing.Point(8, 294);
            this.lbOcorrencia.Name = "lbOcorrencia";
            this.lbOcorrencia.Size = new System.Drawing.Size(0, 24);
            this.lbOcorrencia.TabIndex = 9;
            // 
            // IncidenteCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 329);
            this.Controls.Add(this.lbOcorrencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarInc);
            this.Controls.Add(this.txtSolicitatante);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.txtNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncidenteCreator";
            this.Text = "IncidenteCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSolicitatante;
        private System.Windows.Forms.Button btnGerarInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOcorrencia;
    }
}


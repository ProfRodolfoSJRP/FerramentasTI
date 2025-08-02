namespace ferramentas
{
    partial class desligaPc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEscolhaH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesligaMin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDesligaAgora = new System.Windows.Forms.Button();
            this.btnCancelaDesligamento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEscolhaH);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Horário que deseja Desligar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnEscolhaH
            // 
            this.btnEscolhaH.Location = new System.Drawing.Point(79, 65);
            this.btnEscolhaH.Name = "btnEscolhaH";
            this.btnEscolhaH.Size = new System.Drawing.Size(75, 23);
            this.btnEscolhaH.TabIndex = 1;
            this.btnEscolhaH.Text = "Agendar";
            this.btnEscolhaH.UseVisualStyleBackColor = true;
            this.btnEscolhaH.Click += new System.EventHandler(this.btnEscolhaH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnDesligaMin);
            this.groupBox2.Location = new System.Drawing.Point(21, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desligar daqui a:";
            // 
            // btnDesligaMin
            // 
            this.btnDesligaMin.Location = new System.Drawing.Point(79, 65);
            this.btnDesligaMin.Name = "btnDesligaMin";
            this.btnDesligaMin.Size = new System.Drawing.Size(75, 23);
            this.btnDesligaMin.TabIndex = 1;
            this.btnDesligaMin.Text = "Agendar";
            this.btnDesligaMin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite Em Minutos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelaDesligamento);
            this.groupBox3.Controls.Add(this.btnDesligaAgora);
            this.groupBox3.Location = new System.Drawing.Point(21, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 104);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desligar";
            // 
            // btnDesligaAgora
            // 
            this.btnDesligaAgora.Location = new System.Drawing.Point(78, 29);
            this.btnDesligaAgora.Name = "btnDesligaAgora";
            this.btnDesligaAgora.Size = new System.Drawing.Size(75, 23);
            this.btnDesligaAgora.TabIndex = 1;
            this.btnDesligaAgora.Text = "Desligar Agora";
            this.btnDesligaAgora.UseVisualStyleBackColor = true;
            // 
            // btnCancelaDesligamento
            // 
            this.btnCancelaDesligamento.Location = new System.Drawing.Point(42, 59);
            this.btnCancelaDesligamento.Name = "btnCancelaDesligamento";
            this.btnCancelaDesligamento.Size = new System.Drawing.Size(174, 23);
            this.btnCancelaDesligamento.TabIndex = 2;
            this.btnCancelaDesligamento.Text = "Cancelar o Desligamento";
            this.btnCancelaDesligamento.UseVisualStyleBackColor = true;
            this.btnCancelaDesligamento.Click += new System.EventHandler(this.btnCancelaDesligamento_Click);
            // 
            // desligaPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "desligaPc";
            this.Text = "desligaPc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEscolhaH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDesligaMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelaDesligamento;
        private System.Windows.Forms.Button btnDesligaAgora;
    }
}
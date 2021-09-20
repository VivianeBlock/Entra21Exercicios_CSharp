
namespace Estacionamento
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.cbVagas = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSaindo = new System.Windows.Forms.Label();
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.NumeroDaVagaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcupadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonEntrando = new System.Windows.Forms.RadioButton();
            this.radioButtonSaindo = new System.Windows.Forms.RadioButton();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVagas
            // 
            this.cbVagas.FormattingEnabled = true;
            this.cbVagas.Location = new System.Drawing.Point(97, 69);
            this.cbVagas.Name = "cbVagas";
            this.cbVagas.Size = new System.Drawing.Size(61, 44);
            this.cbVagas.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(391, 70);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 44);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.BackColor = System.Drawing.Color.Indigo;
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInstrucao.Location = new System.Drawing.Point(51, 24);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(196, 42);
            this.lblInstrucao.TabIndex = 3;
            this.lblInstrucao.Text = "Selecione uma vaga:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Indigo;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(412, 264);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 40);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSaindo
            // 
            this.lblSaindo.AutoSize = true;
            this.lblSaindo.BackColor = System.Drawing.Color.DeepPink;
            this.lblSaindo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaindo.Location = new System.Drawing.Point(339, 9);
            this.lblSaindo.Name = "lblSaindo";
            this.lblSaindo.Size = new System.Drawing.Size(159, 36);
            this.lblSaindo.TabIndex = 5;
            this.lblSaindo.Text = "Entrada de Veiculo";
            // 
            // dgVagas
            // 
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDaVagaCol,
            this.PlacaCol,
            this.OcupadoCol});
            this.dgVagas.Location = new System.Drawing.Point(97, 131);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.Size = new System.Drawing.Size(401, 115);
            this.dgVagas.TabIndex = 6;
            // 
            // NumeroDaVagaCol
            // 
            this.NumeroDaVagaCol.HeaderText = "Num";
            this.NumeroDaVagaCol.Name = "NumeroDaVagaCol";
            this.NumeroDaVagaCol.Width = 50;
            // 
            // PlacaCol
            // 
            this.PlacaCol.HeaderText = "Placa";
            this.PlacaCol.Name = "PlacaCol";
            this.PlacaCol.Width = 150;
            // 
            // OcupadoCol
            // 
            this.OcupadoCol.HeaderText = "Ocupado";
            this.OcupadoCol.Name = "OcupadoCol";
            // 
            // radioButtonEntrando
            // 
            this.radioButtonEntrando.AutoSize = true;
            this.radioButtonEntrando.Location = new System.Drawing.Point(177, 70);
            this.radioButtonEntrando.Name = "radioButtonEntrando";
            this.radioButtonEntrando.Size = new System.Drawing.Size(97, 40);
            this.radioButtonEntrando.TabIndex = 8;
            this.radioButtonEntrando.TabStop = true;
            this.radioButtonEntrando.Text = "Entando";
            this.radioButtonEntrando.UseVisualStyleBackColor = true;
            this.radioButtonEntrando.CheckedChanged += new System.EventHandler(this.radioButtonEntrando_CheckedChanged);
            // 
            // radioButtonSaindo
            // 
            this.radioButtonSaindo.AutoSize = true;
            this.radioButtonSaindo.Location = new System.Drawing.Point(291, 70);
            this.radioButtonSaindo.Name = "radioButtonSaindo";
            this.radioButtonSaindo.Size = new System.Drawing.Size(84, 40);
            this.radioButtonSaindo.TabIndex = 7;
            this.radioButtonSaindo.TabStop = true;
            this.radioButtonSaindo.Text = "Saindo";
            this.radioButtonSaindo.UseVisualStyleBackColor = true;
            this.radioButtonSaindo.CheckedChanged += new System.EventHandler(this.radioButtonSaindo_CheckedChanged);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Indigo;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlaca.Location = new System.Drawing.Point(96, 259);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(75, 45);
            this.lblPlaca.TabIndex = 9;
            this.lblPlaca.Text = "Placa:";
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(188, 264);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(205, 37);
            this.textPlaca.TabIndex = 10;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 316);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.radioButtonEntrando);
            this.Controls.Add(this.radioButtonSaindo);
            this.Controls.Add(this.dgVagas);
            this.Controls.Add(this.lblSaindo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbVagas);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVagas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSaindo;
        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDaVagaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcupadoCol;
        private System.Windows.Forms.RadioButton radioButtonEntrando;
        private System.Windows.Forms.RadioButton radioButtonSaindo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox textPlaca;
    }
}
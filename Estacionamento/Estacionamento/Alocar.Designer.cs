
namespace Estacionamento
{
    partial class Alocar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alocar));
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.radioButtonSaindo = new System.Windows.Forms.RadioButton();
            this.radioButtonEntrando = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(100, 66);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(205, 37);
            this.textPlaca.TabIndex = 0;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Indigo;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Uighur", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlaca.Location = new System.Drawing.Point(65, 18);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(75, 45);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            // 
            // radioButtonSaindo
            // 
            this.radioButtonSaindo.AutoSize = true;
            this.radioButtonSaindo.Location = new System.Drawing.Point(221, 109);
            this.radioButtonSaindo.Name = "radioButtonSaindo";
            this.radioButtonSaindo.Size = new System.Drawing.Size(84, 40);
            this.radioButtonSaindo.TabIndex = 2;
            this.radioButtonSaindo.TabStop = true;
            this.radioButtonSaindo.Text = "Saindo";
            this.radioButtonSaindo.UseVisualStyleBackColor = true;
            this.radioButtonSaindo.CheckedChanged += new System.EventHandler(this.radioButtonSaindo_CheckedChanged);
            // 
            // radioButtonEntrando
            // 
            this.radioButtonEntrando.AutoSize = true;
            this.radioButtonEntrando.Location = new System.Drawing.Point(100, 109);
            this.radioButtonEntrando.Name = "radioButtonEntrando";
            this.radioButtonEntrando.Size = new System.Drawing.Size(97, 40);
            this.radioButtonEntrando.TabIndex = 3;
            this.radioButtonEntrando.TabStop = true;
            this.radioButtonEntrando.Text = "Entando";
            this.radioButtonEntrando.UseVisualStyleBackColor = true;
            this.radioButtonEntrando.CheckedChanged += new System.EventHandler(this.radioButtonEntrando_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(425, 227);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 43);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Alocar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 317);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.radioButtonEntrando);
            this.Controls.Add(this.radioButtonSaindo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.textPlaca);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Alocar";
            this.Text = "Alocar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.RadioButton radioButtonSaindo;
        private System.Windows.Forms.RadioButton radioButtonEntrando;
        private System.Windows.Forms.Button btnVoltar;
    }
}
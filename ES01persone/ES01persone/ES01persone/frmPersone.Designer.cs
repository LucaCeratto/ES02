namespace ES01persone
{
    partial class frmPersone
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.btnInserire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCognome
            // 
            this.txtCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCognome.Location = new System.Drawing.Point(156, 35);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(186, 30);
            this.txtCognome.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(156, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 30);
            this.txtNome.TabIndex = 2;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(12, 35);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(118, 25);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "COGNOME";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "NOME";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascita.Location = new System.Drawing.Point(12, 158);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(90, 25);
            this.lblDataNascita.TabIndex = 6;
            this.lblDataNascita.Text = "NATO IL";
            // 
            // txtDataNascita
            // 
            this.txtDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascita.Location = new System.Drawing.Point(156, 153);
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(186, 30);
            this.txtDataNascita.TabIndex = 5;
            // 
            // btnInserire
            // 
            this.btnInserire.Location = new System.Drawing.Point(27, 247);
            this.btnInserire.Name = "btnInserire";
            this.btnInserire.Size = new System.Drawing.Size(121, 70);
            this.btnInserire.TabIndex = 7;
            this.btnInserire.Text = "INSERIRE";
            this.btnInserire.UseVisualStyleBackColor = true;
            // 
            // frmPersone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserire);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCognome);
            this.Name = "frmPersone";
            this.Text = "GESTIONE PERSONE";
            this.Load += new System.EventHandler(this.frmPersone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.Button btnInserire;
    }
}


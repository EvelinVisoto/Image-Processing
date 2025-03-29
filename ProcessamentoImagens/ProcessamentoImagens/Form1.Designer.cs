
namespace ProcessamentoImagens
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.processButton = new System.Windows.Forms.Button();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbGray = new System.Windows.Forms.PictureBox();
            this.pbBrilho = new System.Windows.Forms.PictureBox();
            this.pbBinaria = new System.Windows.Forms.PictureBox();
            this.pbRotacionada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotacionada)).BeginInit();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.processButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.processButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.processButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.processButton.FlatAppearance.BorderSize = 0;
            this.processButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.processButton.Location = new System.Drawing.Point(482, 32);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(138, 29);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Processar Imagens";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.processButton_Click_1);
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(12, 100);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(322, 241);
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            // 
            // pbGray
            // 
            this.pbGray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGray.Location = new System.Drawing.Point(749, 100);
            this.pbGray.Name = "pbGray";
            this.pbGray.Size = new System.Drawing.Size(322, 241);
            this.pbGray.TabIndex = 2;
            this.pbGray.TabStop = false;
            // 
            // pbBrilho
            // 
            this.pbBrilho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbBrilho.Location = new System.Drawing.Point(386, 100);
            this.pbBrilho.Name = "pbBrilho";
            this.pbBrilho.Size = new System.Drawing.Size(322, 241);
            this.pbBrilho.TabIndex = 3;
            this.pbBrilho.TabStop = false;
            // 
            // pbBinaria
            // 
            this.pbBinaria.Location = new System.Drawing.Point(217, 368);
            this.pbBinaria.Name = "pbBinaria";
            this.pbBinaria.Size = new System.Drawing.Size(322, 250);
            this.pbBinaria.TabIndex = 4;
            this.pbBinaria.TabStop = false;
            // 
            // pbRotacionada
            // 
            this.pbRotacionada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRotacionada.Location = new System.Drawing.Point(567, 368);
            this.pbRotacionada.Name = "pbRotacionada";
            this.pbRotacionada.Size = new System.Drawing.Size(322, 295);
            this.pbRotacionada.TabIndex = 5;
            this.pbRotacionada.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1083, 680);
            this.Controls.Add(this.pbRotacionada);
            this.Controls.Add(this.pbBinaria);
            this.Controls.Add(this.pbBrilho);
            this.Controls.Add(this.pbGray);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.processButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotacionada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbGray;
        private System.Windows.Forms.PictureBox pbBrilho;
        private System.Windows.Forms.PictureBox pbBinaria;
        private System.Windows.Forms.PictureBox pbRotacionada;
    }
}


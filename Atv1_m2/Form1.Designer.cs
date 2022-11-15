namespace Atv1_m2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dadosPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosComplementaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosPessoaisToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.dadosComplementaresToolStripMenuItem,
            this.revisarDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dadosPessoaisToolStripMenuItem
            // 
            this.dadosPessoaisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosPessoaisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadosPessoaisToolStripMenuItem.Name = "dadosPessoaisToolStripMenuItem";
            this.dadosPessoaisToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.dadosPessoaisToolStripMenuItem.Text = "Dados pessoais";
            this.dadosPessoaisToolStripMenuItem.Click += new System.EventHandler(this.dadosPessoaisToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // dadosComplementaresToolStripMenuItem
            // 
            this.dadosComplementaresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosComplementaresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadosComplementaresToolStripMenuItem.Name = "dadosComplementaresToolStripMenuItem";
            this.dadosComplementaresToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.dadosComplementaresToolStripMenuItem.Text = "Dados complementares";
            // 
            // revisarDadosToolStripMenuItem
            // 
            this.revisarDadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisarDadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.revisarDadosToolStripMenuItem.Name = "revisarDadosToolStripMenuItem";
            this.revisarDadosToolStripMenuItem.Size = new System.Drawing.Size(105, 21);
            this.revisarDadosToolStripMenuItem.Text = "Revisar dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 684);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dadosPessoaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosComplementaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarDadosToolStripMenuItem;
    }
}


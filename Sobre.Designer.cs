namespace Cadastro_de_Clientes
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLinkdin = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meu programa criado para a matéria de \r\nProjeto de Software do curso de \r\nADS da " +
    "faculdade Impacta.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLinkdin
            // 
            this.btnLinkdin.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkdin.Image")));
            this.btnLinkdin.Location = new System.Drawing.Point(58, 78);
            this.btnLinkdin.Name = "btnLinkdin";
            this.btnLinkdin.Size = new System.Drawing.Size(47, 44);
            this.btnLinkdin.TabIndex = 2;
            this.btnLinkdin.UseVisualStyleBackColor = true;
            this.btnLinkdin.Click += new System.EventHandler(this.btnLinkdin_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.Location = new System.Drawing.Point(167, 78);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(52, 44);
            this.btnEmail.TabIndex = 3;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 134);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnLinkdin);
            this.Controls.Add(this.label1);
            this.Name = "Sobre";
            this.Text = "Sobre...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLinkdin;
        private System.Windows.Forms.Button btnEmail;
    }
}
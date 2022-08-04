
namespace pliniosalgado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOutroFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.loucoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aplicativoToolStripMenuItem
            // 
            this.aplicativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.umToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.abrirOutroFormToolStripMenuItem,
            this.loucoToolStripMenuItem});
            this.aplicativoToolStripMenuItem.Name = "aplicativoToolStripMenuItem";
            this.aplicativoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aplicativoToolStripMenuItem.Text = "Opções";
            this.aplicativoToolStripMenuItem.Click += new System.EventHandler(this.aplicativoToolStripMenuItem_Click);
            // 
            // umToolStripMenuItem
            // 
            this.umToolStripMenuItem.Name = "umToolStripMenuItem";
            this.umToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.umToolStripMenuItem.Text = "Fechar";
            this.umToolStripMenuItem.Click += new System.EventHandler(this.umToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // abrirOutroFormToolStripMenuItem
            // 
            this.abrirOutroFormToolStripMenuItem.Name = "abrirOutroFormToolStripMenuItem";
            this.abrirOutroFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirOutroFormToolStripMenuItem.Text = "Cadastrar";
            this.abrirOutroFormToolStripMenuItem.Click += new System.EventHandler(this.abrirOutroFormToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "CRIAÇÃO DE PERSONAGENS PARA RPG";
            // 
            // loucoToolStripMenuItem
            // 
            this.loucoToolStripMenuItem.Name = "loucoToolStripMenuItem";
            this.loucoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loucoToolStripMenuItem.Text = "Louco";
            this.loucoToolStripMenuItem.Click += new System.EventHandler(this.loucoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::pliniosalgado.Properties.Resources.nerdola;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOutroFormToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loucoToolStripMenuItem;
    }
}


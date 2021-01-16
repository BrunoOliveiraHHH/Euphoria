namespace Euphoria
{
    partial class MenuEuphoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEuphoria));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasDeModSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modPorNDSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modPorNivelSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modPorHabilidadeSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tesourosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monstrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgTelaInicial = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTelaInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioMenu,
            this.estatisticasMenu,
            this.tesourosToolStripMenuItem,
            this.monstrosToolStripMenuItem,
            this.magiasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioMenu
            // 
            this.inicioMenu.Name = "inicioMenu";
            this.inicioMenu.Size = new System.Drawing.Size(48, 20);
            this.inicioMenu.Text = "Inicio";
            this.inicioMenu.Click += new System.EventHandler(this.inicioMenu_Click);
            // 
            // estatisticasMenu
            // 
            this.estatisticasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasDeModSubMenu});
            this.estatisticasMenu.Name = "estatisticasMenu";
            this.estatisticasMenu.Size = new System.Drawing.Size(76, 20);
            this.estatisticasMenu.Text = "Estatisticas";
            // 
            // tabelasDeModSubMenu
            // 
            this.tabelasDeModSubMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tabelasDeModSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modPorNDSubMenu,
            this.modPorNivelSubMenu,
            this.modPorHabilidadeSubMenu});
            this.tabelasDeModSubMenu.Name = "tabelasDeModSubMenu";
            this.tabelasDeModSubMenu.Size = new System.Drawing.Size(207, 22);
            this.tabelasDeModSubMenu.Text = "Tabelas de Modificadores";
            // 
            // modPorNDSubMenu
            // 
            this.modPorNDSubMenu.Name = "modPorNDSubMenu";
            this.modPorNDSubMenu.Size = new System.Drawing.Size(228, 22);
            this.modPorNDSubMenu.Text = "Mod. por ND de Monstro";
            this.modPorNDSubMenu.Click += new System.EventHandler(this.modPorNDSubMenu_Click);
            // 
            // modPorNivelSubMenu
            // 
            this.modPorNivelSubMenu.Name = "modPorNivelSubMenu";
            this.modPorNivelSubMenu.Size = new System.Drawing.Size(228, 22);
            this.modPorNivelSubMenu.Text = "Mod. por Nivel de Jogador";
            this.modPorNivelSubMenu.Click += new System.EventHandler(this.modPorNivelSubMenu_Click);
            // 
            // modPorHabilidadeSubMenu
            // 
            this.modPorHabilidadeSubMenu.Name = "modPorHabilidadeSubMenu";
            this.modPorHabilidadeSubMenu.Size = new System.Drawing.Size(228, 22);
            this.modPorHabilidadeSubMenu.Text = "Mod. por Valor de Habilidade";
            this.modPorHabilidadeSubMenu.Click += new System.EventHandler(this.modPorHabilidadeSubMenu_Click);
            // 
            // tesourosToolStripMenuItem
            // 
            this.tesourosToolStripMenuItem.Name = "tesourosToolStripMenuItem";
            this.tesourosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tesourosToolStripMenuItem.Text = "Tesouros";
            // 
            // monstrosToolStripMenuItem
            // 
            this.monstrosToolStripMenuItem.Name = "monstrosToolStripMenuItem";
            this.monstrosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.monstrosToolStripMenuItem.Text = "Monstros";
            // 
            // magiasToolStripMenuItem
            // 
            this.magiasToolStripMenuItem.Name = "magiasToolStripMenuItem";
            this.magiasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.magiasToolStripMenuItem.Text = "Magias";
            // 
            // dgTelaInicial
            // 
            this.dgTelaInicial.AllowUserToAddRows = false;
            this.dgTelaInicial.AllowUserToDeleteRows = false;
            this.dgTelaInicial.AllowUserToResizeColumns = false;
            this.dgTelaInicial.AllowUserToResizeRows = false;
            this.dgTelaInicial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTelaInicial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTelaInicial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTelaInicial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTelaInicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTelaInicial.GridColor = System.Drawing.SystemColors.Control;
            this.dgTelaInicial.Location = new System.Drawing.Point(144, 85);
            this.dgTelaInicial.Name = "dgTelaInicial";
            this.dgTelaInicial.ReadOnly = true;
            this.dgTelaInicial.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgTelaInicial.RowTemplate.ReadOnly = true;
            this.dgTelaInicial.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTelaInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgTelaInicial.Size = new System.Drawing.Size(736, 524);
            this.dgTelaInicial.TabIndex = 1;
            this.dgTelaInicial.Visible = false;
            // 
            // MenuEuphoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 715);
            this.Controls.Add(this.dgTelaInicial);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1037, 754);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1037, 754);
            this.Name = "MenuEuphoria";
            this.Text = "MenuEuphoria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTelaInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estatisticasMenu;
        private System.Windows.Forms.ToolStripMenuItem tabelasDeModSubMenu;
        private System.Windows.Forms.ToolStripMenuItem modPorNDSubMenu;
        private System.Windows.Forms.DataGridView dgTelaInicial;
        private System.Windows.Forms.ToolStripMenuItem inicioMenu;
        private System.Windows.Forms.ToolStripMenuItem tesourosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monstrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modPorNivelSubMenu;
        private System.Windows.Forms.ToolStripMenuItem modPorHabilidadeSubMenu;
    }
}
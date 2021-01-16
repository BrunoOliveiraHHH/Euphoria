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
            this.tabelasDeExperinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experiênciaPorNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experiênciaPorDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experiênciaPorNivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experiênciaPorDificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicadorDeExperiênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesourosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasDe10PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasDe50PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasDe100PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasDe500PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasDe1000PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemasDe5000PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetosDeValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetoDeArteDe25PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetoDeArteDe250PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetoDeArteDe750PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetoDeArteDe2500PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetoDeArteDe7500PoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgTelaInicial = new System.Windows.Forms.DataGridView();
            this.monstrosPorAmbienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.árticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.florestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montanhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pântanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planícieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subaquáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subterrâneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urbanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armadilhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTelaInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioMenu,
            this.estatisticasMenu,
            this.tesourosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioMenu
            // 
            this.inicioMenu.Name = "inicioMenu";
            this.inicioMenu.Size = new System.Drawing.Size(68, 22);
            this.inicioMenu.Text = "Inicio";
            this.inicioMenu.Click += new System.EventHandler(this.inicioMenu_Click);
            // 
            // estatisticasMenu
            // 
            this.estatisticasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasDeModSubMenu,
            this.tabelasDeExperinciaToolStripMenuItem,
            this.monstrosPorAmbienteToolStripMenuItem,
            this.armadilhasToolStripMenuItem});
            this.estatisticasMenu.Name = "estatisticasMenu";
            this.estatisticasMenu.Size = new System.Drawing.Size(116, 22);
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
            this.tabelasDeModSubMenu.Size = new System.Drawing.Size(268, 22);
            this.tabelasDeModSubMenu.Text = "Tabelas de Modificadores";
            // 
            // modPorNDSubMenu
            // 
            this.modPorNDSubMenu.Name = "modPorNDSubMenu";
            this.modPorNDSubMenu.Size = new System.Drawing.Size(300, 22);
            this.modPorNDSubMenu.Text = "Mod. por ND de Monstro";
            this.modPorNDSubMenu.Click += new System.EventHandler(this.modPorNDSubMenu_Click);
            // 
            // modPorNivelSubMenu
            // 
            this.modPorNivelSubMenu.Name = "modPorNivelSubMenu";
            this.modPorNivelSubMenu.Size = new System.Drawing.Size(300, 22);
            this.modPorNivelSubMenu.Text = "Mod. por Nivel de Jogador";
            this.modPorNivelSubMenu.Click += new System.EventHandler(this.modPorNivelSubMenu_Click);
            // 
            // modPorHabilidadeSubMenu
            // 
            this.modPorHabilidadeSubMenu.Name = "modPorHabilidadeSubMenu";
            this.modPorHabilidadeSubMenu.Size = new System.Drawing.Size(300, 22);
            this.modPorHabilidadeSubMenu.Text = "Mod. por Valor de Habilidade";
            this.modPorHabilidadeSubMenu.Click += new System.EventHandler(this.modPorHabilidadeSubMenu_Click);
            // 
            // tabelasDeExperinciaToolStripMenuItem
            // 
            this.tabelasDeExperinciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experiênciaPorNDToolStripMenuItem,
            this.experiênciaPorDiaToolStripMenuItem,
            this.experiênciaPorNivelToolStripMenuItem,
            this.experiênciaPorDificuldadeToolStripMenuItem,
            this.multiplicadorDeExperiênciaToolStripMenuItem});
            this.tabelasDeExperinciaToolStripMenuItem.Name = "tabelasDeExperinciaToolStripMenuItem";
            this.tabelasDeExperinciaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.tabelasDeExperinciaToolStripMenuItem.Text = "Tabela de Experiência";
            // 
            // experiênciaPorNDToolStripMenuItem
            // 
            this.experiênciaPorNDToolStripMenuItem.Name = "experiênciaPorNDToolStripMenuItem";
            this.experiênciaPorNDToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.experiênciaPorNDToolStripMenuItem.Text = "Experiência por ND";
            // 
            // experiênciaPorDiaToolStripMenuItem
            // 
            this.experiênciaPorDiaToolStripMenuItem.Name = "experiênciaPorDiaToolStripMenuItem";
            this.experiênciaPorDiaToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.experiênciaPorDiaToolStripMenuItem.Text = "Experiência por dia";
            // 
            // experiênciaPorNivelToolStripMenuItem
            // 
            this.experiênciaPorNivelToolStripMenuItem.Name = "experiênciaPorNivelToolStripMenuItem";
            this.experiênciaPorNivelToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.experiênciaPorNivelToolStripMenuItem.Text = "Experiência por Nivel";
            // 
            // experiênciaPorDificuldadeToolStripMenuItem
            // 
            this.experiênciaPorDificuldadeToolStripMenuItem.Name = "experiênciaPorDificuldadeToolStripMenuItem";
            this.experiênciaPorDificuldadeToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.experiênciaPorDificuldadeToolStripMenuItem.Text = "Experiência por Dificuldade";
            // 
            // multiplicadorDeExperiênciaToolStripMenuItem
            // 
            this.multiplicadorDeExperiênciaToolStripMenuItem.Name = "multiplicadorDeExperiênciaToolStripMenuItem";
            this.multiplicadorDeExperiênciaToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.multiplicadorDeExperiênciaToolStripMenuItem.Text = "Multiplicador de Experiência";
            // 
            // tesourosToolStripMenuItem
            // 
            this.tesourosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gemasToolStripMenuItem,
            this.objetosDeValorToolStripMenuItem});
            this.tesourosToolStripMenuItem.Name = "tesourosToolStripMenuItem";
            this.tesourosToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.tesourosToolStripMenuItem.Text = "Tesouros";
            // 
            // gemasToolStripMenuItem
            // 
            this.gemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gemasDe10PoToolStripMenuItem,
            this.gemasDe50PoToolStripMenuItem,
            this.gemasDe100PoToolStripMenuItem,
            this.gemasDe500PoToolStripMenuItem,
            this.gemasDe1000PoToolStripMenuItem,
            this.gemasDe5000PoToolStripMenuItem});
            this.gemasToolStripMenuItem.Name = "gemasToolStripMenuItem";
            this.gemasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasToolStripMenuItem.Text = "Gemas";
            // 
            // gemasDe10PoToolStripMenuItem
            // 
            this.gemasDe10PoToolStripMenuItem.Name = "gemasDe10PoToolStripMenuItem";
            this.gemasDe10PoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasDe10PoToolStripMenuItem.Text = "Gemas de 10 Po";
            // 
            // gemasDe50PoToolStripMenuItem
            // 
            this.gemasDe50PoToolStripMenuItem.Name = "gemasDe50PoToolStripMenuItem";
            this.gemasDe50PoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasDe50PoToolStripMenuItem.Text = "Gemas de 50 Po";
            // 
            // gemasDe100PoToolStripMenuItem
            // 
            this.gemasDe100PoToolStripMenuItem.Name = "gemasDe100PoToolStripMenuItem";
            this.gemasDe100PoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasDe100PoToolStripMenuItem.Text = "Gemas de 100 Po";
            // 
            // gemasDe500PoToolStripMenuItem
            // 
            this.gemasDe500PoToolStripMenuItem.Name = "gemasDe500PoToolStripMenuItem";
            this.gemasDe500PoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasDe500PoToolStripMenuItem.Text = "Gemas de 500 Po";
            // 
            // gemasDe1000PoToolStripMenuItem
            // 
            this.gemasDe1000PoToolStripMenuItem.Name = "gemasDe1000PoToolStripMenuItem";
            this.gemasDe1000PoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasDe1000PoToolStripMenuItem.Text = "Gemas de 1000 Po";
            // 
            // gemasDe5000PoToolStripMenuItem
            // 
            this.gemasDe5000PoToolStripMenuItem.Name = "gemasDe5000PoToolStripMenuItem";
            this.gemasDe5000PoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gemasDe5000PoToolStripMenuItem.Text = "Gemas de 5000 Po";
            // 
            // objetosDeValorToolStripMenuItem
            // 
            this.objetosDeValorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objetoDeArteDe25PoToolStripMenuItem,
            this.objetoDeArteDe250PoToolStripMenuItem,
            this.objetoDeArteDe750PoToolStripMenuItem,
            this.objetoDeArteDe2500PoToolStripMenuItem,
            this.objetoDeArteDe7500PoToolStripMenuItem});
            this.objetosDeValorToolStripMenuItem.Name = "objetosDeValorToolStripMenuItem";
            this.objetosDeValorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.objetosDeValorToolStripMenuItem.Text = "Objetos de Valor";
            // 
            // objetoDeArteDe25PoToolStripMenuItem
            // 
            this.objetoDeArteDe25PoToolStripMenuItem.Name = "objetoDeArteDe25PoToolStripMenuItem";
            this.objetoDeArteDe25PoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.objetoDeArteDe25PoToolStripMenuItem.Text = "Objeto de Arte de 25 Po";
            // 
            // objetoDeArteDe250PoToolStripMenuItem
            // 
            this.objetoDeArteDe250PoToolStripMenuItem.Name = "objetoDeArteDe250PoToolStripMenuItem";
            this.objetoDeArteDe250PoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.objetoDeArteDe250PoToolStripMenuItem.Text = "Objeto de Arte de 250 Po";
            // 
            // objetoDeArteDe750PoToolStripMenuItem
            // 
            this.objetoDeArteDe750PoToolStripMenuItem.Name = "objetoDeArteDe750PoToolStripMenuItem";
            this.objetoDeArteDe750PoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.objetoDeArteDe750PoToolStripMenuItem.Text = "Objeto de Arte de 750 Po";
            // 
            // objetoDeArteDe2500PoToolStripMenuItem
            // 
            this.objetoDeArteDe2500PoToolStripMenuItem.Name = "objetoDeArteDe2500PoToolStripMenuItem";
            this.objetoDeArteDe2500PoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.objetoDeArteDe2500PoToolStripMenuItem.Text = "Objeto de Arte de 2500 Po";
            // 
            // objetoDeArteDe7500PoToolStripMenuItem
            // 
            this.objetoDeArteDe7500PoToolStripMenuItem.Name = "objetoDeArteDe7500PoToolStripMenuItem";
            this.objetoDeArteDe7500PoToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.objetoDeArteDe7500PoToolStripMenuItem.Text = "Objeto de Arte de 7500 Po";
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
            // monstrosPorAmbienteToolStripMenuItem
            // 
            this.monstrosPorAmbienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.árticoToolStripMenuItem,
            this.colinaToolStripMenuItem,
            this.costaToolStripMenuItem,
            this.desertoToolStripMenuItem,
            this.florestaToolStripMenuItem,
            this.montanhaToolStripMenuItem,
            this.pântanoToolStripMenuItem,
            this.planícieToolStripMenuItem,
            this.subaquáticoToolStripMenuItem,
            this.subterrâneoToolStripMenuItem,
            this.urbanoToolStripMenuItem});
            this.monstrosPorAmbienteToolStripMenuItem.Name = "monstrosPorAmbienteToolStripMenuItem";
            this.monstrosPorAmbienteToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.monstrosPorAmbienteToolStripMenuItem.Text = "Monstros por Ambiente";
            // 
            // árticoToolStripMenuItem
            // 
            this.árticoToolStripMenuItem.Name = "árticoToolStripMenuItem";
            this.árticoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.árticoToolStripMenuItem.Text = "Ártico";
            // 
            // colinaToolStripMenuItem
            // 
            this.colinaToolStripMenuItem.Name = "colinaToolStripMenuItem";
            this.colinaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.colinaToolStripMenuItem.Text = "Colina";
            // 
            // costaToolStripMenuItem
            // 
            this.costaToolStripMenuItem.Name = "costaToolStripMenuItem";
            this.costaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.costaToolStripMenuItem.Text = "Costa";
            // 
            // desertoToolStripMenuItem
            // 
            this.desertoToolStripMenuItem.Name = "desertoToolStripMenuItem";
            this.desertoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.desertoToolStripMenuItem.Text = "Deserto";
            // 
            // florestaToolStripMenuItem
            // 
            this.florestaToolStripMenuItem.Name = "florestaToolStripMenuItem";
            this.florestaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.florestaToolStripMenuItem.Text = "Floresta";
            // 
            // montanhaToolStripMenuItem
            // 
            this.montanhaToolStripMenuItem.Name = "montanhaToolStripMenuItem";
            this.montanhaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.montanhaToolStripMenuItem.Text = "Montanha";
            // 
            // pântanoToolStripMenuItem
            // 
            this.pântanoToolStripMenuItem.Name = "pântanoToolStripMenuItem";
            this.pântanoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pântanoToolStripMenuItem.Text = "Pântano";
            // 
            // planícieToolStripMenuItem
            // 
            this.planícieToolStripMenuItem.Name = "planícieToolStripMenuItem";
            this.planícieToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.planícieToolStripMenuItem.Text = "Planície";
            // 
            // subaquáticoToolStripMenuItem
            // 
            this.subaquáticoToolStripMenuItem.Name = "subaquáticoToolStripMenuItem";
            this.subaquáticoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.subaquáticoToolStripMenuItem.Text = "Subaquático";
            // 
            // subterrâneoToolStripMenuItem
            // 
            this.subterrâneoToolStripMenuItem.Name = "subterrâneoToolStripMenuItem";
            this.subterrâneoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.subterrâneoToolStripMenuItem.Text = "Subterrâneo";
            // 
            // urbanoToolStripMenuItem
            // 
            this.urbanoToolStripMenuItem.Name = "urbanoToolStripMenuItem";
            this.urbanoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.urbanoToolStripMenuItem.Text = "Urbano";
            // 
            // armadilhasToolStripMenuItem
            // 
            this.armadilhasToolStripMenuItem.Name = "armadilhasToolStripMenuItem";
            this.armadilhasToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.armadilhasToolStripMenuItem.Text = "Armadilhas";
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
        private System.Windows.Forms.ToolStripMenuItem modPorNivelSubMenu;
        private System.Windows.Forms.ToolStripMenuItem modPorHabilidadeSubMenu;
        private System.Windows.Forms.ToolStripMenuItem gemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasDeExperinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experiênciaPorNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experiênciaPorDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experiênciaPorNivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experiênciaPorDificuldadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicadorDeExperiênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemasDe10PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemasDe50PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemasDe100PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemasDe500PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemasDe1000PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemasDe5000PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetosDeValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetoDeArteDe25PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetoDeArteDe250PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetoDeArteDe750PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetoDeArteDe2500PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetoDeArteDe7500PoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monstrosPorAmbienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem árticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem florestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montanhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pântanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planícieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subaquáticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subterrâneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urbanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armadilhasToolStripMenuItem;
    }
}
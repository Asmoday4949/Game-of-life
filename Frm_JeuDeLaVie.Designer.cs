namespace JeuDeLaVie
{
    partial class Frm_jeuDeLaVie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.pnl_generation = new System.Windows.Forms.Panel();
            this.lbl_tempsCycle = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_nouvelle = new System.Windows.Forms.Button();
            this.tb_tempsCycle = new System.Windows.Forms.TrackBar();
            this.lbl_titreGen = new System.Windows.Forms.Label();
            this.pnl_parametres = new System.Windows.Forms.Panel();
            this.lbl_taux = new System.Windows.Forms.Label();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.btn_generer = new System.Windows.Forms.Button();
            this.pnl_couleurCellMorte = new System.Windows.Forms.Panel();
            this.pnl_couleurCellVivante = new System.Windows.Forms.Panel();
            this.nud_qte_colonnes = new System.Windows.Forms.NumericUpDown();
            this.nud_qte_lignes = new System.Windows.Forms.NumericUpDown();
            this.lbl_couleurCellMorte = new System.Windows.Forms.Label();
            this.lbl_couleurCellVivante = new System.Windows.Forms.Label();
            this.lbl_qteColonnes = new System.Windows.Forms.Label();
            this.lbl_qteLignes = new System.Windows.Forms.Label();
            this.tb_taux = new System.Windows.Forms.TrackBar();
            this.gpb_remplissage = new System.Windows.Forms.GroupBox();
            this.rdo_figures = new System.Windows.Forms.RadioButton();
            this.rdo_manuel = new System.Windows.Forms.RadioButton();
            this.rdo_automatique = new System.Windows.Forms.RadioButton();
            this.lbl_titreParam = new System.Windows.Forms.Label();
            this.pnl_informations = new System.Windows.Forms.Panel();
            this.lbl_generations = new System.Windows.Forms.Label();
            this.lbl_cellMortes = new System.Windows.Forms.Label();
            this.lbl_cellVivantes = new System.Windows.Forms.Label();
            this.lbl_titreInfo = new System.Windows.Forms.Label();
            this.dc_couleur = new System.Windows.Forms.ColorDialog();
            this.tim_tempsCycle = new System.Windows.Forms.Timer(this.components);
            this.pnl_options.SuspendLayout();
            this.pnl_generation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tempsCycle)).BeginInit();
            this.pnl_parametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qte_colonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qte_lignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_taux)).BeginInit();
            this.gpb_remplissage.SuspendLayout();
            this.pnl_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_options
            // 
            this.pnl_options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_options.Controls.Add(this.pnl_generation);
            this.pnl_options.Controls.Add(this.pnl_parametres);
            this.pnl_options.Controls.Add(this.pnl_informations);
            this.pnl_options.Location = new System.Drawing.Point(731, 9);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(245, 573);
            this.pnl_options.TabIndex = 1;
            // 
            // pnl_generation
            // 
            this.pnl_generation.BackColor = System.Drawing.Color.White;
            this.pnl_generation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_generation.Controls.Add(this.lbl_tempsCycle);
            this.pnl_generation.Controls.Add(this.btn_stop);
            this.pnl_generation.Controls.Add(this.btn_start);
            this.pnl_generation.Controls.Add(this.btn_nouvelle);
            this.pnl_generation.Controls.Add(this.tb_tempsCycle);
            this.pnl_generation.Controls.Add(this.lbl_titreGen);
            this.pnl_generation.Location = new System.Drawing.Point(3, 397);
            this.pnl_generation.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_generation.Name = "pnl_generation";
            this.pnl_generation.Size = new System.Drawing.Size(237, 171);
            this.pnl_generation.TabIndex = 2;
            // 
            // lbl_tempsCycle
            // 
            this.lbl_tempsCycle.AutoSize = true;
            this.lbl_tempsCycle.Location = new System.Drawing.Point(8, 58);
            this.lbl_tempsCycle.Name = "lbl_tempsCycle";
            this.lbl_tempsCycle.Size = new System.Drawing.Size(116, 13);
            this.lbl_tempsCycle.TabIndex = 2;
            this.lbl_tempsCycle.Text = "Temps de cycle : 50ms";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(138, 25);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(61, 23);
            this.btn_stop.TabIndex = 17;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(71, 25);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(61, 23);
            this.btn_start.TabIndex = 16;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_nouvelle
            // 
            this.btn_nouvelle.Location = new System.Drawing.Point(4, 25);
            this.btn_nouvelle.Name = "btn_nouvelle";
            this.btn_nouvelle.Size = new System.Drawing.Size(61, 23);
            this.btn_nouvelle.TabIndex = 15;
            this.btn_nouvelle.Text = "Nouvelle";
            this.btn_nouvelle.UseVisualStyleBackColor = true;
            this.btn_nouvelle.Click += new System.EventHandler(this.btn_nouvelle_Click);
            // 
            // tb_tempsCycle
            // 
            this.tb_tempsCycle.LargeChange = 50;
            this.tb_tempsCycle.Location = new System.Drawing.Point(-1, 74);
            this.tb_tempsCycle.Maximum = 1000;
            this.tb_tempsCycle.Minimum = 50;
            this.tb_tempsCycle.Name = "tb_tempsCycle";
            this.tb_tempsCycle.Size = new System.Drawing.Size(237, 45);
            this.tb_tempsCycle.SmallChange = 10;
            this.tb_tempsCycle.TabIndex = 14;
            this.tb_tempsCycle.TickFrequency = 10;
            this.tb_tempsCycle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_tempsCycle.Value = 50;
            this.tb_tempsCycle.Scroll += new System.EventHandler(this.tb_tempsCycle_Scroll);
            // 
            // lbl_titreGen
            // 
            this.lbl_titreGen.BackColor = System.Drawing.Color.Black;
            this.lbl_titreGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreGen.ForeColor = System.Drawing.Color.White;
            this.lbl_titreGen.Location = new System.Drawing.Point(3, -1);
            this.lbl_titreGen.Name = "lbl_titreGen";
            this.lbl_titreGen.Size = new System.Drawing.Size(229, 23);
            this.lbl_titreGen.TabIndex = 2;
            this.lbl_titreGen.Text = "Générations";
            this.lbl_titreGen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_parametres
            // 
            this.pnl_parametres.BackColor = System.Drawing.Color.White;
            this.pnl_parametres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_parametres.Controls.Add(this.lbl_taux);
            this.pnl_parametres.Controls.Add(this.btn_effacer);
            this.pnl_parametres.Controls.Add(this.btn_generer);
            this.pnl_parametres.Controls.Add(this.pnl_couleurCellMorte);
            this.pnl_parametres.Controls.Add(this.pnl_couleurCellVivante);
            this.pnl_parametres.Controls.Add(this.nud_qte_colonnes);
            this.pnl_parametres.Controls.Add(this.nud_qte_lignes);
            this.pnl_parametres.Controls.Add(this.lbl_couleurCellMorte);
            this.pnl_parametres.Controls.Add(this.lbl_couleurCellVivante);
            this.pnl_parametres.Controls.Add(this.lbl_qteColonnes);
            this.pnl_parametres.Controls.Add(this.lbl_qteLignes);
            this.pnl_parametres.Controls.Add(this.tb_taux);
            this.pnl_parametres.Controls.Add(this.gpb_remplissage);
            this.pnl_parametres.Controls.Add(this.lbl_titreParam);
            this.pnl_parametres.Location = new System.Drawing.Point(3, 93);
            this.pnl_parametres.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_parametres.Name = "pnl_parametres";
            this.pnl_parametres.Size = new System.Drawing.Size(237, 304);
            this.pnl_parametres.TabIndex = 1;
            // 
            // lbl_taux
            // 
            this.lbl_taux.AutoSize = true;
            this.lbl_taux.Location = new System.Drawing.Point(4, 79);
            this.lbl_taux.Name = "lbl_taux";
            this.lbl_taux.Size = new System.Drawing.Size(54, 13);
            this.lbl_taux.TabIndex = 3;
            this.lbl_taux.Text = "Taux : 0%";
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(134, 276);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(75, 23);
            this.btn_effacer.TabIndex = 13;
            this.btn_effacer.Text = "Effacer";
            this.btn_effacer.UseVisualStyleBackColor = true;
            this.btn_effacer.Click += new System.EventHandler(this.btn_effacer_Click);
            // 
            // btn_generer
            // 
            this.btn_generer.Location = new System.Drawing.Point(20, 276);
            this.btn_generer.Name = "btn_generer";
            this.btn_generer.Size = new System.Drawing.Size(75, 23);
            this.btn_generer.TabIndex = 12;
            this.btn_generer.Text = "Générer";
            this.btn_generer.UseVisualStyleBackColor = true;
            this.btn_generer.Click += new System.EventHandler(this.btn_generer_Click);
            // 
            // pnl_couleurCellMorte
            // 
            this.pnl_couleurCellMorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_couleurCellMorte.Location = new System.Drawing.Point(156, 243);
            this.pnl_couleurCellMorte.Name = "pnl_couleurCellMorte";
            this.pnl_couleurCellMorte.Size = new System.Drawing.Size(40, 15);
            this.pnl_couleurCellMorte.TabIndex = 11;
            this.pnl_couleurCellMorte.Click += new System.EventHandler(this.pnl_couleurCellMorte_Click);
            // 
            // pnl_couleurCellVivante
            // 
            this.pnl_couleurCellVivante.BackColor = System.Drawing.Color.Green;
            this.pnl_couleurCellVivante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_couleurCellVivante.Location = new System.Drawing.Point(156, 215);
            this.pnl_couleurCellVivante.Name = "pnl_couleurCellVivante";
            this.pnl_couleurCellVivante.Size = new System.Drawing.Size(40, 15);
            this.pnl_couleurCellVivante.TabIndex = 10;
            this.pnl_couleurCellVivante.Click += new System.EventHandler(this.pnl_couleurCellVivante_click);
            // 
            // nud_qte_colonnes
            // 
            this.nud_qte_colonnes.Location = new System.Drawing.Point(156, 178);
            this.nud_qte_colonnes.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_qte_colonnes.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_qte_colonnes.Name = "nud_qte_colonnes";
            this.nud_qte_colonnes.Size = new System.Drawing.Size(53, 20);
            this.nud_qte_colonnes.TabIndex = 9;
            this.nud_qte_colonnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_qte_colonnes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nud_qte_lignes
            // 
            this.nud_qte_lignes.Location = new System.Drawing.Point(156, 151);
            this.nud_qte_lignes.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_qte_lignes.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_qte_lignes.Name = "nud_qte_lignes";
            this.nud_qte_lignes.Size = new System.Drawing.Size(53, 20);
            this.nud_qte_lignes.TabIndex = 8;
            this.nud_qte_lignes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_qte_lignes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lbl_couleurCellMorte
            // 
            this.lbl_couleurCellMorte.AutoSize = true;
            this.lbl_couleurCellMorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_couleurCellMorte.Location = new System.Drawing.Point(4, 243);
            this.lbl_couleurCellMorte.Name = "lbl_couleurCellMorte";
            this.lbl_couleurCellMorte.Size = new System.Drawing.Size(80, 15);
            this.lbl_couleurCellMorte.TabIndex = 7;
            this.lbl_couleurCellMorte.Text = "Cellule morte";
            // 
            // lbl_couleurCellVivante
            // 
            this.lbl_couleurCellVivante.AutoSize = true;
            this.lbl_couleurCellVivante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_couleurCellVivante.Location = new System.Drawing.Point(4, 215);
            this.lbl_couleurCellVivante.Name = "lbl_couleurCellVivante";
            this.lbl_couleurCellVivante.Size = new System.Drawing.Size(85, 15);
            this.lbl_couleurCellVivante.TabIndex = 6;
            this.lbl_couleurCellVivante.Text = "Cellule vivante";
            // 
            // lbl_qteColonnes
            // 
            this.lbl_qteColonnes.AutoSize = true;
            this.lbl_qteColonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qteColonnes.Location = new System.Drawing.Point(4, 178);
            this.lbl_qteColonnes.Name = "lbl_qteColonnes";
            this.lbl_qteColonnes.Size = new System.Drawing.Size(123, 15);
            this.lbl_qteColonnes.TabIndex = 5;
            this.lbl_qteColonnes.Text = "Quantité de colonnes";
            // 
            // lbl_qteLignes
            // 
            this.lbl_qteLignes.AutoSize = true;
            this.lbl_qteLignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qteLignes.Location = new System.Drawing.Point(4, 151);
            this.lbl_qteLignes.Name = "lbl_qteLignes";
            this.lbl_qteLignes.Size = new System.Drawing.Size(106, 15);
            this.lbl_qteLignes.TabIndex = 4;
            this.lbl_qteLignes.Text = "Quantité de lignes";
            // 
            // tb_taux
            // 
            this.tb_taux.Location = new System.Drawing.Point(-1, 100);
            this.tb_taux.Maximum = 100;
            this.tb_taux.Name = "tb_taux";
            this.tb_taux.Size = new System.Drawing.Size(237, 45);
            this.tb_taux.TabIndex = 0;
            this.tb_taux.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_taux.Scroll += new System.EventHandler(this.tb_taux_Scroll);
            // 
            // gpb_remplissage
            // 
            this.gpb_remplissage.Controls.Add(this.rdo_figures);
            this.gpb_remplissage.Controls.Add(this.rdo_manuel);
            this.gpb_remplissage.Controls.Add(this.rdo_automatique);
            this.gpb_remplissage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_remplissage.Location = new System.Drawing.Point(4, 27);
            this.gpb_remplissage.Name = "gpb_remplissage";
            this.gpb_remplissage.Size = new System.Drawing.Size(228, 49);
            this.gpb_remplissage.TabIndex = 2;
            this.gpb_remplissage.TabStop = false;
            this.gpb_remplissage.Text = "Remplissage";
            // 
            // rdo_figures
            // 
            this.rdo_figures.AutoSize = true;
            this.rdo_figures.Enabled = false;
            this.rdo_figures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_figures.Location = new System.Drawing.Point(163, 20);
            this.rdo_figures.Name = "rdo_figures";
            this.rdo_figures.Size = new System.Drawing.Size(59, 17);
            this.rdo_figures.TabIndex = 3;
            this.rdo_figures.Text = "Figures";
            this.rdo_figures.UseVisualStyleBackColor = true;
            this.rdo_figures.CheckedChanged += new System.EventHandler(this.rdo_mode_CheckedChanged);
            // 
            // rdo_manuel
            // 
            this.rdo_manuel.AutoSize = true;
            this.rdo_manuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_manuel.Location = new System.Drawing.Point(97, 19);
            this.rdo_manuel.Name = "rdo_manuel";
            this.rdo_manuel.Size = new System.Drawing.Size(60, 17);
            this.rdo_manuel.TabIndex = 1;
            this.rdo_manuel.Text = "Manuel";
            this.rdo_manuel.UseVisualStyleBackColor = true;
            this.rdo_manuel.CheckedChanged += new System.EventHandler(this.rdo_mode_CheckedChanged);
            // 
            // rdo_automatique
            // 
            this.rdo_automatique.AutoSize = true;
            this.rdo_automatique.Checked = true;
            this.rdo_automatique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_automatique.Location = new System.Drawing.Point(7, 20);
            this.rdo_automatique.Name = "rdo_automatique";
            this.rdo_automatique.Size = new System.Drawing.Size(84, 17);
            this.rdo_automatique.TabIndex = 0;
            this.rdo_automatique.TabStop = true;
            this.rdo_automatique.Text = "Automatique";
            this.rdo_automatique.UseVisualStyleBackColor = true;
            this.rdo_automatique.CheckedChanged += new System.EventHandler(this.rdo_mode_CheckedChanged);
            // 
            // lbl_titreParam
            // 
            this.lbl_titreParam.BackColor = System.Drawing.Color.Black;
            this.lbl_titreParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreParam.ForeColor = System.Drawing.Color.White;
            this.lbl_titreParam.Location = new System.Drawing.Point(3, -1);
            this.lbl_titreParam.Name = "lbl_titreParam";
            this.lbl_titreParam.Size = new System.Drawing.Size(229, 24);
            this.lbl_titreParam.TabIndex = 1;
            this.lbl_titreParam.Text = "Paramètres";
            this.lbl_titreParam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_informations
            // 
            this.pnl_informations.BackColor = System.Drawing.Color.White;
            this.pnl_informations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_informations.Controls.Add(this.lbl_generations);
            this.pnl_informations.Controls.Add(this.lbl_cellMortes);
            this.pnl_informations.Controls.Add(this.lbl_cellVivantes);
            this.pnl_informations.Controls.Add(this.lbl_titreInfo);
            this.pnl_informations.Location = new System.Drawing.Point(3, 3);
            this.pnl_informations.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_informations.Name = "pnl_informations";
            this.pnl_informations.Size = new System.Drawing.Size(237, 90);
            this.pnl_informations.TabIndex = 0;
            // 
            // lbl_generations
            // 
            this.lbl_generations.AutoSize = true;
            this.lbl_generations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generations.Location = new System.Drawing.Point(4, 62);
            this.lbl_generations.Name = "lbl_generations";
            this.lbl_generations.Size = new System.Drawing.Size(80, 15);
            this.lbl_generations.TabIndex = 3;
            this.lbl_generations.Text = "Générations :";
            // 
            // lbl_cellMortes
            // 
            this.lbl_cellMortes.AutoSize = true;
            this.lbl_cellMortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cellMortes.Location = new System.Drawing.Point(4, 47);
            this.lbl_cellMortes.Name = "lbl_cellMortes";
            this.lbl_cellMortes.Size = new System.Drawing.Size(98, 15);
            this.lbl_cellMortes.TabIndex = 2;
            this.lbl_cellMortes.Text = "Cellules mortes :";
            // 
            // lbl_cellVivantes
            // 
            this.lbl_cellVivantes.AutoSize = true;
            this.lbl_cellVivantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cellVivantes.Location = new System.Drawing.Point(4, 32);
            this.lbl_cellVivantes.Name = "lbl_cellVivantes";
            this.lbl_cellVivantes.Size = new System.Drawing.Size(103, 15);
            this.lbl_cellVivantes.TabIndex = 1;
            this.lbl_cellVivantes.Text = "Cellules vivantes :";
            // 
            // lbl_titreInfo
            // 
            this.lbl_titreInfo.BackColor = System.Drawing.Color.Black;
            this.lbl_titreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_titreInfo.Location = new System.Drawing.Point(3, 0);
            this.lbl_titreInfo.Name = "lbl_titreInfo";
            this.lbl_titreInfo.Size = new System.Drawing.Size(229, 23);
            this.lbl_titreInfo.TabIndex = 0;
            this.lbl_titreInfo.Text = "Informations";
            this.lbl_titreInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dc_couleur
            // 
            this.dc_couleur.Color = System.Drawing.Color.Green;
            // 
            // tim_tempsCycle
            // 
            this.tim_tempsCycle.Interval = 50;
            this.tim_tempsCycle.Tick += new System.EventHandler(this.tim_tempsCycle_Tick);
            // 
            // Frm_jeuDeLaVie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 743);
            this.Controls.Add(this.pnl_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_jeuDeLaVie";
            this.Text = "Jeu de la vie";
            this.pnl_options.ResumeLayout(false);
            this.pnl_generation.ResumeLayout(false);
            this.pnl_generation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tempsCycle)).EndInit();
            this.pnl_parametres.ResumeLayout(false);
            this.pnl_parametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qte_colonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qte_lignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_taux)).EndInit();
            this.gpb_remplissage.ResumeLayout(false);
            this.gpb_remplissage.PerformLayout();
            this.pnl_informations.ResumeLayout(false);
            this.pnl_informations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_options;
        private System.Windows.Forms.Panel pnl_generation;
        private System.Windows.Forms.Label lbl_titreGen;
        private System.Windows.Forms.Panel pnl_parametres;
        private System.Windows.Forms.Label lbl_titreParam;
        private System.Windows.Forms.Panel pnl_informations;
        private System.Windows.Forms.Label lbl_titreInfo;
        private System.Windows.Forms.Label lbl_generations;
        private System.Windows.Forms.Label lbl_cellMortes;
        private System.Windows.Forms.Label lbl_cellVivantes;
        private System.Windows.Forms.GroupBox gpb_remplissage;
        private System.Windows.Forms.RadioButton rdo_figures;
        private System.Windows.Forms.RadioButton rdo_manuel;
        private System.Windows.Forms.RadioButton rdo_automatique;
        private System.Windows.Forms.TrackBar tb_taux;
        private System.Windows.Forms.Label lbl_couleurCellVivante;
        private System.Windows.Forms.Label lbl_qteColonnes;
        private System.Windows.Forms.Label lbl_qteLignes;
        private System.Windows.Forms.NumericUpDown nud_qte_colonnes;
        private System.Windows.Forms.NumericUpDown nud_qte_lignes;
        private System.Windows.Forms.Label lbl_couleurCellMorte;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_nouvelle;
        private System.Windows.Forms.TrackBar tb_tempsCycle;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.Button btn_generer;
        private System.Windows.Forms.Panel pnl_couleurCellMorte;
        private System.Windows.Forms.Panel pnl_couleurCellVivante;
        private System.Windows.Forms.ColorDialog dc_couleur;
        private System.Windows.Forms.Label lbl_taux;
        private System.Windows.Forms.Label lbl_tempsCycle;
        private System.Windows.Forms.Timer tim_tempsCycle;




    }
}


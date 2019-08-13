//  --------------------------------------------------------------------------
/*  ____.                  .___       .__                 .__        
    |    | ____  __ __    __| _/____   |  | _____    ___  _|__| ____  
    |    |/ __ \|  |  \  / __ |/ __ \  |  | \__  \   \  \/ /  |/ __ \ 
/\__|    \  ___/|  |  / / /_/ \  ___/  |  |__/ __ \_  \   /|  \  ___/ 
\________|\___  >____/  \____ |\___  > |____(____  /   \_/ |__|\___  >
              \/             \/    \/            \/                \/ 
 */
//  --------------------------------------------------------------------------
//  Auteur : Fleury Malik
//  Date : 16.03.2015
//
//  Classe permettant l'affichage du jeu de la vie ainsi que des paramètres
//  --------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeLaVie
{
    public partial class Frm_jeuDeLaVie : Form
    {
        private GrilleGraphique grilleCellules;     // Contient la grille
        private Donnees donneesJeu;                 // Contient les données du jeu

        /// <summary>
        /// Constructeur de la fenêtre principale
        /// </summary>
        public Frm_jeuDeLaVie()
        {
            // Initalisation des composants statiques de la fenêtre
            InitializeComponent();

            // Instancie les données et la grille
            donneesJeu = new Donnees();
            grilleCellules = new GrilleGraphique(donneesJeu);
            this.Controls.Add(grilleCellules);

            // Configuration par défaut du programme
            donneesJeu.QteLignes = 25;                              // Nombre de lignes, par défaut 25
            donneesJeu.QteColonnes = 25;                            // Nombre de colonnes, par défaut 25
            grilleCellules.CouleurCellulesVivantes = Color.Green;   // Couleur des cellules vivantes, par défaut verte
            grilleCellules.CouleurCellulesMortes = Color.White;     // Couleur des cellules mortes, par défaut blanche

            // Création de la première grille
            donneesJeu.CreerTableau();                              // Créer le tableau de cellules et l'initialise
            donneesJeu.GenererCellulesVivantes();                   // Génère les cellules vivantes automatiquement dans le tableau
            grilleCellules.CreerGrille();                           // Créer la grille graphique

            // Affichage des cellules et des informations
            grilleCellules.MajAffichageCellules();                  // Met à jour l'affichage des cellules dans la grille
            MajInformationsIU();                                    // Met à jour l'interface utilisateur    
        }

        /// <summary>
        /// Permet de mettre à jour les informations de l'interface utilisateur
        /// </summary>
        public void MajInformationsIU()
        {
            // Met à jour les informations relatives aux cellules mortes et vivantes ainsi que les générations
            lbl_cellVivantes.Text = "Cellules vivantes : " + donneesJeu.QteCellVivantes.ToString();
            lbl_cellMortes.Text = "Cellules mortes : " + donneesJeu.QteCellMortes.ToString();
            lbl_generations.Text = "Générations : " + donneesJeu.QteGenerations.ToString();
        }

        /// <summary>
        /// Permet de sélectionner le mode de fonctionnement du jeu de la vie (auto, manuel, figures)
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void rdo_mode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo_mode = sender as RadioButton;     // Permet d'obtenir la case à cocher qui a reçu l'événement

            // Test le mode de remplissage
            // Mode automatique
            if (rdo_mode == rdo_automatique && rdo_mode.Checked)
            {
                // Passe le programme en mode automatique
                donneesJeu.Mode = ModeProg.Automatique;

                // Activer la barre de taux
                tb_taux.Enabled = true;
                tb_taux.Visible = true;
                lbl_taux.Visible = true;
            }
            // Mode manuel
            else if (rdo_mode == rdo_manuel && rdo_mode.Checked)
            {
                // Passe le programme en mode manuel
                donneesJeu.Mode = ModeProg.Manuel;

                // Désactiver la barre de taux
                tb_taux.Enabled = false;
                tb_taux.Visible = false;
                lbl_taux.Visible = false;
            }
            // Mode figures
            else if (rdo_mode == rdo_figures && rdo_mode.Checked)
            {
                // Pas encore implémenté
            }
        }

        /// <summary>
        /// Permet d'afficher le taux dans l'interface
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void tb_taux_Scroll(object sender, EventArgs e)
        {
            // Entre la nouvelle valeur de taux dans l'interface
            lbl_taux.Text = "Taux : " + tb_taux.Value.ToString() + "%";
        }

        /// <summary>
        /// Permet de modifier la couleur des cellules vivantes
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void pnl_couleurCellVivante_click(object sender, EventArgs e)
        {
            // Affiche la boîte de dialogue des couleurs
            if (dc_couleur.ShowDialog() == DialogResult.OK)
            {
                // Modifie la couleur des cellules vivantes
                pnl_couleurCellVivante.BackColor = dc_couleur.Color;
                grilleCellules.CouleurCellulesVivantes = dc_couleur.Color;

                // Met à jour l'affichage des cellules avec la nouvelle couleur
                grilleCellules.MajAffichageCellules();
            }
        }

        /// <summary>
        /// Permet de modifier la couleur des cellules mortes
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void pnl_couleurCellMorte_Click(object sender, EventArgs e)
        {
            // Affiche la boîte de dialogue des couleurs
            if (dc_couleur.ShowDialog() == DialogResult.OK)
            {
                // Modifie la couleur des cellules mortes
                pnl_couleurCellMorte.BackColor = dc_couleur.Color;
                grilleCellules.CouleurCellulesMortes = dc_couleur.Color;

                // Met à jour l'affichage des cellules avec la nouvelle couleur
                grilleCellules.MajAffichageCellules();
            }
        }

        /// <summary>
        /// Permet de générer la grille selon les dimensions choisies par l'utilisateur
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void btn_generer_Click(object sender, EventArgs e)
        {
            // Libérer la grille
            grilleCellules.Liberer();

            // Met à jour les données de grille
            donneesJeu.QteLignes = (int)nud_qte_lignes.Value;      // Obtient la quantité de ligne
            donneesJeu.QteColonnes = (int)nud_qte_colonnes.Value;  // Obtient la quantité de colonnes
            donneesJeu.Taux = tb_taux.Value;                       // Obtient le taux de cellules vivantes et mortes

            // Créer la grille
            donneesJeu.CreerTableau();          // Créer un tableau de cellules
            grilleCellules.CreerGrille();       // Créer une grille graphique pour l'affichage des cellules

            // Test le mode de remplissage
            switch (donneesJeu.Mode)
            {
                case ModeProg.Automatique:  // Créer un nouveau tableau et génère de nouvelles cellules mortes
                    
                    donneesJeu.GenererCellulesVivantes();       // Génère les cellules vivantes aléatoirement
                    grilleCellules.MajAffichageCellules();      // Met à jour l'affichage des cellules de la grille
                    break;
                case ModeProg.Manuel:       // Créer un nouveau tableau et initialise toutes les cellules à l'état "morte".
                    donneesJeu.InitCellules(Donnees.morte);     // Initialise les cellules à l'état mort
                    grilleCellules.MajAffichageCellules();      // Met à jour l'affichage des cellules de la grille
                    break;
                case ModeProg.Figure:       // Figure (pas encore implémenté pour cette version)
                    break;
            }

            // Met à jour les informations UI
            MajInformationsIU();
        }

        /// <summary>
        /// Permet de lancer une nouvelle génération
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void btn_nouvelle_Click(object sender, EventArgs e)
        {
            // Calcul la nouvelle génération de cellules
            donneesJeu.CalculerNouvelleGeneration();
          
            // Met à jour les cellules dans la grille et les informations UI
            grilleCellules.MajAffichageCellules();
            MajInformationsIU();
        }

        /// <summary>
        /// Permet de lancer le cycle de générations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            // Permet de lancer le cycle de générations
            tim_tempsCycle.Start();
        }

        /// <summary>
        /// Permet d'arrêter le cycle de générations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            // Permet d'arrêter le cycle de générations
            tim_tempsCycle.Stop();
        }

        /// <summary>
        /// Permet de calculer la génération suivante de cellules et 
        /// affiche les informations dans l'IU
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void tim_tempsCycle_Tick(object sender, EventArgs e)
        {
            // Calcul la nouvelle génération de cellules
            donneesJeu.CalculerNouvelleGeneration();

            // Met à jour les cellules dans la grille et les informations UI
            grilleCellules.MajAffichageCellules();
            MajInformationsIU();
        }

        /// <summary>
        /// Permet de modifier le temps du timer et de l'afficher dans l'interface
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void tb_tempsCycle_Scroll(object sender, EventArgs e)
        {
            // Modifie le temps du timer
            tim_tempsCycle.Interval = tb_tempsCycle.Value;

            // Affiche la nouvelle valeur de temps de cycle dans l'interface
            lbl_tempsCycle.Text = "Temps de cycle : " + tb_tempsCycle.Value + "ms";
        }

        /// <summary>
        /// Permet de remplir la grille de cellules mortes
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void btn_effacer_Click(object sender, EventArgs e)
        {
            // Remet toutes les cellules à dans l'état morte
            donneesJeu.InitCellules(Donnees.morte);

            // Met à jour les cellules dans la grille et les informations UI
            grilleCellules.MajAffichageCellules();
            MajInformationsIU();
        }
    }
}

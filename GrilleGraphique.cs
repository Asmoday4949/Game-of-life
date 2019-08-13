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
//  Classe permettant l'affichage des cellules en grille
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
    public class GrilleGraphique : Panel
    {
        private Donnees donneesJeu;                 // Contient toutes les données du jeu
        private Color couleurCellVivantes;          // Couleur des cellules vivantes
        private Color couleurCellMortes;            // Couleur des cellules mortes

        /// <summary>
        /// Constructeur
        /// </summary>
        public GrilleGraphique(Donnees donneesJeu)
        {
            // Configure la grille avec les paramètres par défaut
            this.Size = new Size(700, 700);                     // Taille de la grille
            this.Location = new Point(10, 10);                  // Position de la grille

            // Obtention des données à afficher dans la grille
            this.donneesJeu = donneesJeu;
        }

        /// <summary>
        /// Permet la création de la grille
        /// </summary>
        public void CreerGrille()
        {
            Panel pnl_cellule;                              // Référence du panel traité
            Point position = new Point(0, 0);               // Position en X et Y du prochain panel
            int qteLignes = donneesJeu.QteLignes;           // Obtient la quantité de lignes
            int qteColonnes = donneesJeu.QteColonnes;       // Obtient la quantité de colonnes

            // Calcul des longueurs
            int longueurCase = this.Size.Width / qteColonnes;          // Calcul la longueur d'une case (pixels)
            int hauteurCase = this.Size.Height / qteLignes;            // Calcul la hauteur d'une case (pixels)

            // Créer le tableau de données
            donneesJeu.CreerTableau();

            // Ajoute les panels dans le tableau
            for (int cptLignes = 0; cptLignes < qteLignes; cptLignes++)
            {
                for (int cptColonnes = 0; cptColonnes < qteColonnes; cptColonnes++)
                {
                    // Création d'un panel dans les bonnes dimensions et les bonnes positions
                    pnl_cellule = new Panel();
                    pnl_cellule.Name = cptLignes + ":" + cptColonnes;                           // Détermine le nom du panel selon la ligne et la colonne
                    pnl_cellule.Size = new Size(longueurCase, hauteurCase);                     // Détermine la largeur et la hauteur du panel
                    pnl_cellule.Location = position;                                            // Détermine la position dans son espace
                    pnl_cellule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;     // Ajoute des bords autour du panel
                    pnl_cellule.MouseClick += grille_click;                                     // Ajoute un événement au panel
                    this.Controls.Add(pnl_cellule);                                             // Ajoute le panel dans les contrôles de la grille

                    // Modifie la position en X(colonne) pour le prochain panel
                    position.X += longueurCase;
                }
                // Modifie la position en X(colonne) et en Y(ligne) pour la prochaine lignée de panels
                position.Y += hauteurCase;
                position.X = 0;
            }
        }

        /// <summary>
        /// Permet de mettre à jour l'affichage des cellules vivantes et mortes
        /// </summary>
        public void MajAffichageCellules()
        {
            Panel pnl_cellule;                              // Référence du panel traité
            int qteLignes = donneesJeu.QteLignes;           // Obtient le nombre de lignes
            int qteColonnes = donneesJeu.QteColonnes;       // Obtient le nombre de colonnes
            bool[,] tabCellules = donneesJeu.TabCellules;   // Obtient le tableau de cellules mortes ou vivantes

            // Défini la couleur adéquate selon l'état de la cellule
            for (int cptLignes = 0; cptLignes < qteLignes; cptLignes++)
            {
                for (int cptColonnes = 0; cptColonnes < qteColonnes; cptColonnes++)
                {
                    // Obtient la référence du panel représentant la cellule
                    pnl_cellule = GetPanelDepuisControls(cptLignes, cptColonnes);

                    // Choisie la couleur correspondant à l'état de la cellule
                    if (tabCellules[cptLignes, cptColonnes])
                        pnl_cellule.BackColor = couleurCellVivantes;
                    else
                        pnl_cellule.BackColor = couleurCellMortes;
                }
            }
        }

        /// <summary>
        /// Permet de vider le tableau de panels
        /// </summary>
        public void Liberer()
        {
            // Enlève les panels lié à la grille
            this.Controls.Clear();
        }

        /// <summary>
        /// Permet d'obtenir le panel se trouvant dans Controls à l'aide de la ligne et de la colonne
        /// </summary>
        /// <param name="ligne">Ligne où se trouve le panel</param>
        /// <param name="colonne">Colonnes où se trouve le panel</param>
        /// <returns>Panel trouvé correspondant aux coordonnées</returns>
        public Panel GetPanelDepuisControls(int ligne, int colonne)
        {
            Panel pnl_cellule;                              // Panel de la cellule que l'on souhaite obtenir
            int qteLignes = donneesJeu.QteLignes;           // Nombre de lignes de la grille
            int qteColonnes = donneesJeu.QteColonnes;       // Nombre de colonnes de la grille
            int posPanel = 0;                               // Position du panel que l'on souhaite obtenir

            // Calcul de la position du panel dans Controls
            posPanel = (ligne * qteColonnes) + colonne;

            // Obtient le panel de la cellule
            pnl_cellule = this.Controls[posPanel] as Panel;

            // Retourne le panel trouvé
            return pnl_cellule;
        }

        /// <summary>
        /// Permet d'ajouter une cellule vivante ou morte lors du mode manuel
        /// </summary>
        /// <param name="sender">Objet qui à lancé l'événement</param>
        /// <param name="e">Objet contenant des informations sur l'événement</param>
        private void grille_click(object sender, MouseEventArgs e)
        {
            Frm_jeuDeLaVie frm_jeuDeLaVie = FindForm() as Frm_jeuDeLaVie;   // Obtient la fenêtre principale du programme
            Panel pnl_cellule = sender as Panel;                            // Panel qui a été cliqué
            string[] tabPosition;                                           // Contient les coordonnées du panel
            bool[,] tabCellules = donneesJeu.TabCellules;                   // Obtient le tableau des cellules
            int ligne = 0;                                                  // Indique la ligne où se trouve le panel cliqué
            int colonne = 0;                                                // Indique la colonne où se trouve le panel cliqué

            if (donneesJeu.Mode == ModeProg.Manuel)
            {
                // Obtient la position du panel dans le tableau de cellule
                tabPosition = pnl_cellule.Name.Split(':');
                ligne = int.Parse(tabPosition[0]);
                colonne = int.Parse(tabPosition[1]);

                // Modifie l'état d'une cellule selon le clique de souris
                // gauche --> cellule vivante
                if (e.Button == MouseButtons.Left)
                {
                    donneesJeu.AjouterCellule(ligne, colonne, Donnees.vivante);                 // Ajoute une nouvelle cellule vivante
                    GetPanelDepuisControls(ligne, colonne).BackColor = couleurCellVivantes;     // Met à jour la couleur de la cellule
                }
                // Droit --> cellule morte
                else if (e.Button == MouseButtons.Right)
                {
                    donneesJeu.AjouterCellule(ligne, colonne, Donnees.morte);                   // Ajoute une nouvelle cellule morte
                    GetPanelDepuisControls(ligne, colonne).BackColor = couleurCellMortes;       // Met à jour la couleur de la cellule
                }

                // Met à jour les informations de l'interface utilisateur
                frm_jeuDeLaVie.MajInformationsIU();
            }
        }

        /// <summary>
        /// Permet de modifier ou connaitre la couleur des cellules vivantes
        /// </summary>
        public Color CouleurCellulesVivantes
        {
            get { return couleurCellVivantes;}
            set { couleurCellVivantes = value;}
        }

        /// <summary>
        /// Permet de modifier ou de connaitre la couleur des cellules mortes
        /// </summary>
        public Color CouleurCellulesMortes
        {
            get { return couleurCellMortes;}
            set { couleurCellMortes = value;}
        }
    }
}

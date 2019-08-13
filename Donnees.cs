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
//  Classe permettant la gestion des données du jeu de la vie
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
    /// <summary>
    /// Permet de définir le mode de fonctionnent du programme (Automatique, Manuel, Figure)
    /// </summary>
    public enum ModeProg
    {
        Automatique,
        Manuel,
        Figure
    }

    public class Donnees
    {
        static public bool morte = false;   // Défini vide comme "faux"
        static public bool vivante = true;  // Défini occupée comme "vrai"

        private bool[,] tabCellules;        // Tableau du jeu
        private int qteLignes;              // Quantité de lignes
        private int qteColonnes;            // Quantité de colonnes
        private int taux;                   // Taux de cellules vivantes/mortes
        private int qteCellVivantes;        // Indique la quantité de cellules vivantes
        private int qteCellMortes;          // Indique la quantité de cellules mortes
        private int qteGenerations;         // Quantité de générations
        private ModeProg mode;              // Mode de fonctionnement du programme

        /// <summary>
        /// Constructeur
        /// </summary>
        public Donnees()
        {
        }

        /// <summary>
        /// Permet de modifier la dimension du tableau de données
        /// </summary>
        /// <param name="qteLignes">Quantité de lignes</param>
        /// <param name="qteColonnes">Quantité de colonnes</param>
        public void SetDimension(int qteLignes, int qteColonnes)
        {
            // Insertion de la nouvelle dimension (lignes, colonnes)
            this.qteLignes = qteLignes;
            this.qteColonnes = qteColonnes;
        }

        /// <summary>
        /// Création d'un nouveau tableau de cellules mortes
        /// </summary>
        public void CreerTableau()
        {
            // Création du tableau
            tabCellules = new bool[qteLignes, qteColonnes];

            // Initialise le tableau avec des cellules mortes
            InitCellules(morte);
        }

        /// <summary>
        /// Affecte un état initiale pour chaque cellule
        /// </summary>
        /// <param name="etat"></param>
        public void InitCellules(bool etat)
        {
            // Initialise tout le tableau de cellules
            for (int cptLignes = 0; cptLignes < qteLignes; cptLignes++)
            {
                for (int cptColonnes = 0; cptColonnes < qteColonnes; cptColonnes++)
                {
                    // Initialise une cellule dans l'état défini
                    tabCellules[cptLignes, cptColonnes] = etat;
                }
            }

            // Détermine le nombre de cellules mortes et vivantes
            if (etat)
            {
                qteCellVivantes = qteLignes * qteColonnes;
                qteCellMortes = 0;
            }
            else
            {
                qteCellVivantes = 0;
                qteCellMortes = qteLignes * qteColonnes;
            }

            // Remet à zéro la quantité de générations
            qteGenerations = 0;
        }

        /// <summary>
        /// Permet de générer aléatoirement les cellules vivantes dans le tableau selon
        /// le taux
        /// </summary>
        public void GenererCellulesVivantes()
        {
            Random genPosition = new Random();                          // Permet la génération de nombre aléatoire pour l'état des cellules
            int nbreTotalCellules = qteLignes * qteColonnes;            // Nombre total de cellules
            int nbreCellulesVivantes = nbreTotalCellules * taux / 100;  // Calcul le nombre de cellules vivantes
            int cptCellulesVivantes = 0;                                // Compteur de cellules vivantes ajoutées
            int ligneGeneree;                                           // Indique la ligne générée
            int colonneGeneree;                                         // Indique la colonne générée

            // Génère des cellules vivantes selon le taux
            while (cptCellulesVivantes < nbreCellulesVivantes)
            {
                // Génère la ligne et la colonne où insérer une nouvelle cellule vivante
                ligneGeneree = (int)genPosition.Next(0, qteLignes);
                colonneGeneree = (int)genPosition.Next(0, qteColonnes);

                // Ajoute une cellule vivante s'il n'y en a pas encore dans la case
                if (!tabCellules[ligneGeneree, colonneGeneree])
                {
                    AjouterCellule(ligneGeneree, colonneGeneree, vivante);          // Nouvelle cellule vivante
                    cptCellulesVivantes++;                                          // Incrémente le compteur de cellules vivantes
                }
            }
        }

        /// <summary>
        /// Permet de corriger les positions de ligne et de colonne qui sont hors du tableau
        /// </summary>
        /// <param name="ligne">Ligne susceptible d'être corrigée</param>
        /// <param name="colonne">Colonne susceptible d'être corrigée</param>
        /// <returns>Position corrigée</returns>
        public Point CorrigerPosition2(int ligne, int colonne)
        {
            Point position = new Point(colonne, ligne);     // Résultat de la position corrigée ou non

            // Corrige la position de ligne lorsque ça dépasse les dimensions de la grille
            if ((ligne % (qteLignes - 1) == 1) && (ligne / (qteLignes - 1) == 1))
                position.Y = 0;                 // Positionne à la ligne 0
            else if (ligne < 0)
                position.Y = qteLignes - 1;     // Positionne à la dernière ligne

            // Corrige la position de colonne lorsque ça dépasse les dimensions de la grille
            if ((colonne % (qteColonnes - 1) == 1) && (colonne / (qteColonnes - 1) == 1))
                position.X = 0;                 // Positionne à la colonne 0
            else if (colonne < 0)
                position.X = qteColonnes - 1;   // Positionnne à la dernière colonne

            // Retourne la position corrigée
             return position;
        }

        /// <summary>
        /// Permet de corriger les positions de ligne et de colonne qui sont hors du tableau
        /// </summary>
        /// <param name="ligne">Ligne susceptible d'être corrigée</param>
        /// <param name="colonne">Colonne susceptible d'être corrigée</param>
        /// <returns>Position corrigée</returns>
        public Point CorrigerPosition(int ligne, int colonne)
        {
            Point position;     // Résultat de la position corrigée ou non

            // Si la ligne et la colonne sont plus petites que les dimensions du tableau
            if (ligne < 0 && colonne < 0)
                position = new Point(qteColonnes - 1, qteLignes - 1);

            // Si la ligne est plus petite et que la colonnes est plus grande que les dimensions du tableau
            else if (ligne < 0 && colonne >= qteColonnes)
                position = new Point(0, qteLignes - 1);

            // Si la ligne est plus grande et que la colonnes est plus petite que les dimensions du tableau
            else if (ligne >= qteLignes && colonne < 0)
                position = new Point(qteColonnes - 1, 0);

            // Si la ligne et la colonne sont plus grandes que que les dimensions du tableau
            else if (ligne >= qteLignes && colonne >= qteColonnes)
                position = new Point(0, 0);

            // Si la ligne est plus petite que les dimensions du tableau
            else if (ligne < 0)
                position = new Point(colonne, qteLignes - 1);

            // Si la colonne est plus petite que les dimensions du tableau
            else if (colonne < 0)
                position = new Point(qteColonnes - 1, ligne);

            // Si la ligne est égale voire plus grande que les dimensions du tableau
            else if (ligne >= qteLignes)
                position = new Point(colonne, 0);

            // Si la colonne est égale voire plus grande que les dimensions du tableau
            else if (colonne >= qteColonnes)
                position = new Point(0, ligne);

            // Sinon on ne corrige pas
            else
                position = new Point(colonne, ligne);

            // Retourne la position corrigée
            return position;
        }

        /// <summary>
        /// Permet de calculer le nombre de voisins d'une cellule
        /// </summary>
        /// <param name="ligne">Ligne de la cellule</param>
        /// <param name="colonne">Colonne de la cellule</param>
        /// <returns>Nombre de voisins de la cellule</returns>
        public int CalculerNombreVoisins(int ligne, int colonne)
        {
            int resultatVoisins = 0;    // Indique le nombre de voisins autour de la cellule (par défaut 1, cellule testée)
            Point posVoisin;            // Position du voisin traité

            // Calcul le nombre de voisins
            for (int cptLignes = ligne - 1; cptLignes <= ligne + 1; cptLignes++)
            {
                for (int cptColonnes = colonne - 1; cptColonnes <= colonne + 1; cptColonnes++)
                {
                    // Obtient le voisin
                    posVoisin = CorrigerPosition2(cptLignes, cptColonnes);

                    // Test si la cellule voisine est vivante
                    // et incrémente le nombre de voisins
                    if (tabCellules[posVoisin.Y, posVoisin.X])
                        resultatVoisins++;
                }
            }

            // Enlève 1 dans le cas où la cellule testée est comprise comme voisin
            if (tabCellules[ligne,colonne])
                resultatVoisins--;

            // Retourne le nombre de voisins trouvés
            return resultatVoisins;
        }

        /// <summary>
        /// Permet d'ajouter une cellule morte ou vivante à la position voulue
        /// </summary>
        /// <param name="etat">Etat choisi pour la cellule</param>
        public void AjouterCellule(int ligne, int colonne, bool etat)
        {
            // Vérifie si la cellule est dans un état différent
            if (tabCellules[ligne, colonne] != etat)
            {
                // Ajoute une cellule morte ou vivante dans le tableau
                tabCellules[ligne, colonne] = etat;

                // Incrémente ou décrémente le compteur de cellules mortes ou vivantes 
                // selon l'état
                if (etat)
                {
                    qteCellVivantes++;
                    qteCellMortes--;
                }
                else
                {
                    qteCellVivantes--;
                    qteCellMortes++;
                }
            }
        }

        /// <summary>
        /// Permet de calculer les cellules vivantes et mortes
        /// </summary>
        public void CalculerCellulesVivantesMortes()
        {
            int cptCellulesVivantes = 0;        // Compteur de cellules vivantes
            int cptCellulesMortes = 0;          // Compteur de cellules mortes

            // Parcours tout le tableau de cellules
            for (int cptLignes = 0; cptLignes < qteLignes; cptLignes++)
            {
                for (int cptColonnes = 0; cptColonnes < qteColonnes; cptColonnes++)
                {
                    // Incrémente le compteur de cellules vivantes ou mortes
                    if (tabCellules[cptLignes, cptColonnes])
                        cptCellulesVivantes++;
                    else
                        cptCellulesMortes++;
                }
            }

            // Modifie les compteurs de cellules vivantes et mortes de la classe
            qteCellVivantes = cptCellulesVivantes;
            qteCellMortes = cptCellulesMortes;
        }

        /// <summary>
        /// Permet de calculer la nouvelle génération
        /// </summary>
        public void CalculerNouvelleGeneration()
        {
            bool[,] nouveauTabCellules = new bool[qteLignes, qteColonnes];  // Nouvelle génération de cellules
            int nbreVoisins = 0;                                            // Nombre de voisins d'une cellule

            // Initialise le nouveau tableau avec des cellules mortes
            for (int cptLignes = 0; cptLignes < qteLignes; cptLignes++)
            {
                for (int cptColonnes = 0; cptColonnes < qteColonnes; cptColonnes++)
                {
                    // Initialise une cellule morte
                    nouveauTabCellules[cptLignes, cptColonnes] = morte;
                }
            }

            // Met à jour le nombre de cellules mortes et vivantes
            qteCellVivantes = 0;
            qteCellMortes = qteLignes * qteColonnes;

            // Introduit les cellules dans le nouveau tableau
            for (int cptLignes = 0; cptLignes < qteLignes; cptLignes++)
            {
                for (int cptColonnes = 0; cptColonnes < qteColonnes; cptColonnes++)
                {
                    // Permet d'obtenir le nombre de voisins autour de la cellule
                    nbreVoisins = CalculerNombreVoisins(cptLignes, cptColonnes);

                    // Règle du jeu de la vie
                    // Cellule vivante + 2 ou 3 voisins --> vivant, sinon mort
                    if (tabCellules[cptLignes, cptColonnes] && (nbreVoisins == 2 || nbreVoisins == 3))
                    {
                        nouveauTabCellules[cptLignes, cptColonnes] = vivante;
                    }
                    else
                    {
                        nouveauTabCellules[cptLignes, cptColonnes] = morte;
                    }

                    // Règle du jeu de la vie
                    // Cellule vide + 3 voisins --> naissance
                    if (!tabCellules[cptLignes, cptColonnes] && nbreVoisins == 3)
                    {
                        nouveauTabCellules[cptLignes, cptColonnes] = vivante;
                    }

                    // Met à jour les compteurs de cellules mortes et vivantes
                    if (nouveauTabCellules[cptLignes, cptColonnes])
                    {
                        qteCellVivantes++;
                        qteCellMortes--;
                    }
                }
            }

            // Met à jour le tableau de cellules
            tabCellules = nouveauTabCellules;

            // Incrémente le nombre de générations
            qteGenerations++;
        }

        /// <summary>
        /// Permet d'obtenir la quantité de lignes
        /// </summary>
        public int QteLignes
        {
            get{return qteLignes;}
            set{qteLignes = value;}
        }

        /// <summary>
        /// Permet d'obtenir la quantité de colonnes
        /// </summary>
        public int QteColonnes
        {
            get{return qteColonnes;}
            set{qteColonnes = value;}
        }

        /// <summary>
        /// Permet d'obtenir ou de modifier le taux
        /// </summary>
        public int Taux
        {
            get{return taux;}
            set{taux = value;}
        }

        /// <summary>
        /// Permet d'obtenir la référence du tableau de cellules
        /// </summary>
        public bool[,] TabCellules
        {
            get{return tabCellules;}
        }

        /// <summary>
        /// Permet d'obtenir la quantité de cellules vivantes
        /// </summary>
        public int QteCellVivantes
        {
            get{return qteCellVivantes;}
        }

        /// <summary>
        /// Permet d'obtenir la quantité de cellules mortes
        /// </summary>
        public int QteCellMortes
        {
            get{return qteCellMortes;}
        }

        /// <summary>
        /// Permet d'obtenir la quantité de générations
        /// </summary>
        public int QteGenerations
        {
            get{return qteGenerations;}
        }

        /// <summary>
        /// Permet d'obtenir ou de modifier le mode de fonctionnement
        /// </summary>
        public ModeProg Mode
        {
            get{return mode;}
            set{mode = value;}
        }
    }
};

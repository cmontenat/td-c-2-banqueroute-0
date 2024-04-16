using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libBanque
{
    public class AgenceBancaire
    {
        // Propriétés privées
        // Liste (collection) des comptes bancaires
        // Une collection est un "tableau dynamique" d'objets
        // ici d'objets de type CompteBanquaire
        private List<CompteBancaire> lesComptes;

        /// <summary>
        /// Obtient la liste des comptes
        /// </summary>
        public List<CompteBancaire> LesComptes
        {
            get { return lesComptes; }
        }
        private string nomAgence;

        /// <summary>
        /// Obtient ou définit le nom de l'agence bancaire
        /// </summary>
        public string NomAgence
        {
            get { return nomAgence; }
            set { nomAgence = value; }
        }

        // Constructeur
        /// <summary>
        /// Initialise une nouvelle instance de la classe libBanque.AgenceBancaire
        /// </summary>
        /// <param name="sonNom">Le nom de l'agence</param>
        public AgenceBancaire(string sonNom)
        {
            // Création (instanciation) de la liste de compte
            // Elle sera vide pour commencer et lesComptes.Count renverra 0
            lesComptes = new List<CompteBancaire>();

            nomAgence = sonNom;
        }
        // Méthodes

        /// <summary>
        /// Obtient le nombre de comptes gérés par la Banque
        /// </summary>
        public int NombreComptes
        {
            get { return lesComptes.Count; }
            // Remarque : je me fous de la propriété privée, je préfère la garder en dynamique
        }

        /// <summary>
        /// Enregistre la création d'un nouveau compte
        /// </summary>
        /// <param name="unCompte">Le compte à ajouter</param>
        public void AjouterCompte(CompteBancaire unCompte)
        {
            lesComptes.Add(unCompte);
        }
        /// <summary>
        /// Enregistre la suppression d'un compte
        /// </summary>
        /// <param name="unCompte">Le compte à supprimer</param>
        public void SupprimerCompte(CompteBancaire unCompte)
        {
            lesComptes.Remove(unCompte);
        }
    }
}

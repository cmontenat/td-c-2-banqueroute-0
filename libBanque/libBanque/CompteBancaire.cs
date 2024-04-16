using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libBanque
{
    public class CompteBancaire
    {
        #region Propriétés privées de la classe

        // Propriétés privées
        private string numCompte;
        private string nomTitulaire;
        private Decimal soldeCompte;
        
        #endregion

        #region Property = Accesseurs (publiques) aux propriétés

        // Property = Accesseurs (publiques) aux propriétés
        public string NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }
        /// <summary>
        /// Obtient ou définit le nom du titulaire du compte
        /// </summary>
        public string NomTitulaire
        {
            get { return nomTitulaire; }
            set { nomTitulaire = value; }
        }
        /// <summary>
        /// Obtient le solde du compte banquaire
        /// </summary>
        public Decimal SoldeCompte
        {
            get { return soldeCompte; }
        }
        #endregion

        #region Constructeurs de la classe
        
        /// <summary>
        /// Initialise un compte à l'aide de son numéro et de son titulaire
        /// </summary>
        /// <param name="sonNumero"></param>
        /// <param name="sonTitulaire"></param>
        public CompteBancaire(string sonNumero, string sonTitulaire)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = 0.00m;
        }

        public CompteBancaire(string sonNumero, string sonTitulaire, Decimal sonSoldeInitial)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = sonSoldeInitial;
        }

        #endregion

        #region Méthodes de la classe

        /// <summary>
        /// Créditer le compte courant d'un certain montant
        /// </summary>
        /// <param name="montantDebit">Montant à créditer (doit être supérieur au solde)</param>
        /// <returns>Vrai si l'opération a pu s'effectuer</returns>
        public Boolean CrediterCompte(Decimal montantCredit)
        {
            bool credit_OK=false;
            if (montantCredit > 0)
            {
                soldeCompte += montantCredit;
                credit_OK = true;
            }
            return (credit_OK);
        }
        /// <summary>
        /// Debiter le compte courant d'un certain montant
        /// </summary>
        /// <param name="montantDebit">Montant à débiter (>0)</param>
        /// <returns>Vrai si l'opération a pu s'effectuer</returns>
        public Boolean DebiterCompte(Decimal montantDebit)
        {
            bool debit_OK = false;
            if (soldeCompte > montantDebit)
            {
                soldeCompte -= montantDebit;
                debit_OK = true;
            }
            return (debit_OK);              
        }
        #endregion
    }
}

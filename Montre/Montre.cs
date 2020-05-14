using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMontre
{
    /// ===================================================================================
    /// <summary>
    /// Repr�sente une montre indiquant l'heure dans le format: HH:MM:SS
    /// On peut faire avancer le temps d'une seconde � la fois.
    /// </summary>
    /// ===================================================================================
    public class Montre
    {
        #region CHAMPS ET PROPRI�T�S
        ///================================================================================
        private int m_heures;
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Obtient l'heure courante de la montre
        /// </summary>
        public int Heures
        {
            get //	acc�s en lecture
            {
                return m_heures;
            }
        }

        ///================================================================================
        private int m_minutes;
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Obtient les minutes courantes de la montre
        /// </summary>
        public int Minutes
        {
            get  //acc�s en lecture
            {
                return m_minutes;
            }
        }

        ///================================================================================
        private int m_secondes;
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Obtient les secondes courantes de la montre
        /// </summary>-
        public int Secondes
        {
            get //acc�s en lecture
            {
                return m_secondes;
            }
        }
        #endregion

        #region CONSTRUCTEURS (2 surcharges)
        ///===================================================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Montre.
        ///  Le temps au d�part est 00:00:00
        /// </summary>
        public Montre()
        {
            m_heures = 0;
            m_minutes = 0;
            m_secondes = 0;
        }

        ///===================================================================================
        /// <summary>
        /// Initialise une nouvelle instance de la classe Montre.
        /// Le temps au d�part est celui sp�cifi� par les param�tres.
        /// </summary>
        /// <param name="pHeures">heure courante</param>
        /// <param name="pMinutes">minute courante</param>
        /// <param name="pSecondes">seconde courante</param>
        public Montre(int pHeures, int pMinutes, int pSecondes)
        {
            m_heures = pHeures;
            m_minutes = pMinutes;
            m_secondes = pSecondes;
        }

        #endregion

        #region M�THODES
        /// <summary>
        /// Augmente le temps courant d'une seconde 
        /// </summary>
        public void AvancerUneSeconde()
        {
            m_secondes++;
            if (m_secondes > 59)
            {
                m_secondes = 0;                
                m_minutes++;    //  avancer d'une minute

                if (m_minutes > 59)
                {
                    m_minutes = 0;
                    m_heures++; //	avancer d'une heure

                    if (m_heures > 23)
                    {
                        m_heures = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Permet d'obtenir le temps courant de la montre
        /// </summary>
        /// <returns>Le temps courant de la montre dans une cha�ne format�e</returns>
        public string ObtenirTempsCourant()
        {
            return m_heures + ":" +
                   m_minutes.ToString("00") + ":" +
                   m_secondes.ToString("00");
        }

        #endregion
    }


}

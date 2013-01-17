using System;
using System.Runtime.Serialization;
namespace TripsService {
	/// <summary>
	/// Klasa s�u��ca do identyfikacji osoby zalogowanej
	/// </summary>
    public class AuthAdapter{
        /// <summary>
        /// Dane zalogowanego u�ytkownika
        /// </summary>
		private User identity = null;

        private static AuthAdapter Identity = new AuthAdapter();
		/// <summary>
		/// Defaultowy konstruktor
		/// </summary>
        private AuthAdapter() {
		}
        /// <summary>
        /// Zwracamy instancj� obiektu
        /// </summary>
        /// <returns>Obiekt authAdapter</returns>
		public static AuthAdapter GetInstance() {
            return AuthAdapter.Identity;
		}
        /// <summary>
        /// Pobranie zalogowanego u�ytkownika
        /// </summary>
        /// <returns></returns>
        public User getIdentity() {
            return this.identity;
        }
        /// <summary>
        /// Dodajemy dane do przechowywania sesji
        /// </summary>
        /// <param name="identity">Zalogowany user</param>
		public void WriteIdentity(User identity) {
            this.identity = identity;
		}
        /// <summary>
        /// Czy�cimy dane o u�ytkowniku
        /// </summary>
		public void ClearIdentity() {
            this.identity = null;
		}



    }

}

using System;
using System.Collections.Generic;
using System.IO;
namespace TripsService {
    /// <summary>
    /// Klasa do przeszukiwania bazy danych w plikach
    /// </summary>
    /// <typeparam name="T">Typ wyszukiwany</typeparam>
	public class FileAdapter<T> where T : class  {
        /// <summary>
        /// Wyszukane wyniki
        /// </summary>
		private IEnumerable<T> results;
        /// <summary>
        /// Pojedy�czy element
        /// </summary>
		private T singleResult;
        /// <summary>
        /// �cie�ka do bazy
        /// </summary>
		private String dataBaseLocation;
        /// <summary>
        /// Typ po��czenia przez providera
        /// </summary>
		public String connectionType;

        public void ForTrip(Trip t) {
            dataBaseLocation = System.IO.Directory.GetCurrentDirectory() + "\\AppFiles\\Resources\\Trip\\"+t.vid+"\\";
        }

        public void ForUser(User u) {
            dataBaseLocation = System.IO.Directory.GetCurrentDirectory() + "\\AppFiles\\User\\" + u.vid;
        }
        /// <summary>
        /// Zmiana parametr�w na stringi
        /// </summary>
        /// <param name="params_">Parametry do formalizacji</param>
        /// <returns>Tablica wynik�w w postaci �a�cuch�w</returns>
		public String[] FormatResultsToString(IEnumerable<T> params_) {
			throw new System.Exception("Not implemented");
		}
        /// <summary>
        /// Zwracamy wyniki zapytania
        /// </summary>
        /// <returns>Iterowalne wyniki</returns>
		public IEnumerable<T> GetResults() {
			return this.results;
		}
        /// <summary>
        /// Ustawiamy wyniki
        /// </summary>
        /// <param name="results">Iterowalne wyniki</param>
		public void SetResults(IEnumerable<T> results) {
			this.results = results;
		}
        /// <summary>
        /// Pobieramy pojedy�czy wynik, pierwszy lub jedyny z listy
        /// </summary>
        /// <returns></returns>
		public T GetSingleResult() {
			return this.singleResult;
		}
        /// <summary>
        /// Ustawiamy pojedy�czy wynik
        /// </summary>
        /// <param name="singleResult">Wynik do pobrania jako nastepny</param>
		public void SetSingleResult(T singleResult) {
			this.singleResult = singleResult;
		}
        /// <summary>
        /// Informacje o bazie danych
        /// </summary>
        /// <returns>String z lokacj� bazy</returns>
        ///[Obsolete("Nie potrzebne dzieki nHibernate",true)]
		public String GetDataBaseLocation() {
			return this.dataBaseLocation;
		}

        /// <summary>
        /// Ustanawiamy lokalizacj� bazy
        /// </summary>
        /// <param name="dataBaseLocation">�cie�ka do pliku</param>
		///[Obsolete("Nie wykorzystywana dzieki nHibernate",true)]
        public void SetDataBaseLocation(String dataBaseLocation) {
			this.dataBaseLocation = dataBaseLocation;
		}

        


	}

}

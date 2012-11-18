using System;
using System.Collections.Generic;
namespace TripsService {
    /// <summary>
    /// Klasa do przeszukiwania bazy danych w plikach
    /// </summary>
    /// <typeparam name="T">Typ wyszukiwany</typeparam>
	public class FileAdapter<T> : IQueryAdapter  {
        /// <summary>
        /// Wyszukane wyniki
        /// </summary>
		private IEnumerable<T> results;
        /// <summary>
        /// Pojedyñczy element
        /// </summary>
		private T singleResult;
        /// <summary>
        /// Œcie¿ka do bazy
        /// </summary>
		private String dataBaseLocation;
        /// <summary>
        /// Typ po³¹czenia przez providera
        /// </summary>
		public String connectionType;
        /// <summary>
        /// Zmiana parametrów na stringi
        /// </summary>
        /// <param name="params_">Parametry do formalizacji</param>
        /// <returns>Tablica wyników w postaci ³añcuchów</returns>
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
        /// Pobieramy pojedyñczy wynik, pierwszy lub jedyny z listy
        /// </summary>
        /// <returns></returns>
		public T GetSingleResult() {
			return this.singleResult;
		}
        /// <summary>
        /// Ustawiamy pojedyñczy wynik
        /// </summary>
        /// <param name="singleResult">Wynik do pobrania jako nastepny</param>
		public void SetSingleResult(T singleResult) {
			this.singleResult = singleResult;
		}
        /// <summary>
        /// Informacje o bazie danych
        /// </summary>
        /// <returns>String z lokacj¹ bazy</returns>
		public String GetDataBaseLocation() {
			return this.dataBaseLocation;
		}

        /// <summary>
        /// Ustanawiamy lokalizacjê bazy
        /// </summary>
        /// <param name="dataBaseLocation">Œcie¿ka do pliku</param>
		public void SetDataBaseLocation(String dataBaseLocation) {
			this.dataBaseLocation = dataBaseLocation;
		}

        /// <summary>
        /// Limit wyszukiwania
        /// </summary>
        /// <param name="count">Ograniczenie</param>
        /// <returns>Adapter zapytañ</returns>
		public IQueryAdapter Limit(int count) {
			throw new System.Exception("Not implemented");
		}
        /// <summary>
        /// Wyszukujemy pojedyñczy wynik
        /// </summary>
        /// <typeparam name="T">Wyszukiwany typ</typeparam>
        /// <param name="query">Zapytanie</param>
        /// <returns>Znaleziony obiekt</returns>
		public T FindOne<T>(IQuery query) {
			throw new System.Exception("Not implemented");
		}
        /// <summary>
        /// Dodajemy zapytanie do wyszukiwanego
        /// </summary>
        /// <param name="query">Zapytanie do dodania</param>
		public void AddQuery(IQuery query) {
			throw new System.Exception("Not implemented");
		}

        /// <summary>
        /// Wykonujemy wyszukiwanie i zwracamy wyniki
        /// </summary>
        /// <typeparam name="T">Typ wyszukiwanych danych</typeparam>
        /// <returns>Iterowalne wyniki</returns>
		public IEnumerable<T> ExecuteQuery<T>() {
			throw new System.Exception("Not implemented");
		}

		/// <returns>IEnumerableT</returns>
		public IEnumerable<T> ExecuteQuery<T>(IQuery query) {
			throw new System.Exception("Not implemented");
		}

	}

}

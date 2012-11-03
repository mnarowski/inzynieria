using System;
using System.Collections.Generic;
namespace TripsService {
	public class FileAdapter<T> : IQueryAdapter  {
		private IEnumerable<T> results;
		private T singleResult;
		private String dataBaseLocation;
		public String connectionType;

		public String[] FormatResultsToString(IEnumerable<T> params_) {
			throw new System.Exception("Not implemented");
		}
		public IEnumerable<T> GetResults() {
			return this.results;
		}
		public void SetResults(IEnumerable<T> results) {
			this.results = results;
		}
		public T GetSingleResult() {
			return this.singleResult;
		}
		public void SetSingleResult(T singleResult) {
			this.singleResult = singleResult;
		}
		public String GetDataBaseLocation() {
			return this.dataBaseLocation;
		}
		public void SetDataBaseLocation(String dataBaseLocation) {
			this.dataBaseLocation = dataBaseLocation;
		}
		public IQueryAdapter Limit(int count) {
			throw new System.Exception("Not implemented");
		}
		public T FindOne<T>(IQuery query) {
			throw new System.Exception("Not implemented");
		}
		public void AddQuery(IQuery query) {
			throw new System.Exception("Not implemented");
		}
		public IEnumerable<T> ExecuteQuery<T>() {
			throw new System.Exception("Not implemented");
		}
		/// <returns>IEnumerableT</returns>
		public IEnumerable<T> ExecuteQuery<T>(IQuery query) {
			throw new System.Exception("Not implemented");
		}

	}

}

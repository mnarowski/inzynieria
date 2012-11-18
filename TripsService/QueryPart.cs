using System;
namespace TripsService {
	public class QueryPart : IPart {
		private Object[] parts = new object[1024];
		private Object[] params_ = new object[1024];
        /// <summary>
        /// Budujemy czêœæ
        /// </summary>
        /// <returns>Czêœæ zapytania</returns>
		public IPart BuildPart() {
			throw new System.Exception("Not implemented");
		}
		public void AddQueryString(String query) {
           
		}
		public void AddQueryParam(object object_o) {
			throw new System.Exception("Not implemented");
		}
		public IQuery ToQuery() {
            return new Query(parts,params_);
		}

	}

}

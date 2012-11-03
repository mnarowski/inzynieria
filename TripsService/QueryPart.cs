using System;
namespace TripsService {
	public class QueryPart : IPart {
		private Object[] parts;
		private Object[] params_;

		public IPart BuildPart() {
			throw new System.Exception("Not implemented");
		}
		public void AddQueryString(String query) {
			throw new System.Exception("Not implemented");
		}
		public void AddQueryParam(object object_o) {
			throw new System.Exception("Not implemented");
		}
		public IQuery ToQuery() {
			throw new System.Exception("Not implemented");
		}

	}

}

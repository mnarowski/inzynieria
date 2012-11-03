using System;
namespace TripsService {
	public class Query : IQuery  {
		private IPart[] parts;
		private bool executed;

		public IPart[] GetQueryParts() {
			throw new System.Exception("Not implemented");
		}
		public string Assemble() {
			throw new System.Exception("Not implemented");
		}
		public bool Compare(IQuery query) {
			throw new System.Exception("Not implemented");
		}
		public void AddParam(object object_o) {
			throw new System.Exception("Not implemented");
		}
		public void AddQueryPart(IPart part) {
			throw new System.Exception("Not implemented");
		}
		public void RemoveQueryPart(IPart part) {
			throw new System.Exception("Not implemented");
		}

	}

}

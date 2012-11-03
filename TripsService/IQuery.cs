using System;
namespace TripsService {
	public interface IQuery {
		void AddQueryPart(IPart part);
		void RemoveQueryPart(IPart part);
		string Assemble();
		bool Compare(IQuery query);
		void AddParam(object object_o);

	}

}

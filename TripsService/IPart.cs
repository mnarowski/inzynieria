using System;
namespace TripsService {
	public interface IPart {
		IPart BuildPart();
		void AddQueryString(String query);
		void AddQueryParam(object object_o);
		IQuery ToQuery();
        bool Equals(object o);

	}

}

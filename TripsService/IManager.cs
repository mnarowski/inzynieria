using System;
namespace TripsService {
	public interface IManager {
		bool IsEnabled();
		IManager GetInstance();

	}

}

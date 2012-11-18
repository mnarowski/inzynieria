using System;
namespace TripsService {
    /// <summary>
    /// Interfejs dla wszelkich menagerów
    /// </summary>
	public interface IManager {
        /// <summary>
        /// Czy us³uga jest w³¹czona
        /// </summary>
        /// <returns></returns>
		bool IsEnabled();
        /// <summary>
        /// Pobieramyn instancjê
        /// </summary>
        /// <returns></returns>
		IManager GetInstance();

	}

}

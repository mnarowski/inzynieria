using System;
namespace TripsService {
    /// <summary>
    /// Interfejs dla wszelkich menager�w
    /// </summary>
	
    public interface IManager {
        /// <summary>
        /// Czy us�uga jest w��czona
        /// </summary>
        /// <returns></returns>
		bool IsEnabled();
        
	}

}

using System;
using System.Collections.Generic;
namespace TripsService {
	public interface IQueryAdapter {

		/// <returns>IEnumerableT</returns>
		IEnumerable<T> ExecuteQuery<T>(IQuery query);
		IEnumerable<T> ExecuteQuery<T>();
		void AddQuery(IQuery query);
		T FindOne<T>(IQuery query);
		IQueryAdapter Limit(int count);

	}

}

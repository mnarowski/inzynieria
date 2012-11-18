using System;
using System.Collections.Generic;
namespace TripsService {
	public class Query : IQuery  {
		private IPart[] parts = (Array.CreateInstance(typeof(IPart),0) as IPart[]);
		private bool executed;
        private List<object> _params = new List<object>();

        public Query(object parts,object params_){
        
        }
        /// <summary>
        /// Zwracamy listê elementów zapytania
        /// </summary>
        /// <returns>Tablica czêœci zapytania</returns>
		public IPart[] GetQueryParts() {
            return parts;
		}
        /// <summary>
        /// Sk³adamy zapytanie do postaci wykonywalenj
        /// </summary>
        /// <returns>³añcuch query do wykonania</returns>
		public string Assemble() {
			throw new System.Exception("Not implemented");
		}
        /// <summary>
        /// Sprawdzamy czy obiekty sa podobne
        /// </summary>
        /// <param name="query">Obiekt porównywany</param>
        /// <returns>Prawda jeœli podobne</returns>
		public bool Compare(IQuery query) {
            if (query is Query) {
                Query p = query as Query;
                if (p == null)
                    return false;

                if (p.GetQueryParts().Length == this.GetQueryParts().Length)
                    return true;
            }
            return false;
		}
		public void AddParam(object object_o) {
            _params.Add(object_o);
		}
		public void AddQueryPart(IPart part) {
            parts[parts.Length] = part;
		}
		public void RemoveQueryPart(IPart part) {
			for(int i=0,size=parts.Length;i<size;i++){
                if(parts[i].Equals(part)){
                    parts[i] = null;
                }
            }

            }
		
    }

}

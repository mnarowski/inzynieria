using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Privillage{
		private String resource;

        public Privillage(String resource) {
            this.resource = resource;
        }

		public String GetResource() {
			return this.resource;
		}

        public override bool Equals(object o) {
            char[] sep = new char[] { '.' };
            if (o is Privillage) {
               string[] selfres= this.GetResource().Split(sep);
               string[] otherres = (o as Privillage).GetResource().Split(sep);
               if (selfres[0].Equals(otherres[0]) && selfres.Length == 1)
                   return true;

               if (selfres[0].Equals(otherres[0])) {
                   if (selfres[1].Equals(otherres[1])) {
                       if (selfres[2].Equals(otherres[2])) {
                           return true;
                       }
                   }
               }
            }

            return false;
        }

    }

}

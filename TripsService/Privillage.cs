using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Privillage : ISerializable {
		private String resource;

        public Privillage(String resource) {
            this.resource = resource;
        }

		public String GetResource() {
			return this.resource;
		}

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

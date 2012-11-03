using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class AuthAdapter{
		private User identity;

		private AuthAdapter() {
			throw new System.Exception("Not implemented");
		}
		public void GetIdentity() {
			throw new System.Exception("Not implemented");
		}
		public AuthAdapter GetInstance() {
			throw new System.Exception("Not implemented");
		}
		public void WriteIdentity(User identity) {
			throw new System.Exception("Not implemented");
		}
		public void ClearIdentity() {
			throw new System.Exception("Not implemented");
		}

		private User[] user;


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

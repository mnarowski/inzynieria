using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class UserRole : ISerializable{
		private String name;
		private int idNumber;
		private Privillage[] privillages;

		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public int GetIdNumber() {
			return this.idNumber;
		}
		public void SetIdNumber(int idNumber) {
			this.idNumber = idNumber;
		}
		public Privillage[] GetPrivillages() {
			return this.privillages;
		}
		public void SetPrivillages(Privillage[] privillages) {
			this.privillages = privillages;
		}
		public bool HasAccess(object resource_Privillage) {
			throw new System.Exception("Not implemented");
		}



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

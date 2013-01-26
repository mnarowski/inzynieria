using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class UserRole{
		private String name;
		private int idNumber;

        public virtual int vid { set { idNumber = value; } get { return idNumber; } }
        public virtual String vname { set { name = value; } get { return name; } }


		public  virtual String GetName() {
			return this.name;
		}
		public virtual void SetName(String name) {
			this.name = name;
		}
		public virtual int GetIdNumber() {
			return this.idNumber;
		}
		public virtual void SetIdNumber(int idNumber) {
			this.idNumber = idNumber;
		}
		
		


    }

}

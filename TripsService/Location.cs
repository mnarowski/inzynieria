using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Location  : ISerializable{
		private String name;
		private String city;
		private float longitude;
		private float latitude;
		private String country;
		private String street;
		private float aMSL;

		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public String GetCity() {
			return this.city;
		}
		public void SetCity(String city) {
			this.city = city;
		}
		public float GetLongitude() {
			return this.longitude;
		}
		public void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
		public float GetLatitude() {
			return this.latitude;
		}
		public void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
		public String GetCountry() {
			return this.country;
		}
		public void SetCountry(String country) {
			this.country = country;
		}
		public String GetStreet() {
			return this.street;
		}
		public void SetStreet(String street) {
			this.street = street;
		}
		public float GetAMSL() {
			return this.aMSL;
		}
		public void SetAMSL(float aMSL) {
			this.aMSL = aMSL;
		}
		public Location(String name) {
			throw new System.Exception("Not implemented");
		}



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

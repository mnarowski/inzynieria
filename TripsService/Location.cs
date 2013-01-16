using System;
using System.Runtime.Serialization;
namespace TripsService {
    /// <summary>
    /// Przechowuje informacje o lokalizacji
    /// </summary>
	public class Location {
        /// <summary>
        /// Nazwa
        /// </summary>
		private String name;
        /// <summary>
        /// Miast
        /// </summary>
		private String city;
        /// <summary>
        /// D³ugoœæ geograficzna
        /// </summary>
		private float longitude;
        /// <summary>
        /// Szerokoœæ geograficzna
        /// </summary>
		private float latitude;
        /// <summary>
        /// Kraj
        /// </summary>
		private String country;
        /// <summary>
        /// Ulica
        /// </summary>
		private String street;
        /// <summary>
        /// Poziom ponad morzem
        /// </summary>
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



    }

}

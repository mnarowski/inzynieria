using System;
using System.Runtime.Serialization;
namespace TripsService {
    /// <summary>
    /// Przechowuje informacje o lokalizacji
    /// </summary>
	public  class Location {

        private int id;

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


        public virtual int vid { set { id = value; } get { return id; } }
        public virtual string vname { set { name = value; } get { return name; } }
        public virtual string vcity { set { city = value; } get { return city; } }
        public virtual float vlongitude { set { longitude = value; } get { return longitude; } }
        public virtual float vlatitude { set { latitude = value; } get { return latitude; } }
        public virtual string vcountry { set { country = value; } get { return country; } }
        public virtual string vstreet { set { street = value; } get { return street; } }
        public virtual float vamls { set { aMSL = value; } get { return aMSL; } }
		public virtual  String GetName() {
			return this.name;
		}
		public virtual  void SetName(String name) {
			this.name = name;
		}
		public virtual  String GetCity() {
			return this.city;
		}
		public virtual  void SetCity(String city) {
			this.city = city;
		}
		public virtual  float GetLongitude() {
			return this.longitude;
		}
		public virtual  void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
		public virtual  float GetLatitude() {
			return this.latitude;
		}
		public virtual  void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
		public virtual  String GetCountry() {
			return this.country;
		}
		public virtual  void SetCountry(String country) {
			this.country = country;
		}
		public virtual  String GetStreet() {
			return this.street;
		}
		public virtual  void SetStreet(String street) {
			this.street = street;
		}
		public virtual  float GetAMSL() {
			return this.aMSL;
		}
		public virtual  void SetAMSL(float aMSL) {
			this.aMSL = aMSL;
		}
		public  Location(String name) {
            this.name = name;
        }

        public Location() { }




    }

}

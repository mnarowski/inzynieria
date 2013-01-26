using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Attraction{
        private int id;
        /// <summary>
        /// Szerokoœæ geograficzna
        /// </summary>
		private float latitude;
        /// <summary>
        /// D³ugoœæ geograficzna
        /// </summary>
		private float longitude;
        /// <summary>
        /// Nazwa atrakcji
        /// </summary>
		private String name;
        /// <summary>
        /// Typ atrakcji
        /// </summary>
		private AttractionType type;

        public virtual int vid { get { return id; } set { id = value; } }
        public virtual AttractionType vtype { set { type = value; } get { return type; } }
        public virtual string vname { set { name = value; } get { return name; } }
        public virtual float vlongitude { set { longitude = value; } get { return longitude; } }
        public virtual float vlatitude { set { latitude = value; } get { return latitude; } }
        /// <summary>
        /// Pobieramy szerokoœæ
        /// </summary>
        /// <returns>Liczba definiujaca szerokoœæ</returns>
		public virtual float GetLatitude() {
			return this.latitude;
		}
        /// <summary>
        /// Ustawiamy szerokoœæ geograficzna
        /// </summary>
        /// <param name="latitude">Szerokoœæ geograficzna</param>
		public virtual void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
        /// <summary>
        /// Pobieramy d³ugoœæ geograficzna
        /// </summary>
        /// <returns>Liczba definuj¹ca d³ugoœæ geograficzna</returns>
		public virtual float GetLongitude() {
			return this.longitude;
		}
        /// <summary>
        /// Ustawiamy d³ugoœæ geograficzna
        /// </summary>
        /// <param name="latitude">d³ugoœæ geograficzna</param>
        public virtual void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
        /// <summary>
        /// Pobieramy nazwê atrakcji
        /// </summary>
        /// <returns>nazwa</returns>
		public virtual String GetName() {
			return this.name;
		}
        /// <summary>
        /// Nadajemy nazwê atrkacji
        /// </summary>
        /// <param name="name">Nowa nazwa</param>
		public virtual void SetName(String name) {
			this.name = name;
		}
        /// <summary>
        /// Pobieramy typ atrakcji
        /// </summary>
        /// <returns>Typ atrakcji</returns>
		public virtual new AttractionType GetType() {
			return this.type;
		}
        /// <summary>
        /// Typ atrakcji w wycieczce
        /// </summary>
        /// <param name="type">Typ wycieczki</param>
		public virtual void SetType(AttractionType type) {
			this.type = type;
		}


    }

}

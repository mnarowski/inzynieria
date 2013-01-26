using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Attraction{
        private int id;
        /// <summary>
        /// Szeroko�� geograficzna
        /// </summary>
		private float latitude;
        /// <summary>
        /// D�ugo�� geograficzna
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
        /// Pobieramy szeroko��
        /// </summary>
        /// <returns>Liczba definiujaca szeroko��</returns>
		public virtual float GetLatitude() {
			return this.latitude;
		}
        /// <summary>
        /// Ustawiamy szeroko�� geograficzna
        /// </summary>
        /// <param name="latitude">Szeroko�� geograficzna</param>
		public virtual void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
        /// <summary>
        /// Pobieramy d�ugo�� geograficzna
        /// </summary>
        /// <returns>Liczba definuj�ca d�ugo�� geograficzna</returns>
		public virtual float GetLongitude() {
			return this.longitude;
		}
        /// <summary>
        /// Ustawiamy d�ugo�� geograficzna
        /// </summary>
        /// <param name="latitude">d�ugo�� geograficzna</param>
        public virtual void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
        /// <summary>
        /// Pobieramy nazw� atrakcji
        /// </summary>
        /// <returns>nazwa</returns>
		public virtual String GetName() {
			return this.name;
		}
        /// <summary>
        /// Nadajemy nazw� atrkacji
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

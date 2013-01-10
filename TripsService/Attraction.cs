using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Attraction  : ISerializable{
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
        /// <summary>
        /// Pobieramy szerokoœæ
        /// </summary>
        /// <returns>Liczba definiujaca szerokoœæ</returns>
		public float GetLatitude() {
			return this.latitude;
		}
        /// <summary>
        /// Ustawiamy szerokoœæ geograficzna
        /// </summary>
        /// <param name="latitude">Szerokoœæ geograficzna</param>
		public void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
        /// <summary>
        /// Pobieramy d³ugoœæ geograficzna
        /// </summary>
        /// <returns>Liczba definuj¹ca d³ugoœæ geograficzna</returns>
		public float GetLongitude() {
			return this.longitude;
		}
        /// <summary>
        /// Ustawiamy d³ugoœæ geograficzna
        /// </summary>
        /// <param name="latitude">d³ugoœæ geograficzna</param>
        public void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
        /// <summary>
        /// Pobieramy nazwê atrakcji
        /// </summary>
        /// <returns>nazwa</returns>
		public String GetName() {
			return this.name;
		}
        /// <summary>
        /// Nadajemy nazwê atrkacji
        /// </summary>
        /// <param name="name">Nowa nazwa</param>
		public void SetName(String name) {
			this.name = name;
		}
        /// <summary>
        /// Pobieramy typ atrakcji
        /// </summary>
        /// <returns>Typ atrakcji</returns>
		public new AttractionType GetType() {
			return this.type;
		}
        /// <summary>
        /// Typ atrakcji w wycieczce
        /// </summary>
        /// <param name="type">Typ wycieczki</param>
		public void SetType(AttractionType type) {
			this.type = type;
		}

		private AttractionType attractionType;


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

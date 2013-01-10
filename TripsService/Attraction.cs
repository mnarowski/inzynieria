using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Attraction  : ISerializable{
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
        /// <summary>
        /// Pobieramy szeroko��
        /// </summary>
        /// <returns>Liczba definiujaca szeroko��</returns>
		public float GetLatitude() {
			return this.latitude;
		}
        /// <summary>
        /// Ustawiamy szeroko�� geograficzna
        /// </summary>
        /// <param name="latitude">Szeroko�� geograficzna</param>
		public void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
        /// <summary>
        /// Pobieramy d�ugo�� geograficzna
        /// </summary>
        /// <returns>Liczba definuj�ca d�ugo�� geograficzna</returns>
		public float GetLongitude() {
			return this.longitude;
		}
        /// <summary>
        /// Ustawiamy d�ugo�� geograficzna
        /// </summary>
        /// <param name="latitude">d�ugo�� geograficzna</param>
        public void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
        /// <summary>
        /// Pobieramy nazw� atrakcji
        /// </summary>
        /// <returns>nazwa</returns>
		public String GetName() {
			return this.name;
		}
        /// <summary>
        /// Nadajemy nazw� atrkacji
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

using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Attraction  : ISerializable{
		private float latitude;
		private float longitude;
		private String name;
		private AttractionType type;

		public float GetLatitude() {
			return this.latitude;
		}
		public void SetLatitude(float latitude) {
			this.latitude = latitude;
		}
		public float GetLongitude() {
			return this.longitude;
		}
		public void SetLongitude(float longitude) {
			this.longitude = longitude;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public AttractionType GetType() {
			return this.type;
		}
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

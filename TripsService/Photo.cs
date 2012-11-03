using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Photo : ISerializable{
		private String name;
		private String fileLocation;
		private DateTime dateCreated;
		private String description;

		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public void SetDescription(String descripton) {
			this.description = descripton;
		}
		public String GetDescription() {
			return this.description;
		}
		public bool ChangeDestinationPath(FileManager fileManager, String path) {
			throw new System.Exception("Not implemented");
		}



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

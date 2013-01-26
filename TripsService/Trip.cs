using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Trip {
        private int id;
		private int localisation;
		private String name;
		private int organizer;
		private float length;
		private string transport;
		private int atraction;
		private int usersNumber;
		private double price;
		private String description;


        public virtual int vid {get{return id;} set{id = value;}}
        public virtual String vname { set{name = value;}
            get{return name;}}
        public virtual int vorganizer { set { organizer = value; } get { return organizer; } }
        public virtual float vlength { set { length = value; } get { return length; } }
        public virtual int vUsersNumber { set { usersNumber = value; } get { return usersNumber; } }
        public virtual double vprice { set { price = value; } get { return price; } }
        public virtual String vdescription { set { description = value; } get { return description; } }
        public virtual string vtransport { set { transport = value; } get { return transport; } }
        public virtual int vattraction { set { atraction = value; } get {return atraction; } }
        public virtual int vlocation { set { localisation = value; } get { return localisation; } }
        public virtual Location GetLocalisation() {
            return TripsService.AppFiles.Database.DbService.Find<Location>(localisation);
		}
		public virtual void SetLocalisation(Location localisation) {
			this.localisation = localisation.vid;
		}
		public virtual String GetName() {
			return this.name;
		}
		public virtual void SetName(String name) {
			this.name = name;
		}
		public virtual User GetOrganizer() {
            return TripsService.AppFiles.Database.DbService.Find<User>(organizer);
		}
		public virtual void SetOrganizer(User organizer) {
			this.organizer = organizer.vid;
		}
		public virtual float GetLength() {
			return this.length;
		}
		public virtual void SetLength(float length) {
			this.length = length;
		}
		public virtual string GetTransport() {
			return this.transport;
		}
		public virtual void SetTransport(string transport) {
			this.transport = transport;
		}
		public virtual Attraction GetAtractions() {
            return TripsService.AppFiles.Database.DbService.Find<Attraction>(this.atraction);
		}
		public virtual void SetAtractions(Attraction atractions) {
			this.atraction = atractions.vid;
		}
		public virtual int GetUsersNumber() {
			return this.usersNumber;
		}
		public virtual void SetUsersNumber(int usersNumber) {
			this.usersNumber = usersNumber;
		}
		public virtual double GetPrice() {
			return this.price;
		}
		public virtual void SetPrice(double price) {
			this.price = price;
		}
		public Trip() {
		}
		public virtual String GetDescription() {
			return this.description;
		}
		public virtual void SetDescription(String description) {
			this.description = description;
		}

    }

}

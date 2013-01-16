using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Trip {
        private int id;
		private Location localisation;
		private String name;
		private User organizer;
		private float length;
		private string[] transport;
		private Attraction[] atractions;
		private int usersNumber;
		private double price;
		private String description;


        public virtual int vid {get{return id;} set{id = value;}}
        public virtual String vname { set{name = value;}
            get{return name;}}
        public virtual User vorganizer { set { organizer = value; } get { return organizer; } }
        public virtual float vlength { set { length = value; } get { return length; } }
        public virtual int vUsersNumber { set { usersNumber = value; } get { return usersNumber; } }
        public virtual double vprice { set { price = value; } get { return price; } }
        public virtual String vdescription { set { description = value; } get { return description; } }

		public Location GetLocalisation() {
			return this.localisation;
		}
		public void SetLocalisation(Location localisation) {
			this.localisation = localisation;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public User GetOrganizer() {
			return this.organizer;
		}
		public void SetOrganizer(User organizer) {
			this.organizer = organizer;
		}
		public float GetLength() {
			return this.length;
		}
		public void SetLength(float length) {
			this.length = length;
		}
		public string[] GetTransport() {
			return this.transport;
		}
		public void SetTransport(string[] transport) {
			this.transport = transport;
		}
		public Attraction[] GetAtractions() {
			return this.atractions;
		}
		public void SetAtractions(Attraction[] atractions) {
			this.atractions = atractions;
		}
		public int GetUsersNumber() {
			return this.usersNumber;
		}
		public void SetUsersNumber(int usersNumber) {
			this.usersNumber = usersNumber;
		}
		public double GetPrice() {
			return this.price;
		}
		public void SetPrice(double price) {
			this.price = price;
		}
		public Trip() {
			throw new System.Exception("Not implemented");
		}
		public String GetDescription() {
			return this.description;
		}
		public void SetDescription(String description) {
			this.description = description;
		}

		private User user;

		private Location[] locations;
		private Attraction[] attractions;

    }

}

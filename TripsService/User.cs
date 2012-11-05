using System;
using System.Runtime.Serialization;
using PhotoGalleryLibrary;

namespace TripsService {
	public class User : ISerializable{
		private String name;
		private String sureName;
		private DateTime dateOfBirth;
		private UserRole role;
		private SexEnum sex;

		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public String GetSureName() {
			return this.sureName;
		}
		public void SetSureName(String sureName) {
			this.sureName = sureName;
		}
		public DateTime GetDateOfBirth() {
			return this.dateOfBirth;
		}
		public void SetDateOfBirth(DateTime dateOfBirt) {
			this.dateOfBirth = dateOfBirt;
		}
		public UserRole GetRole() {
			return this.role;
		}
		public void SetRole(UserRole role) {
			this.role = role;
		}
		public bool IsAdult() {
			throw new System.Exception("Not implemented");
		}
		public int GetAge() {
			throw new System.Exception("Not implemented");
		}
		public SexEnum GetSex() {
			return this.sex;
		}
		public void SetSex(SexEnum sex) {
			this.sex = sex;
		}

		private Album[] albums;
		private UserRole userRole;
		private SexEnum sexEnum;

		private Trip[] trips;


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}

using System;
using System.Runtime.Serialization;
using PhotoGalleryLibrary;

namespace TripsService {
	public class User{
        private int id;
		private String name;
		private String sureName;
		private DateTime dateOfBirth;
		private UserRole role;
		private SexEnum sex;
        private String login;
        private String password;

        public virtual int vid { set { id = value; } get { return id; } }
        public virtual String vname { set { name = value; } get { return name; } }
        public virtual String vSureName { set { sureName = value; } get { return sureName; } }
        public virtual DateTime vDateOfBirth { set { dateOfBirth = value; } get { return dateOfBirth; } }
        public virtual UserRole vRole { set { role = value; } get { return role; } }
        public virtual SexEnum vsex { set { sex = value; } get { return sex; } }
        public virtual String vlogin { set { login = value; } get { return login; } }
        public virtual String vpassword { set { password = value; } get { return password; } }

		public virtual String GetName() {
			return this.name;
		}
		public virtual void SetName(String name) {
			this.name = name;
		}
		public virtual String GetSureName() {
			return this.sureName;
		}
		public virtual void SetSureName(String sureName) {
			this.sureName = sureName;
		}
		public virtual DateTime GetDateOfBirth() {
			return this.dateOfBirth;
		}
		public virtual void SetDateOfBirth(DateTime dateOfBirt) {
			this.dateOfBirth = dateOfBirt;
		}
		public virtual UserRole GetRole() {
			return this.role;
		}
		public virtual void SetRole(UserRole role) {
			this.role = role;
		}
		public virtual bool IsAdult() {
			throw new System.Exception("Not implemented");
		}
		public virtual int GetAge() {
			throw new System.Exception("Not implemented");
		}
		public virtual SexEnum GetSex() {
			return this.sex;
		}
		public virtual void SetSex(SexEnum sex) {
			this.sex = sex;
		}

    }

}

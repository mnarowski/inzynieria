ALTER TABLE "user" DROP COLUMN userrole;

ALTER TABLE "user" ADD COLUMN userrole integer;

ALTER TABLE "user"
  ADD CONSTRAINT user_userrole_fkey FOREIGN KEY (userrole)
      REFERENCES userrole (id_userrole) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE CASCADE;

	  
DROP TABLE user_userrole;
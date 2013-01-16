- DROP TABLE user_userrole;

CREATE TABLE user_userrole
(
  id_user integer,
  id_userrole integer,
  CONSTRAINT user_fk FOREIGN KEY (id_user)
      REFERENCES "user" (id_user) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE CASCADE,
  CONSTRAINT userrole_fk FOREIGN KEY (id_userrole)
      REFERENCES userrole (id_userrole) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE user_userrole
  OWNER TO inzynieria;

-- Index: fki_userrole_fk

-- DROP INDEX fki_userrole_fk;

CREATE INDEX fki_userrole_fk
  ON user_userrole
  USING btree
  (id_userrole);

-- Index: user_userrole_index

-- DROP INDEX user_userrole_index;

CREATE UNIQUE INDEX user_userrole_index
  ON user_userrole
  USING btree
  (id_user, id_userrole);


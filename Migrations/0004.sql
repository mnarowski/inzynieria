-- Table: "User"
-- Pawe³ za enuma nie widocznego nigdzie karniak!!
DROP TABLE "User";


CREATE TABLE "User"
(
  "ID_USER" serial NOT NULL,
  "Name" character varying(64) NOT NULL,
  "SureName" character varying(64) NOT NULL,
  "DateOfBirth" date NOT NULL,
  "UserRole" character varying(64),
  login character varying(255),
  password character varying(32),
  "Sex" integer,
  CONSTRAINT "PK_ID_USER" PRIMARY KEY ("ID_USER")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "User"
  OWNER TO postgres;

-- Index: user_login_uniqx

-- DROP INDEX user_login_uniqx;

CREATE UNIQUE INDEX user_login_uniqx
  ON "User"
  USING btree
  (login COLLATE pg_catalog."default");


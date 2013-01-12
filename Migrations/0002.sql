ALTER TABLE "User" ADD COLUMN login character varying(255);
ALTER TABLE "User" ADD COLUMN password character varying(32);

CREATE UNIQUE INDEX user_login_uniqx
  ON "User"
  USING btree
  (login COLLATE pg_catalog."default");

CREATE TABLE album
(
  id_album bigserial NOT NULL,
  name text,
  CONSTRAINT album_pkey PRIMARY KEY (id_album)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE album
  OWNER TO postgres;

-- Database: inzynieria

-- DROP DATABASE inzynieria;

CREATE DATABASE inzynieria
  WITH OWNER = postgres
       ENCODING = 'UTF8'
       TABLESPACE = pg_default
       LC_COLLATE = 'en_US.UTF-8'
       LC_CTYPE = 'en_US.UTF-8'
       CONNECTION LIMIT = -1;
GRANT CONNECT, TEMPORARY ON DATABASE inzynieria TO public;
GRANT ALL ON DATABASE inzynieria TO postgres;
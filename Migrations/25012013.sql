--
-- PostgreSQL database dump
--

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'pl/pgsql procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: album; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE album (
    id_album bigint NOT NULL,
    name text
);


ALTER TABLE public.album OWNER TO postgres;

--
-- Name: album_id_album_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE album_id_album_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.album_id_album_seq OWNER TO postgres;

--
-- Name: album_id_album_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE album_id_album_seq OWNED BY album.id_album;


--
-- Name: attraction; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE attraction (
    id_attraction integer NOT NULL,
    latitude real NOT NULL,
    longitude real NOT NULL,
    name character varying(64) NOT NULL,
    attractiontype integer NOT NULL
);


ALTER TABLE public.attraction OWNER TO postgres;

--
-- Name: attraction_id_attraction_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE attraction_id_attraction_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.attraction_id_attraction_seq OWNER TO postgres;

--
-- Name: attraction_id_attraction_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE attraction_id_attraction_seq OWNED BY attraction.id_attraction;


--
-- Name: location; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE location (
    id_location integer NOT NULL,
    name character varying(64) NOT NULL,
    city character varying(64),
    latitude real,
    longitude real,
    country character varying(64),
    street character varying(255),
    amsl real DEFAULT 0.0 NOT NULL
);


ALTER TABLE public.location OWNER TO postgres;

--
-- Name: location_id_location_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE location_id_location_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.location_id_location_seq OWNER TO postgres;

--
-- Name: location_id_location_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE location_id_location_seq OWNED BY location.id_location;


--
-- Name: photo; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE photo (
    id_photo integer NOT NULL,
    name character varying(64) NOT NULL,
    filelocation text NOT NULL,
    datecreated date NOT NULL,
    description character varying(255)
);


ALTER TABLE public.photo OWNER TO postgres;

--
-- Name: photos_id_photo_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE photos_id_photo_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.photos_id_photo_seq OWNER TO postgres;

--
-- Name: photos_id_photo_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE photos_id_photo_seq OWNED BY photo.id_photo;


--
-- Name: privillage; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE privillage (
    id_res integer NOT NULL,
    resource character varying(255) NOT NULL,
    id_userrole integer
);


ALTER TABLE public.privillage OWNER TO postgres;

--
-- Name: privillage_id_res_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE privillage_id_res_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.privillage_id_res_seq OWNER TO postgres;

--
-- Name: privillage_id_res_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE privillage_id_res_seq OWNED BY privillage.id_res;


--
-- Name: trip; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE trip (
    id_trip bigint NOT NULL,
    localisation integer NOT NULL,
    name character varying(64) NOT NULL,
    organiser integer NOT NULL,
    length real,
    usersnumber integer,
    price double precision,
    description text,
    transport text,
    attraction integer
);


ALTER TABLE public.trip OWNER TO postgres;

--
-- Name: trip_id_trip_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE trip_id_trip_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.trip_id_trip_seq OWNER TO postgres;

--
-- Name: trip_id_trip_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE trip_id_trip_seq OWNED BY trip.id_trip;


--
-- Name: user; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "user" (
    id_user regclass NOT NULL,
    name character varying(64) NOT NULL,
    surename character varying(64) NOT NULL,
    dateofbirth date NOT NULL,
    login character varying(255),
    password character varying(32),
    sex integer,
    userrole integer
);


ALTER TABLE public."user" OWNER TO postgres;

--
-- Name: user_id_user_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE user_id_user_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.user_id_user_seq OWNER TO postgres;

--
-- Name: user_id_user_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE user_id_user_seq OWNED BY "user".id_user;


--
-- Name: userrole; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE userrole (
    name character varying(255) NOT NULL,
    id_userrole integer NOT NULL
);


ALTER TABLE public.userrole OWNER TO postgres;

--
-- Name: userrole_id_userrole_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE userrole_id_userrole_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.userrole_id_userrole_seq OWNER TO postgres;

--
-- Name: userrole_id_userrole_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE userrole_id_userrole_seq OWNED BY userrole.id_userrole;


--
-- Name: id_album; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY album ALTER COLUMN id_album SET DEFAULT nextval('album_id_album_seq'::regclass);


--
-- Name: id_attraction; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY attraction ALTER COLUMN id_attraction SET DEFAULT nextval('attraction_id_attraction_seq'::regclass);


--
-- Name: id_location; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY location ALTER COLUMN id_location SET DEFAULT nextval('location_id_location_seq'::regclass);


--
-- Name: id_photo; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY photo ALTER COLUMN id_photo SET DEFAULT nextval('photos_id_photo_seq'::regclass);


--
-- Name: id_res; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY privillage ALTER COLUMN id_res SET DEFAULT nextval('privillage_id_res_seq'::regclass);


--
-- Name: id_trip; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trip ALTER COLUMN id_trip SET DEFAULT nextval('trip_id_trip_seq'::regclass);


--
-- Name: id_user; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "user" ALTER COLUMN id_user SET DEFAULT nextval('user_id_user_seq'::regclass);


--
-- Name: id_userrole; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY userrole ALTER COLUMN id_userrole SET DEFAULT nextval('userrole_id_userrole_seq'::regclass);


--
-- Data for Name: album; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY album (id_album, name) FROM stdin;
\.


--
-- Name: album_id_album_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('album_id_album_seq', 1, false);


--
-- Data for Name: attraction; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY attraction (id_attraction, latitude, longitude, name, attractiontype) FROM stdin;
\.


--
-- Name: attraction_id_attraction_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('attraction_id_attraction_seq', 1, false);


--
-- Data for Name: location; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY location (id_location, name, city, latitude, longitude, country, street, amsl) FROM stdin;
\.


--
-- Name: location_id_location_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('location_id_location_seq', 1, false);


--
-- Data for Name: photo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY photo (id_photo, name, filelocation, datecreated, description) FROM stdin;
\.


--
-- Name: photos_id_photo_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('photos_id_photo_seq', 1, false);


--
-- Data for Name: privillage; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY privillage (id_res, resource, id_userrole) FROM stdin;
1	Root	1
2	Root.add	1
3	User	2
4	User.join	2
\.


--
-- Name: privillage_id_res_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('privillage_id_res_seq', 4, true);


--
-- Data for Name: trip; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY trip (id_trip, localisation, name, organiser, length, usersnumber, price, description, transport, attraction) FROM stdin;
\.


--
-- Name: trip_id_trip_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('trip_id_trip_seq', 1, false);


--
-- Data for Name: user; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "user" (id_user, name, surename, dateofbirth, login, password, sex, userrole) FROM stdin;
12	system		2012-01-01	root	63a9f0ea7bb98050796b649e85481845	1	\N
\.


--
-- Name: user_id_user_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('user_id_user_seq', 12, true);


--
-- Data for Name: userrole; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY userrole (name, id_userrole) FROM stdin;
Admin	1
User	2
\.


--
-- Name: userrole_id_userrole_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('userrole_id_userrole_seq', 2, true);


--
-- Name: album_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY album
    ADD CONSTRAINT album_pkey PRIMARY KEY (id_album);


--
-- Name: pk_id_attraction; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY attraction
    ADD CONSTRAINT pk_id_attraction PRIMARY KEY (id_attraction);


--
-- Name: pk_id_location; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY location
    ADD CONSTRAINT pk_id_location PRIMARY KEY (id_location);


--
-- Name: pk_id_photo; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY photo
    ADD CONSTRAINT pk_id_photo PRIMARY KEY (id_photo);


--
-- Name: pk_id_res; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY privillage
    ADD CONSTRAINT pk_id_res PRIMARY KEY (id_res);


--
-- Name: pk_id_trip; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY trip
    ADD CONSTRAINT pk_id_trip PRIMARY KEY (id_trip);


--
-- Name: pk_id_user; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "user"
    ADD CONSTRAINT pk_id_user PRIMARY KEY (id_user);


--
-- Name: pk_id_userrole; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY userrole
    ADD CONSTRAINT pk_id_userrole PRIMARY KEY (id_userrole);


--
-- Name: fki_attraction_id_attraction_fkx; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE INDEX fki_attraction_id_attraction_fkx ON trip USING btree (attraction);


--
-- Name: fki_user_id_user_fkx; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE INDEX fki_user_id_user_fkx ON trip USING btree (organiser);


--
-- Name: fki_userrole_idx; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE INDEX fki_userrole_idx ON privillage USING btree (id_userrole);


--
-- Name: user_login_uniqx; Type: INDEX; Schema: public; Owner: postgres; Tablespace: 
--

CREATE UNIQUE INDEX user_login_uniqx ON "user" USING btree (login);


--
-- Name: attraction_id_attraction_fkx; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trip
    ADD CONSTRAINT attraction_id_attraction_fkx FOREIGN KEY (attraction) REFERENCES attraction(id_attraction);


--
-- Name: fk_localisation_location; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trip
    ADD CONSTRAINT fk_localisation_location FOREIGN KEY (localisation) REFERENCES location(id_location);


--
-- Name: fk_organiser_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trip
    ADD CONSTRAINT fk_organiser_user FOREIGN KEY (organiser) REFERENCES "user"(id_user);


--
-- Name: fk_userrole_idx; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY privillage
    ADD CONSTRAINT fk_userrole_idx FOREIGN KEY (id_userrole) REFERENCES userrole(id_userrole) ON DELETE CASCADE;


--
-- Name: user_id_user_fkx; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trip
    ADD CONSTRAINT user_id_user_fkx FOREIGN KEY (organiser) REFERENCES "user"(id_user) ON DELETE CASCADE;


--
-- Name: user_userrole_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "user"
    ADD CONSTRAINT user_userrole_fkey FOREIGN KEY (userrole) REFERENCES userrole(id_userrole) ON DELETE CASCADE;


--
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


--
-- PostgreSQL database dump complete
--


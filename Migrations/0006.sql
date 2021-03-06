﻿--
-- postgresql database dump
--

-- dumped from database version 9.2.2
-- dumped by pg_dump version 9.2.2
-- started on 2013-01-14 21:31:27

set statement_timeout = 0;
set client_encoding = 'utf8';
set standard_conforming_strings = on;
set check_function_bodies = false;
set client_min_messages = warning;

--
-- toc entry 184 (class 3079 oid 11727)
-- name: plpgsql; type: extension; schema: -; owner: 
--

create extension if not exists plpgsql with schema pg_catalog;


--
-- toc entry 2013 (class 0 oid 0)
-- dependencies: 184
-- name: extension plpgsql; type: comment; schema: -; owner: 
--

comment on extension plpgsql is 'pl/pgsql procedural language';


set search_path = public, pg_catalog;

set default_tablespace = '';

set default_with_oids = false;

--
-- toc entry 168 (class 1259 oid 16399)
-- name: attraction; type: table; schema: public; owner: postgres; tablespace: 
--

create table "attraction" (
    "id_attraction" integer not null,
    "latitude" real not null,
    "longitude" real not null,
    "name" character varying(64) not null,
    "attractiontype" integer not null
);


alter table public."attraction" owner to postgres;

--
-- toc entry 169 (class 1259 oid 16402)
-- name: attractiontype; type: table; schema: public; owner: postgres; tablespace: 
--

create table "attractiontype" (
    "id_att_type" integer not null,
    "attractiontype" character varying(64) not null
);


alter table public."attractiontype" owner to postgres;

--
-- toc entry 170 (class 1259 oid 16405)
-- name: attractiontype_id_att_type_seq; type: sequence; schema: public; owner: postgres
--

create sequence "attractiontype_id_att_type_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."attractiontype_id_att_type_seq" owner to postgres;

--
-- toc entry 2014 (class 0 oid 0)
-- dependencies: 170
-- name: attractiontype_id_att_type_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "attractiontype_id_att_type_seq" owned by "attractiontype"."id_att_type";


--
-- toc entry 171 (class 1259 oid 16407)
-- name: attraction_id_attraction_seq; type: sequence; schema: public; owner: postgres
--

create sequence "attraction_id_attraction_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."attraction_id_attraction_seq" owner to postgres;

--
-- toc entry 2015 (class 0 oid 0)
-- dependencies: 171
-- name: attraction_id_attraction_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "attraction_id_attraction_seq" owned by "attraction"."id_attraction";


--
-- toc entry 172 (class 1259 oid 16409)
-- name: location; type: table; schema: public; owner: postgres; tablespace: 
--

create table "location" (
    "id_location" integer not null,
    "name" character varying(64) not null,
    "city" character varying(64),
    "latitude" real,
    "longitude" real,
    "country" character varying(64),
    "street" character varying(255),
    "amsl" real default 0.0 not null
);


alter table public."location" owner to postgres;

--
-- toc entry 173 (class 1259 oid 16413)
-- name: location_id_location_seq; type: sequence; schema: public; owner: postgres
--

create sequence "location_id_location_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."location_id_location_seq" owner to postgres;

--
-- toc entry 2016 (class 0 oid 0)
-- dependencies: 173
-- name: location_id_location_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "location_id_location_seq" owned by "location"."id_location";


--
-- toc entry 174 (class 1259 oid 16415)
-- name: photo; type: table; schema: public; owner: postgres; tablespace: 
--

create table "photo" (
    "id_photo" integer not null,
    "name" character varying(64) not null,
    "filelocation" text not null,
    "datecreated" date not null,
    "description" character varying(255)
);


alter table public."photo" owner to postgres;

--
-- toc entry 175 (class 1259 oid 16421)
-- name: photos_id_photo_seq; type: sequence; schema: public; owner: postgres
--

create sequence "photos_id_photo_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."photos_id_photo_seq" owner to postgres;

--
-- toc entry 2017 (class 0 oid 0)
-- dependencies: 175
-- name: photos_id_photo_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "photos_id_photo_seq" owned by "photo"."id_photo";


--
-- toc entry 176 (class 1259 oid 16423)
-- name: privillage; type: table; schema: public; owner: postgres; tablespace: 
--

create table "privillage" (
    "id_res" integer not null,
    "resource" character varying(255) not null
);


alter table public."privillage" owner to postgres;

--
-- toc entry 177 (class 1259 oid 16426)
-- name: privillage_id_res_seq; type: sequence; schema: public; owner: postgres
--

create sequence "privillage_id_res_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."privillage_id_res_seq" owner to postgres;

--
-- toc entry 2018 (class 0 oid 0)
-- dependencies: 177
-- name: privillage_id_res_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "privillage_id_res_seq" owned by "privillage"."id_res";


--
-- toc entry 178 (class 1259 oid 16428)
-- name: trip; type: table; schema: public; owner: postgres; tablespace: 
--

create table "trip" (
    "id_trip" bigint not null,
    "localisation" integer not null,
    "name" character varying(64) not null,
    "organiser" integer not null,
    "length" real,
    "transports" character varying(255)[],
    "attractions" integer[],
    "usersnumber" integer,
    "price" double precision,
    "description" text
);


alter table public."trip" owner to postgres;

--
-- toc entry 179 (class 1259 oid 16434)
-- name: trip_id_trip_seq; type: sequence; schema: public; owner: postgres
--

create sequence "trip_id_trip_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."trip_id_trip_seq" owner to postgres;

--
-- toc entry 2019 (class 0 oid 0)
-- dependencies: 179
-- name: trip_id_trip_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "trip_id_trip_seq" owned by "trip"."id_trip";


--
-- toc entry 180 (class 1259 oid 16436)
-- name: user; type: table; schema: public; owner: postgres; tablespace: 
--

create table "user" (
    "id_user" regclass not null,
    "name" character varying(64) not null,
    "surename" character varying(64) not null,
    "dateofbirth" date not null,
    "userrole" character varying(64),
    login character varying(255),
    password character varying(32),
    "sex" integer
);


alter table public."user" owner to postgres;

--
-- toc entry 181 (class 1259 oid 16439)
-- name: userrole; type: table; schema: public; owner: postgres; tablespace: 
--

create table "userrole" (
    "name" character varying(255) not null,
    "id_userrole" integer not null,
    "idnumber" bigint,
    "privillages" integer[]
);


alter table public."userrole" owner to postgres;

--
-- toc entry 182 (class 1259 oid 16445)
-- name: userrole_id_userrole_seq; type: sequence; schema: public; owner: postgres
--

create sequence "userrole_id_userrole_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."userrole_id_userrole_seq" owner to postgres;

--
-- toc entry 2020 (class 0 oid 0)
-- dependencies: 182
-- name: userrole_id_userrole_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "userrole_id_userrole_seq" owned by "userrole"."id_userrole";


--
-- toc entry 183 (class 1259 oid 16447)
-- name: user_id_user_seq; type: sequence; schema: public; owner: postgres
--

create sequence "user_id_user_seq"
    start with 1
    increment by 1
    no minvalue
    no maxvalue
    cache 1;


alter table public."user_id_user_seq" owner to postgres;

--
-- toc entry 2021 (class 0 oid 0)
-- dependencies: 183
-- name: user_id_user_seq; type: sequence owned by; schema: public; owner: postgres
--

alter sequence "user_id_user_seq" owned by "user"."id_user";


--
-- toc entry 1961 (class 2604 oid 16449)
-- name: id_attraction; type: default; schema: public; owner: postgres
--

alter table only "attraction" alter column "id_attraction" set default nextval('"attraction_id_attraction_seq"'::regclass);


--
-- toc entry 1962 (class 2604 oid 16450)
-- name: id_att_type; type: default; schema: public; owner: postgres
--

alter table only "attractiontype" alter column "id_att_type" set default nextval('"attractiontype_id_att_type_seq"'::regclass);


--
-- toc entry 1964 (class 2604 oid 16451)
-- name: id_location; type: default; schema: public; owner: postgres
--

alter table only "location" alter column "id_location" set default nextval('"location_id_location_seq"'::regclass);


--
-- toc entry 1965 (class 2604 oid 16452)
-- name: id_photo; type: default; schema: public; owner: postgres
--

alter table only "photo" alter column "id_photo" set default nextval('"photos_id_photo_seq"'::regclass);


--
-- toc entry 1966 (class 2604 oid 16453)
-- name: id_res; type: default; schema: public; owner: postgres
--

alter table only "privillage" alter column "id_res" set default nextval('"privillage_id_res_seq"'::regclass);


--
-- toc entry 1967 (class 2604 oid 16454)
-- name: id_trip; type: default; schema: public; owner: postgres
--

alter table only "trip" alter column "id_trip" set default nextval('"trip_id_trip_seq"'::regclass);


--
-- toc entry 1968 (class 2604 oid 32771)
-- name: id_user; type: default; schema: public; owner: postgres
--

alter table only "user" alter column "id_user" set default nextval('"user_id_user_seq"'::regclass);


--
-- toc entry 1969 (class 2604 oid 16456)
-- name: id_userrole; type: default; schema: public; owner: postgres
--

alter table only "userrole" alter column "id_userrole" set default nextval('"userrole_id_userrole_seq"'::regclass);


--
-- toc entry 1990 (class 0 oid 16399)
-- dependencies: 168
-- data for name: attraction; type: table data; schema: public; owner: postgres
--



--
-- toc entry 1991 (class 0 oid 16402)
-- dependencies: 169
-- data for name: attractiontype; type: table data; schema: public; owner: postgres
--



--
-- toc entry 2022 (class 0 oid 0)
-- dependencies: 170
-- name: attractiontype_id_att_type_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"attractiontype_id_att_type_seq"', 1, false);


--
-- toc entry 2023 (class 0 oid 0)
-- dependencies: 171
-- name: attraction_id_attraction_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"attraction_id_attraction_seq"', 1, false);


--
-- toc entry 1994 (class 0 oid 16409)
-- dependencies: 172
-- data for name: location; type: table data; schema: public; owner: postgres
--



--
-- toc entry 2024 (class 0 oid 0)
-- dependencies: 173
-- name: location_id_location_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"location_id_location_seq"', 1, false);


--
-- toc entry 1996 (class 0 oid 16415)
-- dependencies: 174
-- data for name: photo; type: table data; schema: public; owner: postgres
--


--
-- toc entry 2025 (class 0 oid 0)
-- dependencies: 175
-- name: photos_id_photo_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"photos_id_photo_seq"', 1, false);


--
-- toc entry 1998 (class 0 oid 16423)
-- dependencies: 176
-- data for name: privillage; type: table data; schema: public; owner: postgres
--




--
-- toc entry 2026 (class 0 oid 0)
-- dependencies: 177
-- name: privillage_id_res_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"privillage_id_res_seq"', 1, false);


--
-- toc entry 2000 (class 0 oid 16428)
-- dependencies: 178
-- data for name: trip; type: table data; schema: public; owner: postgres
--



--
-- toc entry 2027 (class 0 oid 0)
-- dependencies: 179
-- name: trip_id_trip_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"trip_id_trip_seq"', 1, false);


--
-- toc entry 2002 (class 0 oid 16436)
-- dependencies: 180
-- data for name: user; type: table data; schema: public; owner: postgres
--




--
-- toc entry 2003 (class 0 oid 16439)
-- dependencies: 181
-- data for name: userrole; type: table data; schema: public; owner: postgres
--




--
-- toc entry 2028 (class 0 oid 0)
-- dependencies: 182
-- name: userrole_id_userrole_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"userrole_id_userrole_seq"', 1, false);


--
-- toc entry 2029 (class 0 oid 0)
-- dependencies: 183
-- name: user_id_user_seq; type: sequence set; schema: public; owner: postgres
--

select pg_catalog.setval('"user_id_user_seq"', 11, true);


--
-- toc entry 1971 (class 2606 oid 16458)
-- name: pk_id_attraction; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "attraction"
    add constraint "pk_id_attraction" primary key ("id_attraction");


--
-- toc entry 1973 (class 2606 oid 16460)
-- name: pk_id_att_type; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "attractiontype"
    add constraint "pk_id_att_type" primary key ("id_att_type");


--
-- toc entry 1975 (class 2606 oid 16462)
-- name: pk_id_location; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "location"
    add constraint "pk_id_location" primary key ("id_location");


--
-- toc entry 1977 (class 2606 oid 16464)
-- name: pk_id_photo; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "photo"
    add constraint "pk_id_photo" primary key ("id_photo");


--
-- toc entry 1979 (class 2606 oid 16466)
-- name: pk_id_res; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "privillage"
    add constraint "pk_id_res" primary key ("id_res");


--
-- toc entry 1981 (class 2606 oid 16468)
-- name: pk_id_trip; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "trip"
    add constraint "pk_id_trip" primary key ("id_trip");


--
-- toc entry 1983 (class 2606 oid 32773)
-- name: pk_id_user; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "user"
    add constraint "pk_id_user" primary key ("id_user");


--
-- toc entry 1986 (class 2606 oid 16472)
-- name: pk_id_userrole; type: constraint; schema: public; owner: postgres; tablespace: 
--

alter table only "userrole"
    add constraint "pk_id_userrole" primary key ("id_userrole");


--
-- toc entry 1984 (class 1259 oid 24576)
-- name: user_login_uniqx; type: index; schema: public; owner: postgres; tablespace: 
--

create unique index user_login_uniqx on "user" using btree (login);


--
-- toc entry 1987 (class 2606 oid 16473)
-- name: fk_attractiontype; type: fk constraint; schema: public; owner: postgres
--

alter table only "attraction"
    add constraint "fk_attractiontype" foreign key ("attractiontype") references "attractiontype"("id_att_type");


--
-- toc entry 1988 (class 2606 oid 16478)
-- name: fk_localisation_location; type: fk constraint; schema: public; owner: postgres
--

alter table only "trip"
    add constraint "fk_localisation_location" foreign key ("localisation") references "location"("id_location");


--
-- toc entry 1989 (class 2606 oid 32774)
-- name: fk_organiser_user; type: fk constraint; schema: public; owner: postgres
--

alter table only "trip"
    add constraint "fk_organiser_user" foreign key ("organiser") references "user"("id_user");


--
-- toc entry 2012 (class 0 oid 0)
-- dependencies: 6
-- name: public; type: acl; schema: -; owner: postgres
--

revoke all on schema public from public;
revoke all on schema public from postgres;
grant all on schema public to postgres;
grant all on schema public to public;


-- completed on 2013-01-14 21:31:28

--
-- postgresql database dump complete
--


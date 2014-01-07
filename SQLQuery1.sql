DROP TABLE grupa;
DROP TABLE osoba;


CREATE TABLE osoba (
        id_osoba int IDENTITY PRIMARY KEY NOT NULL, 
        imie varchar(30) NOT NULL, 
        nazwisko varchar(30)NOT NULL
);

CREATE TABLE marka(
        id_marka int IDENTITY PRIMARY KEY NOT NULL, 
        nazwa VARCHAR(30) NOT NULL, 
        kraj VARCHAR(30) NOT NULL, 
);

CREATE TABLE komorka(
        id_komorka int IDENTITY PRIMARY KEY NOT NULL, 
        model VARCHAR(20) NOT NULL, 
        waga int, 
        cena int,
        id_osoba int REFERENCES osoba(id_osoba) not null,
        id_marka int REFERENCES marka(id_marka) not null,  
);

--Insert
INSERT INTO osoba (imie, nazwisko) VALUES ('Michal', 'Skalkowski');
INSERT INTO osoba (imie, nazwisko) VALUES  ('Jan', 'Kowalski');
INSERT INTO osoba (imie, nazwisko) VALUES ('Piotr', 'Nowak');
INSERT INTO osoba (imie, nazwisko) VALUES ('Adam', 'Ma³ysz');

INSERT INTO marka (nazwa, kraj) VALUES ('Samsung', 'Korea')
INSERT INTO marka (nazwa, kraj) VALUES ('Sony', 'Japonia');
INSERT INTO marka (nazwa, kraj) VALUES ('HTC', 'Tajwan');
INSERT INTO marka (nazwa, kraj) VALUES ('Nokia', 'Finlandia');


INSERT INTO komorka (model, waga, cena, id_osoba, id_marka) values('I9100', 116, 1000, 1, 1);
INSERT INTO komorka (model, waga, cena, id_osoba, id_marka) values('Xperia Z', 146, 1500, 3, 2);
INSERT INTO komorka (model, waga, cena, id_osoba, id_marka) values('Desire Z', 180, 900, 2, 3);
INSERT INTO komorka (model, waga, cena, id_osoba, id_marka) values('Lumia 920', 185, 1150, 4, 4);

SELECT * FROM marka;
SELECT * FROM osoba;
SELECT * FROM komorka;
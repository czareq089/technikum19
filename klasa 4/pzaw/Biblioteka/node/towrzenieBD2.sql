
/*CREATE DATABASE ksiazkiklasa;*/
     
CREATE TABLE autorzy
		(
			IDautor serial NOT NULL ,
			nazwisko character(30),
			imie character(30),
			CONSTRAINT kluczAutorzy PRIMARY KEY (IDautor)
		);

CREATE TABLE ksiazki
		(
			IDksiazka serial NOT NULL ,
			tytul character(30),
			autor integer,
			cena integer,
			dataZakupu date,
			CONSTRAINT kluczKsiazki PRIMARY KEY (IDksiazka)
		);
		
CREATE TABLE czytelnicy
		(
			IDczytelnik serial NOT NULL ,
			czytImie character(30),
			czytNazwisko character(30),
			CONSTRAINT kluczCzytelnicy PRIMARY KEY (IDczytelnik)
		);		

CREATE TABLE wypozyczenia
		(
			IDczytelnik integer NOT NULL ,
			IDksiazka integer NOT NULL
		);

/*tabela autorzy*/

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('1', 'Adam','Mickiewicz');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('2', 'Jan','Kochanowski');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('3', 'Bolesław','Prus');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('4', 'Juliusz','Słowacki');

INSERT INTO autorzy (IDautor,imie,nazwisko)
VALUES ('5', 'Henryk','Sienkiewicz');


/*tabela ksiazki*/

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('1', 'Pan Tadeusz','1','12','1999-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('2', 'Grażyna','1','22','2019-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('3', 'Ballady i romanse','1','15','1987-11-15');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('4', 'Pan Tadeusz','1','33','2009-01-22');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('5', 'Pan Tadeusz','1','55','2009-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('6', 'Treny','2','78','1999-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('7', 'Fraszki','2','65','1959-10-11');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('8', 'Treny','2','35','2019-03-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('9', 'Treny','2','69','2006-01-22');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('10', 'Fraszki','2','44','1966-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('11', 'Emancypantki','3','69','2001-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('12', 'Emancypantki','3','99','2011-05-09');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('13', 'Emancypantki','3','25','2025-08-21');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('14', 'Emancypantki','3','75','2011-11-11');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('15', 'Emancypantki','3','33','2031-06-16');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('16', 'Ogniem i mieczem','5','69','2001-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('17', 'Potop','5','159','2011-12-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('18', 'Pan Wołodiowski','5','222','2021-02-16');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('19', 'Krzyżacy','5','147','2051-09-01');

INSERT INTO ksiazki (IDksiazka,tytul,autor,cena,datazakupu)
VALUES ('20', 'Quo vadis','5','25','2001-12-01');


/*tabela czytelnicy*/

INSERT INTO czytelnicy (IDczytelnik,czytimie,czytnazwisko)
VALUES ('1', 'Adam','Kowalski');
INSERT INTO czytelnicy (IDczytelnik,czytimie,czytnazwisko)
VALUES ('2', 'Barbara','Kowalska');
INSERT INTO czytelnicy (IDczytelnik,czytimie,czytnazwisko)
VALUES ('3', 'Jan','Nowak');
INSERT INTO czytelnicy (IDczytelnik,czytimie,czytnazwisko)
VALUES ('4', 'Barnaba','Nowak');

/*tabela wypozyczenia*/

INSERT INTO wypozyczenia (IDczytelnik,IDksiazka)
VALUES ('1', '3');
INSERT INTO wypozyczenia (IDczytelnik,IDksiazka)
VALUES ('2', '15');
INSERT INTO wypozyczenia (IDczytelnik,IDksiazka)
VALUES ('2', '10');
INSERT INTO wypozyczenia (IDczytelnik,IDksiazka)
VALUES ('3', '19');


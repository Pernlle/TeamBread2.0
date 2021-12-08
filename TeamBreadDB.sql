
DROP TABLE Ejendomsmaegler;
DROP TABLE Kunder;
DROP TABLE Tlf;
DROP TABLE Bolig;
DROP TABLE Postnummer;

CREATE TABLE Postnummer(
	postNr INT PRIMARY KEY NOT NULL,
	byNavn VARCHAR(50) NOT NULL,
);


CREATE TABLE Ejendomsmaegler(
	eID Int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	pass VARCHAR(100),

	fNavn VARCHAR(30),
	eNavn VARCHAR(30),
	email VARCHAR(50),
);

CREATE TABLE Kunder(
	kID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	fNavn VARCHAR(30),
	eNavn VARCHAR(30),
	email VARCHAR(50),
	saelger INT,
	koeber INT,
);

CREATE TABLE Tlf (
	tlf VARCHAR(100),
	kID INT FOREIGN KEY REFERENCES Kunder(kID),
	eID INT FOREIGN KEY REFERENCES Ejendomsmaegler(eID),
);

CREATE TABLE Bolig (
	bID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	adresse VARCHAR (50),
	postNr INT FOREIGN KEY REFERENCES Postnummer(postNr),
	solgt INT,
	kvm DECIMAL,
	salgsPris DECIMAL,
	handelsPris DECIMAL,
	handelsDato DATE,
	eID INT FOREIGN KEY REFERENCES Ejendomsmaegler(eID),
	kID INT FOREIGN KEY REFERENCES Kunder(kID),
);

INSERT INTO Postnummer (postNr, byNavn) VALUES
(2650, 'Hvidovre'),
(6400, 'Sønderborg'),
(6980, 'Tim'),
(7100, 'Vejle'),
(7120, 'Vejle Øst'),
(7190, 'Billund'),
(7300, 'Jelling'),
(7323, 'Give'),
(8700, 'Horsens'),
(8800, 'Viborg'),
(9000, 'Aalborg')


INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Tom Pernille', 'Ali', 'tompernilleali@yahoo.com', '1', '0')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Ulla Karsten', 'Christensen', 'ukc@yahoo.com', '1', '0')
INSERT INTO Ejendomsmaegler (pass, fNavn, eNavn, email) VALUES ('root','Admin', '','')
INSERT INTO Ejendomsmaegler (pass, fNavn, eNavn, email) VALUES ('1234','Tom Ali', 'Hansen','tomalihansen@realbolig.dk')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris) VALUES ('2','1','Mywaye','7100','110','2000000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris) VALUES ('2','2','Syrengården 19','7100','150','5000000')

SELECT * FROM Ejendomsmaegler

SELECT * FROM Bolig

SELECT * FROM Kunder
DROP TABLE Administrator;
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
	eID INT FOREIGN KEY REFERENCES Ejendomsmaegler(eID),
	kID INT FOREIGN KEY REFERENCES Kunder(kID),

	adresse VARCHAR (50),
	postNr INT FOREIGN KEY REFERENCES Postnummer(postNr),
	kvm DECIMAL,

	salgsPris DECIMAL,

	handelsPris DECIMAL,
	handelsDato DATE,
	solgt INT,
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



INSERT INTO Ejendomsmaegler (pass, fNavn, eNavn, email) VALUES ('root','Admin', '','')
INSERT INTO Ejendomsmaegler (pass, fNavn, eNavn, email) VALUES ('1234','Tom Ali', 'Hansen','tomalihansen@realbolig.dk')

SELECT * FROM Ejendomsmaegler


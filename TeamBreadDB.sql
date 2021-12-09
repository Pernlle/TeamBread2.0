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
	handelsDato VARCHAR(50),
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
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Pernille', 'Ali', 'pa@yahoo.com', '1', '0')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Ulla', 'Christensen', 'uc@yahoo.com', '1', '1')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Karen', 'Christensen', 'kc@yahoo.com', '0', '1')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Ingeborg', 'Iversen', 'ii@yahoo.com', '0', '1')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Donald', 'Pence', 'dp@yahoo.com', '0', '1')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Tornhøj', 'Skyskraper', 'ths@yahoo.com', '1', '0')
INSERT INTO Kunder(fNavn, eNavn, email, saelger, koeber) VALUES ('Mega', 'Bussinesman', 'mbm@yahoo.com', '1', '0')


INSERT INTO Ejendomsmaegler (pass, fNavn, eNavn, email) VALUES ('root','Admin', '','')
INSERT INTO Ejendomsmaegler (pass, fNavn, eNavn, email) VALUES ('1234','Tom Ali', 'Hansen','tomalihansen@realbolig.dk')

INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','3','Kæmpestor 32','2650','110','9000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','4','Someway 16','9000','110','3000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','5','Over 7','8800','100','1000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','6','The 41','8700','160','1000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','1','Rainbow 4','7323','130','2000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','2','Wassup 25','7300','60','3000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','3','Kommernu 30','7190','177','4000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','4','Hvorfra Vej 21','7120','150','5000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','5','Munkegade 118','6980','80','6000000','0')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt) VALUES ('2','6','Klarsynsgade 121','6400','70','7000000','0')

INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','3','Over Jyden 130','2650','110','1000000','1','01-12-2021 00:00:00','895000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','4','Klippersten 65','9000','110','2000000','1','01-12-2021 00:00:00','1900000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','5','Harry Vej 14','8800','100','3000000','1','01-12-2021 00:00:00','2900000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','6','Dum Dum Vej 50','8700','160','4000000','1','01-12-2021 00:00:00','3900000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','1','Regnbue 68','7323','130','5000000','1','01-12-2021 00:00:00','5500000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','2','Pæn Vej 25','7300','60','6000000','1','01-12-2021 00:00:00','6000000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','3','Grim Vej 30','7190','177','7000000','1','01-12-2021 00:00:00','6500000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','4','Jeganerdetikke 21','7120','150','8000000','1','01-12-2021 00:00:00','7600000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','5','Farout 40','6980','80','9000000','1','01-12-2021 00:00:00','8700000')
INSERT INTO Bolig (eID, kID, adresse, postNr, kvm, salgsPris, solgt, handelsDato, handelsPris) VALUES ('2','6','Tomhjerne 20','6400','70','1000000','1','01-12-2021 00:00:00','900000')


SELECT * FROM Ejendomsmaegler

SELECT * FROM Bolig

SELECT * FROM Kunder
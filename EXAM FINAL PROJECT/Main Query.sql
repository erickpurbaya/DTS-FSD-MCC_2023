CREATE TABLE vendor (
	vID int PRIMARY KEY,
	vNAME varchar(50) NOT NULL,
	vORIGIN varchar(50),
	vTYPE varchar(50),
	vVERIFIED bit
);

CREATE TABLE purchase (
	pID int PRIMARY KEY,
	pDATE date NOT NULL,
	pTOTAL int NOT NULL,
	pITEM varchar(100) NOT NULL,
	pvID int NOT NULL,
	pPAID bit NOT NULL,
	FOREIGN KEY (pvID) REFERENCES vendor(vID)	
);

CREATE TABLE item (
	iID int PRIMARY KEY,
	iNAME varchar(100) NOT NULL,
	iPRICE int NOT NULL,
	iTOTAL int NOT NULL,
	iTYPE varchar(50),
	iVENDOR int,
	iHALAL bit,
	FOREIGN KEY (iVENDOR) REFERENCES vendor(vID)
);

SELECT * FROM purchase;

INSERT INTO item VALUES (123, 'Athariq', 'Palembang', 'Elektronik', 1);
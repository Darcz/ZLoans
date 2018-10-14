IF OBJECT_ID('tblClients') IS NOT NULL DROP TABLE tblClients


GO
CREATE TABLE tblClients (
	Id INT IDENTITY(1, 1) NOT NULL,
	FirstName NVARCHAR(1000) NOT NULL,
	MiddleName NVARCHAR(1000) NULL,
	LastName NVARCHAR(1000) NOT NULL,
	GenderId INT NULL,
	SuffixId INT NULL,
	Birthday DATETIME NULL,
	CivilStatusId INT NULL,
	FullName AS FirstName + ' ' + SUBSTRING(MiddleName, 1, 1) + ' ' + LastName,
	Active BIT NOT NULL CONSTRAINT DF_tblClients_Active DEFAULT(1),
	CONSTRAINT PK_tblClients PRIMARY KEY (Id),	
)


GO

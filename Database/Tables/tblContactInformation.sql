IF OBJECT_ID('tblContactInformation')IS NOT NULL DROP TABLE tblContactInformation


GO
CREATE TABLE tblContactInformation(
	Id INT IDENTITY(1, 1) NOT NULL,
	ClientId INT NULL,
	ContactNumber NVARCHAR(1000) NULL,
	ContactTypeId INT NOT NULL,
	Active BIT NOT NULL CONSTRAINT DF_tblContactInformationClients_Active DEFAULT(1),
	CONSTRAINT PK_tblContactInformation PRIMARY KEY (Id),
)


GO

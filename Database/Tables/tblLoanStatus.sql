IF OBJECT_ID('tblLoanStatus')IS NOT NULL DROP TABLE tblLoanStatus


GO
CREATE TABLE tblLoanStatus(
	Id INT IDENTITY(1, 1) NOT NULL,
	Code NVARCHAR(1000) NOT NULL,
	Name NVARCHAR(1000) NOT NULL,
	Active BIT NOT NULL CONSTRAINT DF_tblLoanStatusClients_Active DEFAULT(1),
	CONSTRAINT PK_tblLoanStatus PRIMARY KEY (Id),
)


GO
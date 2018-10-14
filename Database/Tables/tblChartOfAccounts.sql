USE Accounting

IF OBJECT_ID('tblChartOfAccounts') IS NOT NULL DROP TABLE tblChartOfAccounts

GO
CREATE TABLE tblChartOfAccounts (
	Id INT IDENTITY(1, 1) NOT NULL,
	Code VARCHAR(255) NOT NULL,
	Name VARCHAR(1000) NOT NULL,
	[Description] VARCHAR(MAX) NULL,
	AccountTypeId INT NOT NULL,
	Active BIT NOT NULL CONSTRAINT DF_tblChartofAccounts_Active DEFAULT(1),
	CONSTRAINT PK_tblChartofAccounts PRIMARY KEY (ID),
)


GO



GO

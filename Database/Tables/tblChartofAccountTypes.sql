IF OBJECT_ID('tblChartOfAccountTypes') IS NOT NULL DROP TABLE tblChartOfAccountTypes


GO
CREATE TABLE tblChartOfAccountTypes (
	Id INT IDENTITY(1, 1) NOT NULL,
	Code VARCHAR(255) NOT NULL,
	Name VARCHAR(1000) NOT NULL,
	[Description] VARCHAR(1000) NULL,
	Active BIT NOT NULL CONSTRAINT DF_tblChartOfAccountTypes_Active DEFAULT(1),
	CONSTRAINT PK_tblChartOfAccountTypes PRIMARY KEY (ID),
)


GO

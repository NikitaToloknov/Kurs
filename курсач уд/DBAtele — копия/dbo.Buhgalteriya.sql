CREATE TABLE [dbo].[Бухгалтерия]
(
	[ID зарплаты] INT NOT NULL PRIMARY KEY, 
    [ID сотрудника] NCHAR(10) NULL, 
    [Зарплата] MONEY NULL, 
    [Премия] MONEY NULL, 
    [Дата зарплаты] DATE NULL
)

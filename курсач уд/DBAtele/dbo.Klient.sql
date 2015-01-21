CREATE TABLE [dbo].[Клиент]
(
	[ID заказчика] INT NOT NULL PRIMARY KEY, 
    [Фамилия] NCHAR(30) NULL, 
    [Имя] NCHAR(30) NULL, 
    [Отчество] NCHAR(30) NULL, 
    [Контактный телефон] INT NULL, 
    [E-mail] NCHAR(30) NULL, 
    [Password] NCHAR(30) NULL
)

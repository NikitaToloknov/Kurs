CREATE TABLE [dbo].[Сотрудник]
(
	[ID сотрудника] INT NOT NULL PRIMARY KEY, 
    [Фамилия] NCHAR(30) NULL, 
    [Имя] NCHAR(30) NULL, 
    [Отчество] NCHAR(30) NULL, 
    [Должность] NCHAR(30) NULL, 
    [Дата приема на работу] DATE NULL, 
    [Общий стаж] INT NULL, 
    [Стаж] INT NULL, 
    [Доступ ко всем данным] BIT NULL, 
    [E-mail] NCHAR(30) NULL, 
    [Password] NCHAR(30) NULL
)

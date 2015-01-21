CREATE TABLE [dbo].[Оборудование]
(
	[ID оборудования] INT NOT NULL PRIMARY KEY, 
    [Наименование оборудования] NCHAR(30) NULL, 
    [Дата приобретения] DATE NULL, 
    [Состояние] BIT NULL
)

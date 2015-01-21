CREATE TABLE [dbo].[Мерки]
(
	[ID мерки] INT NOT NULL PRIMARY KEY, 
    [Обхват груди] INT NULL, 
    [Обхват талии] INT NULL, 
    [Обхват бедер] INT NULL, 
    [Рост] INT NULL, 
    [Примечания] NVARCHAR(50) NULL
)

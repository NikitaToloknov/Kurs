CREATE TABLE [dbo].[СкладТканей]
(
	[ID ткани] INT NOT NULL PRIMARY KEY, 
    [Наименование ткани] NCHAR(30) NULL, 
    [Количество ] INT NULL, 
    [Состав ткани] NCHAR(30) NULL, 
    [Цвет] NCHAR(30) NULL, 
    [Цена] MONEY NULL
)

CREATE TABLE [dbo].[СведенияОТканях]
(
	[ID ткани] INT NOT NULL PRIMARY KEY, 
    [Страна производитель] NCHAR(30) NULL, 
    [Дата изготовления] DATE NULL, 
    [Дата привоза] DATE NULL, 
    [Покупная цена] MONEY NULL
)

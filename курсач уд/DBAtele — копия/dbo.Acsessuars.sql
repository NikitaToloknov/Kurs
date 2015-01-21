CREATE TABLE [dbo].[Аксессуары]
(
	[ID аксессуара] INT NOT NULL PRIMARY KEY, 
    [Наименование акссуара] NCHAR(30) NULL, 
    [Тип] NCHAR(30) NULL, 
    [Фото] IMAGE NULL
)

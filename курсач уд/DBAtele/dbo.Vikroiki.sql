CREATE TABLE [dbo].[Выкройки]
(
	[ID выкройки] INT NOT NULL PRIMARY KEY, 
    [Модель] NCHAR(30) NULL, 
    [Схема] NCHAR(10) NULL, 
    [Фото модели] IMAGE NULL, 
    [ID мерки] INT NULL, 
    [ID ткани] INT NULL, 
    [ID аксессуара] INT NULL
)

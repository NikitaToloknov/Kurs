CREATE TABLE [dbo].[ЗаписьНаМерку]
(
	[ID мерки] INT NOT NULL PRIMARY KEY, 
    [ID заказчика] INT NULL, 
    [Дата] DATE NULL, 
    [Время] TIME NULL
)

CREATE TABLE [dbo].[Заказ]
(
	[ID заказа] INT NOT NULL PRIMARY KEY, 
    [ID заказчика] INT NULL, 
    [ID доставки] INT NULL, 
    [ID сотрудника] INT NULL, 
    [ID выкройки] INT NULL, 
    [Цена заказа] MONEY NULL, 
    [Предоплата] MONEY NULL, 
    [Дата заказа] NCHAR(10) NULL, 
    [Срочность] BIT NULL
)

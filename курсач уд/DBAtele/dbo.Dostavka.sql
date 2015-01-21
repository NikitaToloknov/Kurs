CREATE TABLE [dbo].[Доставка]
(
	[ID доставки] INT NOT NULL PRIMARY KEY, 
    [ID сотрудника] INT NULL, 
    [Стоимость доставки] MONEY NULL, 
    [Дата доставки] DATE NULL, 
    [Время доставки] TIME NULL
)

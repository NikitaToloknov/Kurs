USE [C:\USERS\ИВАН\DESKTOP\КУРСАЧ УД\DBATELE\ATELIER.MDF]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER TRIGGER [dbo].[DiscountTrigg]
 ON [dbo].[Заказ]
   AFTER INSERT
AS 
DECLARE @perem int
DECLARE @NewCena money 
declare @idtekZ int =(select inserted.[ID заказа] from inserted)
declare @idtekK int =(select inserted.[ID заказчика] from inserted)
DECLARE @Колво int=(select [dbo].Клиент.[Количество заказов] from dbo.Клиент where [dbo].Клиент.[ID заказчика]=@idtekK)
DECLARE @Скидка int=(select max([dbo].Скидка.Скидка)  from [dbo].Скидка where [dbo].[Скидка].[Количество заказов]<=@Колво)	
	BEGIN	
	IF @Скидка!=null
	update  [dbo].[Заказ] SET [Цена заказа]=[Цена заказа]-(([Цена заказа]*@Скидка)/100) where [ID заказа]=@idtekZ
	
	END
	
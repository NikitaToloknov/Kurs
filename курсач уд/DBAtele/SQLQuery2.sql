USE [C:\USERS\ИВАН\DESKTOP\КУРСАЧ УД\DBATELE\ATELIER.MDF]
GO
/****** Object:  Trigger [dbo].[DiscountTrig]    Script Date: 10.01.2015 20:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER TRIGGER [dbo].[DiscountTrig]
 ON [dbo].[Заказ]
   AFTER INSERT
AS 
DECLARE @perem int
DECLARE @NewCena money 
DECLARE @Колво int=(select [dbo].Клиент.[Количество заказов] from dbo.Клиент where inserted.[ID заказчика]=[dbo].Клиент.[ID заказчика])
	DECLARE @Скидка money=(select [dbo].Скидка.Скидка  from [dbo].Скидка where @Колво=[dbo].[Скидка].[Количество заказов])
		--if  @Скидка=@Колво		
	BEGIN	
	IF @Скидка=@Колво
	update  [dbo].[Заказ]
SET [Цена заказа]=[Цена заказа]-[Цена заказа]*@Скидка
	END
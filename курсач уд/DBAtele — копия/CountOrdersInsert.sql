SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER CountOrdersInsert
   ON  [dbo].Заказ 
   AFTER insert
AS 
declare @idZakTek int=(select inserted.[ID заказчика] from inserted)
declare @Kolvo int= (select [dbo].Клиент.[Количество заказов] from [dbo].Клиент where [dbo].Клиент.[ID заказчика]=@idZakTek)
BEGIN
update [dbo].Клиент set [dbo].Клиент.[Количество заказов]=(@Kolvo+1) where [dbo].Клиент.[ID заказчика]=@idZakTek
END
GO

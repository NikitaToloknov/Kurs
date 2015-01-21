SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER CountOrdersDelete
   ON  [dbo].Заказ 
   AFTER DELETE
AS 
declare @idZakTek int=(select deleted.[ID заказчика] from deleted)
declare @Kolvo int= (select [dbo].Клиент.[Количество заказов] from [dbo].Клиент where [dbo].Клиент.[ID заказчика]=@idZakTek)
BEGIN
update [dbo].Клиент set [dbo].Клиент.[Количество заказов]=(@Kolvo-1) where [dbo].Клиент.[ID заказчика]=@idZakTek
END
GO

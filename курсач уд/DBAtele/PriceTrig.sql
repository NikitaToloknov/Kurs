SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER PriceTrig
   ON  [dbo].Заказ 
   AFTER INSERT
AS 
declare @TekVikr int=(select inserted.[ID выкройки] from inserted)
declare @ModelZak nchar(30)=(select [dbo].Выкройки.Модель from [dbo].Выкройки where [dbo].Выкройки.[ID выкройки]=@TekVikr)
declare @KolvoTkani int=(select [dbo].Выкройки.[Количество ткани] from [dbo].Выкройки where [dbo].Выкройки.[ID выкройки]=@TekVikr)
declare @IdTekTkani int=(select [dbo].Выкройки.[ID ткани] from [dbo].Выкройки where [dbo].Выкройки.[ID выкройки]=@TekVikr)
declare @CenaMetr money=(select [dbo].СкладТканей.Цена from [dbo].СкладТканей where [dbo].СкладТканей.[ID ткани]=@IdTekTkani)
BEGIN
if @ModelZak='Юбка'
update [dbo].Заказ set [Цена заказа]=1500+@KolvoTkani*@CenaMetr
END
GO

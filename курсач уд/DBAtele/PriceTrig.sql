SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER PriceTrig
   ON  [dbo].����� 
   AFTER INSERT
AS 
declare @TekVikr int=(select inserted.[ID ��������] from inserted)
declare @ModelZak nchar(30)=(select [dbo].��������.������ from [dbo].�������� where [dbo].��������.[ID ��������]=@TekVikr)
declare @KolvoTkani int=(select [dbo].��������.[���������� �����] from [dbo].�������� where [dbo].��������.[ID ��������]=@TekVikr)
declare @IdTekTkani int=(select [dbo].��������.[ID �����] from [dbo].�������� where [dbo].��������.[ID ��������]=@TekVikr)
declare @CenaMetr money=(select [dbo].�����������.���� from [dbo].����������� where [dbo].�����������.[ID �����]=@IdTekTkani)
BEGIN
if @ModelZak='����'
update [dbo].����� set [���� ������]=1500+@KolvoTkani*@CenaMetr
END
GO

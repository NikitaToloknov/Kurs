SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER CountOrdersInsert
   ON  [dbo].����� 
   AFTER insert
AS 
declare @idZakTek int=(select inserted.[ID ���������] from inserted)
declare @Kolvo int= (select [dbo].������.[���������� �������] from [dbo].������ where [dbo].������.[ID ���������]=@idZakTek)
BEGIN
update [dbo].������ set [dbo].������.[���������� �������]=(@Kolvo+1) where [dbo].������.[ID ���������]=@idZakTek
END
GO

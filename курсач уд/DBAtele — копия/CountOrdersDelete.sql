SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER CountOrdersDelete
   ON  [dbo].����� 
   AFTER DELETE
AS 
declare @idZakTek int=(select deleted.[ID ���������] from deleted)
declare @Kolvo int= (select [dbo].������.[���������� �������] from [dbo].������ where [dbo].������.[ID ���������]=@idZakTek)
BEGIN
update [dbo].������ set [dbo].������.[���������� �������]=(@Kolvo-1) where [dbo].������.[ID ���������]=@idZakTek
END
GO

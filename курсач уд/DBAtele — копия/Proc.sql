SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ProcedureExperience
AS
declare @RusDate date=CONVERT (date, GETDATE())
declare @NewStazh int
declare @ID���� int
declare @������� nchar(30)
declare @��� nchar(30)
declare @�������� nchar(30)
declare @��������� nchar(30)
declare @������� date
declare @��������� int
declare @���� int
declare @����������� bit
declare @email nchar(30)
declare @pass nchar(30)
declare @CursPerem Cursor
select @ID����,@�������,@���,@��������,@���������,@�������,@���������,@����,@�����������,@email,@pass from dbo.���������
open @CursPerem 
fetch next from @CursPerem into @ID����,@�������,@���,@��������,@���������,@�������,@���������,@����,@�����������,@email,@pass
while @@FETCH_STATUS=0
BEGIN
SET DATEFORMAT dmy;
DECLARE @datevar date = CONVERT (date, GETDATE());
SELECT @datevar;
set @NewStazh =(SELECT DATEDIFF(month,@�������,@datevar))
update dbo.��������� set dbo.���������.���� = @NewStazh , dbo.���������.[����� ����]= @���������+@NewStazh-@���� where dbo.���������.[ID ����������]=@ID����
fetch next from @CursPerem into @ID����,@�������,@���,@��������,@���������,@�������,@���������,@����,@�����������,@email,@pass
END
close @CursPerem
deallocate @CursPerem 
GO

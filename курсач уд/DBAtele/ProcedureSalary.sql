SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE ProcedureSalary
AS
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
declare @����� money
declare @CursPerem Cursor
select @ID����,@�������,@���,@��������,@���������,@�������,@���������,@����,@�����������,@email,@pass,@����� from dbo.���������
open @CursPerem 
fetch next from @CursPerem into @ID����,@�������,@���,@��������,@���������,@�������,@���������,@����,@�����������,@email,@pass,@�����
while @@FETCH_STATUS=0
BEGIN
SET DATEFORMAT dmy;
DECLARE @datevar date = CONVERT (date, GETDATE());
SELECT @datevar;
insert into [dbo].�����������.[��������] ([dbo].�����������.[ID ����������],[dbo].�����������.[���� ��������], [dbo].�����������.��������,[dbo].�����������.������) values 
(@ID����,@datevar,dbo.FunctionSalary(@�����,@����,1),dbo.FunctionSalary(@�����,@����,0))
fetch next from @CursPerem into @ID����,@�������,@���,@��������,@���������,@�������,@���������,@����,@�����������,@email,@pass,@�����
END
close @CursPerem
deallocate @CursPerem 

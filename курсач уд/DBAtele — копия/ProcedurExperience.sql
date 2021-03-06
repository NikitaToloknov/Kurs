USE [C:\USERS\ИВАН\DESKTOP\КУРСАЧ УД\DBATELE\ATELIER.MDF]
GO
/****** Object:  StoredProcedure [dbo].[ProcedureExperience]    Script Date: 11.01.2015 0:32:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ProcedurExperience
AS
declare @RusDate date=CONVERT (date, GETDATE())
declare @NewStazh int
declare @IDсотр int
declare @Фамилия nchar(30)
declare @Имя nchar(30)
declare @Отчество nchar(30)
declare @Должность nchar(30)
declare @Приемка date
declare @ОбщийСтаж int
declare @Стаж int
declare @Доступность bit
declare @email nchar(30)
declare @pass nchar(30)
declare @Оклад money
declare @CursPerem Cursor
select @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass,@Оклад from dbo.Сотрудник
open @CursPerem 
fetch next from @CursPerem into @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass,@Оклад
while @@FETCH_STATUS=0
BEGIN
SET DATEFORMAT dmy;
DECLARE @datevar date = CONVERT (date, GETDATE());
SELECT @datevar;
set @NewStazh =(SELECT DATEDIFF(month,@Приемка,@datevar))
update dbo.Сотрудник set dbo.Сотрудник.Стаж = @NewStazh , dbo.Сотрудник.[Общий стаж]= @ОбщийСтаж+@NewStazh-@Стаж where dbo.Сотрудник.[ID сотрудника]=@IDсотр
fetch next from @CursPerem into @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass,@Оклад
END
close @CursPerem
deallocate @CursPerem 

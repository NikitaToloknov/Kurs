SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ProcedureExperience
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
declare @CursPerem Cursor
select @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass from dbo.Сотрудник
open @CursPerem 
fetch next from @CursPerem into @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass
while @@FETCH_STATUS=0
BEGIN
SET DATEFORMAT dmy;
DECLARE @datevar date = CONVERT (date, GETDATE());
SELECT @datevar;
set @NewStazh =(SELECT DATEDIFF(month,@Приемка,@datevar))
update dbo.Сотрудник set dbo.Сотрудник.Стаж = @NewStazh , dbo.Сотрудник.[Общий стаж]= @ОбщийСтаж+@NewStazh-@Стаж where dbo.Сотрудник.[ID сотрудника]=@IDсотр
fetch next from @CursPerem into @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass
END
close @CursPerem
deallocate @CursPerem 
GO

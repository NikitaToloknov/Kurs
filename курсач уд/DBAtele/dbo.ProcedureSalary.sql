CREATE PROCEDURE ProcedureSalary
AS
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
--knnnnnnnnnnnnnnnnn
insert into [dbo].Бухгалтерия ([dbo].Бухгалтерия.[ID сотрудника],[dbo].Бухгалтерия.[Дата зарплаты], [dbo].Бухгалтерия.Зарплата,[dbo].Бухгалтерия.Премия) values 
(@datevar,dbo.FunctionSalary(@Оклад,@Стаж,1),dbo.FunctionSalary(@Оклад,@Стаж,0))
fetch next from @CursPerem into @IDсотр,@Фамилия,@Имя,@Отчество,@Должность,@Приемка,@ОбщийСтаж,@Стаж,@Доступность,@email,@pass,@Оклад
END
close @CursPerem
deallocate @CursPerem
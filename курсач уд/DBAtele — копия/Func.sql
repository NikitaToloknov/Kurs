SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION FunctionSalary
(

	@Оклад money, @Стаж int, @ЧтоВернуть bit
)
RETURNS money
AS
BEGIN
DECLARE @temper money
DECLARE @Зарплата money= (((@Оклад*@Стаж)/12)/100)+@Оклад
DECLARE @Премия money = (@Зарплата*3)/100
DECLARE @ПремиалЗарплата money=@Зарплата+@Премия
if @ЧтоВернуть=1

	set @temper= @Зарплата
else
	set @temper= @Премия

	return @temper

END
GO


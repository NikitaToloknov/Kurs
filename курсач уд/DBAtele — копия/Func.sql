SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION FunctionSalary
(

	@����� money, @���� int, @���������� bit
)
RETURNS money
AS
BEGIN
DECLARE @temper money
DECLARE @�������� money= (((@�����*@����)/12)/100)+@�����
DECLARE @������ money = (@��������*3)/100
DECLARE @��������������� money=@��������+@������
if @����������=1

	set @temper= @��������
else
	set @temper= @������

	return @temper

END
GO


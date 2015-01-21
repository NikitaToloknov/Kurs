CREATE TRIGGER DiscountTrig
	ON [dbo].[Заказ]
	FOR DELETE, INSERT, UPDATE
	as
	DECLARE @NewCena money
	DECLARE @Скидка money
	--set @NewCena = select [Скидка].Скидка from [dbo].Скидка 
	if [dbo].[Клиент].[Количество заказов]=[dbo].[Скидка].[Количество заказов]
	BEGIN	
	update [dbo].[Заказ]
		SET [Цена заказа]=[Цена заказа]-[Цена заказа]*(select [dbo].Скидка.Скидка  from [dbo].Скидка)
	END
	--CREATE TRIGGER [dbo].[CalculateSpotsForInsert]
 --                                  ON  [dbo].[SectionRankUsers]
 --                                  AFTER INSERT
 --                               AS 
 --                               BEGIN
 --                                SET NOCOUNT ON;
 --                                UPDATE dbo.Sections SET ParticipantsCount = (SELECT COUNT(*) FROM [dbo].[SectionRankUsers] WHERE [dbo].[SectionRankUsers].Section_SectionID = SectionId) WHERE SectionId IN (SELECT i.Section_SectionId FROM inserted AS i)
 --                                   UPDATE dbo.Sections SET FreeSpotsCount =  SpotsCount - (SELECT COUNT(*) FROM [dbo].[SectionRankUsers] WHERE [dbo].[SectionRankUsers].Section_SectionID = SectionId) WHERE SectionId IN (SELECT i.Section_SectionId FROM inserted AS i)
 --                               END‏

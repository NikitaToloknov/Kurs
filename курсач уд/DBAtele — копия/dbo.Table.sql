CREATE TABLE [dbo].[СотрудникОборудование]
(
	[ID Связи] INT NOT NULL PRIMARY KEY, 
    [ID сотрудника] INT NULL, 
    [ID оборудования] INT NULL, 
    CONSTRAINT [FK_СотрудникОборудование_Сотрудник] FOREIGN KEY ([ID сотрудника]) REFERENCES [Сотрудник]([ID сотрудника]), 
    CONSTRAINT [FK_СотрудникОборудование_ToTable] FOREIGN KEY ([ID оборудования]) REFERENCES [Оборудование]([ID оборудования])
)

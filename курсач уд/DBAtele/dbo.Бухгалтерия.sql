CREATE TABLE [dbo].[Бухгалтерия] (
    [ID зарплаты]   INT        NOT NULL,
    [ID сотрудника] INT NULL,
    [Зарплата]      MONEY      NULL,
    [Премия]        MONEY      NULL,
    [Дата зарплаты] DATE       NULL,
    PRIMARY KEY CLUSTERED ([ID зарплаты] ASC), 
    CONSTRAINT [FK_Бухгалтерия_Сотрудник] FOREIGN KEY ([ID сотрудника]) REFERENCES [Сотрудник]([ID сотрудника])
);


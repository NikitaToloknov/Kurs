CREATE TABLE [dbo].[Заказ] (
    [ID заказа]     INT        NOT NULL,
    [ID заказчика]  INT        NULL,
    [ID доставки]   INT        NULL,
    [ID сотрудника] INT        NULL,
    [ID выкройки]   INT        NULL,
    [Цена заказа]   MONEY      NULL DEFAULT 0,
    [Предоплата]    MONEY      NULL DEFAULT 0,
    [Дата заказа]   NCHAR (10) NULL DEFAULT '01.01.2014',
    [Срочность]     BIT        NULL DEFAULT 'False',
    PRIMARY KEY CLUSTERED ([ID заказа] ASC),
    CONSTRAINT [FK_Заказ_Выкройки] FOREIGN KEY ([ID выкройки]) REFERENCES [dbo].[Выкройки] ([ID выкройки]),
    CONSTRAINT [FK_Заказ_Доставка] FOREIGN KEY ([ID доставки]) REFERENCES [dbo].[Доставка] ([ID доставки]),
    CONSTRAINT [FK_Заказ_Клиент] FOREIGN KEY ([ID заказчика]) REFERENCES [dbo].[Клиент] ([ID заказчика]),
    CONSTRAINT [FK_Заказ_Сотрудник] FOREIGN KEY ([ID сотрудника]) REFERENCES [dbo].[Сотрудник] ([ID сотрудника])
);


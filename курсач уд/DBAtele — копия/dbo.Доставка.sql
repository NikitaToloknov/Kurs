CREATE TABLE [dbo].[Доставка] (
    [ID доставки]        INT      NOT NULL,
    [ID сотрудника]      INT      NULL,
    [Стоимость доставки] MONEY    NULL DEFAULT 0,
    [Дата доставки]      DATE     NULL DEFAULT '01.01.2014',
    [Время доставки]     TIME (7) NULL DEFAULT '00:00',
    PRIMARY KEY CLUSTERED ([ID доставки] ASC),
    CONSTRAINT [FK_Доставка_Сотрудник] FOREIGN KEY ([ID сотрудника]) REFERENCES [dbo].[Сотрудник] ([ID сотрудника])
);


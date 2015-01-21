CREATE TABLE [dbo].[ЗаписьНаМерку] (
    [ID мерки]     INT      NOT NULL,
    [ID заказчика] INT      NULL,
    [Дата]         DATE     NULL DEFAULT '01.01.2014',
    [Время]        TIME (7) NULL DEFAULT '00:00',
    PRIMARY KEY CLUSTERED ([ID мерки] ASC),
    CONSTRAINT [FK_ЗаписьНаМерку_Заказчик] FOREIGN KEY ([ID заказчика]) REFERENCES [dbo].[Клиент] ([ID заказчика])
);


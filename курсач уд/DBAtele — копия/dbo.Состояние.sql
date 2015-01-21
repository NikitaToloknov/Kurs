CREATE TABLE [dbo].[Состояние] (
    [ID заказа]  INT           NOT NULL,
    [Примечания] NVARCHAR (50) NULL DEFAULT 'Текст примечания',
    [Состояние]  BIT           NULL DEFAULT 'False',
    PRIMARY KEY CLUSTERED ([ID заказа] ASC),
    CONSTRAINT [FK_Состояние_Заказ] FOREIGN KEY ([ID заказа]) REFERENCES [dbo].[Заказ] ([ID заказа])
);


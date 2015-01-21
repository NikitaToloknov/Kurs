CREATE TABLE [dbo].[Скидка] (
    [Количество заказов] INT NOT NULL,
    [Скидка]             INT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([Количество заказов] ASC)
);


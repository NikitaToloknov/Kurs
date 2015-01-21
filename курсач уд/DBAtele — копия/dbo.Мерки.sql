CREATE TABLE [dbo].[Мерки] (
    [ID мерки]     INT           NOT NULL,
    [Обхват груди] INT           NULL DEFAULT 0,
    [Обхват талии] INT           NULL DEFAULT 0,
    [Обхват бедер] INT           NULL DEFAULT 0,
    [Рост]         INT           NULL DEFAULT 0,
    [Примечания]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID мерки] ASC)
);


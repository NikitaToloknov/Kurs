CREATE TABLE [dbo].[Выкройки] (
    [ID выкройки]   INT        NOT NULL,
    [Модель]        NCHAR (30) NULL DEFAULT 'Описание модели',
    [Схема]         IMAGE NULL,
    [Фото модели]   IMAGE      NULL,
    [ID мерки]      INT        NULL,
    [ID ткани]      INT        NULL,
    [ID аксессуара] INT        NULL,
    PRIMARY KEY CLUSTERED ([ID выкройки] ASC),
    CONSTRAINT [FK_Выкройки_Аксессуар] FOREIGN KEY ([ID аксессуара]) REFERENCES [dbo].[Аксессуары] ([ID аксессуара]),
    CONSTRAINT [FK_Выкройки_Мерки] FOREIGN KEY ([ID мерки]) REFERENCES [dbo].[Мерки] ([ID мерки]),
    CONSTRAINT [FK_Выкройки_Ткани] FOREIGN KEY ([ID ткани]) REFERENCES [dbo].[СкладТканей] ([ID ткани])
);


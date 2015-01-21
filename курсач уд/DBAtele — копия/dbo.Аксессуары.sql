CREATE TABLE [dbo].[Аксессуары] (
    [ID аксессуара]           INT        NOT NULL IDENTITY,
    [Наименование аксессуара] NCHAR (30) DEFAULT ('???????????? ??????????') NULL,
    [Тип]                     NCHAR (30) DEFAULT ('?????????') NULL,
    [Фото]                    IMAGE      NULL,
    PRIMARY KEY CLUSTERED ([ID аксессуара] ASC)
);


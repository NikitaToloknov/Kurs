CREATE TABLE [dbo].[Оборудование] (
    [ID оборудования]           INT        NOT NULL,
    [Наименование оборудования] NCHAR (30) NULL DEFAULT 'Наименование оборудования',
    [Дата приобретения]         DATE       NULL DEFAULT '01.01.2014',
    [Состояние]                 BIT        NULL DEFAULT 'True',
    PRIMARY KEY CLUSTERED ([ID оборудования] ASC)
);


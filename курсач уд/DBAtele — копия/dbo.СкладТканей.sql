CREATE TABLE [dbo].[СкладТканей] (
    [ID ткани]           INT        NOT NULL,
    [Наименование ткани] NCHAR (30) NULL DEFAULT 'Ткань',
    [Количество ]        INT        NULL DEFAULT 0,
    [Состав ткани]       NCHAR (30) NULL DEFAULT 'Состав',
    [Цвет]               NCHAR (30) NULL DEFAULT 'Цвет ткани',
    [Цена]               MONEY      NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([ID ткани] ASC)
);


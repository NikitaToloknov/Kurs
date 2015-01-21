CREATE TABLE [dbo].[СведенияОТканях] (
    [ID ткани]             INT        NOT NULL,
    [Страна производитель] NCHAR (30) NULL DEFAULT 'Страна производитель',
    [Дата изготовления]    DATE       NULL DEFAULT '01.01.2014',
    [Дата привоза]         DATE       NULL DEFAULT '01.01.2014',
    [Покупная цена]        MONEY      NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([ID ткани] ASC)
);


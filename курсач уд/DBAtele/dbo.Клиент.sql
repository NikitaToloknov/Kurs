CREATE TABLE [dbo].[Клиент] (
    [ID заказчика]       INT        NOT NULL,
    [Фамилия]            NCHAR (30) NULL DEFAULT 'Ваша фамилия',
    [Имя]                NCHAR (30) NULL DEFAULT 'Ваше имя',
    [Отчество]           NCHAR (30) NULL DEFAULT 'Ваше отчество',
    [Контактный телефон] INT        NULL DEFAULT 89000000000,
    [E-mail]             NCHAR (30) NULL,
    [Password]           NCHAR (30) NULL,
    [Количество заказов] INT        NULL,
    PRIMARY KEY CLUSTERED ([ID заказчика] ASC), 
    CONSTRAINT [CK_Клиент_КонтактныйТелефонColumn] CHECK ([dbo].[Клиент].[Контактный телефон] LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);


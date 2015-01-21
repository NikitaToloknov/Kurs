CREATE TABLE [dbo].[Сотрудник] (
    [ID сотрудника]         INT        NOT NULL,
    [Фамилия]               NCHAR (30) NULL DEFAULT 'Фамилия',
    [Имя]                   NCHAR (30) NULL DEFAULT 'Имя',
    [Отчество]              NCHAR (30) NULL DEFAULT 'Отчество',
    [Должность]             NCHAR (30) NULL DEFAULT 'Должность сотрудника',
    [Дата приема на работу] DATE       NULL DEFAULT '01.01.2014',
    [Общий стаж]            INT        NULL DEFAULT 0,
    [Стаж]                  INT        NULL DEFAULT 0,
    [Доступ ко всем данным] BIT        NULL DEFAULT 'False',
    [E-mail]                NCHAR (30) NULL DEFAULT 'Почта сотрудника',
    [Password]              NCHAR (30) NULL DEFAULT 'Password',
    PRIMARY KEY CLUSTERED ([ID сотрудника] ASC)
);


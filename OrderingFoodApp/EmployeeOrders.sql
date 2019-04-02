
CREATE DATABASE EmployeeOrders;
GO
USE EmployeeOrders;

--drink
CREATE TABLE [dbo].[Drink] (
    [Id]    INT        IDENTITY (1, 1) NOT NULL,
    [Name]  NCHAR (30) NOT NULL,
    [Price] MONEY      NOT NULL,
    CONSTRAINT [PK_Drinks] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 1)
);
GO
--food
CREATE TABLE [dbo].[Food] (
    [Id]    INT        IDENTITY (1, 1) NOT NULL,
    [Name]  NCHAR (30) NOT NULL,
    [Price] MONEY      NOT NULL,
    CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 1)
);
GO
--order
CREATE TABLE [dbo].[Order] (
    [Id]       INT   IDENTITY (1, 1) NOT NULL,
    [Drink_Id] INT   NULL,
    [Food_Id]  INT   NULL,
    [Total]    MONEY NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 1),
    CONSTRAINT [Fk_Orders_Food] FOREIGN KEY ([Food_Id]) REFERENCES [dbo].[Food] ([Id]),
    CONSTRAINT [Fk_Orders_Drink] FOREIGN KEY ([Drink_Id]) REFERENCES [dbo].[Drink] ([Id])
);
GO
--user
CREATE TABLE [dbo].[User] (
    [Id]           INT         IDENTITY (1, 1) NOT NULL,
    [Name]         NCHAR (50)  NOT NULL,
    [PasswordHash] NCHAR (200) NOT NULL,
    [Department]   NCHAR (40)  NOT NULL,
    [IsAdmin]      BIT         NOT NULL,
    [IsPurchaser]  BIT         NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 1)
);
--user`s order
CREATE TABLE [dbo].[UserOrders] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [User_Id]  INT           NOT NULL,
    [Order_Id] INT           NOT NULL,
    [Date]     DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_UserOrders] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 1),
    CONSTRAINT [Fk_Users_Orders_o] FOREIGN KEY ([Order_Id]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [Fk_Users_Orders_u] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([Id])
);
GO

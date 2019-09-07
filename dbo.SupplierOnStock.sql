CREATE TABLE [dbo].[SupplierOnStock] (
    [SupOnStock_ID] INT IDENTITY (1, 1) NOT NULL,
    [Order_ID]      INT NOT NULL,
    [Sup_ID]        INT NOT NULL,
    [Quantity]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([SupOnStock_ID] ASC),
    FOREIGN KEY ([Order_ID]) REFERENCES [dbo].[Stock_Order] ([Order_Id]),
    FOREIGN KEY ([Sup_ID]) REFERENCES [dbo].[Supplier] ([Sup_ID])
);


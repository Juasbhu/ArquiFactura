﻿CREATE TABLE [dbo].[FACTURA]
(
	[ID_FACTURA] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ID_CLIENTE_FK] INT NOT NULL, 
    [ID_EMPLEADO_FK] INT NOT NULL, 
    [FECHA] DATETIME NOT NULL, 
    CONSTRAINT [FK_FACTURA_ToCLIENTE] FOREIGN KEY ([ID_CLIENTE_FK]) REFERENCES [CLIENTE]([ID_CLIENTE]), 
    CONSTRAINT [FK_FACTURA_ToEMPLEADO] FOREIGN KEY ([ID_EMPLEADO_FK]) REFERENCES [EMPLEADO]([ID_EMPLEADO])
)

GO

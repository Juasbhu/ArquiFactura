﻿CREATE TABLE [dbo].[PRODUCTO]
(
	[CODIGO] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NOMBRE] NVARCHAR(50) NOT NULL, 
    [CANTIDAD] INT NOT NULL, 
    [VALOR_UNITARIO] DECIMAL NOT NULL, 
    [PORCENTAJE_IVA] INT NOT NULL
)

/*
Script de implementación para FACTURA

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FACTURA"
:setvar DefaultFilePrefix "FACTURA"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESSSEBAS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESSSEBAS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 23ff96ed-e119-4954-aa46-5bd60b9bf7b1, 9acb1d27-0f2e-443b-a2f8-71d42edb7428 se ha omitido; no se cambiará el nombre del elemento [dbo].[PRODUCTO].[Id] (SqlSimpleColumn) a CODIGO';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 52d7a42f-b8d5-4e97-82e7-7199276ce35e, 46f4e04c-ae0f-4324-aa16-ebf336a15bf3 se ha omitido; no se cambiará el nombre del elemento [dbo].[D_FACTURA].[Id] (SqlSimpleColumn) a ID_D_FACTURA';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave c6c22c7d-c0f1-46ec-8a54-732f7fc4291f, 0cec1171-68a5-4211-bd32-2b406acec3f4, 134cfd8a-c6b6-4429-8b97-b89c5d22f517 se ha omitido; no se cambiará el nombre del elemento [dbo].[D_FACTURA].[CODIGO] (SqlSimpleColumn) a VALOR_IVA';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 3a70d0fc-c5b4-4317-97a5-a52d657d3b4a se ha omitido; no se cambiará el nombre del elemento [dbo].[FACTURA].[Id] (SqlSimpleColumn) a ID_FACTURA';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 62ddd4f1-94b0-4687-a337-0b8c0096d732 se ha omitido; no se cambiará el nombre del elemento [dbo].[CLIENTE].[Id] (SqlSimpleColumn) a ID_CLIENTE';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave ae5e73da-f398-4abe-b27f-3f8584e89162 se ha omitido; no se cambiará el nombre del elemento [dbo].[CLIENTE].[DIRECCION] (SqlSimpleColumn) a FIJO';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 91828f91-26f7-4f62-a10c-ec8460f9f76f se ha omitido; no se cambiará el nombre del elemento [dbo].[EMPLEADO].[Id] (SqlSimpleColumn) a ID_EMPLEADO';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 6d71daa1-1111-4535-9e38-2118fb2d7191 se ha omitido; no se cambiará el nombre del elemento [dbo].[FACTURA].[ID_EMPLEADO] (SqlSimpleColumn) a ID_EMPLEADO_FK';


GO
PRINT N'La operación de refactorización Cambiar nombre con la clave 274ccbcf-7821-4d6d-acb6-28c4b47bdc45 se ha omitido; no se cambiará el nombre del elemento [dbo].[D_FACTURA].[ID_PRODUCTO_FK ] (SqlSimpleColumn) a ID_PRODUCTO_FK';


GO
PRINT N'Creando [dbo].[CLIENTE]...';


GO
CREATE TABLE [dbo].[CLIENTE] (
    [ID_CLIENTE] INT          NOT NULL,
    [NOMBRE]     VARCHAR (50) NOT NULL,
    [APELLIDO]   VARCHAR (50) NOT NULL,
    [FIJO]       CHAR (10)    NOT NULL,
    [CELULAR]    CHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_CLIENTE] ASC)
);


GO
PRINT N'Creando [dbo].[D_FACTURA]...';


GO
CREATE TABLE [dbo].[D_FACTURA] (
    [ID_D_FACTURA]   INT          IDENTITY (1, 1) NOT NULL,
    [ID_FACTURA_FK]  INT          NOT NULL,
    [CANTIDAD]       INT          NOT NULL,
    [VALOR_IVA]      DECIMAL (18) NOT NULL,
    [SUBTOTAL]       DECIMAL (18) NOT NULL,
    [ID_PRODUCTO_FK] INT          NOT NULL,
    CONSTRAINT [PK_D_FACTURA] PRIMARY KEY CLUSTERED ([ID_D_FACTURA] ASC)
);


GO
PRINT N'Creando [dbo].[EMPLEADO]...';


GO
CREATE TABLE [dbo].[EMPLEADO] (
    [ID_EMPLEADO] INT          IDENTITY (1, 1) NOT NULL,
    [NOMBRE]      VARCHAR (50) NOT NULL,
    [APELLIDO]    VARCHAR (50) NOT NULL,
    [DIRECCION]   VARCHAR (50) NOT NULL,
    [CARGO]       VARCHAR (20) NOT NULL,
    [FIJO]        CHAR (10)    NOT NULL,
    [CELULAR]     CHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_EMPLEADO] ASC)
);


GO
PRINT N'Creando [dbo].[FACTURA]...';


GO
CREATE TABLE [dbo].[FACTURA] (
    [ID_FACTURA]     INT IDENTITY (1, 1) NOT NULL,
    [ID_CLIENTE_FK]  INT NOT NULL,
    [ID_EMPLEADO_FK] INT NOT NULL,
    [FECHA]          INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_FACTURA] ASC)
);


GO
PRINT N'Creando [dbo].[PRODUCTO]...';


GO
CREATE TABLE [dbo].[PRODUCTO] (
    [CODIGO]         INT           IDENTITY (1, 1) NOT NULL,
    [NOMBRE]         NVARCHAR (50) NOT NULL,
    [CANTIDAD]       INT           NOT NULL,
    [VALOR_UNITARIO] DECIMAL (18)  NOT NULL,
    [PORCENTAJE_IVA] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CODIGO] ASC)
);


GO
PRINT N'Creando [dbo].[FK_D_FACTURA_ToFACTURA]...';


GO
ALTER TABLE [dbo].[D_FACTURA] WITH NOCHECK
    ADD CONSTRAINT [FK_D_FACTURA_ToFACTURA] FOREIGN KEY ([ID_FACTURA_FK]) REFERENCES [dbo].[FACTURA] ([ID_FACTURA]);


GO
PRINT N'Creando [dbo].[FK_D_FACTURA_ToPRODUCTO]...';


GO
ALTER TABLE [dbo].[D_FACTURA] WITH NOCHECK
    ADD CONSTRAINT [FK_D_FACTURA_ToPRODUCTO] FOREIGN KEY ([ID_PRODUCTO_FK]) REFERENCES [dbo].[PRODUCTO] ([CODIGO]);


GO
PRINT N'Creando [dbo].[FK_FACTURA_ToCLIENTE]...';


GO
ALTER TABLE [dbo].[FACTURA] WITH NOCHECK
    ADD CONSTRAINT [FK_FACTURA_ToCLIENTE] FOREIGN KEY ([ID_CLIENTE_FK]) REFERENCES [dbo].[CLIENTE] ([ID_CLIENTE]);


GO
PRINT N'Creando [dbo].[FK_FACTURA_ToEMPLEADO]...';


GO
ALTER TABLE [dbo].[FACTURA] WITH NOCHECK
    ADD CONSTRAINT [FK_FACTURA_ToEMPLEADO] FOREIGN KEY ([ID_EMPLEADO_FK]) REFERENCES [dbo].[EMPLEADO] ([ID_EMPLEADO]);


GO
-- Paso de refactorización para actualizar el servidor de destino con los registros de transacciones implementadas

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '23ff96ed-e119-4954-aa46-5bd60b9bf7b1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('23ff96ed-e119-4954-aa46-5bd60b9bf7b1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '9acb1d27-0f2e-443b-a2f8-71d42edb7428')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('9acb1d27-0f2e-443b-a2f8-71d42edb7428')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '52d7a42f-b8d5-4e97-82e7-7199276ce35e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('52d7a42f-b8d5-4e97-82e7-7199276ce35e')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c6c22c7d-c0f1-46ec-8a54-732f7fc4291f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c6c22c7d-c0f1-46ec-8a54-732f7fc4291f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '0cec1171-68a5-4211-bd32-2b406acec3f4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('0cec1171-68a5-4211-bd32-2b406acec3f4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '134cfd8a-c6b6-4429-8b97-b89c5d22f517')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('134cfd8a-c6b6-4429-8b97-b89c5d22f517')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '46f4e04c-ae0f-4324-aa16-ebf336a15bf3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('46f4e04c-ae0f-4324-aa16-ebf336a15bf3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '6a83a25a-3e90-4c51-9ec9-dc184fd5106f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('6a83a25a-3e90-4c51-9ec9-dc184fd5106f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '30736d57-a449-49a9-8952-be31a76330ab')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('30736d57-a449-49a9-8952-be31a76330ab')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '3a70d0fc-c5b4-4317-97a5-a52d657d3b4a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('3a70d0fc-c5b4-4317-97a5-a52d657d3b4a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '62ddd4f1-94b0-4687-a337-0b8c0096d732')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('62ddd4f1-94b0-4687-a337-0b8c0096d732')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ae5e73da-f398-4abe-b27f-3f8584e89162')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ae5e73da-f398-4abe-b27f-3f8584e89162')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '91828f91-26f7-4f62-a10c-ec8460f9f76f')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('91828f91-26f7-4f62-a10c-ec8460f9f76f')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '6d71daa1-1111-4535-9e38-2118fb2d7191')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('6d71daa1-1111-4535-9e38-2118fb2d7191')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '274ccbcf-7821-4d6d-acb6-28c4b47bdc45')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('274ccbcf-7821-4d6d-acb6-28c4b47bdc45')

GO

GO
PRINT N'Comprobando los datos existentes con las restricciones recién creadas';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[D_FACTURA] WITH CHECK CHECK CONSTRAINT [FK_D_FACTURA_ToFACTURA];

ALTER TABLE [dbo].[D_FACTURA] WITH CHECK CHECK CONSTRAINT [FK_D_FACTURA_ToPRODUCTO];

ALTER TABLE [dbo].[FACTURA] WITH CHECK CHECK CONSTRAINT [FK_FACTURA_ToCLIENTE];

ALTER TABLE [dbo].[FACTURA] WITH CHECK CHECK CONSTRAINT [FK_FACTURA_ToEMPLEADO];


GO
PRINT N'Actualización completada.';


GO

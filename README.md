# CoreWebApi
Core 3.0 c# 8.0 web api application

Hi guys,

First of need data. Example db name d1;
TestTable t-sql ;

USE [d1]
GO


CREATE TABLE [dbo].[TestTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Il_ad] [varchar](50) NULL,
	[Hava_Durumu] [varchar](150) NULL,
	[aktif] [bit] NULL,
	[create_date] [datetime] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_TestTable_aktif]  DEFAULT ((1)) FOR [aktif]
GO

ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_WebApiTest_Table_create_date]  DEFAULT (getdate()) FOR [create_date]
GO



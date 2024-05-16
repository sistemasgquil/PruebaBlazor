create database blazortest
--DESKTOP-FTFNV0M\MSSQLSERVER2014
use blazortest 

GO


create table Departamentos
(
codDepto varchar(4) primary key
,nombreDpto varchar(20)
,ciudad varchar(15)
,codDirector varchar(12)
)

/****** Object:  Table [dbo].[Empleado]    Script Date: 14/5/2024 15:41:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO


CREATE TABLE [dbo].[Empleado](
	nDimemp varchar(12),
	nomEmp varchar(30) NOT NULL,
	sexEmp char(1) NOT NULL,
	FecNac DateTime NOT NULL, --Date
	salEmp float NOT NULL,
	comisionE float NOT NULL,
	cargoE varchar(15) NOT NULL,
	jefeID varchar(12) NOT NULL,
	codDepto varchar(4)
PRIMARY KEY CLUSTERED 
(
	nDimemp ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([codDepto])
REFERENCES [dbo].[Departamentos] ([codDepto])
GO


select * from Departamentos
select * from Empleado

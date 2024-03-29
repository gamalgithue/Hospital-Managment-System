USE [HospitalSystem]
GO
/****** Object:  Table [dbo].[DoctorsTbl]    Script Date: 12/3/2023 12:05:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorsTbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DocName] [varchar](255) NULL,
	[yearsofexprience] [int] NULL,
	[age] [int] NULL,
	[contactphone] [varchar](40) NULL,
	[address] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

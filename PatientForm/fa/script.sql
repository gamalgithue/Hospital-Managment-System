USE [HospitalSystem]
GO
/****** Object:  Table [dbo].[DoctorsTbl]    Script Date: 12/3/2023 7:29:07 PM ******/
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
/****** Object:  Table [dbo].[PatientTbl]    Script Date: 12/3/2023 7:29:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientTbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Contact] [nvarchar](50) NULL,
	[Blood] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Symptom] [nvarchar](50) NULL,
	[DoctorId] [int] NULL,
 CONSTRAINT [PK_PatientTbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PatientTbl]  WITH CHECK ADD  CONSTRAINT [FK_PatientTbl_DoctorsTbl1] FOREIGN KEY([DoctorId])
REFERENCES [dbo].[DoctorsTbl] ([id])
GO
ALTER TABLE [dbo].[PatientTbl] CHECK CONSTRAINT [FK_PatientTbl_DoctorsTbl1]
GO

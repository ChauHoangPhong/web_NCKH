USE [WebNCKH_Demo]
GO
/****** Object:  Table [dbo].[tb_Achievements]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Achievements](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AchievementsDateID] [int] NULL,
	[AchievementsCategoryID] [int] NULL,
	[Details] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Achievements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_AchievementsCategory]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_AchievementsCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_AchievementsCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_AchievementsDate]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_AchievementsDate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_AchievementsDate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Adv]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Adv](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[Type] [int] NULL,
	[Link] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Adv] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Category]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Description] [nvarchar](4000) NULL,
	[Position] [int] NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[SeoDescription] [nvarchar](550) NULL,
	[SeoKeywords] [nvarchar](550) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_LocationCategory]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_LocationCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_LocationCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Member]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[LocationCategoryID] [int] NULL,
	[Description] [nvarchar](4000) NULL,
	[Detail] [nvarchar](max) NULL,
	[Link] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_New]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_New](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Category] [int] NULL,
	[Description] [nvarchar](4000) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](500) NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[SeoDescription] [nvarchar](550) NULL,
	[SeoKeywords] [nvarchar](550) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_New] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Projects]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[Description] [nvarchar](4000) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](500) NULL,
	[Link] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Recruitment]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Recruitment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[Details] [nvarchar](max) NULL,
	[image] [nvarchar](500) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Recruitment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SystemSetting]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SystemSetting](
	[SettingKey] [nvarchar](50) NOT NULL,
	[SettingValue] [nvarchar](max) NULL,
	[SettingDescription] [nvarchar](250) NULL,
 CONSTRAINT [PK_tb_SystemSetting] PRIMARY KEY CLUSTERED 
(
	[SettingKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TopicCategory]    Script Date: 8/17/2023 7:06:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TopicCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Description] [nvarchar](4000) NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedrDate] [datetime] NULL,
	[ModifierBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_TopicCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

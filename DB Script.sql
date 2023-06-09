-- Create a database named HotelBookingDB in the server first, then run the srcipt
USE [HotelBookingDB]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[GuestId] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BookingDetail]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingDetail](
	[BookingDetailId] [int] IDENTITY(1,1) NOT NULL,
	[BookingId] [int] NULL,
	[RoomId] [int] NULL,
	[DateFrom] [datetime] NULL,
	[DateTo] [datetime] NULL,
	[IsActive] [bit] NULL,
	[BookingStatusId] [int] NULL,
 CONSTRAINT [PK_BookingDetail] PRIMARY KEY CLUSTERED 
(
	[BookingDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BookingStatus]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookingStatus](
	[BookingStatusId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_BookingStatus] PRIMARY KEY CLUSTERED 
(
	[BookingStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cities](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CountryId] [int] NULL,
	[Name] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comment](
	[CommentId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](1000) NULL,
	[GuestId] [int] NULL,
	[StaffId] [int] NULL,
	[CommentTime] [datetime] NULL,
	[HotelId] [int] NULL,
	[IsDeleted] [bit] NULL,
	[UserReview] [int] NULL,
	[ParentKey] [int] NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Guest](
	[GuestId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[City] [int] NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Email] [varchar](30) NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[GuestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hotel](
	[HotelID] [int] IDENTITY(1,1) NOT NULL,
	[HotelCode] [nchar](10) NULL,
	[Name] [varchar](80) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [int] NULL,
	[Phone] [varchar](50) NULL,
	[Website] [varchar](50) NULL,
	[ImagePath] [varchar](300) NULL,
	[RatingId] [int] NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[HotelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Position]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Position](
	[PositionId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[IsActive] [bit] NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingId] [int] IDENTITY(1,1) NOT NULL,
	[Value] [int] NULL,
	[Description] [varchar](10) NULL,
 CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED 
(
	[RatingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[RoomTypeId] [int] NULL,
	[RoomNumber] [varchar](10) NULL,
	[Description] [varchar](100) NULL,
	[RoomStatus] [bit] NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoomType](
	[RoomTypeId] [int] IDENTITY(1,1) NOT NULL,
	[RoomDetail] [varchar](20) NULL,
	[Description] [varchar](100) NULL,
	[NumberOfRooms] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 5/21/2023 7:29:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[PositionId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[City] [int] NULL,
	[Country] [int] NULL,
	[Phone] [varchar](15) NULL,
	[Email] [varchar](30) NULL,
	[JoinDate] [datetime] NULL,
	[ResignDate] [datetime] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingId], [HotelId], [GuestId], [IsActive]) VALUES (1, 1, 1, 1)
INSERT [dbo].[Booking] ([BookingId], [HotelId], [GuestId], [IsActive]) VALUES (3, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[BookingDetail] ON 

INSERT [dbo].[BookingDetail] ([BookingDetailId], [BookingId], [RoomId], [DateFrom], [DateTo], [IsActive], [BookingStatusId]) VALUES (1, 3, 1, CAST(N'2023-05-21 03:47:46.640' AS DateTime), CAST(N'2023-05-21 03:47:46.640' AS DateTime), 1, 2)
INSERT [dbo].[BookingDetail] ([BookingDetailId], [BookingId], [RoomId], [DateFrom], [DateTo], [IsActive], [BookingStatusId]) VALUES (2, 3, 3, CAST(N'2023-05-21 03:47:46.640' AS DateTime), CAST(N'2023-05-21 03:47:46.640' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[BookingDetail] OFF
SET IDENTITY_INSERT [dbo].[BookingStatus] ON 

INSERT [dbo].[BookingStatus] ([BookingStatusId], [Description], [IsActive]) VALUES (1, N'Booked without pay', 1)
INSERT [dbo].[BookingStatus] ([BookingStatusId], [Description], [IsActive]) VALUES (2, N'Partially Paid', 1)
INSERT [dbo].[BookingStatus] ([BookingStatusId], [Description], [IsActive]) VALUES (3, N'Fully Paid', 1)
SET IDENTITY_INSERT [dbo].[BookingStatus] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (1, 1, N'Dhaka', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (2, 1, N'Sylhet', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (3, 1, N'Cox''s Bazar', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (4, 2, N'Delhi', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (5, 2, N'Kolkata', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (6, 2, N'Ahmedabad', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (7, 3, N'Khatmundu', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (8, 3, N'Pokhra', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (9, 3, N'Thamel', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (10, 4, N'Thimpu', 1)
INSERT [dbo].[Cities] ([CityId], [CountryId], [Name], [IsActive]) VALUES (11, 1, N'Gazipur', 1)
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([CommentId], [Description], [GuestId], [StaffId], [CommentTime], [HotelId], [IsDeleted], [UserReview], [ParentKey]) VALUES (5, N'hellow', 1, NULL, CAST(N'2023-05-19 16:47:45.587' AS DateTime), 1, 1, 3, NULL)
INSERT [dbo].[Comment] ([CommentId], [Description], [GuestId], [StaffId], [CommentTime], [HotelId], [IsDeleted], [UserReview], [ParentKey]) VALUES (6, N'Service was great, food was good, pricing was a bit on the higher side. Overall experience is good', 1, NULL, CAST(N'2023-05-19 16:48:56.923' AS DateTime), 1, 0, 6, NULL)
INSERT [dbo].[Comment] ([CommentId], [Description], [GuestId], [StaffId], [CommentTime], [HotelId], [IsDeleted], [UserReview], [ParentKey]) VALUES (9, N'fabulous', 1, 0, CAST(N'2023-05-21 11:43:23.020' AS DateTime), 1, NULL, 1, NULL)
INSERT [dbo].[Comment] ([CommentId], [Description], [GuestId], [StaffId], [CommentTime], [HotelId], [IsDeleted], [UserReview], [ParentKey]) VALUES (18, N'Thank you for staying with us, hoping to see you soon', NULL, 1, CAST(N'2023-05-21 11:58:55.370' AS DateTime), 1, NULL, 1, 9)
INSERT [dbo].[Comment] ([CommentId], [Description], [GuestId], [StaffId], [CommentTime], [HotelId], [IsDeleted], [UserReview], [ParentKey]) VALUES (19, N'Glad to make this choice, highly recommended', 1, NULL, CAST(N'2023-05-21 12:00:17.457' AS DateTime), 1, NULL, 1, 18)
INSERT [dbo].[Comment] ([CommentId], [Description], [GuestId], [StaffId], [CommentTime], [HotelId], [IsDeleted], [UserReview], [ParentKey]) VALUES (20, N'COMPLETE SCAM', 2, NULL, CAST(N'2023-05-21 12:01:06.933' AS DateTime), 1, NULL, 1, 9)
SET IDENTITY_INSERT [dbo].[Comment] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryId], [Name], [IsActive]) VALUES (1, N'Bangladesh', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [IsActive]) VALUES (2, N'India', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [IsActive]) VALUES (3, N'Nepal', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [IsActive]) VALUES (4, N'Bhutan', 1)
INSERT [dbo].[Country] ([CountryId], [Name], [IsActive]) VALUES (5, N'Maldives', 1)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Guest] ON 

INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [City], [PhoneNumber], [Email]) VALUES (1, N'Sabbir', N'Ahmed', N'Mohammadpur', 1, N'01312786854', N'hire@sabbirahmed.net')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [City], [PhoneNumber], [Email]) VALUES (2, N'John', N'Doe', N'Main avenue', 10, N'01234567890', N'jhondoe@gmail.com')
INSERT [dbo].[Guest] ([GuestId], [FirstName], [LastName], [Address], [City], [PhoneNumber], [Email]) VALUES (3, N'Humayun', N'Ahmed', N'Gazipur, NuhashPalli', 11, N'01234567899', N'nuhash@gamil.com')
SET IDENTITY_INSERT [dbo].[Guest] OFF
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([HotelID], [HotelCode], [Name], [Address], [City], [Phone], [Website], [ImagePath], [RatingId]) VALUES (1, N'12345     ', N'Westin', N'Gulshan 2', 1, N'01234567890', N'www.westin.com', NULL, 4)
INSERT [dbo].[Hotel] ([HotelID], [HotelCode], [Name], [Address], [City], [Phone], [Website], [ImagePath], [RatingId]) VALUES (2, N'1         ', N'Khulna', NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Hotel] ([HotelID], [HotelCode], [Name], [Address], [City], [Phone], [Website], [ImagePath], [RatingId]) VALUES (3, NULL, N'Regency', N'Sub street', 9, N'01234567890', N'www.regency.com', NULL, 3)
INSERT [dbo].[Hotel] ([HotelID], [HotelCode], [Name], [Address], [City], [Phone], [Website], [ImagePath], [RatingId]) VALUES (4, NULL, N'Mariott', N'King Street', 10, N'01234567890', N'www.mariott.com', NULL, 3)
INSERT [dbo].[Hotel] ([HotelID], [HotelCode], [Name], [Address], [City], [Phone], [Website], [ImagePath], [RatingId]) VALUES (5, NULL, N'Pan Pacific', NULL, NULL, NULL, NULL, NULL, 5)
INSERT [dbo].[Hotel] ([HotelID], [HotelCode], [Name], [Address], [City], [Phone], [Website], [ImagePath], [RatingId]) VALUES (6, N'1226      ', N'Le Meridian', N'Khilkhet', 1, N'98765432101', N'www.lem.com', NULL, 4)
SET IDENTITY_INSERT [dbo].[Hotel] OFF
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (1, N'Manager', 1, 1)
INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (2, N'Concierge', 1, 1)
INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (3, N'Chef', 1, NULL)
INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (4, N'Cook', 1, NULL)
INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (5, N'Cleaner', 1, NULL)
INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (6, N'Room Service', 1, NULL)
INSERT [dbo].[Position] ([PositionId], [Name], [IsActive], [IsAdmin]) VALUES (7, N'Receptionist', 1, NULL)
SET IDENTITY_INSERT [dbo].[Position] OFF
SET IDENTITY_INSERT [dbo].[Rating] ON 

INSERT [dbo].[Rating] ([RatingId], [Value], [Description]) VALUES (1, 1, N'1 Star')
INSERT [dbo].[Rating] ([RatingId], [Value], [Description]) VALUES (2, 2, N'2 Star')
INSERT [dbo].[Rating] ([RatingId], [Value], [Description]) VALUES (3, 3, N'3 Star')
INSERT [dbo].[Rating] ([RatingId], [Value], [Description]) VALUES (4, 4, N'4 Star')
INSERT [dbo].[Rating] ([RatingId], [Value], [Description]) VALUES (5, 5, N'5 Star')
INSERT [dbo].[Rating] ([RatingId], [Value], [Description]) VALUES (6, 0, N'Unrated')
SET IDENTITY_INSERT [dbo].[Rating] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (1, 1, 1, N'101', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (2, 1, 1, N'102', N'Scenic view from south', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (3, 1, 2, N'201', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (4, 1, 2, N'202', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (5, 1, 3, N'301', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (6, 1, 3, N'302', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (7, 1, 4, N'401', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (8, 1, 4, N'402', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (9, 2, 1, N'101', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (10, 2, 1, N'102', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (11, 2, 2, N'201', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (12, 2, 2, N'202', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (13, 2, 3, N'301', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (14, 2, 3, N'302', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (15, 2, 4, N'401', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (16, 2, 4, N'402', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (17, 3, 1, N'101', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (18, 3, 1, N'101', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (19, 3, 2, N'201', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (20, 3, 2, N'202', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (21, 3, 3, N'301', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (22, 3, 3, N'302', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (23, 3, 4, N'401', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (24, 3, 4, N'402', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (25, 4, 1, N'101', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (26, 4, 1, N'102', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (27, 4, 2, N'201', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (28, 4, 2, N'202', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (29, 4, 3, N'301', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (30, 4, 3, N'302', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (31, 4, 4, N'401', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (32, 4, 4, N'402', N'Scenic view from west', 1)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (33, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Room] ([RoomId], [HotelId], [RoomTypeId], [RoomNumber], [Description], [RoomStatus]) VALUES (34, NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[RoomType] ON 

INSERT [dbo].[RoomType] ([RoomTypeId], [RoomDetail], [Description], [NumberOfRooms], [IsActive]) VALUES (1, N'Single', N'Single bed, toilet', 1, 1)
INSERT [dbo].[RoomType] ([RoomTypeId], [RoomDetail], [Description], [NumberOfRooms], [IsActive]) VALUES (2, N'Double', N'Double bed, toilet, balcony', 1, 1)
INSERT [dbo].[RoomType] ([RoomTypeId], [RoomDetail], [Description], [NumberOfRooms], [IsActive]) VALUES (3, N'Deluxe', N'Double bed, toilet, balcony, smoking zone', 1, 1)
INSERT [dbo].[RoomType] ([RoomTypeId], [RoomDetail], [Description], [NumberOfRooms], [IsActive]) VALUES (4, N'Suite', N'Three rooms, three double beds, three toilets, common space', 3, 1)
SET IDENTITY_INSERT [dbo].[RoomType] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffId], [HotelId], [PositionId], [FirstName], [LastName], [Address], [City], [Country], [Phone], [Email], [JoinDate], [ResignDate]) VALUES (1, 1, 1, N'Bruce', N'Wayne', N'Gotham City', 1, 1, N'1234567891', N'batman@dc.com', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Staff] OFF
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetail_Booking] FOREIGN KEY([BookingId])
REFERENCES [dbo].[Booking] ([BookingId])
GO
ALTER TABLE [dbo].[BookingDetail] CHECK CONSTRAINT [FK_BookingDetail_Booking]
GO
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetail_BookingStatus] FOREIGN KEY([BookingStatusId])
REFERENCES [dbo].[BookingStatus] ([BookingStatusId])
GO
ALTER TABLE [dbo].[BookingDetail] CHECK CONSTRAINT [FK_BookingDetail_BookingStatus]
GO
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetail_Rooms] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[BookingDetail] CHECK CONSTRAINT [FK_BookingDetail_Rooms]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Country]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Comment1] FOREIGN KEY([ParentKey])
REFERENCES [dbo].[Comment] ([CommentId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Comment1]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Guest] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guest] ([GuestId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Guest]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([HotelID])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Hotel]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Ratings] FOREIGN KEY([UserReview])
REFERENCES [dbo].[Rating] ([RatingId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Ratings]
GO
ALTER TABLE [dbo].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Rating] FOREIGN KEY([RatingId])
REFERENCES [dbo].[Rating] ([RatingId])
GO
ALTER TABLE [dbo].[Hotel] CHECK CONSTRAINT [FK_Hotel_Rating]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_Rooms] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([HotelID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Rooms_Rooms]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomType] ([RoomTypeId])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Rooms_RoomTypes]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Cities] FOREIGN KEY([City])
REFERENCES [dbo].[Cities] ([CityId])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Cities]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([HotelID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Hotel]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Position] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Position] ([PositionId])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Position]
GO
USE [master]
GO
ALTER DATABASE [HotelBookingDB] SET  READ_WRITE 
GO

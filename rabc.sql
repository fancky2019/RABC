USE [ClearAPEXDB]
GO
/****** Object:  Table [dbo].[Authorities]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Authorities](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MenuID] [int] NULL,
	[Name] [varchar](100) NOT NULL,
	[Remark] [varchar](500) NULL,
 CONSTRAINT [PK_AUTHORITIES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Menus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[FormName] [varchar](50) NOT NULL,
	[TabHeaderText] [varchar](50) NOT NULL,
	[SortCode] [int] NULL,
	[Remark] [varchar](500) NULL,
	[Status] [smallint] NOT NULL,
 CONSTRAINT [PK_MENUS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoleMenuAuthorities]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleMenuAuthorities](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AuthorityID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
 CONSTRAINT [PK_ROLEMENUAUTHORITIES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoleMenus]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleMenus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
 CONSTRAINT [PK_ROLEMENUS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[Remark] [varchar](500) NULL,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_USERROLES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2018-5-11 9:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Account] [varchar](20) NOT NULL,
	[Password] [varchar](16) NOT NULL,
	[Status] [smallint] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[ModityTime] [datetime] NOT NULL,
	[TimeStamp] [timestamp] NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Authorities] ON 

INSERT [dbo].[Authorities] ([ID], [MenuID], [Name], [Remark]) VALUES (25, 33, N'Add', NULL)
SET IDENTITY_INSERT [dbo].[Authorities] OFF
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (1, 0, N'Static Config', N'Static Config', 100, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (2, 1, N'frmExchangeInformation', N'Exchange', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (3, 1, N'frmProductInformation', N'Product', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (4, 1, N'frmContractInformation', N'Contract', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (5, 1, N'frmExchangeFeeEnquiry', N'Exchange Fee', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (6, 0, N'frmRiskMonitoring', N'Risk Monitoring', 600, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (7, 0, N'Account Management', N'Account Management', 700, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (8, 7, N'frmFIRMInformation', N'Firm', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (9, 7, N'frmAccountInformation', N'Position Account', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (10, 7, N'frmClearingClient', N'Legal Name', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (11, 7, N'frmTraderInformation', N'Beneficial Owner', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (12, 7, N'frmTAG50Information', N'BizUnit', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (13, 0, N'Operation', N'Operation', 1300, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (14, 13, N'frmTradeCaptureEnquiry', N'Trade Enquiry', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (15, 13, N'frmCloseoutEnquiry', N'Closeout Enquiry', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (16, 13, N'frmDepositAndWithdraw', N'Journal Entry', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (17, 13, N'frmSettlementPrice', N'Settlement Price', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (18, 13, N'frmExchangeRate', N'Exchange Rate', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (19, 13, N'frmFileManagement', N'Clearing Report', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (20, 0, N'Reconciliation', N'Reconciliation', 2000, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (21, 20, N'frmClientReconciliation', N'Client Reconciliation', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (22, 0, N'System Admin', N'System Admin', 2200, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (23, 22, N'frmReferenceManagement', N'Reference Management', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (24, 22, N'frmSystemMonitoring', N'System Monitoring', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (25, 0, N'FrmUserManagement', N'User Management', 2500, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (26, 25, N'FrmUserManagement', N'User', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (27, 25, N'FrmRoleManagement', N'Role Management', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (28, 25, N'FrmDistributeUserRoles', N'Distribute User Roles', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (29, 25, N'FrmDistributeRoleMenus', N'Distribute Role Menus', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (30, 25, N'FrmDistributeRoleMenuAuthorities', N'Distribute Role Menu Authorities', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (31, 20, N'frmTradeReconciliation', N'Trade Reconciliation', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (32, 25, N'FrmAuthoritiesManagement', N'Authority Management', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (33, 25, N'Form1', N'Form1', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (34, 13, N'frmPositionTransfer', N'Position Transfer', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (35, 25, N'FrmMenuManagement', N'Menu Management', NULL, NULL, 1)
INSERT [dbo].[Menus] ([ID], [ParentID], [FormName], [TabHeaderText], [SortCode], [Remark], [Status]) VALUES (36, 13, N'frmTransferIn', N'Transfer In', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Menus] OFF
SET IDENTITY_INSERT [dbo].[RoleMenus] ON 

INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (182, 1, 1)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (162, 1, 2)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (163, 1, 3)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (164, 1, 4)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (165, 1, 5)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (183, 1, 6)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (184, 1, 7)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (166, 1, 8)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (167, 1, 9)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (168, 1, 10)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (169, 1, 11)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (170, 1, 12)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (185, 1, 13)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (171, 1, 14)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (172, 1, 15)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (173, 1, 16)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (174, 1, 17)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (175, 1, 18)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (176, 1, 19)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (186, 1, 20)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (178, 1, 21)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (187, 1, 22)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (180, 1, 23)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (181, 1, 24)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (179, 1, 31)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (177, 1, 34)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (2, 2, 1)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (6, 2, 2)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (10, 2, 3)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (14, 2, 4)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (18, 2, 5)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (22, 2, 6)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (26, 2, 7)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (30, 2, 8)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (34, 2, 9)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (38, 2, 10)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (42, 2, 11)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (46, 2, 12)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (50, 2, 13)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (54, 2, 14)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (58, 2, 15)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (62, 2, 16)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (66, 2, 17)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (70, 2, 18)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (74, 2, 19)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (78, 2, 20)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (82, 2, 21)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (86, 2, 22)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (90, 2, 23)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (94, 2, 24)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (98, 2, 25)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (102, 2, 26)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (106, 2, 27)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (110, 2, 28)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (114, 2, 29)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (118, 2, 30)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (122, 2, 31)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (126, 2, 32)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (130, 2, 33)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (134, 2, 34)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (138, 2, 35)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (188, 2, 36)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (210, 14, 1)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (206, 14, 2)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (207, 14, 3)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (208, 14, 4)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (209, 14, 5)
INSERT [dbo].[RoleMenus] ([ID], [RoleID], [MenuID]) VALUES (211, 14, 6)
SET IDENTITY_INSERT [dbo].[RoleMenus] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([ID], [Name], [CreateTime], [Remark]) VALUES (1, N'user', CAST(0x0000A8CF00E69631 AS DateTime), NULL)
INSERT [dbo].[Roles] ([ID], [Name], [CreateTime], [Remark]) VALUES (2, N'admin', CAST(0x0000A8CF00E6CBDE AS DateTime), NULL)
INSERT [dbo].[Roles] ([ID], [Name], [CreateTime], [Remark]) VALUES (14, N'TestRole', CAST(0x0000A8DC012F4C33 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([ID], [UserID], [RoleID]) VALUES (7, 1, 1)
INSERT [dbo].[UserRoles] ([ID], [UserID], [RoleID]) VALUES (2, 2, 2)
INSERT [dbo].[UserRoles] ([ID], [UserID], [RoleID]) VALUES (18, 23, 1)
INSERT [dbo].[UserRoles] ([ID], [UserID], [RoleID]) VALUES (22, 24, 14)
INSERT [dbo].[UserRoles] ([ID], [UserID], [RoleID]) VALUES (19, 25, 1)
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (1, N'UserTest', N'123456', 1, CAST(0x0000A8CF00000000 AS DateTime), CAST(0x0000A8CF00000000 AS DateTime))
INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (2, N'admin', N'123456', 1, CAST(0x0000A8CF00000000 AS DateTime), CAST(0x0000A8CF00000000 AS DateTime))
INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (21, N'1221', N'tt', 1, CAST(0x0000A8D0012FA52A AS DateTime), CAST(0x0000A8D0012FA52A AS DateTime))
INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (22, N'3223trrt', N'22', 1, CAST(0x0000A8D00130AF43 AS DateTime), CAST(0x0000A8D00130AF43 AS DateTime))
INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (23, N'UserTest', N'123456', 1, CAST(0x0000A8D201356542 AS DateTime), CAST(0x0000A8D201356542 AS DateTime))
INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (24, N'Test', N'123', 1, CAST(0x0000A8D600F87A0B AS DateTime), CAST(0x0000A8D600F87A0B AS DateTime))
INSERT [dbo].[Users] ([ID], [Account], [Password], [Status], [CreateTime], [ModityTime]) VALUES (25, N'fancky', N'123456', 1, CAST(0x0000A8DC01088F8E AS DateTime), CAST(0x0000A8DC01088F8E AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [Constraint_MenuIDName]    Script Date: 2018-5-11 9:55:10 ******/
ALTER TABLE [dbo].[Authorities] ADD  CONSTRAINT [Constraint_MenuIDName] UNIQUE NONCLUSTERED 
(
	[MenuID] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Constraint_RoleIDMenuIDAuthorityID]    Script Date: 2018-5-11 9:55:10 ******/
ALTER TABLE [dbo].[RoleMenuAuthorities] ADD  CONSTRAINT [Constraint_RoleIDMenuIDAuthorityID] UNIQUE NONCLUSTERED 
(
	[AuthorityID] ASC,
	[RoleID] ASC,
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Constraint_RoleMenus]    Script Date: 2018-5-11 9:55:10 ******/
ALTER TABLE [dbo].[RoleMenus] ADD  CONSTRAINT [Constraint_RoleMenus] UNIQUE NONCLUSTERED 
(
	[RoleID] ASC,
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Constraint_UserRoles]    Script Date: 2018-5-11 9:55:10 ******/
ALTER TABLE [dbo].[UserRoles] ADD  CONSTRAINT [Constraint_UserRoles] UNIQUE NONCLUSTERED 
(
	[UserID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF__Menus__ParentID__59063A47]  DEFAULT ((0)) FOR [ParentID]
GO
ALTER TABLE [dbo].[Menus] ADD  CONSTRAINT [DF_Menus_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [ModityTime]
GO
ALTER TABLE [dbo].[Authorities]  WITH CHECK ADD  CONSTRAINT [FK_Authorities_Menus] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menus] ([ID])
GO
ALTER TABLE [dbo].[Authorities] CHECK CONSTRAINT [FK_Authorities_Menus]
GO
ALTER TABLE [dbo].[RoleMenuAuthorities]  WITH CHECK ADD  CONSTRAINT [FK_ROLEMENU_REFERENCE_AUTHORIT] FOREIGN KEY([AuthorityID])
REFERENCES [dbo].[Authorities] ([ID])
GO
ALTER TABLE [dbo].[RoleMenuAuthorities] CHECK CONSTRAINT [FK_ROLEMENU_REFERENCE_AUTHORIT]
GO
ALTER TABLE [dbo].[RoleMenuAuthorities]  WITH CHECK ADD  CONSTRAINT [FK_RoleMenuAuthorities_Menus] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menus] ([ID])
GO
ALTER TABLE [dbo].[RoleMenuAuthorities] CHECK CONSTRAINT [FK_RoleMenuAuthorities_Menus]
GO
ALTER TABLE [dbo].[RoleMenuAuthorities]  WITH CHECK ADD  CONSTRAINT [FK_RoleMenuAuthorities_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[RoleMenuAuthorities] CHECK CONSTRAINT [FK_RoleMenuAuthorities_Roles]
GO
ALTER TABLE [dbo].[RoleMenus]  WITH CHECK ADD  CONSTRAINT [FK_ROLEMENU_REFERENCE_MENUS] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menus] ([ID])
GO
ALTER TABLE [dbo].[RoleMenus] CHECK CONSTRAINT [FK_ROLEMENU_REFERENCE_MENUS]
GO
ALTER TABLE [dbo].[RoleMenus]  WITH CHECK ADD  CONSTRAINT [FK_ROLEMENU_REFERENCE_ROLES] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[RoleMenus] CHECK CONSTRAINT [FK_ROLEMENU_REFERENCE_ROLES]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_USERROLE_REFERENCE_ROLES] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_USERROLE_REFERENCE_ROLES]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_USERROLE_REFERENCE_USERS] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_USERROLE_REFERENCE_USERS]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Authorities', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作名称（增删改查之一）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Authorities', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Authorities', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Authorities'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父ID（默认0，无父级）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'ParentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'窗体名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'FormName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tab页标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'TabHeaderText'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1：启用，0：未启用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenuAuthorities', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'权限ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenuAuthorities', @level2type=N'COLUMN',@level2name=N'AuthorityID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色菜单权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenuAuthorities'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenus', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenus', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenus', @level2type=N'COLUMN',@level2name=N'MenuID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RoleMenus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRoles', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRoles', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRoles', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRoles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Account'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态（0，未启用，1启用）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'ModityTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时间戳' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'TimeStamp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users'
GO

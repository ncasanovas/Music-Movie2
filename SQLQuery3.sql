/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Mail]
      ,[Password]
  FROM [MusicMovieContext].[dbo].[Users]


INSERT INTO [MusicMovieContext].[dbo].[Users] ([Mail], [Password])
VALUES ('nataliasolcasanovas@gmail.com', '1234');

DELETE FROM [MusicMovieContext].[dbo].[Users]
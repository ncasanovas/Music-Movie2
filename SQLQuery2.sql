/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [ID]
      ,[Moods]
  FROM [MusicMovieContext].[dbo].[Moods]


INSERT INTO [MusicMovieContext].[dbo].[Moods] ([Moods])
VALUES ('Peaceful');
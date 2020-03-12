select s.StudentID,s.FirstName,c.CourseName,t.TrainerID,t.FirstName,t.Bio from Student s
join Course c on c.CourseID = s.CourseID
join TrainerCourses tc on tc.CourseID = c.CourseID
join Trainer t on t.TrainerID = tc.TrainerID
--Part 1
SELECT column_name, data_type
FROM information_schema.columns
WHERE TABLE_NAME = 'Jobs';

--Part 2
SELECT Name
FROM Employers as e
WHERE e.Location = 'St. Louis City';

--Part 3
SELECT Name, Description
FROM Skills as s
INNER JOIN JobSkills as k
ON k.SkillId = s.Id

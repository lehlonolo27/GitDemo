USE Student2
--Modifying the database through:
--'Adding a filegroup'
ALTER DATABASE Student2
ADD FILEGROUP SECONDARY

-- Adding a File
ALTER DATABASE Student2
ADD FILE(NAME=NewData1,
FILENAME='C:\MyFolder\Data\NewData1.ndf', 
SIZE=10MB,
MAXSIZE=100MB,
FILEGROWTH=5MB) TO FILEGROUP SECONDARY

-- Modify a file (For instance you want to change the filegrowth to 15)

ALTER DATABASE Student2
MODIFY FILE
(
NAME=NewData1,
FILENAME='C:\MyFolder\Data\NewData1.ndf',
FILEGROWTH=15
)

-- Removing the File and Secondary Filegroup
ALTER DATABASE Student2
REMOVE FILE NewData1

ALTER DATABASE Student2
REMOVE FILEGROUP SECONDARY

--Remove the Database 
DROP DATABASE Student
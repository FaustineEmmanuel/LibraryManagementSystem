-- =============================
-- DATABASE: LibraryDB
-- =============================

CREATE DATABASE LibraryDB;
GO
USE LibraryDB;
GO

-- =============================
-- USERS
-- =============================
CREATE TABLE Users (
    UserID INT IDENTITY PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);

INSERT INTO Users (Username, Password)
VALUES ('admin', '1234');

-- =============================
-- MEMBERS
-- =============================
CREATE TABLE Members (
    MemberID INT IDENTITY PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(200)
);

-- =============================
-- BOOKS
-- =============================
CREATE TABLE Books (
    BookID INT IDENTITY PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    Author NVARCHAR(100),
    Quantity INT NOT NULL
);

-- =============================
-- BORROWED BOOKS
-- =============================
CREATE TABLE BorrowedBooks (
    BorrowID INT IDENTITY PRIMARY KEY,
    MemberID INT NOT NULL,
    BookID INT NOT NULL,
    IssueDate DATETIME NOT NULL,
    ReturnDate DATETIME NULL,
    Status NVARCHAR(20) NOT NULL,

    CONSTRAINT FK_Borrowed_Member
        FOREIGN KEY (MemberID) REFERENCES Members(MemberID),

    CONSTRAINT FK_Borrowed_Book
        FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

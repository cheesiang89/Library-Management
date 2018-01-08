**********************************************************
SA45 Team 10a PGP Library Management System
**********************************************************
For demonstration purposes:

Member - Username: louanna, Password: password
Librarian- Username: davio123, Password: asdfg1

Warning: 
Please start testing from form frmLogin. 
This is because some of the functions will need to obtain the username to
trigger subsequent actions.This will ensure the right user has the right access.
===========================================================
Software Specifications
===========================================================
SQL Server Edition: 2014
Visual Studio Edition: 2015
SQL filename: SA45Team10A-PGPLibrary.bak (*Restore this file to Database before executing program)
Solution name: SA45Team10A-PGPLibrary.sln
For best display results: Use 1920 x 1080 resolution

===========================================================
Brief explanation of Business Logic
===========================================================
1. PGP library has 2 member category i.e. Basic members,B and Premium members P.
2. Basic members can borrow up to 6 books, while Premium members can borrow up to 12 books.
3. All members can borrow up to 1 month duration.
4. Only Librarian can access the return book function.
5. The fine is $0.50 per day per book and is compulsory to pay on book return.

===========================================================
Brief explanation of User Interface
===========================================================
1. Login/Logout: User can login as Librarian or Member.
2. Dashboard Layout: After logging in:
			- Member has 2 functions: Search Book, Borrow Book
			- Librarian has 5 functions: Search Book, Return Book, Manage Book, Manage Member, Generate Report
3. General layout: On each screen, User can 
	- Go back Dashboard (by clicking the PGP library logo)
	- Go Profile page (applicable for members only)
	- Logout
4. Search Book: User can search by Book Title, Author, or Book Type.
5. Manage Book/Manage Member: These 2 forms are for maitenance of Members and Books database.
6. Create New Member: This form is for new member registration.
7. Borrow Book: Only Member can borrow book. Once logged in, the MemberID cannot be changed and a receipt can be generated after successful borrowing.
8. Return Book: Only Librarian is allowed to help members to return book.
9. Generate Report: 
   For a Librarian, there are 4 types of report they can generate:
	- Management Report[CrossTab] (Borrow trend among different member category)
	- Transaction Report 
	- Booklisting Report (List of book inventory)
	- Chart (Chart showcasing popularity of books by comparing the quantity borrow)

===========================================================
Brief highlight of programming logic
===========================================================
1. Login and Create Member: Password confidentiality
	- The member chooses a unique set of username and password.
	- A hash of the password and a randomly generated salt is stored on Database instead of the actual password itself.
	- Password is masked with option to unmask

2. Navigation:
	- Each form is navigated to by calling a method from the Navigation class

3. All forms inherit except Login and Create Member form inherit from frmDetails, which is a blank form that stores "UserName" and "User Category" (i.e. Librarian or Member)

4. Logic checks:

/// Borrow book ////: 
i) If bookID mismatch with BookListing table, indicate no such book exists.
ii) If bookID is found but quantity available is 0, indicate book is not available.
iii) Basic member can borrow up to 6 books, Premium member can borrow up to 12 books.

/// Return book ///
i) Librarian will enter the Member ID to retrieve the list of books borrowed. 
ii) If the member ID is incorrect in data type, length and no match in database record. The system will prompt for re-enter of memberID. 
iii) If the Member ID exists but there is no transaction record. The system will inform librarian that the member has not borrowed any book.

///Create Member///
i) All fields must be filled
ii) Format check of NRIC, Post code, Email, Phone
iii) Password must have min length of 6

///Manage Book///
This form has 2 functions:
i) Add new book: 
	- Librarian will input the details for newly purchased books.
	- System will not accept quantity below or equals 0

ii) Update quantity of book: 
	- Librarian will change the details and/or quantity of existing books.
	- System will not accept null data, mismatch BookID, and wrong datatype,ensure total stock will not go below 0.
	
///Manage Member///
This form has 2 functions:
i) Update particulars of existing member: 
	- Librarian will input the member ID to retrieve existing particulars
	- Changes can be made to related field(s) that require changes. 
	- System will not accept null data, mismatch MemberID, and wrong datatype.
ii) Delete member: 
	- System will delete member record when obtaining the matching member ID.
	- System will not accept null data, mismatch MemberID, and wrong datatype.

/// Search Book ///
i) System will check for matching book title, author name and book type in BookListing table. 
ii)  System will prompt if mismatch of the above details.
iii) Should book is not available now, system will show to come back on the day after the earliest due date.


5) Transaction logic:

/// Borrow book ///:
i) Update IssueTrans table as new transaction, 1 book borrowed at a time
ii) Update Member table: "CurrentNumberOnLoan ++"
iii) Update BookListing table: "NumberLoaned ++"

///Return book ///
i) Fine is calculated if Actual Return date exceeds Due date
ii) Update IssueTrans table, to change status to "IN", 1 book returned at a time
iii) Update BookListing table: "NumberLoaned --"
iv) Update Member table: "CurrentNumberOnLoan --"

///Create Member///
i) Will create new entry in Member table after submission

///Manage Book///
i) Add new book:
	- Update BookAdjustment table, showing who adjust, number of adjustment, adjust reason and etc..
	- Update BookListing table, to add a new record of book, TotalStock+quantity

ii) Update existing book:
	- Update BookListing table, TotalStock+quantity
	- Update BookAdjustment table, adjust reason can be different according to quantity, book damaged or buy new book or update information.
	

///Manage Member///
i) Update particulars of existing member:
	- Member table will be updated.
	- System will not accept null data, mismatch MemberID, and wrong datatype.

ii) Delete existing member record:
	- Member table will be updated.


=====================================================================
Brief highlight of Database desgin
=====================================================================
1. Table: Authors - Contains Author Name and Author ID
2. Table: BookAdjustment - Record of book quantity change due to inventory management
3. Table: BookListing- Record of book catalogue
4. Table: ControlTable - Record of numbers "Add" transactions can use (e.g. BookID, AuthorID, etc). As some Primary Keys (e.g. BookID) are stored as nvarchar, we cannot set these columns to Identity column and need to ensure the numbers do not clash for new transactions.
5. Table: IssueTrans - Record of all borrowing/returning book transactions
6. Table: Librarian - Contains Librarian details
7. Table: MemberCategory- Contains Member Category Types (Basic or Premium)
8. Table: Members - Contains Member details
9. Table: Publisher - Contains Publisher details
10. Views: BookAvailability - Shows calculated book availability column
11. Views: BorrowReceipt - Gathers record of all borrowed books
12. Views: ListOfBook - Combines Book Listing, Author Name, Publisher Name columns for generation of report
13. Views: BookBorrowAnalysis: Gathers record of quantity of books borrow by each category of member per day






# STUDENT_MANAGEMENT

### Domain : student
atrrinutes : StudentId, FirstName, LastName, Address, Gender, NIC, Email,Nationality
             
Contact NUmber:  StudentId,  ContactNo

Add create student

add telephone number



Student Table
`
CREATE TABLE STUDENT (
            StudentId VARCHAR (5),
            FirstName VARCHAR  (20),
            LastName   VARCHAR  (20),
            Address   VARCHAR  (20),
            Gender   VARCHAR  (5),
            NIC   VARCHAR  (10),
            Email VARCHAR (30),
            Nationality VARCHAR  (20)
            
);

`

## Please Use Below Connection Strings to Run This Program

`
<connectionString>
 <add name="dbString" connectionString="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BEELIFE)));User Id=;Password=;" />
  <add name="localDbString" connectionString="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=sa;Password=Tharushi123;" />
</connectionString>
`


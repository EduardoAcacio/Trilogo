CREATE TABLE Tickets(
   id           INTEGER  NOT NULL PRIMARY KEY
  ,description  VARCHAR(300) NOT NULL
  ,author       VARCHAR(150) NOT NULL
  ,creationDate DATETIME(19) NOT NULL
  ,updated 		DATETIME(19) NULL
);
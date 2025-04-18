CREATE Database Library;
use Library
create table Readers (
  id int Identity(1,1) Primary key not null ,
  name varchar(45) not null,
  email varchar(45) not null,
  phone_number bigint not null,
  date_registration datetime2(3) not null,
 );


create table librarians (
  id int not null Identity(1,1) primary key,
  name varchar(45) not null,
  phone_number bigint not null);

  
  create table events (
  id int not null primary key Identity(1,1),
  name varchar not null,
  date datetime2(3) NOT NULL,
  description varchar(100) not null,
  librarian_id int not null,
  constraint fk_events_librarians
  foreign key (librarian_id)
  references librarians (id));


  create table events_readers
 (
 reader_id int not null,
 event_id int not null,
 primary key (reader_id,event_id),
 constraint fk_events_readers_readers
 foreign key (reader_id)
 references readers(id),
 constraint fk_events_readers_events
 foreign key (event_id)
 references events(id)
 );

  
  create table categories(
  id int not null primary key Identity,
  name varchar(45) not null,
  description varchar(100) not null
  );
  
  create table authors(
  id int not null primary key Identity(1,1),
  name varchar(45) not null
  );
 
  create table books(
  id int not null primary key Identity(1,1),
  heading varchar(45) not null,
  year int not null,
  author_id int not null,
  category_id int not null,
  constraint fk_books_authors
  foreign key(author_id)
  references authors(id),
  constraint fk_books_categories
  foreign key(category_id)
  references categories(id)
  );
  
  create table borrowings
 (
 id int not null primary key Identity(1,1),
 librarian_id int not null,
 reader_id int not null,
 book_id int not null,
 date_got  datetime2(3) not null,
 date_return datetime2(3) ,
 status varchar(10) not null,
 constraint fk_borrowing_reader
 foreign key (reader_id)
 references readers(id),
 constraint fk_borrowing_book
 foreign key (book_id)
 references books(id),
 constraint fk_borrowing_librarian
 foreign key(librarian_id)
 references librarians(id)
 );
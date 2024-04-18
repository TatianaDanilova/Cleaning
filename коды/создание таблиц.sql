create table Users(
[user_id] int not null primary key,
[name] nchar(100) not null,
pass nchar(100) not null)


create table Things(
mi_id int not null primary key,
thing_type nchar(100) not null,
[name] nchar(100) not null,
material nchar(100) not null,
price int not null,
color nchar(100) not null,
[user_id] int not null foreign key references Users([user_id]))
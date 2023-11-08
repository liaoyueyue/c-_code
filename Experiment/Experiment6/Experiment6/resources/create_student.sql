use test;
drop table if exists student;
create table student
(
    id         int primary key auto_increment,
    studentid  int not null unique,
    name       varchar(100) not null,
    gender     varchar(100),
    age        varchar(100),
    major      varchar(100),
    phone      varchar(100)
) default charset 'utf8mb4';
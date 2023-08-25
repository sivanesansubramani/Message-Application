create table minitwittwr
(
id int primary key identity(1,1),
Name  varchar(500) not null,
Command varchar(500) not null,
Time datetime2
)
insert into minitwittwr values('Sivanesan','this is good job','8-25-2023')
Select * from minitwittwr

delete from minitwittwr



-- insert records into PersonalBio 
create or alter procedure Insertminitwitter(@Name nvarchar(100),@Command nvarchar(500),@Time nvarchar(100))
as
begin

  insert into minitwittwr (Name,Command,Time)values (@Name,@Command,@Time)
end

exec Insertminitwitter  'Sivanesan','this is good job','8-25-2023'

-------select sp
create or alter procedure Selectcommand
as
begin

  Select * from minitwittwr
  ORDER BY id DESC;

end

exec Selectcommand


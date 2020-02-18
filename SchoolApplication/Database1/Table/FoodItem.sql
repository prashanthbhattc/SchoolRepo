CREATE TABLE FoodItem
(
	
	Id int IDENTITY(1,1) NOT NULL,
	FoodName varchar(100) NOT NULL,
	Price money NOT NULL,
	CategoryId int 
	constraint fk_id foreign key(Id) references Category(Id) NOT NULL )




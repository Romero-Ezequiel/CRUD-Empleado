-- Creo la base de datos
Create Database DBEmpleados

use DBEmpleados

-- Creo la tabla Empleado
Create table Empleado(
	IdEmpleado int primary key identity,
	Nombre varchar(100),
	Apellido varchar(100),
	Correo varchar(250),
	Salario decimal(10,2)
)

-- Inserto algunos registros a la tabla Empleado
Insert into Empleado (Nombre, Apellido, Correo, Salario) 
values ('Eze', 'Romero', 'eze@gmail.com',10000);
Insert into Empleado (Nombre, Apellido, Correo, Salario) 
values ('Digneli', 'Davila', 'digne@gmail.com',20000);
Insert into Empleado (Nombre, Apellido, Correo, Salario) 
values ('Gabriela', 'Romero', 'gabi@gmail.com',15000);
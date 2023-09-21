-- Store Procedure para crear los empleados
Create Proc sp_CrearEmpleado(
	@Nombre varchar(100),
	@Apellido varchar(100),
	@Correo varchar(250),
	@Salario decimal(10,2)
)
as 
begin
	Insert into Empleado(Nombre, Apellido, Correo, Salario) 
		Values (@Nombre, @Apellido, @Correo, @Salario)
end

-- Store Procedure para editar los empleados
Create Proc sp_EditarEmpleado(
	@IdEmpleado int,
	@Nombre varchar(100),
	@Apellido varchar(100),
	@Correo varchar(250),
	@Salario decimal(10,2)
)
as 
begin
	Update Empleado SET 
	Nombre = @Nombre,
	Apellido = @Apellido,
	Correo = @Correo,
	Salario = @Salario
	where IdEmpleado = @IdEmpleado
end

-- Store Procedure para eliminar empleados
Create Proc sp_EliminarEmpleado(
	@IdEmpleado int
)
as 
begin
	delete from Empleado Where IdEmpleado = @IdEmpleado
end

-- Store Procedure para buscar empleados por nombre o apellidos
Create Proc sp_BuscarEmpleado(
	@Nombre varchar(100),
	@Apellido varchar(100)
)
as 
begin

	select * from Empleado 
		where Nombre=@Nombre OR Apellido=@Apellido 
end
CREATE TABLE DetallePedido
(
    iddetalle int primary key identity(1,1),
    idpedido int,
    iddiscos int,
    cantidad int,
    precioVenta float
);
CREATE TABLE Pedido
(
    idpedido int primary key identity(1,1),
    fechaPedido DATETIME,
    idcliente int,
    idempleado int,
    direccionEntrega varchar(250),
    estado int
);
CREATE TABLE cliente
(
    idcliente int primary key identity(1,1),
    nombres varchar(250),
    apellidos varchar(250),
    direccion varchar(250)
);
CREATE TABLE empleado
(
    idempleado int primary key identity(1,1),
    nombres varchar(250),
    apellidos varchar(250),
    direccion varchar(250),
    username varchar(25),
    clave varchar(25)
);
CREATE TABLE categoria
(
    idcategoria int primary key identity(1,1),
    nombreCategoria varchar(50)
);
CREATE TABLE discos
(
    iddisco int primary key identity(1,1),
    idcategoria int,
    idartista int,
    titulo varchar(50),
    fecha DATETIME,
    formato varchar(150),
    numeroCanciones int,
    precio float,
    observaciones varchar(500),
    imagen varchar(500)
);
CREATE TABLE canciones
(
    idcancion int primary key identity(1,1),
    iddisco int,
    numero int,
    tiempo float,
    cancion varchar(150)
)
CREATE TABLE artista
(
    idartista int primary key identity(1,1),
    nombre varchar(150),
    apellido varchar(150),
    fechaNacimiento DATETIME,
    lugarNacimiento VARCHAR(150),
    email varchar(100)
);
ALTER TABLE pedido ADD CONSTRAINT FK_Pedido_clientes FOREIGN KEY (idcliente) REFERENCES cliente(idcliente)
ALTER TABLE pedido ADD CONSTRAINT FK_Pedido_Empleado FOREIGN KEY (idempleado) REFERENCES empleado(idempleado)
ALTER TABLE DetallePedido ADD CONSTRAINT FK_DetallePedido_Pedido FOREIGN KEY (idpedido) REFERENCES Pedido(idpedido)
ALTER TABLE DetallePedido ADD CONSTRAINT FK_DetallePedido_Discos FOREIGN KEY (iddiscos) REFERENCES discos(iddiscos)
ALTER TABLE discos ADD CONSTRAINT FK_discos_categoria FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
ALTER TABLE discos ADD CONSTRAINT FK_discos_artista FOREIGN KEY (idartista) REFERENCES artista(idartista)
ALTER TABLE canciones ADD CONSTRAINT FK_canciones_disco FOREIGN KEY (iddisco) REFERENCES discos(iddisco)

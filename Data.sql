insert into categoria
values('CategoriaTest');
insert into artista
values('ArtistaPrueba', 'ApellidoPrueba', SYSDATETIME(), 'LugarTest', '');

insert into discos
values(1, 1, 'Discovendido1', SYSDATETIME(), 'cd', 1, 5, '', '');
insert into discos
values(1, 1, 'Discovendido2', SYSDATETIME(), 'cd', 2, 7, '', '');
insert into discos
values(1, 1, 'Discovendido3', SYSDATETIME(), 'cd', 3, 9, '', '');
insert into discos
values(1, 1, 'Discovendido4', SYSDATETIME(), 'cd', 4, 11, '', '');
insert into discos
values(1, 1, 'Discovendido5', SYSDATETIME(), 'cd', 5, 13, '', '');
insert into discos
values(1, 1, 'Discovendido6', SYSDATETIME(), 'cd', 6, 15, '', '');

insert into cliente
values('NombreCliente1', 'ApellidoCliente1', 'Direccion cliente 1');
insert into empleado
values('nombresEmpleado1', 'ApellidosEmpleado1', 'Direccion 1', 'loginEmpleado1', 'claveEmpleado1');

insert into Pedido
values('05/05/2008', 1, 1, 'Direccion Pedido 1', 0);
insert into Pedido
values('06/08/2015', 1, 1, 'Direccion Pedido 2', 0);
insert into Pedido
values('05/05/2013', 1, 1, 'Direccion Pedido 3', 0);
insert into Pedido
values('05/05/2020', 1, 1, 'Direccion Pedido 4', 0);
insert into Pedido
values('05/05/2021', 1, 1, 'Direccion Pedido 5', 0);
insert into Pedido
values('05/05/2010', 1, 1, 'Direccion Pedido 6', 0);


insert into pedido
values('2010-06-10', 1, 1, 'Direccion pedido 6', 0);
insert into pedido
values('2012-06-10', 1, 1, 'Direccion pedido 6', 0);
insert into pedido
values('2015-06-10', 1, 1, 'Direccion pedido 6', 0);
insert into pedido
values('2020-06-10', 1, 1, 'Direccion pedido 6', 0);


pedido,disco,cant,precio

insert into DetallePedido
values(7, 1, 15, 13);
insert into DetallePedido
values(8, 2, 5, 35);
insert into DetallePedido
values(9, 3, 20, 13);
insert into DetallePedido
values(10, 4, 50, 0.5);
insert into DetallePedido
values(11, 5, 2, 13);
insert into DetallePedido
values(7, 6, 9, 9);


insert into DetallePedido
values(7, 2, 9, 9);


insert into DetallePedido
values(7, 3, 10, 2);


insert into DetallePedido
values(7, 4, 10, 2);

insert into DetallePedido
values(7, 4, 10, 10);

select *
from pedido
select *
from DetallePedido

select *
from discos
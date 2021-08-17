drop database PrototipoP1;
create database PrototipoP1;
use PrototipoP1;

create table factura(
idFactura int not NULL,
fkIdc int,
cliente varchar (45),
producto varchar (20),
total double,
estado int,
primary key (idFactura)
);


create table cliente(
idCliente int not NULL,
nomCliente varchar (45),
telCliente varchar (8),
estado int,
primary key (idCliente)
);
ALTER TABLE factura
  ADD CONSTRAINT fkCliente FOREIGN KEY (fkIdc) REFERENCES cliente (idCliente);
-- Crud Cliente
DELIMITER //
	CREATE PROCEDURE insertCliente (in id int, in nom varchar(45), in tel varchar(8)) BEGIN
		INSERT INTO cliente values (id,nom,tel,1);
END//
DELIMITER //
	CREATE PROCEDURE consultGenCliente () BEGIN
		SELECT idCliente, nomCliente FROM cliente;
END//
DELIMITER //
	CREATE PROCEDURE consultIcliente (in id int) BEGIN
		select * from clientes where id = idCLiente;
END//
DELIMITER //
	CREATE PROCEDURE deleteCliente (in id int) BEGIN
		UPDATE cliente set estado = 0 where id = idCliente;
END//
DELIMITER //
	CREATE PROCEDURE actuCliente (in id int, in nom varchar (45), in tel varchar (8)) BEGIN
		UPDATE cliente set nomCliente = nom, telCliente = tel where id = idCliente;
END//
-- Crud Factura
DELIMITER //
	CREATE PROCEDURE insertFactura (in id int,in idC int, in cl varchar(45), in producto varchar(20),in total int) BEGIN
		INSERT INTO factura values (id,idC,cl,producto,total,1);
END//
DELIMITER //
	CREATE PROCEDURE consultIfactura () BEGIN
		SELECT * FROM cliente where id = idFactura;
END//
DELIMITER //
	CREATE PROCEDURE bajaFactura (in id int) BEGIN
		UPDATE factura set estado = 0 where id = idFactura;
END//
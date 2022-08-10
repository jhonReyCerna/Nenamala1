USE EMTRAFESA
GO

-- PASAJEROS

INSERT INTO PASAJERO (CodPasajero, Apellidos, Nombres, DNI)
	VALUES (17849995, 'Herman', 'Noel', '10546876'),
	(27233188, 'Eichmann', 'Camren', '11451188'),
	(31363213, 'Keeling', 'Adelbert', '91429793'),
	(57049321, 'Becker', 'Juwan', '19174377'),
	(62556178, 'Douglas', 'Shaniya', '78855251'),
	(70343092, 'Stanton', 'Daphne', '77953395'),
	(73743553, 'Bergnaum', 'Reagan', '47150716'),
	(86235673, 'Ortiz', 'Mortimer', '52032993'),
	(89364591, 'Hermann', 'Jett', '59170373'),
	(93114350, 'Grant', 'Harrison', '93308799');

GO

-- PILOTOS

INSERT INTO PILOTO (IdConductor, Nombre, Apellido, Licencia, Vivienda)
	VALUES (11512413, 'Alvena', 'Gleason', '18582259', '2766 Kautzer Squares\nLake Quincy, NJ 93046-2804'),
	(13777990, 'Lenna', 'Leuschke', '71978220', '891 Little Turnpike Apt. 589\nEast Nikkiburgh, ME 98643-5775'),
	(17488200, 'Ian', 'Brakus', '69577202', '8996 Bailey Fords\nSouth Breanne, WA 76732'),
	(32454530, 'Godfrey', 'Emmerich', '36457762', '3839 Breitenberg Port\nGarrisonport, WA 15544'),
	(35158004, 'Elisha', 'Dibbert', '11988800', '15520 Ankunding Meadow Suite 011\nNew Vella, AL 40973-4672'),
	(42707958, 'Chandler', 'Lemke', '47479361', '6598 Nader Pass Suite 078\nPort Abdullahshire, IA 04148'),
	(59646004, 'Milford', 'Macejkovic', '90847623', '37908 Garth Causeway Suite 260\nCreminmouth, MI 39545-2231'),
	(67128553, 'Grover', 'Lakin', '73598501', '47397 Jast Green Apt. 237\nSouth Rosamond, NJ 57026-2981'),
	(76148094, 'Cletus', 'Gleichner', '42644230', '72687 Alyson Vista\nSouth Jadenland, TX 05645'),
	(98898187, 'Garth', 'Kessler', '83751866', '6822 Alvera Causeway\nBednarburgh, GA 67792');

GO

-- BUS

INSERT INTO BUS (NroAsientos, Costo, Matricula, Infracciones, Estado)
	VALUES (56, '44.58', 'A51-54H', 8, 1),
	(54, '37.92', 'A52-54H', 5, 1),
	(59, '33.47', 'A53-54H', 6, 1),
	(46, '29.83', 'A54-54H', 7, 1),
	(53, '21.81', 'A55-54H', 2, 1),
	(44, '74.09', 'A56-54H', 9, 1),
	(60, '37.79', 'A57-54H', 2, 1),
	(42, '51.39', 'A58-54H', 1, 1),
	(50, '53.65', 'A59-54H', 2, 1),
	(49, '78.72', 'A61-54H', 5, 1);

GO

-- SEGURO

INSERT INTO ASEGURADORA (RUC, NroPoliza, FechaFinSeguro, FechaInicioSeguro)
	VALUES (284166336466, 48, '12-mar-2022', '12-mar-2013'),
	(309564443265, 58, '12-mar-2022', '12-mar-2014'),
	(369932129255, 52, '12-mar-2022', '12-mar-2015'),
	(569944763222, 49, '12-mar-2022', '12-mar-2016'),
	(565174868885, 59, '12-mar-2022', '12-mar-2016'),
	(738570394502, 59, '12-mar-2022', '12-mar-2016'),
	(132362964920, 57, '12-mar-2022', '12-mar-2016'),
	(284924879852, 54, '12-mar-2022', '12-mar-2016'),
	(975302694441, 58, '12-mar-2022', '12-mar-2018'),
	(210987516900, 53, '12-mar-2022', '12-mar-2019');

GO

-- Servicio

INSERT INTO SERVICIO (Descripcion, TipoServicio, PrecioUnitario)
	VALUES ('Servicio de Buscama Premiun', 'BUSCAMA', 40.2),
	('Servicio Normal', 'NORMAL', 20.1)

GO

-- Users
INSERT INTO USERS
	VALUES ('avefenix', '123')

-- Viajes

INSERT INTO VIAJE (IdViaje, Ruta, Turno, Fecha, Asiento, Embarque, Desembarque, IdBus, IdConductor)
	VALUES (1, 'Guadalupe-Trujillo', '10:15 AM', '12-mar-2022', 8, 'Guadalupe S/n', 'Av Peru-TRJ', 1, 17488200),
	(2, 'Chepen-Trujillo', '11:15 AM', '12-mar-2022', 8, 'Guadalupe S/n', 'Av Peru-TRJ', 2, 13777990),
	(3, 'Cajamarca-Trujillo', '6:15 AM', '12-mar-2022', 8, 'Guadalupe S/n', 'Av Peru-TRJ', 3, 11512413),
	(4, 'Lima-Trujillo', '7:15 AM', '12-mar-2022', 8, 'Guadalupe S/n', 'Av Peru-TRJ', 4, 67128553)
GO

-- Recepcionistas

INSERT INTO RECEPCIONISTA(IdRecepcionista, Nombre)
VALUES
(1, 'Jhonatan Mostacero'),
(2, 'Cerna Alvarado'),
(3, 'Jorge Yovera'),
(4, 'Roberth Cabrera'),
(5, 'George Peraldo')
GO


-- Modulos de atencion

INSERT INTO MODULO_ATENCION(IdModulo, Oficina, IdRecepcionista)
VALUES
(1, 'Guadalupe',1),
(2, 'Guadalupe',2),
(3, 'Guadalupe',3),
(4, 'Guadalupe',4),
(5, 'Guadalupe',5)

-- Boleta Pasajes

INSERT INTO BOLETA_PASAJE(NroBoleta, FechaEmision, IGV, ImporteTotal, CodPasajero, RUC,IdViaje, IdModulo)
VALUES
('10212531', '12-ago-2022', 16.0, 60,31363213, 284166336466, 1, 1)

GO

select * from BOLETA_PASAJE
go


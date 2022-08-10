USE MASTER
GO

DROP DATABASE if EXISTS EMTRAFESA

CREATE DATABASE EMTRAFESA
GO

use EMTRAFESA
GO

CREATE TABLE ASEGURADORA
( 
	RUC                  char(12)  NOT NULL ,
	NroPoliza            char(08)  NULL ,
	FechaFinSeguro       datetime  NULL ,
	FechaInicioSeguro    datetime  NULL 
)
go



ALTER TABLE ASEGURADORA
	ADD CONSTRAINT XPKASEGURADORA PRIMARY KEY  CLUSTERED (RUC ASC)
go



CREATE TABLE BOLETA_ENCOMIENDA
( 
	NroEncomienda        char(12)  NOT NULL ,
	LugarEmpresa         char(30)  NULL ,
	PuntoEmision         char(30)  NULL ,
	FechaEmision         datetime  NULL ,
	Recepcionista        char(30)  NULL ,
	TipoEncomienda       char(30)  NULL ,
	Origen               char(30)  NULL ,
	Destino              char(30)  NULL ,
	CondPago             char(30)  NULL ,
	DocAnexos            char(30)  NULL ,
	Servicio             char(30)  NULL ,
	Descripcion          char(30)  NULL ,
	Descuento            float  NULL ,
	IGV                  float  NULL ,
	ImporteTotal         float  NULL ,
	Observacion          char(30)  NULL ,
	DNIconsignado        char(08)  NOT NULL ,
	DNImensajero         char(08)  NOT NULL ,
	IdModulo             int  NOT NULL ,
	RUC                  char(12)  NOT NULL ,
	DNIrepresentate      char(08)  NOT NULL 
)
go



ALTER TABLE BOLETA_ENCOMIENDA
	ADD CONSTRAINT XPKBOLETA_ENCOMIENDA PRIMARY KEY  CLUSTERED (NroEncomienda ASC)
go



CREATE TABLE BOLETA_PASAJE
( 
	NroBoleta            char(12)  NOT NULL ,
	FechaEmision         date  NULL ,
	HoraEmision          time  NULL ,
	IGV                  float  NULL ,
	ImporteTotal         float  NULL ,
	CondicionPago        char(30)  NULL ,
	Observacion          char(30)  NULL ,
	CodPasajero          int  NOT NULL ,
	Descuentos           float  NULL ,
	RUC                  char(12)  NOT NULL ,
	IdViaje              int  NOT NULL ,
	IdModulo             int  NOT NULL 
)
go



ALTER TABLE BOLETA_PASAJE
	ADD CONSTRAINT XPKBOLETA_PASAJE PRIMARY KEY  CLUSTERED (NroBoleta ASC)
go



CREATE TABLE BUS
( 
	IdBus                int IDENTITY(1,1) NOT NULL ,
	DiaAdquisicion       datetime  NULL ,
	NroAsientos          int  NULL ,
	Costo                float  NULL ,
	Matricula            char(30)  NULL ,
	Estado               tinyint  NULL ,
	Infracciones         int  NULL 
)
go



ALTER TABLE BUS
	ADD CONSTRAINT XPKBUS PRIMARY KEY  CLUSTERED (IdBus ASC)
go



CREATE TABLE CONSIGNADO
( 
	Apellidos            char(30)  NULL ,
	Nombres              char(30)  NULL ,
	DNIconsignado        char(08)  NOT NULL 
)
go



ALTER TABLE CONSIGNADO
	ADD CONSTRAINT XPKCONSIGNADO PRIMARY KEY  CLUSTERED (DNIconsignado ASC)
go



CREATE TABLE ENCOMIENDA_DETALLE
( 
	Descripcion          varchar(90)  NULL ,
	Unidad               varchar(90)  NULL ,
	Cantidad             int  NULL ,
	Total                float  NULL ,
	NroEncomienda        char(12)  NOT NULL ,
	IdDetalle            int  NOT NULL 
)
go



ALTER TABLE ENCOMIENDA_DETALLE
	ADD CONSTRAINT XPKENCOMIENDA_DETALLE PRIMARY KEY  CLUSTERED (IdDetalle ASC)
go



CREATE TABLE GUIA_REMISION_REMITENTE
( 
	FechaInicioTranslado datetime  NULL ,
	FechaImpresion       datetime  NULL ,
	NroImpresion         int  NULL ,
	DireccionPuntoLlegada char(30)  NULL ,
	DireccionPuntoPartida char(30)  NULL ,
	MotivoTranslado      char(30)  NULL ,
	NroRemision          int  NOT NULL ,
	SerieNumDocumento    int  NULL ,
	RUCtransportista     char(12)  NOT NULL ,
	RUC                  char(12)  NOT NULL ,
	DNIrepresentate      char(08)  NOT NULL 
)
go



ALTER TABLE GUIA_REMISION_REMITENTE
	ADD CONSTRAINT XPKGUIA_REMISION_REMITENTE PRIMARY KEY  CLUSTERED (NroRemision ASC)
go



CREATE TABLE MANTENIMIENTO
( 
	Fecha                datetime  NULL ,
	IdBus                int  NOT NULL ,
	IdMecanico           int  NOT NULL 
)
go



ALTER TABLE MANTENIMIENTO
	ADD CONSTRAINT XPKMANTENIMIENTO PRIMARY KEY  CLUSTERED (IdBus ASC,IdMecanico ASC)
go



CREATE TABLE MECANICO
( 
	IdMecanico           int  NOT NULL ,
	Certificado          char(30)  NULL ,
	Nombre               char(30)  NULL ,
	Apellido             char(30)  NULL ,
	Telefono             char(09)  NULL 
)
go



ALTER TABLE MECANICO
	ADD CONSTRAINT XPKMECANICO PRIMARY KEY  CLUSTERED (IdMecanico ASC)
go



CREATE TABLE MENSAJERO
( 
	DNImensajero         char(08)  NOT NULL ,
	Nombre               char(30)  NULL ,
	Telefono             char(09)  NULL ,
	IdVehiculo           int  NOT NULL 
)
go



ALTER TABLE MENSAJERO
	ADD CONSTRAINT XPKMENSAJERO PRIMARY KEY  CLUSTERED (DNImensajero ASC)
go



CREATE TABLE MODULO_ATENCION
( 
	IdModulo             int  NOT NULL ,
	Oficina              char(30)  NULL ,
	Descripcion          char(30)  NULL ,
	IdRecepcionista      int  NOT NULL 
)
go



ALTER TABLE MODULO_ATENCION
	ADD CONSTRAINT XPKMODULO_ATENCION PRIMARY KEY  CLUSTERED (IdModulo ASC)
go



CREATE TABLE PASAJE_DETALLE
( 
	Item                 char(30)  NULL ,
	Descripcion          char(30)  NULL ,
	Unidad               char(30)  NULL ,
	Cantidad             int  NULL ,
	PrecioUnitario       float  NULL ,
	Importe              float  NULL ,
	NroBoleta            char(12)  NOT NULL ,
	IdServico            int  NOT NULL 
)
go



ALTER TABLE PASAJE_DETALLE
	ADD CONSTRAINT XPKPASAJE_DETALLE PRIMARY KEY  CLUSTERED (NroBoleta ASC,IdServico ASC)
go



CREATE TABLE PASAJERO
( 
	Apellidos            char(30)  NULL ,
	Nombres              char(30)  NULL ,
	DNI                  char(08)  NULL ,
	CodPasajero          int  NOT NULL 
)
go



ALTER TABLE PASAJERO
	ADD CONSTRAINT XPKPASAJERO PRIMARY KEY  CLUSTERED (CodPasajero ASC)
go



CREATE TABLE PILOTO
( 
	IdConductor          int  NOT NULL ,
	Nombre               char(30)  NULL ,
	Apellido             char(30)  NULL ,
	Licencia             char(30)  NULL ,
	Vivienda             varchar(120)  NULL ,
	Nacimiento           datetime  NULL 
)
go



ALTER TABLE PILOTO
	ADD CONSTRAINT XPKPILOTO PRIMARY KEY  CLUSTERED (IdConductor ASC)
go



CREATE TABLE RECEPCIONISTA
( 
	IdRecepcionista      int  NOT NULL ,
	Nombre               varchar(70)  NULL 
)
go



ALTER TABLE RECEPCIONISTA
	ADD CONSTRAINT XPKRECEPCIONISTA PRIMARY KEY  CLUSTERED (IdRecepcionista ASC)
go



CREATE TABLE REMISION_REMITENTE_DETALLE
( 
	DescripcionObjeto    char(30)  NULL ,
	Cantidad             int  NULL ,
	UnidadMedida         char(30)  NULL ,
	Peso                 float  NULL ,
	NroRemision          int  NOT NULL ,
	IdDetalle            int  NOT NULL 
)
go



ALTER TABLE REMISION_REMITENTE_DETALLE
	ADD CONSTRAINT XPKREMISION_REMITENTE_DETALLE PRIMARY KEY  CLUSTERED (IdDetalle ASC)
go



CREATE TABLE REMITENTE
( 
	Direccion            char(30)  NULL ,
	RUC                  char(12)  NOT NULL ,
	Nombre               varchar(70)  NULL ,
	DNIrepresentate      char(08)  NOT NULL 
)
go



ALTER TABLE REMITENTE
	ADD CONSTRAINT XPKREMITENTE PRIMARY KEY  CLUSTERED (RUC ASC,DNIrepresentate ASC)
go



CREATE TABLE REPRESENTANTE
( 
	Apellidos            char(30)  NULL ,
	Nombres              char(30)  NULL ,
	DNIrepresentate      char(08)  NOT NULL ,
	Telefono             char(09)  NULL ,
	Correo               char(30)  NULL 
)
go



ALTER TABLE REPRESENTANTE
	ADD CONSTRAINT XPKREPRESENTANTE PRIMARY KEY  CLUSTERED (DNIrepresentate ASC)
go



CREATE TABLE SERVICIO
( 
	Descripcion          char(30)  NULL ,
	IdServico            int  NOT NULL ,
	TipoServicio         char(30)  NULL ,
	PrecioUnitario       float  NULL 
)
go



ALTER TABLE SERVICIO
	ADD CONSTRAINT XPKSERVICIO PRIMARY KEY  CLUSTERED (IdServico ASC)
go



CREATE TABLE TRANSPORTISTA
( 
	RUCtransportista     char(12)  NOT NULL ,
	Denominacion         char(30)  NULL ,
	Licencia             char(30)  NULL ,
	NombreEmpresa        char(30)  NULL 
)
go



ALTER TABLE TRANSPORTISTA
	ADD CONSTRAINT XPKDATOS_TRANSPORTISTA PRIMARY KEY  CLUSTERED (RUCtransportista ASC)
go



CREATE TABLE VEHICULO
( 
	IdVehiculo           int  NOT NULL ,
	Tipo                 char(30)  NULL ,
	Capacidad            float  NULL 
)
go



ALTER TABLE VEHICULO
	ADD CONSTRAINT XPKVEHICULO PRIMARY KEY  CLUSTERED (IdVehiculo ASC)
go



CREATE TABLE VIAJE
( 
	Ruta                 char(30)  NULL ,
	IdViaje              int  NOT NULL ,
	Turno                time  NULL ,
	Fecha                date  NULL ,
	Asiento              int  NULL ,
	Embarque             char(30)  NULL ,
	Desembarque          char(30)  NULL ,
	Desplazamiento       char(30)  NULL ,
	IdBus                int  NOT NULL ,
	IdConductor          int  NOT NULL 
)
go



ALTER TABLE VIAJE
	ADD CONSTRAINT XPKVIAJE PRIMARY KEY  CLUSTERED (IdViaje ASC)
go




ALTER TABLE BOLETA_ENCOMIENDA
	ADD CONSTRAINT R_49 FOREIGN KEY (DNIconsignado) REFERENCES CONSIGNADO(DNIconsignado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_ENCOMIENDA
	ADD CONSTRAINT R_50 FOREIGN KEY (DNImensajero) REFERENCES MENSAJERO(DNImensajero)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_ENCOMIENDA
	ADD CONSTRAINT R_51 FOREIGN KEY (RUC,DNIrepresentate) REFERENCES REMITENTE(RUC,DNIrepresentate)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_ENCOMIENDA
	ADD CONSTRAINT R_64 FOREIGN KEY (IdModulo) REFERENCES MODULO_ATENCION(IdModulo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_PASAJE
	ADD CONSTRAINT R_46 FOREIGN KEY (CodPasajero) REFERENCES PASAJERO(CodPasajero)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_PASAJE
	ADD CONSTRAINT R_47 FOREIGN KEY (RUC) REFERENCES ASEGURADORA(RUC)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_PASAJE
	ADD CONSTRAINT R_48 FOREIGN KEY (IdViaje) REFERENCES VIAJE(IdViaje)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE BOLETA_PASAJE
	ADD CONSTRAINT R_63 FOREIGN KEY (IdModulo) REFERENCES MODULO_ATENCION(IdModulo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ENCOMIENDA_DETALLE
	ADD CONSTRAINT R_11 FOREIGN KEY (NroEncomienda) REFERENCES BOLETA_ENCOMIENDA(NroEncomienda)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE GUIA_REMISION_REMITENTE
	ADD CONSTRAINT R_58 FOREIGN KEY (RUCtransportista) REFERENCES TRANSPORTISTA(RUCtransportista)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE GUIA_REMISION_REMITENTE
	ADD CONSTRAINT R_67 FOREIGN KEY (RUC,DNIrepresentate) REFERENCES REMITENTE(RUC,DNIrepresentate)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE MANTENIMIENTO
	ADD CONSTRAINT R_60 FOREIGN KEY (IdBus) REFERENCES BUS(IdBus)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE MANTENIMIENTO
	ADD CONSTRAINT R_61 FOREIGN KEY (IdMecanico) REFERENCES MECANICO(IdMecanico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE MENSAJERO
	ADD CONSTRAINT R_57 FOREIGN KEY (IdVehiculo) REFERENCES VEHICULO(IdVehiculo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE MODULO_ATENCION
	ADD CONSTRAINT R_62 FOREIGN KEY (IdRecepcionista) REFERENCES RECEPCIONISTA(IdRecepcionista)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PASAJE_DETALLE
	ADD CONSTRAINT R_9 FOREIGN KEY (NroBoleta) REFERENCES BOLETA_PASAJE(NroBoleta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PASAJE_DETALLE
	ADD CONSTRAINT R_33 FOREIGN KEY (IdServico) REFERENCES SERVICIO(IdServico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE REMISION_REMITENTE_DETALLE
	ADD CONSTRAINT R_34 FOREIGN KEY (NroRemision) REFERENCES GUIA_REMISION_REMITENTE(NroRemision)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE REMITENTE
	ADD CONSTRAINT R_68 FOREIGN KEY (DNIrepresentate) REFERENCES REPRESENTANTE(DNIrepresentate)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VIAJE
	ADD CONSTRAINT R_54 FOREIGN KEY (IdBus) REFERENCES BUS(IdBus)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VIAJE
	ADD CONSTRAINT R_55 FOREIGN KEY (IdConductor) REFERENCES PILOTO(IdConductor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

CREATE TABLE USERS( 
	usuario          varchar(30)  NULL ,
	contrasenia      varchar(30)  NOT NULL
)
go


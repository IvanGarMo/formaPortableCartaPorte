IF TYPE_ID(N'UbicacionTipo') IS NOT NULL
	BEGIN
		DROP TYPE UbicacionTipo 
	END
;
CREATE TYPE UbicacionTipo AS TABLE(
	TipoUbicacion VARCHAR(10),
	IDUbicacion VARCHAR(50),
	RFC VARCHAR(13),
	Nombre VARCHAR(2000),
	NumRegIdTrib VARCHAR(20),
	ResidenciaFiscal CHAR(3),
	FechaHoraSalidaLlegada VARCHAR(100),
	DistanciaRecorrida VARCHAR(15),
	EsOrigen BIT,
	EsDestinoIntermedio BIT,
	EsDestinoFinal BIT,
	EsExtranjero BIT
)
;
IF TYPE_ID(N'DomicilioTipo') IS NOT NULL
	BEGIN
		DROP TYPE DomicilioTipo 
	END
;
CREATE TYPE DomicilioTipo AS TABLE(
	Calle VARCHAR(1000),
	NumeroExterior VARCHAR(10),
	NumeroInterior VARCHAR(10),
	Colonia VARCHAR(200),
	Localidad VARCHAR(200),
	Referencia VARCHAR(300),
	Municipio VARCHAR(200),
	Estado VARCHAR(100),
	Pais VARCHAR(10),
	CodigoPostal VARCHAR(7),
	IDUbicacion VARCHAR(10),
	EsExtranjero BIT
)
;
IF TYPE_ID(N'CantidadTransportaTipo') IS NOT NULL
	BEGIN
		DROP TYPE CantidadTransportaTipo
	END
;
CREATE TYPE CantidadTransportaTipo AS TABLE (
	CadProdServ VARCHAR(20),
	IDOrigen VARCHAR(50),
	IDDestino VARCHAR(50),
	Cantidad NUMERIC(10,0)
)
;
IF TYPE_ID(N'MercanciaTipo') IS NOT NULL
	BEGIN
		DROP TYPE MercanciaTipo
	END
;
CREATE TYPE MercanciaTipo AS TABLE (
	CadProdServ VARCHAR(20),
	Descripcion VARCHAR(1000),
	Cantidad NUMERIC(5,0),
	ClaveUnidad VARCHAR(10),
	Unidad VARCHAR(200),
	Dimensiones VARCHAR(500),
	MaterialPeligroso BIT,
	CveMaterialPeligroso VARCHAR(300),
	Embalaje VARCHAR(30),
	DescripEmbalaje VARCHAR(300),
	PesoEnKg NUMERIC(10,3),
	ValorMercancia NUMERIC(20,2),
	Moneda VARCHAR(10),
	FraccionArancelaria VARCHAR(15),
	Pedimento VARCHAR(30)
)
;
IF TYPE_ID(N'RemolquesTipo') IS NOT NULL
	BEGIN
		DROP TYPE RemolquesTipo
	END
;
CREATE TYPE RemolquesTipo AS TABLE (
	SubTipoRem VARCHAR(100),
	Placa VARCHAR(100)
)
;
IF OBJECT_ID(N'sat.FN_CCP_CreacionDomicilios') IS NOT NULL
	BEGIN
		DROP FUNCTION sat.FN_CCP_CreacionDomicilios
	END
;
CREATE FUNCTION sat.FN_CCP_CreacionDomicilios (  
 @ParCadCalle VARCHAR(200),  
 @ParCadNumeroExterior VARCHAR(5),  
 @ParCadNumeroInterior VARCHAR(5) = '',  
 @ParCadColonia VARCHAR(200),  
 @ParCadLocalidad VARCHAR(200) = '',  
 @ParCadReferencia VARCHAR(500) = '',  
 @ParCadMunicipio VARCHAR(200) = '',  
 @ParCadEstado VARCHAR(200),  
 @ParCadPais VARCHAR(200),  
 @ParCadCodigoPostal VARCHAR(10)  
)  
RETURNS VARCHAR(8000)  
AS  
BEGIN  
 DECLARE @VarCadResultado VARCHAR(8000);  
  
 DECLARE @VarCadAperturaDomicilio VARCHAR(100);  
 SELECT @VarCadAperturaDomicilio = '<cartaporte20:Domicilio ';  
 SELECT @VarCadResultado = @VarCadAperturaDomicilio;  
  
 --Calle  
 DECLARE @VarCadCalle VARCHAR(300);  
 SELECT @VarCadCalle = CONCAT('Calle="', @ParCadCalle,'" ');  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadCalle);  
  
 --Número exterior  
 DECLARE @VarCadNumeroExterior VARCHAR(30);  
 SELECT @VarCadNumeroExterior = CONCAT('NumeroExterior="', @ParCadNumeroExterior ,'" ');  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadNumeroExterior);  
  
 --Número interior  
 IF @ParCadNumeroInterior<>''  
  BEGIN  
   DECLARE @VarCadNumeroInterior VARCHAR(30);  
   SELECT @VarCadNumeroInterior = CONCAT('NumeroInterior="', @ParCadNumeroInterior ,'" ');  
   SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadNumeroInterior);  
  END  
  
 --Colonia  
 DECLARE @VarCadColonia VARCHAR(250);  
 SELECT @VarCadColonia = CONCAT('Colonia="', @ParCadColonia,'" ');  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadColonia);  
  
 --Localidad: Aquí va if porque si es extranjero esto no necesita ir  
 IF @ParCadLocalidad <> ''  
  BEGIN  
   DECLARE @VarCadLocalidad VARCHAR(250);  
   SELECT @VarCadLocalidad = CONCAT('Localidad="', @ParCadLocalidad, '" ');  
   SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadLocalidad);  
  END  
  
 --Referencia: Aquí va if porque esto es opcional  
 IF @ParCadReferencia <> ''  
  BEGIN  
   DECLARE @VarCadReferencia VARCHAR(550);  
   SELECT @VarCadReferencia = CONCAT('Referencia="', @ParCadReferencia ,'" ');  
   SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadReferencia);  
  END  
  
 --Municipio: Aquí va if porque si es extranjero puede no venir  
 IF @ParCadMunicipio <> ''  
  BEGIN  
   DECLARE @VarCadMunicipio VARCHAR(250);  
   SELECT @VarCadMunicipio = CONCAT('Municipio="', @ParCadMunicipio,'" ');  
   SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadMunicipio);  
  END  
  
 --Sigue el estado, esto es forzoso  
 DECLARE @VarCadEstado VARCHAR(250);  
 SELECT @VarCadEstado = CONCAT('Estado="', @ParCadEstado,'" ');  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadEstado);  
  
 --Sigue el país, esto también es forzoso  
 DECLARE @VarCadPais VARCHAR(250);  
 SELECT @VarCadPais = CONCAT('Pais="', @ParCadPais,'" ');  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadPais);  
  
 --Por último, el código postal  
 DECLARE @VarCadCodigoPostal VARCHAR(60);  
 SELECT @VarCadCodigoPostal = CONCAT('CodigoPostal="', @ParCadCodigoPostal,'" ');  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, @VarCadCodigoPostal);  
  
 --Y cerramos  
 SELECT @VarCadResultado = CONCAT(@VarCadResultado, '/>');  
  
 RETURN @VarCadResultado;  
END  
;
IF OBJECT_ID(N'sat.FN_CCP_CreacionUbicacion') IS NOT NULL
	BEGIN
		DROP FUNCTION sat.FN_CCP_CreacionUbicacion
	END
;
CREATE FUNCTION sat.FN_CCP_CreacionUbicacion (  
 @ParCadTipoUbicacion VARCHAR(15),  
 @ParCadIdUbicacion CHAR(8),  
 @ParCadRfcRemitenteDestinatario VARCHAR(15),  
 @ParCadNombreRemitenteDestinatario VARCHAR(500),  
 @ParCadNumRegIdTrib VARCHAR(50),  
 @ParCadResidenciaFiscal VARCHAR(10),  
 @ParCadFechaHoraSalidaLlegada VARCHAR(60),  
 @ParCadDistanciaRecorrida VARCHAR(10),  
 @ParBitEsUbicacionExtranjera BIT,  
 @ParBitEsDestino BIT,  
 @ParCadCalle VARCHAR(200),  
 @ParCadNumeroExterior VARCHAR(5),  
 @ParCadNumeroInterior VARCHAR(5) = '',  
 @ParCadColonia VARCHAR(200),  
 @ParCadLocalidad VARCHAR(200) = '',  
 @ParCadReferencia VARCHAR(500) = '',  
 @ParCadMunicipio VARCHAR(200) = '',  
 @ParCadEstado VARCHAR(200),  
 @ParCadPais VARCHAR(200),  
 @ParCadCodigoPostal VARCHAR(10)  
)  
RETURNS VARCHAR(MAX)  
AS  
 BEGIN  
  DECLARE @VarCadResultado VARCHAR(MAX);  
  
  --Comienzo, primero abro  
  SELECT @VarCadResultado = '<cartaporte20:Ubicacion ';  
  
  --Sigue el tipo de ubicacion  
  DECLARE @VarCadTipoUbicacion VARCHAR(60);  
  SELECT @VarCadTipoUbicacion = CONCAT('TipoUbicacion="', @ParCadTipoUbicacion ,'" ');  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadTipoUbicacion;  
  
  --Luego el id de la ubicación  
  DECLARE @VarCadIdUbicacion VARCHAR(60);  
  SELECT @VarCadIdUbicacion = CONCAT('IDUbicacion="', @ParCadIdUbicacion,'" ');  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadIdUbicacion;  
  
  --Luego el RFC de la persona  
  DECLARE @VarCadRfcRemitenteDestinatario VARCHAR(65);  
  SELECT @VarCadRfcRemitenteDestinatario = CONCAT('RFCRemitenteDestinatario="', @ParCadRfcRemitenteDestinatario,'" ');  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadRfcRemitenteDestinatario;  
  
  --A continuación el nombre  
  DECLARE @VarCadNombre VARCHAR(550);  
  SELECT @VarCadNombre = CONCAT('NombreRemitenteDestinatario="', @ParCadNombreRemitenteDestinatario,'" ');  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadNombre;  
  
  --Lo siguiente es solo es un destino extranjero  
  IF @ParBitEsUbicacionExtranjera = 1  
   BEGIN  
    DECLARE @VarCadNumRegIdTrib VARCHAR(100);  
    SELECT @VarCadNumRegIdTrib = CONCAT('NumRegIdTrib="', @ParCadNumRegIdTrib, '" ');  
    SELECT @VarCadResultado = @VarCadResultado + @VarCadNumRegIdTrib;  
  
    DECLARE @VarCadResidenciaFiscal VARCHAR(100);  
    SELECT @VarCadResidenciaFiscal = CONCAT('ResidenciaFiscal="', @ParCadResidenciaFiscal,'" ');  
    SELECT @VarCadResultado = @VarCadResultado + @VarCadResidenciaFiscal;  
   END  
  
  --Fecha y hora de salida, estos siempre van  
  DECLARE @VarCadFechaHoraSalida VARCHAR(110);  
  SELECT @VarCadFechaHoraSalida = CONCAT('FechaHoraSalidaLlegada="',@ParCadFechaHoraSalidaLlegada,'" ');  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadFechaHoraSalida;  
  
  --La distancia recorrida solo aplica si se es destino  
  IF @ParBitEsDestino = 1  
   BEGIN  
    DECLARE @VarCadDistanciaRecorrida VARCHAR(110);  
    SELECT @VarCadDistanciaRecorrida = CONCAT('DistanciaRecorrida="', @ParCadDistanciaRecorrida,'" ');  
    SELECT @VarCadResultado = @VarCadResultado + @VarCadDistanciaRecorrida;  
   END  
  
  --Ahora cierro  
  SELECT @VarCadResultado = @VarCadResultado+'>';  
  
    --Luego, obtenemos los datos del domicilio  
    SELECT @VarCadResultado = @VarCadResultado + sat.FN_CCP_CreacionDomicilios(  
   @ParCadCalle,   
   @ParCadNumeroExterior,  
   @ParCadNumeroInterior,  
   @ParCadColonia,  
   @ParCadLocalidad,  
   @ParCadReferencia,  
   @ParCadMunicipio,  
   @ParCadEstado,  
   @ParCadPais,  
   @ParCadCodigoPostal  
  );  
  
  --Finalmente, cerramos la parte de la ubicación y terminamos  
  SELECT @VarCadResultado = @VarCadResultado + ' </cartaporte20:Ubicacion>'  
      
  
    RETURN @VarCadResultado;  
 END
;
IF OBJECT_ID(N'sat.FN_CCP_CreacionMercancia') IS NOT NULL
	BEGIN
		DROP FUNCTION sat.FN_CCP_CreacionMercancia
	END
;
CREATE FUNCTION sat.FN_CCP_CreacionMercancia(  
 @ParCadCadProdServ VARCHAR(20),  
 @ParCadDescripcion VARCHAR(1000),  
 @ParCadCantidad VARCHAR(10),  
 @ParCadClaveUnidad VARCHAR(10),  
 @ParCadUnidad VARCHAR(200),  
 @ParCadDimensiones VARCHAR(500),  
 @ParBitMaterialPeligroso BIT,  
 @ParCadCveMaterialPeligroso VARCHAR(30),  
 @ParCadEmbalaje VARCHAR(30),  
 @ParCadDescripEmbalaje VARCHAR(200),  
 @ParCadPesoEnKg VARCHAR(15),  
 @ParCadValorMercancia VARCHAR(25),  
 @ParCadMoneda VARCHAR(10),  
 @ParCadFraccionArancelaria VARCHAR(15),  
 @ParCadPedimento VARCHAR(30),  
 @ParTabCantidadTransporta CantidadTransportaTipo READONLY  
)  
RETURNS VARCHAR(MAX)  
AS  
BEGIN  
 --Declaro una variable local para evitar parameter sniffing  
 DECLARE @VarTabCantidadTransporta CantidadTransportaTipo;  
 INSERT INTO @VarTabCantidadTransporta   
  SELECT * FROM @ParTabCantidadTransporta WHERE CadProdServ=@ParCadCadProdServ;  
  
 DECLARE @VarCadResultado VARCHAR(MAX);  
  
 SELECT @VarCadResultado = '<cartaporte20:Mercancia ';  
  
 --Clave prod serv  
 DECLARE @VarCadProdServ VARCHAR(60);  
 SELECT @VarCadProdServ = CONCAT('BienesTransp="', @ParCadCadProdServ, '" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadProdServ;  
  
 --Descripcion  
 DECLARE @VarCadDescripcion VARCHAR(1030);  
 SELECT @VarCadDescripcion = CONCAT('Descripcion="', @ParCadDescripcion, '" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadDescripcion;  
  
 --Cantidad  
 DECLARE @VarCadCantidad VARCHAR(60);  
 SELECT @VarCadCantidad = CONCAT('Cantidad="', @ParCadCantidad,'" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadCantidad;  
  
 --Clave unidad  
 DECLARE @VarCadClaveUnidad VARCHAR(60);  
 SELECT @VarCadClaveUnidad = CONCAT('ClaveUnidad="', @ParCadClaveUnidad,'" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadClaveUnidad;  
  
 --Unidad: Esta es opcional  
 IF @ParCadUnidad <> ''  
  BEGIN  
   DECLARE @VarCadUnidad VARCHAR(230);  
   SELECT @VarCadUnidad = CONCAT('Unidad="', @ParCadUnidad,'" ');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadUnidad;  
  END  
  
 --Material Peligroso: Solo incluir si se traslada material peligroso  
 IF @ParBitMaterialPeligroso = 1  
  BEGIN  
   DECLARE @VarCadMaterialPeligrosoSiNo VARCHAR(40) = 'MaterialPeligroso="Sí" ';  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadMaterialPeligrosoSiNo;  
  
   DECLARE @VarCadCveMaterialPeligroso VARCHAR(80);  
   SELECT @VarCadCveMaterialPeligroso = CONCAT('CveMaterialPeligroso="', @ParCadCveMaterialPeligroso,'" ');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadCveMaterialPeligroso;  
  
   DECLARE @VarCadEmbalaje VARCHAR(80);  
   SELECT @VarCadEmbalaje = CONCAT('Embalaje="', @ParCadEmbalaje ,'');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadEmbalaje;  
  
   DECLARE @VarCadDescripcionEmbalaje VARCHAR(230);  
   SELECT @VarCadDescripcionEmbalaje = CONCAT('DescripEmbalaje="', @ParCadDescripEmbalaje,'" ');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadDescripcionEmbalaje;  
  END  
  
 --Peso en kg  
 DECLARE @VarCadPesoEnKg VARCHAR(40);  
 SELECT @VarCadPesoEnKg = CONCAT('PesoEnKg="', @ParCadPesoEnKg,'" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadPesoEnKg;  
  
 --Dimensiones: Esta es opcional  
 IF @ParCadDimensiones <> ''  
  BEGIN  
   DECLARE @VarCadDimensiones VARCHAR(540);  
   SELECT @VarCadDimensiones = CONCAT('Dimensiones="', @ParCadDimensiones ,'" ');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadDimensiones;  
  END  
  
 --Valor de la mercancía  
 DECLARE @VarCadValorMercancia VARCHAR(80);  
 SELECT @VarCadValorMercancia = CONCAT('ValorMercancia="', @ParCadValorMercancia, '" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadValorMercancia;  
  
 --Moneda  
 DECLARE @VarCadMoneda VARCHAR(40);  
 SELECT @VarCadMoneda = CONCAT('Moneda="', @ParCadMoneda,'" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadMoneda;  
   
 --Fracción arancelaria: También es opcional  
 IF @ParCadFraccionArancelaria <> ''  
  BEGIN  
   DECLARE @VarCadFraccionArancelaria VARCHAR(100);  
   SELECT @VarCadFraccionArancelaria = CONCAT('FraccionArancelaria="', @ParCadFraccionArancelaria,'" ');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadFraccionArancelaria;  
  END  
  
 --Ahora tenemos que ver que procede  
 --Si no hay ni pedimento (movimiento fuera del país) ni cantidad de mercancías transportadas, podemos cerrar directamente  
 --y regresar  
 --Si hay alguno de dos, la etiqueta tendrá hijos  
 IF @ParCadPedimento = 0 AND (SELECT COUNT(*) FROM @VarTabCantidadTransporta)=0  
  BEGIN  
   SELECT @VarCadResultado = @VarCadResultado + '/>';  
   RETURN @VarCadResultado;  
  END  
 SELECT @VarCadResultado = @VarCadResultado + '>';  
  
 --Pedimento: Esta también es opcional  
 IF @ParCadPedimento <> ''  
  BEGIN  
   DECLARE @VarCadPedimento VARCHAR(200);  
   SELECT @VarCadPedimento = CONCAT('<Pedimentos Pedimento="', @ParCadPedimento, '"/>');  
   SELECT @VarCadResultado = @VarCadResultado + @VarCadPedimento;  
  END  
  
 --Ahora la cantidad de mercancías  
 IF (SELECT COUNT(*) FROM @VarTabCantidadTransporta)>0  
  BEGIN  
   WITH CTE_Cadenas(Cadena) AS (  
    SELECT CONCAT('<cartaporte20:CantidadTransporta ',  
    'Cantidad="', Cantidad, '" ',  
    'IDOrigen="', IDOrigen, '" ',  
    'IDDestino="', IDDestino, '" ',  
    '/>')  
    FROM @VarTabCantidadTransporta  
   )  
   SELECT @VarCadResultado = @VarCadResultado + STRING_AGG(Cadena, '')  
    FROM CTE_Cadenas;  
  END  
  
 SELECT @VarCadResultado = @VarCadResultado + '</cartaporte20:Mercancia>'  
 RETURN @VarCadResultado;  
END
;
IF OBJECT_ID(N'sat.FN_CCP_CreacionAutoTransporte') IS NOT NULL
	BEGIN
		DROP FUNCTION sat.FN_CCP_CreacionAutoTransporte
	END
;
CREATE FUNCTION sat.FN_CCP_CreacionAutoTransporte(  
 @ParCadPermSCT VARCHAR(10),  
 @ParCadNumPermisoSCT VARCHAR(20),  
 @ParCadConfigVehicular VARCHAR(10),  
 @ParCadPlacaVM VARCHAR(20),  
 @ParCadAnioModeloVM VARCHAR(20),  
 @ParCadAseguraRespCivil VARCHAR(1000),  
 @ParCadPolizRespCivil VARCHAR(300),  
 @ParCadAseguraMedioAmbiente VARCHAR(1000) = '',  
 @ParCadPolizaMedAmbiente VARCHAR(300) = '',  
 @ParCadAseguraCarga VARCHAR(1000),  
 @ParCadPolizaCarga VARCHAR(2000),  
 @ParCadPrimaSeguro VARCHAR(25) = '',  
 @ParTabRemolques RemolquesTipo READONLY  
)  
RETURNS VARCHAR(MAX)  
AS  
BEGIN  
 DECLARE @VarCadResultado VARCHAR(MAX) = '<cartaporte20:Autotransporte ';  
   
 --Permiso de la SCT  
 DECLARE @VarCadPermSct VARCHAR(30);  
 SELECT @VarCadPermSct = CONCAT('PermSCT="', @ParCadPermSCT ,'" ');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadPermSct;  
   
 --Número de permiso de la SCT  
 DECLARE @VarCadNumPermisoSct VARCHAR(60);  
 SELECT @VarCadNumPermisoSct = CONCAT('NumPermisoSCT="', @ParCadNumPermisoSct, '"');  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadNumPermisoSct;  
  
 --Cierro este nodo padre  
 SELECT @VarCadResultado = @VarCadResultado + '>';  
  
  --Ahora, la parte de configuración vehícular  
  --Hago otro tab para que se note que es nodo hijo en el XML  
  DECLARE @VarCadTagConfigVehicular VARCHAR(800) = '<cartaporte20:IdentificacionVehicular ';  
  
  --Config vehicular del catalogo  
  DECLARE @VarCadConfigVehicular VARCHAR(40) = CONCAT('ConfigVehicular="', @ParCadConfigVehicular ,'" ');  
  --Placas  
  DECLARE @VarCadPlacaVM VARCHAR(50) = CONCAT('PlacaVM="', @ParCadPlacaVM, '" ');  
  ---Y año modelo  
  DECLARE @VarCadAnioModelo VARCHAR(50) = CONCAT('AnioModeloVM="', @ParCadAnioModeloVM, '" ');  
  
  SELECT @VarCadTagConfigVehicular = @VarCadTagConfigVehicular + @VarCadConfigVehicular  
          + @VarCadPlacaVM   
          + @VarCadAnioModelo;  
  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadTagConfigVehicular + '/>';  
  
  --Ahora la parte de los seguros  
   --Al igual que ConfigVehicular, lo hago aparte para que se note que es nodo hijo en el XML  
   DECLARE @VarCadTagSeguros VARCHAR(2000) = '<cartaporte20:Seguros ';  
   --Aseguradora de resp civil  
   DECLARE @VarCadAseguraRespCivil VARCHAR(1050) = CONCAT('AseguraRespCivil="', @ParCadAseguraRespCivil, '" ');  
   SELECT @VarCadTagSeguros = @VarCadTagSeguros + @VarCadAseguraRespCivil;  
   --Póliza de seguros  
   DECLARE @VarCadPolizaRespCivil VARCHAR(350) = CONCAT('PolizaRespCivil="', @ParCadPolizRespCivil, '" ');  
   SELECT @VarCadTagSeguros = @VarCadTagSeguros + @VarCadPolizaRespCivil;  
  
   --Daños al medio ambiente, solo incluir si ha dado bien la info  
   IF @ParCadAseguraMedioAmbiente <> '' AND @ParCadPolizaMedAmbiente <> ''  
    BEGIN  
     --Aseguradora de años al medio ambinete  
     DECLARE @VarCadAseguraMedioAmbiente VARCHAR(1030) = CONCAT('AseguraMedAmbiente="', @ParCadAseguraMedioAmbiente,'" ');  
     --Póliza de seguros por daños al medio ambiente  
     DECLARE @VarCadPolizaMedioAmbiente VARCHAR(330) = CONCAT('PolizaMedAmbiente="', @ParCadPolizaMedAmbiente,'" ');  
     SELECT @VarCadTagSeguros = @VarCadTagSeguros + @VarCadAseguraMedioAmbiente + @VarCadPolizaMedioAmbiente;  
    END  
  
   --Aseguradora de la carga, por si es necesario también  
   IF @ParCadAseguraCarga <> '' AND @ParCadPolizaCarga <> ''  
    BEGIN  
     --Aseguradora de la carga  
     DECLARE @VarCadAseguraCarga VARCHAR(1030) = CONCAT('AseguraCarga="', @ParCadAseguraCarga, '" ');  
     --Póliza de seguros de la carga  
     DECLARE @VarCadPolizaCarga VARCHAR(330) = CONCAT('PolizaCarga="', @ParCadPolizaCarga, '" ');  
     SELECT @VarCadTagSeguros = @VarCadTagSeguros + @VarCadAseguraCarga + @VarCadPolizaCarga;  
    END  
  
  --Por último, la prima del seguro  
  IF @ParCadPrimaSeguro <> ''  
   BEGIN  
    DECLARE @VarCadPrimaSeguro VARCHAR(55) = CONCAT('PrimaSeguro="', @ParCadPrimaSeguro, '" ');  
    SELECT @VarCadTagSeguros = @VarCadTagSeguros + @VarCadPrimaSeguro;  
   END  
  
  SELECT @VarCadTagSeguros = @VarCadTagSeguros + '/>';  
  
 --Termino la sección de seguros  
 SELECT @VarCadResultado = @VarCadResultado + @VarCadTagSeguros;  
  
  --Por último la opción de remolques  
  --También lo pongo con tab para indicar que es hijo  
  DECLARE @VarTabRemolques RemolquesTipo;  
  INSERT INTO @VarTabRemolques   
   SELECT * FROM @ParTabRemolques;  
  
  IF (SELECT COUNT(*) FROM @VarTabRemolques)>0   
   BEGIN  
    SELECT @VarCadResultado = @VarCadResultado + (  
    SELECT STRING_AGG(  
     CONCAT(  
      '<cartaporte20:Remolques ',  
      'SubTipoRem="', SubTipoRem, '" ',  
      'Placa="', Placa,'" ',  
      '/>'  
     )  
    , ' ')  
    FROM @VarTabRemolques);  
   END  
  
 SELECT @VarCadResultado = @VarCadResultado + '</cartaporte20:Autotransporte>';  
 RETURN @VarCadResultado;  
END
;
IF OBJECT_ID(N'sat.FN_CCP_CreacionFiguraTransporte') IS NOT NULL
	BEGIN
		DROP FUNCTION sat.FN_CCP_CreacionFiguraTransporte
	END
;
CREATE FUNCTION sat.FN_CCP_CreacionFiguraTransporte(  
 @ParCadTipoFigura VARCHAR(2),  
 @ParCadRfcFiguraTransporte VARCHAR(25),  
 @ParCadNumLicencia VARCHAR(50),  
 @ParCadNombreFiguraTransporte VARCHAR(300),  
 @ParBitEsTransportistaExtranjero BIT,  
 @ParCadNumRegIdTrib VARCHAR(50) = '',  
 @ParCadResidenciaFiscalFigura VARCHAR(30) = '',  
 @ParTabPartesTransporte RemolquesTipo READONLY,  
 @ParTabDomicilioOperador DomicilioTipo READONLY  
)  
RETURNS VARCHAR(MAX)  
AS  
BEGIN  
 DECLARE @VarCadResultado VARCHAR(MAX);  
  
 SELECT @VarCadResultado = '<cartaporte20:FiguraTransporte>';  
  
 --Creación del tipo de figura  
  DECLARE @VarCadTagTipoFigura VARCHAR(2000) = '<cartaporte20:TiposFigura ';  
  --Tipo de figura  
  DECLARE @VarCadTipoFigura VARCHAR(30) = CONCAT('TipoFigura="', @ParCadTipoFigura, '" ');  
  SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + @VarCadTipoFigura;  
  --RFC  
  DECLARE @VarCadRfcFigura VARCHAR(60) = CONCAT('RFCFigura="', @ParCadRfcFiguraTransporte, '" ');  
  SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + @VarCadRfcFigura;  
  --Número de licencia  
  DECLARE @VarCadNumLicencia VARCHAR(60) = CONCAT('NumLicencia="', @ParCadNumLicencia,'" ');  
  SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + @VarCadNumLicencia;  
  --Nombre del operador  
  DECLARE @VarCadNombreOperador VARCHAR(330) = CONCAT('NombreFigura="', @ParCadNombreFiguraTransporte,'" ');  
  SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + @VarCadNombreOperador;   
  --Esto solo aplica si es extranjero  
  IF @ParBitEsTransportistaExtranjero = 1  
   BEGIN  
    --NumRegIdTribFigura  
    DECLARE @VarCadNumRegIdTrib VARCHAR(80) = CONCAT('NumRegIdTribFigura="', @ParCadNumRegIdTrib, '" ');  
    SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + @VarCadNumRegIdTrib;  
    --ResidenciaFiscalFigura  
    DECLARE @VarCadResidenciaFiscal VARCHAR(80) = CONCAT('ResidenciaFiscalFigura="', @ParCadResidenciaFiscalFigura,'" ');  
    SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + @VarCadResidenciaFiscal;  
   END  
  --Termino el tipo de figura  
  SELECT @VarCadTagTipoFigura = @VarCadTagTipoFigura + '>';  
  
  --Añado el tipo de figura al resultado  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadTagTipoFigura;  
  
  --Ahora, las partes del remolque  
  DECLARE @VarTabPartesTransporte RemolquesTipo;  
  INSERT INTO @VarTabPartesTransporte   
   SELECT * FROM @ParTabPartesTransporte;  
  
  IF (SELECT COUNT(*) FROM @VarTabPartesTransporte)>0  
   BEGIN  
    WITH CTE_PartesTransporte(Cadena) AS (  
     SELECT CONCAT(  
      '<cartaporte20:PartesTransporte',  
      'ParteTransporte="', SubTipoRem, '" ',  
      ' />'  
     ) FROM @VarTabPartesTransporte  
    )  
    SELECT @VarCadResultado = @VarCadResultado + STRING_AGG(Cadena, '')  
     FROM CTE_PartesTransporte;  
   END  
  
  --Ahora, obtengo el domicilio  
  SELECT @VarCadResultado = @VarCadResultado +   
   (SELECT sat.FN_CCP_CreacionDomicilios(  
     Calle,  
     NumeroExterior,  
     NumeroInterior,  
     Colonia,  
     Localidad,  
     Referencia,  
     Municipio,  
     Estado,  
     Pais,  
     CodigoPostal  
    )  
    FROM @ParTabDomicilioOperador);  
  
  SELECT @VarCadResultado = @VarCadResultado + '</cartaporte20:TiposFigura>';  
    
  SELECT @VarCadResultado = @VarCadResultado + '</cartaporte20:FiguraTransporte>';  
  RETURN @VarCadResultado;  
END  
;
IF OBJECT_ID(N'sat.SP_CCP_CreacionComplementoCartaPorte') IS NOT NULL
	BEGIN
		DROP FUNCTION sat.SP_CCP_CreacionComplementoCartaPorte
	END
;
CREATE FUNCTION sat.SP_CCP_CreacionComplementoCartaPorte(  
 @ParCadTipoCfdi CHAR(1), --Debe ser T o I  
 @ParBitTransporteInternacional BIT,  
 @ParCadEntradaSalidaMercancias VARCHAR(15) = '',  
 @ParCadPaisOrigenDestino VARCHAR(15) = '',  
 @ParCadViaEntradaSalida CHAR(2) = '',  
 @ParNumTotalDistRec NUMERIC(15,3),  
 @ParTabUbicaciones UbicacionTipo  READONLY,  
 @ParTabDomicilio DomicilioTipo  READONLY,  
 @ParNumPesoBrutoTotal NUMERIC(15,0),  
 @ParCadUnidadPeso VARCHAR(5),  
 @ParNumTotalMercancias NUMERIC(10,0),  
 @ParTabMercancia MercanciaTipo  READONLY,  
 @ParTabMercanciaConDestinos CantidadTransportaTipo  READONLY,  
 @ParCadPermSCT VARCHAR(10),  
 @ParCadNumPermisoSCT VARCHAR(20),  
 @ParCadConfigVehicular VARCHAR(10),  
 @ParCadPlacaVM VARCHAR(20),  
 @ParCadAnioModeloVM VARCHAR(20),  
 @ParCadAseguraRespCivil VARCHAR(1000),  
 @ParCadPolizRespCivil VARCHAR(300),  
 @ParCadAseguraMedioAmbiente VARCHAR(1000) = '',  
 @ParCadPolizaMedAmbiente VARCHAR(1000) = '',  
 @ParCadAseguraCarga VARCHAR(1000),  
 @ParCadPolizaCarga VARCHAR(2000),  
 @ParNumPrimaSeguro VARCHAR(25),  
 @ParTabRemolques RemolquesTipo READONLY,  
 @ParCadTipoFigura VARCHAR(20),  
 @ParCadRfcFiguraTransporte VARCHAR(25),  
 @ParCadNumLicencia VARCHAR(50),  
 @ParCadNombreFiguraTransporte VARCHAR(1000),  
 @ParBitEsTransportistaExtranjero BIT,  
 @ParCadNumRegIdTribTransportista VARCHAR(500) = '',  
 @ParCadResidenciaFiscalFigura VARCHAR(30) = '',  
 @ParTabPartesTransporte RemolquesTipo READONLY,  
 @ParTabDomicilioOperador DomicilioTipo READONLY  
)  
RETURNS VARCHAR(MAX)  
AS  
BEGIN  
 --Resultado  
 DECLARE @VarCadResultado VARCHAR(MAX) = '';  
 --Partes de la carta porte  
 DECLARE @VarCadNodoApertura VARCHAR(1000);  
 DECLARE @VarCadUbicaciones VARCHAR(8000);  
  
 DECLARE @VarCadTerminacion CHAR(1)='>';  
   
 ------------------------------------------------------------------------------------------  
  --Primero el nodo de apertura  
  DECLARE @VarCadAperturaCartaPorte VARCHAR(200)='<cartaporte20:CartaPorte ';  
  
  --Comienzo con el primero de la mercancía  
  DECLARE @VarCadVersion VARCHAR(15)='Version="2.0" ';  
  DECLARE @VarCadTranspInter VARCHAR(500);  
  
  IF @ParBitTransporteInternacional = 1  
   BEGIN  
    SELECT @VarCadTranspInter = CONCAT(  
     'TranspInternac="Sí" ',  
     'EntradaSalidaMerc="', @ParCadEntradaSalidaMercancias,'" ',  
     'PaisOrigenDestino="', @ParCadPaisOrigenDestino, '" ',  
     'ViaEntradaSalida="', @ParCadViaEntradaSalida, '" '  
    );  
   END  
  ELSE  
   BEGIN  
    SELECT @VarCadTranspInter = 'TranspInternac="No" ';  
   END  
  
  DECLARE @VarCadTotalDist VARCHAR(500);  
  SELECT @VarCadTotalDist = CONCAT('TotalDistRec="', @ParNumTotalDistRec,'" ');  
  
  SELECT @VarCadNodoApertura = CONCAT(@VarCadAperturaCartaPorte,   
   @VarCadVersion, @VarCadTranspInter, @VarCadTotalDist,   
   @VarCadTerminacion  
  );  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadNodoApertura;  
  ------------------------------------------------------------------------------------------  
  --FIN del nodo de apertura  
  
  ------------------------------------------------------------------------------------------  
  --Continuo con el nodo de ubicaciones  
  DECLARE @VarCadAperturaUbicaciones VARCHAR(50)='<cartaporte20:Ubicaciones>';  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadAperturaUbicaciones;  
  
  WITH CTE_ListadoUbis(IDUbicacion, XmlResultado) AS  
    (  
    SELECT A.IDUbicacion, sat.FN_CCP_CreacionUbicacion(  
      A.TipoUbicacion, --ParCadTipoUbicacion  
      A.IDUbicacion, --ParCadIdUbicacion  
      A.RFC, --ParCadRfcRemitenteDestinatario  
      A.Nombre, --ParCadNombreRemitenteDestinatario  
      A.NumRegIdTrib, --ParCadNumRegIdTrib  
      A.ResidenciaFiscal, --ParCadResidenciaFiscal  
      A.FechaHoraSalidaLlegada, --ParCadFechaHoraSalidaLlegada  
      A.DistanciaRecorrida, --ParCadDistanciaRecorrida  
      A.EsExtranjero, --ParBitEsUbicacionExtranjera  
      A.EsDestinoIntermedio, --ParBitEsDestino  
      B.Calle, --ParCadCalle  
      B.NumeroExterior, --ParCadNumeroExterior  
      B.NumeroInterior, --ParCadNumeroInterior   
      B.Colonia, --ParCadColonia  
      B.Localidad, --ParCadLocalidad  
      B.Referencia, --ParCadReferencia  
      B.Municipio, --ParCadMunicipio  
      B.Estado, --ParCadEstado  
      B.Pais, --ParCadPais  
      B.CodigoPostal --ParCadCodigoPostal  
     )  
     FROM @ParTabUbicaciones A  
      INNER JOIN @ParTabDomicilio B ON A.IDUbicacion=B.IDUbicacion  
      ORDER BY CASE WHEN A.EsOrigen=1 THEN 1  
           WHEN A.EsDestinoIntermedio=1 AND A.EsDestinoFinal=0 THEN 2  
           WHEN A.EsDestinoFinal=1 THEN 3 END ASC  
           OFFSET 0 ROWS  
   )  
  SELECT @VarCadResultado = @VarCadResultado + STRING_AGG(XmlResultado,'') FROM CTE_ListadoUbis;  
  
  DECLARE @VarCadCierreUbicaciones VARCHAR(50)='</cartaporte20:Ubicaciones>'  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadCierreUbicaciones;  
  ------------------------------------------------------------------------------------------  
  --FIN del nodo de ubicaciones  
  
  ------------------------------------------------------------------------------------------  
  --Continuo con el nodo de mercancías  
  DECLARE @VarCadAperturaMercancias VARCHAR(80)='<cartaporte20:Mercancias ';  
   SELECT @VarCadResultado = @VarCadResultado +  
    @VarCadAperturaMercancias +  
    CONCAT(  
     'PesoBrutoTotal="', @ParNumPesoBrutoTotal,'" ',  
     'UnidadPeso="', @ParCadUnidadPeso, '" ',  
     'NumTotalMercancias="', @ParNumTotalMercancias, '" ',  
     '>'  
    );  
  
  WITH CTE_Mercancias(Cadena) AS (  
   SELECT sat.FN_CCP_CreacionMercancia(  
     CadProdServ, --ParCadCadProdServ  
     Descripcion, --ParCadDescripcion  
     Cantidad, --ParCadCantidad  
     ClaveUnidad, --ParCadClaveUnidad  
     Unidad, --ParCadUnidad  
     Dimensiones, --ParCadDimensiones  
     MaterialPeligroso, --ParBitMaterialPeligroso  
     CveMaterialPeligroso, --ParCadCveMaterialPeligroso  
     Embalaje, --ParCadEmbalaje  
     DescripEmbalaje, --ParCadDescripEmbalaje  
     PesoEnKg, --ParCadPesoEnKg  
     ValorMercancia, --ParCadValorMercancia  
     Moneda, --ParCadMoneda  
     FraccionArancelaria, --ParCadFraccionArancelaria  
     Pedimento, --ParCadPedimento  
     @ParTabMercanciaConDestinos  
    ) FROM @ParTabMercancia  
  )  
  SELECT @VarCadResultado = @VarCadResultado + STRING_AGG(Cadena, '')  
   FROM CTE_Mercancias;  
  DECLARE @VarCadCierreMercancias VARCHAR(80)='</cartaporte20:Mercancias>'  
  SELECT @VarCadResultado = @VarCadResultado + @VarCadCierreMercancias;  
  ------------------------------------------------------------------------------------------  
  --FIN del nodo de mercancías  
  
  ------------------------------------------------------------------------------------------  
  --Continuo con el nodo de autotransportes  
  SELECT @VarCadResultado = @VarCadResultado + sat.FN_CCP_CreacionAutoTransporte(  
    @ParCadPermSCT, --ParCadPermSCT  
    @ParCadNumPermisoSCT, --ParCadNumPermisoSCT  
    @ParCadConfigVehicular, --ParCadConfigVehicular  
    @ParCadPlacaVM, --ParCadPlacaVM  
    @ParCadAnioModeloVM, --ParCadAnioModeloVM  
    @ParCadAseguraRespCivil, --ParCadAseguraRespCivil  
    @ParCadPolizRespCivil, --ParCadPolizRespCivil  
    @ParCadAseguraMedioAmbiente, --ParCadAseguraMedioAmbiente  
    @ParCadPolizaMedAmbiente, --ParCadPolizaMedAmbiente  
    @ParCadAseguraCarga, --ParCadAseguraCarga  
    @ParCadPolizaCarga, --ParCadPolizaCarga  
    CAST(@ParNumPrimaSeguro AS VARCHAR(25)),  --ParCadPrimaSeguro  
    @ParTabRemolques --ParTabRemolques  
   );  
  ------------------------------------------------------------------------------------------  
  --FIN del nodo de autotransportes  
  
  ------------------------------------------------------------------------------------------  
  --Por último, el nodo de la figura del transporte  
  SELECT @VarCadResultado = @VarCadResultado + sat.FN_CCP_CreacionFiguraTransporte(  
    @ParCadTipoFigura, --ParCadTipoFigura  
    @ParCadRfcFiguraTransporte, --ParCadRfcFiguraTransporte  
    @ParCadNumLicencia, --ParCadNumLicencia      @ParCadNombreFiguraTransporte, --ParCadNombreFiguraTransporte  
    @ParBitEsTransportistaExtranjero, --ParBitEsTransportistaExtranjero  
    @ParCadNumRegIdTribTransportista, --ParCadNumRegIdTrib  
    @ParCadResidenciaFiscalFigura, --ParCadResidenciaFiscalFigura  
    @ParTabPartesTransporte, --ParTabPartesTransporte  
    @ParTabDomicilioOperador --ParTabDomicilioOperador  
   );  
    
  --Cerramos el complemento carta porte  
  SELECT @VarCadResultado = @VarCadResultado + '</cartaporte20:CartaPorte>';  
    
  RETURN @VarCadResultado;  
END
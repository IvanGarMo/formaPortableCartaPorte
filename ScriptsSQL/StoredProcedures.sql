IF OBJECT_ID('sat.SP_CCP_ObtenParametros') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenParametros;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenParametros  
AS  
BEGIN  
 SELECT c2.clave, c2.pestana, c2.valor  
  FROM sat.Parametros_CartaPorte c1  
  INNER JOIN sat.Parametros_CartaPorte c2  
  ON c1.clave='VERSION_ACTIVA' AND (c1.version=c2.version or c2.version IS NULL)  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenPaises') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenPaises;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenPaises(  
 @ParBitOpcionPorDefecto BIT,
 @ParCadPais VARCHAR(10) = ''
)  
AS  
BEGIN  
 IF @ParCadPais <> ''
	BEGIN
		SELECT c_Pais AS id, Descripcion AS descripcion
			FROM sat.c_Pais
			WHERE c_Pais=@ParCadPais
			ORDER BY id ASC;
			RETURN;
	END
 IF @ParBitOpcionPorDefecto = 1   
  BEGIN  
   SELECT '-01' AS id, '-SELECCIONE UN PAÍS-' AS descripcion  
   UNION ALL  
   SELECT c_Pais AS id, Descripcion AS descripcion  
   FROM sat.c_Pais  
   ORDER BY id ASC;  
  END  
 ELSE   
  SELECT c_Pais AS id, Descripcion AS descripcion  
  FROM sat.c_Pais  
  ORDER BY id ASC;  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenDescripcionPais') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenDescripcionPais;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenDescripcionPais(  
 @ParCadClavePais VARCHAR(100),  
 @ParCadDescripcionPais VARCHAR(100) OUTPUT  
)  
AS  
BEGIN  
 SELECT @ParCadDescripcionPais = Descripcion  
  FROM sat.c_Pais   
  WHERE c_Pais=@ParCadClavePais;  
 IF @ParCadDescripcionPais IS NULL  
  BEGIN  
   SET @ParCadDescripcionPais = '';  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenEstadosPais') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenEstadosPais;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenEstadosPais(  
 @ParBitOpcionPorDefecto BIT,  
 @ParCadPais VARCHAR(10)  
)  
AS  
BEGIN  
 IF @ParBitOpcionPorDefecto = 1   
  BEGIN  
   SELECT '-01' AS id, '-SELECCIONE UN ESTADO-' AS descripcion  
   UNION ALL  
   SELECT c_Estado AS id, [Nombre del estado] AS descripcion  
   FROM sat.c_Estado  
   WHERE c_Pais=@ParCadPais  
  END  
 ELSE   
  SELECT c_Estado AS id, [Nombre del estado] AS descripcion  
   FROM sat.c_Estado  
   WHERE c_Pais=@ParCadPais  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenMunicipiosEstado') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenMunicipiosEstado;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenMunicipiosEstado(  
 @ParBitOpcionPorDefecto BIT,  
 @ParCadEstado VARCHAR(5)  
)  
AS  
BEGIN  
 IF @ParBitOpcionPorDefecto = 1  
  BEGIN  
   SELECT '-01' AS id, '-SELECCIONE UN MUNICIPIO-' AS descripcion  
   UNION ALL  
   SELECT c_Municipio AS id, Descripción as descripcion  
   FROM sat.c_Municipio  
   WHERE c_Estado=@ParCadEstado;  
  END  
 ELSE  
  BEGIN  
   SELECT c_Municipio AS id, Descripción as descripcion  
   FROM sat.c_Municipio  
   WHERE c_Estado=@ParCadEstado;  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenLocalidadesEstado') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenLocalidadesEstado;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenLocalidadesEstado(  
 @ParBitOpcionPorDefecto BIT,  
 @ParCadEstado VARCHAR(5)  
)  
AS  
BEGIN  
 IF @ParBitOpcionPorDefecto = 1  
  BEGIN  
   SELECT '-1' AS id, '-SELECCIONE UNA LOCALIDAD-' AS descripcion  
   UNION ALL  
   SELECT c_Localidad AS id, Descripción AS descripcion  
   FROM sat.c_Localidad  
   WHERE c_Estado=@ParCadEstado  
  END  
 ELSE  
  BEGIN  
   SELECT c_Localidad AS id, Descripción AS descripcion  
   FROM sat.c_Localidad  
   WHERE c_Estado=@ParCadEstado  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenColoniasCodigoPostal') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenColoniasCodigoPostal;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenColoniasCodigoPostal(  
 @ParBitOpcionPorDefecto BIT,  
 @ParCadCodigoPostal VARCHAR(10)  
)  
AS  
BEGIN  
 IF @ParBitOpcionPorDefecto = 1  
  BEGIN  
   SELECT '-01' AS id, '-SELECCIONE UNA COLONIA-' AS descripcion  
   UNION ALL  
   SELECT c_Colonia AS id, NombreAsentamiento AS descripcion  
    FROM sat.c_colonia  
    WHERE c_CodigoPostal=@ParCadCodigoPostal  
  END  
 ELSE   
  BEGIN  
   SELECT c_Colonia AS id, NombreAsentamiento AS descripcion  
    FROM sat.c_colonia  
    WHERE c_CodigoPostal=@ParCadCodigoPostal  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_CargaDescripcionProducto') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_CargaDescripcionProducto;
	END
;
CREATE PROCEDURE sat.SP_CCP_CargaDescripcionProducto(  
 @ParCadClaveProdServ VARCHAR(100),  
 @ParCadDescripcionProdServ VARCHAR(500) OUTPUT  
)  
AS  
BEGIN  
 SELECT @ParCadDescripcionProdServ = Descripcion  
  FROM sat.c_ClaveProdServ   
  WHERE c_ClaveProdServ=@ParCadClaveProdServ;  
 IF @ParCadDescripcionProdServ IS NULL   
  BEGIN  
   SELECT @ParCadDescripcionProdServ = '';  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ClaveUnidadPeso') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ClaveUnidadPeso;
	END
;
CREATE PROCEDURE sat.SP_CCP_ClaveUnidadPeso(  
 @ParCadClaveUnidad VARCHAR(10),  
 @ParCadDescripcionClaveUnidad VARCHAR(500) OUTPUT  
)  
AS  
BEGIN  
 SELECT @ParCadDescripcionClaveUnidad = Nombre
  FROM sat.c_ClaveUnidad  
  WHERE c_ClaveUnidad=@ParCadClaveUnidad;  
 IF @ParCadDescripcionClaveUnidad IS NULL  
  BEGIN  
   SET @ParCadDescripcionClaveUnidad = '';  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenDescripcionMoneda') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenDescripcionMoneda;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenDescripcionMoneda(  
 @ParCadClaveMoneda VARCHAR(100),  
 @ParCadDescripcionMoneda VARCHAR(100) OUTPUT  
)  
AS  
BEGIN  
 SELECT @ParCadDescripcionMoneda = Descripcion  
  FROM sat.c_Moneda   
  WHERE c_Moneda=@ParCadClaveMoneda;  
 IF @ParCadDescripcionMoneda IS NULL  
  BEGIN  
   SET @ParCadDescripcionMoneda = '';  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenOpcionesDimensiones') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenOpcionesDimensiones;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenOpcionesDimensiones  
AS  
BEGIN  
 SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
 UNION ALL  
 SELECT 'cm' AS id, 'CENTÍMETROS' AS descripcion  
 UNION ALL  
 SELECT 'plg' AS id, 'PULGADAS' AS descripcion  
END
;
IF OBJECT_ID('sat.SP_CCP_TiposRemolque') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_TiposRemolque;
	END
;
CREATE PROCEDURE sat.SP_CCP_TiposRemolque  
AS  
BEGIN  
 SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
 UNION ALL  
 SELECT clave AS id, Descripcion AS descripcion FROM sat.c_SubTipoRem;  
END
;
IF OBJECT_ID('sat.SP_CCP_CargaDescripcionTipoTransporte') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_CargaDescripcionTipoTransporte;
	END
;
CREATE PROCEDURE sat.SP_CCP_CargaDescripcionTipoTransporte(  
 @ParCadClaveTransporte VARCHAR(10),  
 @ParCadDescripcionTransporte VARCHAR(100) OUTPUT  
)  
AS  
BEGIN  
 SELECT @ParCadDescripcionTransporte = Descripcion  
  FROM sat.c_SubTipoRem   
  WHERE clave=@ParCadClaveTransporte  
 IF @ParCadDescripcionTransporte IS NULL  
  BEGIN  
   SELECT @ParCadDescripcionTransporte = '';   
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_CargaPropiedadTransporte') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_CargaPropiedadTransporte;
	END
;
CREATE PROCEDURE sat.SP_CCP_CargaPropiedadTransporte  
AS  
BEGIN  
 SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
 UNION ALL  
 SELECT 'PP' AS id, 'PROPIO' AS descripcion  
 UNION ALL  
 SELECT 'RE' AS id, 'RENTADO' AS descripcion  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenTiposPermiso') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenTiposPermiso;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenTiposPermiso  
AS  
BEGIN  
 SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
 UNION ALL  
 SELECT Clave AS id, Descripcion AS descripcion  
  FROM sat.c_TipoPermiso  
END
;
IF OBJECT_ID('sat.SP_CPP_CargaConfiguracionAutoTransporte') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CPP_CargaConfiguracionAutoTransporte;
	END
;
CREATE PROCEDURE sat.SP_CPP_CargaConfiguracionAutoTransporte  
AS  
BEGIN  
 SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
 UNION ALL  
 SELECT clave AS id, Descripcion AS descripcion FROM sat.c_ConfigAutotransporte  
END  
;
IF OBJECT_ID('sat.SP_CPP_CargaDescripcionConfigAutoTransporte') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CPP_CargaDescripcionConfigAutoTransporte;
	END
;
CREATE PROCEDURE sat.SP_CPP_CargaDescripcionConfigAutoTransporte(  
 @ParCadClave AS VARCHAR(100),  
 @ParCadDescripcion AS VARCHAR(600) OUTPUT  
)  
AS  
BEGIN  
 SELECT @ParCadDescripcion = Descripcion  
  FROM sat.c_ConfigAutotransporte  
  WHERE Clave=@ParCadClave;  
 IF @ParCadDescripcion IS NULL  
  BEGIN  
   SELECT @ParCadDescripcion = '';  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ObtenTiposFiguraTransporte') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenTiposFiguraTransporte;
	END
;
CREATE PROCEDURE sat.SP_CCP_ObtenTiposFiguraTransporte(  
 @ParBitPropiedadAjena BIT  
)  
AS  
BEGIN  
 IF @ParBitPropiedadAjena = 0  
  BEGIN  
   SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
   UNION ALL  
   SELECT c_Clave AS id, descripcion AS descripcion  
    FROM sat.c_FiguraTransporte  
  END  
 ELSE  
  BEGIN  
   SELECT '-01' AS id, '-SELECCIONE-' AS descripcion  
   UNION ALL  
   SELECT c_Clave AS id, descripcion AS descripcion  
    FROM sat.c_FiguraTransporte WHERE validoSoloConPropiedadAjena=@ParBitPropiedadAjena  
  END  
END
;
IF OBJECT_ID('sat.SP_CCP_ValidaCodigoPostal') IS NOT NULL
	BEGIN
		DROP PROCEDURE sat.SP_CCP_ObtenTiposFiguraTransporte;
	END
;
CREATE PROCEDURE sat.SP_CCP_ValidaCodigoPostal(
	@ParCadCodigoPostal VARCHAR(8),
	@ParCadCodigoEstado VARCHAR(5),
	@ParCadMunicipio VARCHAR(5),
	@ParCadLocalidad VARCHAR(5),
	@ParBitValido BIT OUTPUT,
	@ParCadMensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    --Primero tengo que ver que el código postal exista
	IF NOT EXISTS(SELECT 1 FROM sat.c_CodigoPostal WHERE c_CodigoPostal=@ParCadCodigoPostal)
		BEGIN
			SELECT @ParBitValido = 0;
			SELECT @ParCadMensaje = 'El código postal ingresado no existe';
			RETURN;
		END
	DECLARE @VarCadCodigoEstado VARCHAR(5), @VarCadCodigoMunicipio VARCHAR(5), @VarCadCodigoLocalidad VARCHAR(5);

	--Luego aplico validacion de estados
	IF NOT EXISTS(SELECT 1 FROM sat.c_CodigoPostal WHERE c_CodigoPostal=@ParCadCodigoPostal AND c_Estado=@ParCadCodigoEstado)
		BEGIN
			SELECT @ParBitValido=0;
			SELECT @ParCadMensaje='El código postal ingresado no coincide con el estado ingresado'
		END

	--Luego, si hay uno que tenga tanto municipio como localidad, si puedo validar
	IF EXISTS(SELECT 1 FROM sat.c_CodigoPostal WHERE c_CodigoPostal=@ParCadCodigoPostal
				AND c_Estado IS NOT NULL
				AND c_Estado=@ParCadCodigoEstado
				AND c_Municipío IS NOT NULL
				AND c_Municipío=@ParCadMunicipio
				AND c_Localidad IS NOT NULL
				AND c_Localidad=@ParCadLocalidad)
		BEGIN
			SELECT TOP 1 
				@VarCadCodigoEstado=c_Estado, @VarCadCodigoMunicipio=c_Municipío, @VarCadCodigoLocalidad=c_Localidad
			FROM sat.c_CodigoPostal 
				WHERE c_CodigoPostal=@ParCadCodigoPostal
				AND c_Estado IS NOT NULL
				AND c_Estado=@ParCadCodigoEstado
				AND c_Municipío IS NOT NULL
				AND c_Municipío=@ParCadMunicipio
				AND c_Localidad IS NOT NULL
				AND c_Localidad=@ParCadLocalidad;

			--Ahora, ya puedo aplicar la validación de si son iguales
			IF (@ParCadCodigoEstado=@VarCadCodigoEstado) AND 
				(@ParCadMunicipio=@VarCadCodigoMunicipio) AND
				(@ParCadLocalidad=@VarCadCodigoLocalidad)
					BEGIN
						SET @ParBitValido=1; --Coincide
						SELECT @ParCadMensaje = '';
						RETURN;
					END
			ELSE
					BEGIN
						SELECT @ParBitValido=0;
						SELECT @ParCadMensaje='El código postal ingresado no coincide con el municipio o localidad ingresadas';
						RETURN;
					END
		END

		--Ahora, en el caso de que se de un codigo postal con localidad, pero municipio en null
		 IF EXISTS(SELECT 1 FROM sat.c_CodigoPostal WHERE c_CodigoPostal=@ParCadCodigoPostal
					AND c_Estado IS NOT NULL
					AND c_Estado=@ParCadCodigoEstado
					AND c_Municipío IS NULL
					AND c_Localidad IS NOT NULL
					AND c_Localidad=@ParCadLocalidad)
					BEGIN
						SELECT TOP 1 
						@VarCadCodigoEstado=c_Estado, @VarCadCodigoLocalidad=c_Localidad
						FROM sat.c_CodigoPostal 
							WHERE c_CodigoPostal=@ParCadCodigoPostal
							AND c_Estado IS NOT NULL
							AND c_Estado=@ParCadCodigoEstado
							AND c_Municipío IS NULL
							AND c_Localidad IS NOT NULL
							AND c_Localidad=@ParCadLocalidad;

							--Ahora, ya puedo aplicar la validación de si el estado y la localidad son iguales
							IF (@ParCadCodigoEstado=@VarCadCodigoEstado) AND 
								(@ParCadLocalidad=@VarCadCodigoLocalidad)
									BEGIN
										SET @ParBitValido=1; --Coincide
										SELECT @ParCadMensaje = '';
										RETURN;
									END
							ELSE
									BEGIN
										SELECT @ParBitValido=0;
										SELECT @ParCadMensaje='El código postal ingresado no coincide con localidad ingresada';
									END
					END

			--Ahora, en el caso de que se de un codigo postal con municipio, pero localidad en null
			IF EXISTS(SELECT 1 FROM sat.c_CodigoPostal WHERE c_CodigoPostal=@ParCadCodigoPostal
					AND c_Estado IS NOT NULL
					AND c_Estado=@ParCadCodigoEstado
					AND c_Municipío IS NOT NULL
					AND c_Municipío=@ParCadMunicipio
					AND c_Localidad IS NULL)
					BEGIN
						SELECT TOP 1 
						@VarCadCodigoEstado=c_Estado, @VarCadCodigoMunicipio=c_Municipío
						FROM sat.c_CodigoPostal 
							WHERE c_CodigoPostal=@ParCadCodigoPostal
							AND c_Estado IS NOT NULL
							AND c_Estado=@ParCadCodigoEstado
							AND c_Municipío IS NOT NULL
							AND c_Municipío=@ParCadMunicipio
							AND c_Localidad IS NULL

							--Ahora, ya puedo aplicar la validación de si el estado y la localidad son iguales
							IF (@ParCadCodigoEstado=@VarCadCodigoEstado) AND 
								(@ParCadLocalidad=@VarCadCodigoLocalidad)
									BEGIN
										SET @ParBitValido=1; --Coincide
										SELECT @ParCadMensaje = '';
										RETURN;
									END
							ELSE
									BEGIN
										SELECT @ParBitValido=0;
										SELECT @ParCadMensaje='El código postal ingresado no coincide con el municipio ingresado';
										RETURN;
									END
					END
END

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DBGral
        {private class ConStrings
            {public static String DataBase = "data source=.; initial catalog=HENDERSON_DB; integrated security=sspi";  //String de conexion
             //Strings de seleccion de todos los registros de cada entidad
             public static String AdministradorAll = "SELECT E.NOMBRE,E.APELLIDO,E.FECHANAC,E.DNI,TE.TELEFONO,EE.MAIL,DE.CALLE,DE.ALTURA,DE.PISO,DE.DEPARTAMENTO,E.FECHAINGRESO,E.SUELDO,E.SEXO "
                                                     + "FROM ADMINISTRADORES AS A,EMPLEADOS AS E,TELEFONOSE AS TE,DOMICILIOSE AS DE, EMAILSE AS EE "
                                                     + "WHERE A.DNI=E.DNI AND A.DNI=TE.DNI AND A.DNI=DE.DNI AND EE.DNI=A.DNI";
            public static String EmpleadosAll = "SELECT E.DNI,E.NOMBRE,E.APELLIDO,E.FECHANAC,TE.TELEFONO,EE.MAIL,DE.CALLE,DE.ALTURA,DE.PISO,DE.DEPARTAMENTO,E.FECHAINGRESO,E.SUELDO,E.SEXO "
                                                    + "FROM EMPLEADOS AS E,TELEFONOSE AS TE,DOMICILIOSE AS DE, EMAILSE AS EE "
                                                    + "WHERE E.DNI=TE.DNI AND E.DNI=DE.DNI AND EE.DNI=E.DNI";
             public static String ClientesAll = "SELECT C.NOMBRE,C.APELLIDO,C.FECHANAC,C.DNI,TE.TELEFONO,EE.MAIL,DE.CALLE,DE.ALTURA,DE.PISO,DE.DEPARTAMENTO,C.SEXO " + 
                                                     "FROM CLIENTES AS C, TELEFONOSC AS TE, DOMICILIOSC AS DE, EMAILSC AS EE " +
                                                     "WHERE C.DNI=TE.DNI AND C.DNI= DE.DNI AND EE.DNI= C.DNI";
             public static String ArticulosAll = "SELECT * FROM ARTICULOS";
             public static String EquiposAll = "SELECT * FROM EQUIPOS";
             public static String TelefonosEmAll = "SELECT * FROM TELEFONOSE";
             public static String DomiciliosEmAll = "SELECT * FROM DOMICILIOSE";
             public static String MailsEmAll = "SELECT * FROM EMAILSE";
             public static String TelefonosClAll = "SELECT * FROM TELEFONOSC";
             public static String DomiciliosClAll = "SELECT * FROM DOMICILIOSC";
             public static String MailsClAll = "SELECT * FROM EMAILSC";
             public static String InteresesAll = "SELECT * FROM INTERESES";
             public static String VentasAll = "SELECT * FROM VENTAS";
             public static String ArticulosVentasAll = "SELECT * FROM ARTICULOSXVENTA";
             public static String GrupoIncidenteAll = "SELECT * FROM GRUPOINCIDENTE";
             public static String SubTipoIncidenteAll = "SELECT * FROM SUBTIPOINCIDENTE";
             public static String TipoIncidenteAll = "SELECT * FROM TIPOINCIDENTE";
             public static String IncidentesAll = "SELECT * FROM INCIDENTES";
             public static String EmpleadosEquipoAll = "SELECT * FROM EMPLEADOSXEQUIPO";

            //Strings para insertar una fila completa en cada entidad
            public static String AdministradorInsert = "INSERT INTO ADMINISTRADORES (DNI) VALUES ('@dni')";
            public static String EmpleadosInsert = "INSERT INTO EMPLEADOS (DNI,NOMBRE,APELLIDO,FECHANAC,FECHAINGRESO,SEXO,SUELDO,EQUIPO) VALUES (@dni,@nombre,@apellido,@fechanac,@fechaingreso,@sexo,@sueldo,@equipo)";
            public static String ClientesInsert = "INSERT INTO CLIENTES (DNI,NOMBRE,APELLIDO,SEXO,FECHANAC) VALUES (@dni,@nombre,@apellido,@sexo,@fechanac)";
            public static String ArticulosInsert = "INSERT INTO ARTICULOS (NOMBRE,PRECIO,STOCK) VALUES (@nombre,@precio,@stock)";
            public static String EquiposInsert = "INSERT INTO EQUIPOS (NOMBRE) VALUES (@nombre)";
            public static String TelefonosEmInsert = "INSERT INTO TELEFONOSE (DNI,TELEFONO,DESCRIPCION) VALUES (@dni,@telefono,@descripcion)";
            public static String DomiciliosEmInsert = "INSERT INTO DOMICILIOSE (DNI,CALLE,ALTURA,PISO,DEPARTAMENTO) VALUES (@dni,@calle,@altura,@piso,@depto)";
            public static String MailsEmInsert = "INSERT INTO EMAILSE (DNI,MAIL) VALUES (@dni,@mail)";
            public static String TelefonosClInsert = "INSERT INTO TELEFONOSC (DNI,TELEFONO,DESCRIPCION) VALUES (@dni,@telefono,@descripcion)";
            public static String DomiciliosClInsert = "INSERT INTO DOMICILIOSC (DNI,CALLE,ALTURA,PISO,DEPARTAMENTO) VALUES (@dni,@calle,@altura,@piso,@depto)";
            public static String MailsClInsert = "INSERT INTO EMAILSC (DNI,MAIL) VALUES (@dni,@mail)";
            public static String InteresesInsert = "INSERT INTO INTERESES (PORCENTAJE,DESCRIPCION) VALUES (@porcentaje,@descripcion)";
            public static String VentasInsert = "INSERT INTO VENTAS (DNIE,DNIC,IDINTERES,FECHA) VALUES (@dnie,@dnic,@idinteres,@fecha)";
            public static String ArticulosVentasInsert = "INSERT INTO ARTICULOSXVENTA (IDVENTA,IDARTICULO,QART) VALUES (@idv,@ida,@qart)";
            public static String GrupoIncidenteInsert = "INSERT INTO GRUPOINCIDENTE (DESCRIPCION,IDTIPO) VALUES (@descripcion,@idt)";
            public static String SubTipoIncidenteInsert = "INSERT INTO SUBTIPOINCIDENTE (DESCRIPCION,IDGRUPO) VALUES (@descripcion,@idg)";
            public static String TipoIncidenteInsert = "INSERT INTO TIPOINCIDENTE (DESCRIPCION) VALUES (@descripcion)";
            public static String IncidentesInsert = "INSERT INTO INCIDENTES (ESTADO,DNICLIENTE,DNIEMPLEADO,PALTA,IDTIPO,IDGRUPO,IDSUB,IDVENTA,FECHA,DESCRIPCION) VALUES (@estado,@dnic,@dnie,@palta,@idt,@idg,@ids,@idv,@fecha,@desc)";
            public static String EmpleadosEquipoInsert = "INSERT INTO EMPLEADOSXEQUIPO (DNI,EQUIPO) VALUES (@dni,@equipo)";

            //String para seleccionar por ID
            public static String AdministradorById = "SELECT E.NOMBRE,E.APELLIDO,E.FECHANAC,E.DNI,TE.TELEFONO,EE.MAIL,DE.CALLE,DE.ALTURA,DE.PISO,DE.DEPARTAMENTO,E.FECHAINGRESO,E.SUELDO "
                                                     + "FROM ADMINISTRADORES AS A,EMPLEADOS AS E,TELEFONOSE AS TE,DOMICILIOSE AS DE, EMAILSE AS EE "
                                                     + "WHERE A.DNI=E.DNI AND A.DNI=TE.DNI AND A.DNI=DE.DNI AND EE.DNI=A.DNI AND A.DNI = @dni";
            public static String EmpleadosById = "SELECT * FROM EMPLEADOS WHERE DNI = @dni";
            public static String ClientesById = "SELECT * FROM CLIENTES WHERE DNI=@dni";
            public static String ArticulosById = "SELECT * FROM ARTICULOS WHERE IDARTICULO = @ida";
            public static String EquiposById = "SELECT * FROM EQUIPOS WHERE EQUIPO = @equipo";
            public static String TelefonosEmById = "SELECT * FROM TELEFONOSE WHERE DNI = @dni";
            public static String DomiciliosEmById = "SELECT * FROM DOMICILIOSE WHERE DNI = @dni";
            public static String MailsEmById = "SELECT * FROM EMAILSE WHERE DNI = @dni";
            public static String TelefonosClById = "SELECT * FROM TELEFONOSC WHERE DNI = @dni";
            public static String DomiciliosClById = "SELECT * FROM DOMICILIOSC WHERE DNI = @dni";
            public static String MailsClById = "SELECT * FROM EMAILSC WHERE DNI = @dni";
            public static String InteresesById = "SELECT * FROM INTERESES WHERE IDINTERES = @idi";
            public static String VentasById = "SELECT * FROM VENTAS WHERE IDVENTA = @idv";
            public static String ArticulosVentasByIdArt = "SELECT * FROM ARTICULOSXVENTA WHERE IDARTICULO = @ida";
            public static String ArticulosVentasByIdVen = "SELECT * FROM ARTICULOSXVENTA WHERE IDVENTA = @idv";
            public static String GrupoIncidenteById = "SELECT * FROM GRUPOINCIDENTE WHERE IDGRUPO = @idg";
            public static String GrupoIncidenteByIdTipo = "SELECT * FROM GRUPOINCIDENTE WHERE IDTIPO = @idt";
            public static String SubTipoIncidenteById = "SELECT * FROM SUBTIPOINCIDENTE WHERE IDSUBTIPO = @idst";
            public static String SubTipoIncidenteByIdGrupo = "SELECT * FROM SUBTIPOINCIDENTE WHERE IDGRUPO = @idg";
            public static String TipoIncidenteById = "SELECT * FROM TIPOINCIDENTE WHERE IDTIPO = @idt";
            public static String IncidentesById = "SELECT * FROM INCIDENTES WHERE IDINCID = @idi";
            public static String EmpleadosEquipoById = "SELECT * FROM EMPLEADOSXEQUIPO WHERE DNI = @dni";

            //Strings para actualizar un registro en cada tabla
            public static String EmpleadosUpdate = "UPDATE EMPLEADOS SET NOMBRE = @nombre, APELLIDO = @apellido, FECHANAC = @fechanac, FECHAINGRESO = @fechaing, " +
                                                    "SEXO = @sexo, SUELDO = @sueldo, EQUIPO = @equipo WHERE DNI = @dni";
            public static String ClientesUpdate = "UPDATE CLIENTES SET NOMBRE = @nombre, APELLIDO = @apellido, SEXO = @sexo, FECHANAC = @fechanac WHERE DNI= @dni";
            public static String ArticulosUpdate = "UPDATE ARTICULOS SET NOMBRE = @nombre, PRECIO = @precio, STOCK = @stock WHERE IDARTICULO = @ida";
            public static String EquiposUpdate = "UPDATE EQUIPOS SET NOMBRE = @nombre WHERE EQUIPO = @equipo";
            public static String TelefonosEmUpdate = "UPDATE TELEFONOSE SET TELEFONO = @telefono, DESCRIPCION = @descripcion WHERE DNI = @dni";
            public static String DomiciliosEmUpdate = "UPDATE DOMICILIOSE SET CALLE = @calle, ALTURA = @altura, PISO = @piso, DEPARTAMENTO = @departamento WHERE DNI = @dni";
            public static String MailsEmUpdate = "UPDATE EMAILSE SET MAIL = @mail WHERE DNI = @dni";
            public static String TelefonosClUpdate = "UPDATE TELEFONOSC SET TELEFONO = @telefono, DESCRIPCION = @descripcion WHERE DNI = @dni";
            public static String DomiciliosClUpdate = "UPDATE DOMICILIOSC SET CALLE = @calle, ALTURA = @altura, PISO = @piso, DEPARTAMENTO = @depto WHERE DNI = @dni";
            public static String MailsClUpdate = "UPDATE EMAILSC SET MAIL = @mail WHERE DNI = @dni";
            public static String InteresesUpdate = "UPDATE INTERESES SET PORCENTAJE = @porcentaje, DESCRIPCION = @descripcion WHERE IDINTERES = @idi";
            public static String VentasUpdate = "UPDATE VENTAS SET DNIE = @dnie, DNIC = @dnic, IDINTERES = @idi, FECHA = @fecha WHERE IDVENTA = @idv";
            public static String ArticulosVentasUpdateByArt = "UPDATE ARTICULOSXVENTA SET IDARTICULO = @ida, QART = @qart WHERE IDVENTA = @idv";
            public static String ArticulosVentasUpdateByVen = "UPDATE ARTICULOSXVENTA SET IDVENTA = @idv, QART = @qart WHERE IDARTICULO = @ida";
            public static String GrupoIncidenteUpdate = "UPDATE GRUPOINCIDENTE SET DESCRIPCION = @descripcion, IDTIPO = @idt WHERE IDGRUPO = @idg";
            public static String SubTipoIncidenteUpdate = "UPDATE SUBTIPOINCIDENTE SET DESCRIPCION = @descripcion, IDGRUPO = @idg WHERE IDSUBTIPO = @idst";
            public static String TipoIncidenteUpdate = "UPDATE TIPOINCIDENTE SET DESCRIPCION = @descripcion WHERE IDTIPO = @idt";
            public static String IncidentesUpdate = "UPDATE INCIDENTES SET ESTADO = @estado, DNICLIENTE = @dnic, DNIEMPLEADO = @dnie, PALTA = @palta, IDTIPO = @idt, IDGRUPO = @idg, IDSUB = @ids, IDVENTA = @idv, FECHA = @fecha, DESCRIPCION = @desc WHERE IDINCID = @idi";
            public static String EmpleadosEquipoUpdateByDni = "UPDATE EMPLEADOSXEQUIPO SET EQUIPO = @equipo WHERE DNI = @dni";
            public static String EmpleadosEquipoUpdateByEquipo = "UPDATE EMPLEADOSXEQUIPO SET DNI = @dni WHERE EQUIPO = @equipo";

            //Strings para borrar registros por ID
            public static String AdministradorDelete = "DELETE FROM ADMINISTRADORES WHERE DNI = @dni";
            public static String EmpleadosDelete = "DELETE FROM EMPLEADOS WHERE DNI = @dni";
            public static String ClientesDelete = "DELETE FROM CLIENTES WHERE DNI = @dni";
            public static String ArticulosDelete = "DELETE FROM ARTICULOS WHERE IDARTICULO = @ida";
            public static String EquiposDelete = "DELETE FROM EQUIPOS WHERE EQUIPO = @equipo";
            public static String TelefonosEmDelete = "DELETE FROM TELEFONOSE WHERE DNI = @dni";
            public static String DomiciliosEmDelete = "DELETE FROM DOMICILIOSE WHERE DNI = @dni";
            public static String MailsEmDelete = "DELETE FROM MAILSE WHERE DNI = @dni";
            public static String TelefonosClDelete = "DELETE FROM TELEFONOSC WHERE DNI = @dni";
            public static String DomiciliosClDelete = "DELETE FROM DOMICILIOSC WHERE DNI = @dni";
            public static String MailsClDelete = "DELETE FROM MAILSC WHERE DNI = @dni";
            public static String InteresesDelete = "DELETE FROM INTERESES WHERE IDINTERES = @idi";
            public static String VentasDelete = "DELETE FROM VENTAS WHERE IDVENTA = @idv";
            public static String ArticulosVentasDeleteByArt = "DELETE FROM ARTICULOSXVENTA WHERE IDVENTA = @idv";
            public static String ArticulosVentasDeleteByVen = "DELETE FROM ARTICULOSXVENTA WHERE IDARTICULO = @ida";
            public static String GrupoIncidenteDelete = "DELETE FROM GRUPOINCIDENTE WHERE IDGRUPO = @idg";
            public static String SubTipoIncidenteDelete = "DELETE FROM SUBTIPOINCIDENTE WHERE IDSUBTIPO = @idst";
            public static String TipoIncidenteDelete = "DELETE FROM TIPOINCIDENTE WHERE IDTIPO = @idt";
            public static String IncidentesDelete = "DELETE FROM INCIDENTES WHERE IDINCID = @idi";
            public static String EmpleadosEquipoDeleteByDni = "DELETE FROM EMPLEADOSXEQUIPO WHERE DNI = @dni";
            public static String EmpleadosEquipoDeleteByEquipo = "DELETE FROM EMPLEADOSXEQUIPO WHERE EQUIPO = @equipo";

            //Strings para obtener IDs en funcion de Objetos
            public static String TipoIncidenciaIdByGrupo = "SELECT IDTIPO FROM GRUPOINCIDENTE WHERE IDGRUPO = @idg";
            public static String GrupoIncidenciaIdBySubTipo = "SELECT IDGRUPO FROM SUBTIPOINCIDENTE WHERE IDSUBTIPO = @idst";
            public static String VentasByDia = "SELECT * FROM VENTAS WHERE YEAR(FECHA) = YEAR(@fecha) AND MONTH(FECHA) = MONTH(@fecha) AND DAY(FECHA) = DAY(@fecha)";
            public static String IncidentesByDia = "SELECT * FROM INCIDENTES WHERE YEAR(FECHA) = YEAR(@fecha) AND MONTH(FECHA) = MONTH(@fecha) AND DAY(FECHA) = DAY(@fecha)";
            public static String LastIdVenta = "SELECT MAX(IDVENTA) FROM VENTAS";

            //Strings relacionadas a usuarios y permisos
            public static String UsuariosAll = "SELECT * FROM USERS";
            public static String UsuariosByDNI = "SELECT * FROM USERS WHERE DNI = @dni";
            public static String UsuariosByUser = "SELECT * FROM USERS WHERE NOMBRE = @nombre";
            public static String CheckUsuario = "SELECT COUNT(*) FROM USERS NOMBRE = @nombre";
            public static String UsuarioInsert = "INSERT INTO USERS (DNI, NOMBRE, PASS, TIPO) VALUES (@dni,@nombre,@pass,@tipo)";
            public static String UsuarioUpdate = "UPDATE USERS SET DNI = @dni, NOMBRE = @n1, PASS = @pass, TIPO = @tipo WHERE NOMBRE = @n2";
        }
       
        //Funcion que devuelve string de conexion a BD
        public static String DataBaseConectString() { return ConStrings.DataBase; }

         //Funciones que devuelven strings de seleccion        
         public static String AdministradorAllString() { return ConStrings.AdministradorAll; }
         public static String EmpleadosAllString() { return ConStrings.EmpleadosAll; }
         public static String ClientesAllString() { return ConStrings.ClientesAll; }
         public static String ArticulosAllString() { return ConStrings.ArticulosAll; }
         public static String EquiposAllString() { return ConStrings.EquiposAll; }
         public static String TelefonosClAllString() { return ConStrings.TelefonosClAll; }
         public static String DomiciliosClAllString() { return ConStrings.DomiciliosClAll; }
         public static String MailsClAllString() { return ConStrings.MailsClAll; }
         public static String TelefonosEmAllString() { return ConStrings.TelefonosEmAll; }
         public static String DomiciliosEmAllString() { return ConStrings.DomiciliosEmAll; }
         public static String MailsEmAllString() { return ConStrings.MailsEmAll; }
         public static String InteresesAllString() { return ConStrings.InteresesAll; }
         public static String VentasAllString() { return ConStrings.VentasAll; }
         public static String ArticulosVentasAllString() { return ConStrings.ArticulosVentasAll; }
         public static String GrupoIncidenteAllString() { return ConStrings.GrupoIncidenteAll; }
         public static String SubTipoIncidenteAllString() { return ConStrings.SubTipoIncidenteAll; }
         public static String TipoIncidenteAllString() { return ConStrings.TipoIncidenteAll; }
         public static String IncidentesAllString() { return ConStrings.IncidentesAll; }
         public static String EmpleadosEquipoAllString() { return ConStrings.EmpleadosEquipoAll; }

        //Funciones que devuelven strings de insert de valor unico por tabla
        public static String AdministradorInsertString() { return ConStrings.AdministradorInsert; }
        public static String EmpleadosInsertString() { return ConStrings.EmpleadosInsert; }
        public static String ClientesInsertString() { return ConStrings.ClientesInsert; }
        public static String ArticulosInsertString() { return ConStrings.ArticulosInsert; }
        public static String EquiposInsertString() { return ConStrings.EquiposInsert; }
        public static String TelefonosClInsertString() { return ConStrings.TelefonosClInsert; }
        public static String DomiciliosClInsertString() { return ConStrings.DomiciliosClInsert; }
        public static String MailsClInsertString() { return ConStrings.MailsClInsert; }
        public static String TelefonosEmInsertString() { return ConStrings.TelefonosEmInsert; }
        public static String DomiciliosEmInsertString() { return ConStrings.DomiciliosEmInsert; }
        public static String MailsEmInsertString() { return ConStrings.MailsEmInsert; }
        public static String InteresesInsertString() { return ConStrings.InteresesInsert; }
        public static String VentasInsertString() { return ConStrings.VentasInsert; }
        public static String ArticulosVentasInsertString() { return ConStrings.ArticulosVentasInsert; }
        public static String GrupoIncidenteInsertString() { return ConStrings.GrupoIncidenteInsert; }
        public static String SubTipoIncidenteInsertString() { return ConStrings.SubTipoIncidenteInsert; }
        public static String TipoIncidenteInsertString() { return ConStrings.TipoIncidenteInsert; }
        public static String IncidentesInsertString() { return ConStrings.IncidentesInsert; }
        public static String EmpleadosEquipoInsertString() { return ConStrings.EmpleadosEquipoInsert; }

        //Funciones que devuelven strings de seleccion por id
        public static String AdministradorByIdString() { return ConStrings.AdministradorById; }
        public static String EmpleadosByIdString() { return ConStrings.EmpleadosById; }
        public static String ClientesByIdString() { return ConStrings.ClientesById; }
        public static String ArticulosByIdString() { return ConStrings.ArticulosById; }
        public static String EquiposByIdString() { return ConStrings.EquiposById; }
        public static String TelefonosClByIdString() { return ConStrings.TelefonosClById; }
        public static String DomiciliosClByIdString() { return ConStrings.DomiciliosClById; }
        public static String MailsClByIdString() { return ConStrings.MailsClById; }
        public static String TelefonosEmByIdString() { return ConStrings.TelefonosEmById; }
        public static String DomiciliosEmByIdString() { return ConStrings.DomiciliosEmById; }
        public static String MailsEmByIdString() { return ConStrings.MailsEmById; }
        public static String InteresesByIdString() { return ConStrings.InteresesById; }
        public static String VentasByIdString() { return ConStrings.VentasById; }
        public static String ArticulosVentasByIdArtString() { return ConStrings.ArticulosVentasByIdArt; }
        public static String ArticulosVentasByIdVenString() { return ConStrings.ArticulosVentasByIdVen; }
        public static String GrupoIncidenteByIdString() { return ConStrings.GrupoIncidenteById; }
        public static String SubTipoIncidenteByIdString() { return ConStrings.SubTipoIncidenteById; }
        public static String GrupoIncidenteByIdTipoString() { return ConStrings.GrupoIncidenteByIdTipo; }
        public static String SubTipoIncidenteByIdGrupoString() { return ConStrings.SubTipoIncidenteByIdGrupo; }
        public static String TipoIncidenteByIdString() { return ConStrings.TipoIncidenteById; }
        public static String IncidentesByIdString() { return ConStrings.IncidentesById; }
        public static String EmpleadosEquipoByIdString() { return ConStrings.EmpleadosEquipoById; }

        //Funciones que devuelven strings para actualizar campos en la base
        public static String EmpleadosUpdateString() { return ConStrings.EmpleadosUpdate; }
        public static String ClientesUpdateString() { return ConStrings.ClientesUpdate; }
        public static String ArticulosUpdateString() { return ConStrings.ArticulosUpdate; }
        public static String EquiposUpdateString() { return ConStrings.EquiposUpdate; }
        public static String TelefonosClUpdateString() { return ConStrings.TelefonosClUpdate; }
        public static String DomiciliosClUpdateString() { return ConStrings.DomiciliosClUpdate; }
        public static String MailsClUpdateString() { return ConStrings.MailsClUpdate; }
        public static String TelefonosEmUpdateString() { return ConStrings.TelefonosEmUpdate; }
        public static String DomiciliosEmUpdateString() { return ConStrings.DomiciliosEmUpdate; }
        public static String MailsEmUpdateString() { return ConStrings.MailsEmUpdate; }
        public static String InteresesUpdateString() { return ConStrings.InteresesUpdate; }
        public static String VentasUpdateString() { return ConStrings.VentasUpdate; }
        public static String ArticulosVentasUpdateArtString() { return ConStrings.ArticulosVentasUpdateByArt; }
        public static String ArticulosVentasUpdateVenString() { return ConStrings.ArticulosVentasUpdateByVen; }
        public static String GrupoIncidenteUpdateString() { return ConStrings.GrupoIncidenteUpdate; }
        public static String SubTipoIncidenteUpdateString() { return ConStrings.SubTipoIncidenteUpdate; }
        public static String TipoIncidenteUpdateString() { return ConStrings.TipoIncidenteUpdate; }
        public static String IncidentesUpdateString() { return ConStrings.IncidentesUpdate; }
        public static String EmpleadosEquipoUpdateByDNIString() { return ConStrings.EmpleadosEquipoUpdateByDni; }
        public static String EmpleadosEquipoUpdateByEquipoString() { return ConStrings.EmpleadosEquipoUpdateByEquipo; }

        //Funciones que devuelven strings para BORRAR campos en la base
        public static String AdministradorDeleteString() { return ConStrings.AdministradorDelete; }
        public static String EmpleadosDeleteString() { return ConStrings.EmpleadosDelete; }
        public static String ClientesDeleteString() { return ConStrings.ClientesDelete; }
        public static String ArticulosDeleteString() { return ConStrings.ArticulosDelete; }
        public static String EquiposDeleteString() { return ConStrings.EquiposDelete; }
        public static String TelefonosClDeleteString() { return ConStrings.TelefonosClDelete; }
        public static String DomiciliosClDeleteString() { return ConStrings.DomiciliosClDelete; }
        public static String MailsClDeleteString() { return ConStrings.MailsClDelete; }
        public static String TelefonosEmDeleteString() { return ConStrings.TelefonosEmDelete; }
        public static String DomiciliosEmDeleteString() { return ConStrings.DomiciliosEmDelete; }
        public static String MailsEmDeleteString() { return ConStrings.MailsEmDelete; }
        public static String InteresesDeleteString() { return ConStrings.InteresesDelete; }
        public static String VentasDeleteString() { return ConStrings.VentasDelete; }
        public static String ArticulosVentasDeleteArtString() { return ConStrings.ArticulosVentasDeleteByArt; }
        public static String ArticulosVentasDeleteVenString() { return ConStrings.ArticulosVentasDeleteByVen; }
        public static String GrupoIncidenteDeleteString() { return ConStrings.GrupoIncidenteDelete; }
        public static String SubTipoIncidenteDeleteString() { return ConStrings.SubTipoIncidenteDelete; }
        public static String TipoIncidenteDeleteString() { return ConStrings.TipoIncidenteDelete; }
        public static String IncidentesDeleteString() { return ConStrings.IncidentesDelete; }
        public static String EmpleadosEquipoDeleteByDNIString() { return ConStrings.EmpleadosEquipoDeleteByDni; }
        public static String EmpleadosEquipoDeleteByEquipoString() { return ConStrings.EmpleadosEquipoDeleteByEquipo; }

        //Funciones que devuelven strings de seleccion de IDs en base a objetos
        public static String TipoIncidenciaIdByGrupoString() { return ConStrings.TipoIncidenciaIdByGrupo; }
        public static String GrupoIncidenciaIdBySubTipoString() { return ConStrings.GrupoIncidenciaIdBySubTipo; }
        public static String VentasByDia() { return ConStrings.VentasByDia; }
        public static String IncidentesByDia() { return ConStrings.IncidentesByDia; }
        public static String LastIdVenta() { return ConStrings.LastIdVenta; }

        //Funciones que devuelven strings de manejo de usuarios
        public static String UsuariosAllString() { return ConStrings.UsuariosAll; }
        public static String UsuariosByDNIString() { return ConStrings.UsuariosByDNI; }
        public static String UsuariosByUserString() { return ConStrings.UsuariosByUser; }
        public static String CheckUsuariosString() { return ConStrings.CheckUsuario; }
        public static String UsuariosInsertString() { return ConStrings.UsuarioInsert; }
        public static String UsuariosUpdateString() { return ConStrings.UsuarioUpdate; }
    }
}

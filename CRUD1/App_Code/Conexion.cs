using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


public class Conexion
{

    SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=crud1;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    bool sw = false;

    public Conexion()
    {
        try
        {
            cn.Open();
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
    }

    public string insertar(string nom, string ced, string pass, string fechaNac)
    {
        string salida = "Se insertó";
        try
        {
            cmd = new SqlCommand(
                "insert into usuarios(nombre, idUsuario, contraseña, fechaNacimiento)" +
                "values('" + nom + "', '" + ced + "', '" + pass + "', '" + fechaNac + "')", cn
                );
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "Error al insertar: "+ex.ToString();
        }
        return salida;
    }

    public int buscarPersona(int id)
    {
        int cont = 0;
        try
        {
            cmd = new SqlCommand("select * from usuarios where idUsuario = '" + id+"'"
                ,cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cont++;
            }
            dr.Close();
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        return cont;
        
    }



}
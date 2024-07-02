using System;
using System.Data.SqlClient;

public class Metos_Opciones
{
    private static string connectionString = "Data Source=LAPTOP-JQHJ2716;Initial Catalog=ExamenPar2_GonzalezCen;Integrated Security=True;TrustServerCertificate=True";

    public static void CrearAutor(string nombre, string apellido, string fechaNacimiento)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Autor (nombre, apellido, fecha_nacimiento) VALUES (@nombre, @apellido, @fecha_nacimiento)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static void ActualizarAutor(int id, string nombre, string apellido, string fechaNacimiento)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE Autor SET nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha_nacimiento WHERE id = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static void EliminarAutor(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Autor WHERE id = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static void CrearLibro(string titulo, string fechaPublicacion, int autorId, float precio)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Libros (titulo, fecha_publicacion, autor_id, precio) VALUES (@titulo, @fecha_publicacion, @autor_id, @precio)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@titulo", titulo);
            command.Parameters.AddWithValue("@fecha_publicacion", fechaPublicacion);
            command.Parameters.AddWithValue("@autor_id", autorId);
            command.Parameters.AddWithValue("@precio", precio);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static void ActualizarLibro(int id, string titulo, string fechaPublicacion, int autorId, float precio)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE Libros SET titulo = @titulo, fecha_publicacion = @fecha_publicacion, autor_id = @autor_id, precio = @precio WHERE id = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@titulo", titulo);
            command.Parameters.AddWithValue("@fecha_publicacion", fechaPublicacion);
            command.Parameters.AddWithValue("@autor_id", autorId);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static void EliminarLibro(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Libros WHERE id = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}

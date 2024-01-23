using Microsoft.Data.Sqlite;

using crud_adonet_sqlite.Models;
using crud_adonet_sqlite.Interfaces;

namespace crud_adonet_sqlite.Repositories;

public class CustomerRepository(string dbPath) : ICustomer, IDisposable
{
    private readonly SqliteConnection connection = new($"Data Source={ dbPath }");

    public Customer CreateCustomer(Customer customer)
    {
        connection.Open();

        using (SqliteCommand command = new("INSERT INTO Customers (Name, Email) VALUES (@Name, @Email);SELECT LAST_INSERT_ROWID();", connection))
        {
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Email", customer.Email);

            customer.Id = Convert.ToInt32(command.ExecuteScalar());
        }

        connection.Close();
        
        return customer;
    }

    public Customer UpdateCustomer(Customer customer)
    {
        connection.Open();

        using (SqliteCommand command = new("UPDATE Customers SET Name = @Name, Email = @Email WHERE Id = @Id", connection))
        {
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Email", customer.Email);
            command.Parameters.AddWithValue("@Id", customer.Id);

            command.ExecuteNonQuery();
        }

        connection.Close();

        return customer;
    }

    public bool DeleteCustomer(int id)
    {
        connection.Open();

        using (SqliteCommand command = new("DELETE FROM Customers WHERE Id = @Id", connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        connection.Close();

        return true;
    }

    public Customer GetCustomerById(int id)
    {
        Customer customer = new();

        connection.Open();

        using (SqliteCommand command = new("SELECT * FROM Customers WHERE Id = @Id", connection))
        {
            command.Parameters.AddWithValue("@Id", id);

            using SqliteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                customer.Id = Convert.ToInt32(reader["Id"]);
                customer.Name =  reader["Name"].ToString() ?? string.Empty;
                customer.Email = reader["Email"].ToString() ?? string.Empty;
            }
        }

        connection.Close();

        return customer;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        List<Customer> customers = [];
 
        connection.Open();

        using (SqliteCommand command = new("SELECT * FROM Customers", connection))
        {
            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    Email = reader["Email"].ToString() ?? string.Empty
                });
            }
        }

        connection.Close();

        return customers;
    }

    public void Dispose() => connection.Dispose();
}
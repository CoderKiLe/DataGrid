using DataGrid.Interface;
using DataGrid.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataGrid.DataSource
{

    public class TaskRepository: ITaskRepository
    {
        private readonly SqliteConnection _connection;

        public TaskRepository(string connectionString)
        {
            _connection = new SqliteConnection(connectionString);
        }

        public void InitializeDatabase()
        {
            using var command = _connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Tasks (
                    Id TEXT PRIMARY KEY,
                    Title TEXT NOT NULL,
                    Description TEXT NOT NULL,                    
                    DateTime TEXT NOT NULL,
                    Priority TEXT NOT NULL,
                    IsCompleted INTEGER NOT NULL
                )";

            ExecuteNonQuery(command);
        }

        public void InsertTask(DataSourceModel task)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Tasks 
                (Id, Title, Description, DateTime, Priority, IsCompleted) 
                VALUES 
                (@id, @title, @description, @dateTime, @priority, @isCompleted)";

            command.Parameters.AddWithValue("@id", task.Id);
            command.Parameters.AddWithValue("@title", task.Title);
            command.Parameters.AddWithValue("@description", task.Description);
            command.Parameters.AddWithValue("@dateTime", task.DateTime.ToString("O"));
            command.Parameters.AddWithValue("@priority", task.Priority.ToString());
            command.Parameters.AddWithValue("@isCompleted", task.IsCompleted ? 1 : 0);

            ExecuteNonQuery(command);
        }

        public IEnumerable<DataSourceModel> GetAllTasks()
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Tasks";

            _connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                yield return new DataSourceModel
                {
                    Id = reader.GetString(0),
                    Title = reader.GetString(1),
                    Description = reader.GetString(2),
                    DateTime = DateTime.Parse(reader.GetString(3)),
                    Priority = Enum.Parse<Priority>(reader.GetString(4)),
                    IsCompleted = reader.GetInt32(5) == 1
                };
            }
        }

        public DataTable GetAllTasksAsDataTable()
        {
            var dataTable = new DataTable("Tasks");


            try
            {
                // defining the column in the data table
                dataTable.Columns.AddRange(new[]
                {
                    new DataColumn("Id", typeof(string)),
                    new DataColumn("Title", typeof(string)),
                    new DataColumn("Description", typeof(string)),
                    new DataColumn("DueDate", typeof(DateTime)),
                    new DataColumn("Priority", typeof(string)),
                    new DataColumn("IsComplete", typeof(bool))
                });


                using var command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Tasks";

                _connection.Open();
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // defing the row in the data table
                    var row = dataTable.NewRow();

                    row["Id"] = reader.IsDBNull(0) ? DBNull.Value : reader.GetString(0);
                    row["Title"] = reader.IsDBNull(1) ? DBNull.Value : reader.GetString(1);
                    row["Description"] = reader.IsDBNull(2) ? DBNull.Value : reader.GetString(2);
                    row["DueDate"] = reader.IsDBNull(3) ? DBNull.Value : DateTime.Parse(reader.GetString(3));
                    row["Priority"] = reader.IsDBNull(4) ? DBNull.Value : reader.GetString(4);
                    row["IsComplete"] = reader.IsDBNull(5) ? DBNull.Value : (reader.GetInt32(5) == 1);

                    dataTable.Rows.Add(row);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"error: {e}");
            }
            finally
            {
                _connection.Close();
            }
            return dataTable;
        }

        private void ExecuteNonQuery(SqliteCommand command)
        {
            try
            {
                _connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
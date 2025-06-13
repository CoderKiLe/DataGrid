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
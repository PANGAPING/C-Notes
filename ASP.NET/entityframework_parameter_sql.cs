context.Database.ExecuteSqlCommand(@"UPDATE dbo.Customers 
            SET Name = 'Test' WHERE Id = @id and Name =@name", 
               new SqlParameter("Id", id),
               new SqlParameter("name", fname));
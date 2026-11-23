using Npgsql;

public class FortuneDB{
   
   private readonly NpgsqlDataSource _datasrc;
   public FortuneDB(NpgsqlDataSource ds){
      _datasrc = ds; 
   }

   public void async insertSentence(string sentence){
      await using var cmd = dataSource.CreateCommand(
           "INSERT INTO data (some_field) VALUES ($1)"
        );
         
      cmd.Parameters.AddWithValue(sentence);
      await cmd.ExecuteNonQueryAsync();
       
   }
};


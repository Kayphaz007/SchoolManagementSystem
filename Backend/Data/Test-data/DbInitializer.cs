using System.Text.Json;

namespace Backend;

public static class DbInitializer
{
    public static async Task Initialize(SchoolContext context){
        if (!context.Subjects.Any()){
            var subjectData = File.ReadAllText("./Data/Test-data/Subject.json");
            var subjects = JsonSerializer.Deserialize<List<Subject>>(subjectData);
            await context.Subjects.AddRangeAsync(subjects);
            // context.SaveChanges();
        }

        if(context.ChangeTracker.HasChanges()){
            await context.SaveChangesAsync();
        }
    }
}

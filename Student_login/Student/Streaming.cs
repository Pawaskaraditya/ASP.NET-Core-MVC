using System.Text.Json;

public class Streaming{
    public static void Ser(List<Student> li){
         String produtsJson=JsonSerializer.Serialize<List<Student>>(li);
         String fileName=@"E:\dotnet\day8\Student\data.json";
        File.WriteAllText(fileName,produtsJson); 

    }
    public static List<Student> Dser(){
        List<Student> li=new List<Student>();
        string fileName=@"E:\dotnet\day8\Student\data.json";
        string jsonString = File.ReadAllText(fileName);
        if(jsonString=="")
        return null;
        li = JsonSerializer.Deserialize<List<Student>>(jsonString);
        return li;
    }
}
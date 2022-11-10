// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string projetos = @"C:\Users\juliano.hein\Documents\projetos\passe2020\build";

string projetos2 = @"C:\Users\juliano.hein\Documents\projetos2\passe2020\build";

List<string> arquivos = listar(projetos);
List<string> arquivos2 = listar(projetos2);
Diferenciar(arquivos, arquivos2);

void Diferenciar(List<string> arquivos, List<string> arquivos2)
{
    List<string> diff = arquivos.Except(arquivos2).ToList();

    diff.ForEach(x => Console.WriteLine(x));
}

List<string> listar(string filename)
{
    List<string> lita = new List<string>();
    DirectoryInfo Dir = new DirectoryInfo(filename);
    // Busca automaticamente todos os arquivos em todos os subdiretórios
    FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
    foreach (FileInfo File in Files)
    {        
        lita.Add(File.Name);
    }
    Console.WriteLine(lita.Count);
    return lita;
}


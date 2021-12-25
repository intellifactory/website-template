open System
open System.IO

Directory.EnumerateFiles(Environment.CurrentDirectory, "*.html")
|> Seq.toList
|> List.iter (fun path ->
    let txt = File.ReadAllText(path)
    File.WriteAllText(path, txt.Replace("%24%7B", "${").Replace("%7D", "}").Replace("&amp;", "&").Replace("\"images", "\"/images"))
)

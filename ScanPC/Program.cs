
using Microsoft.EntityFrameworkCore;
using ScanPC;
using ScanPC.BL;

var path = Console.ReadLine();
var fileScann = new FileScanner();
fileScann.ScanFolder(path);
fileScann.ScanFile(path);



//try
//{
//    Only get files that begin with the letter "c".
//    string[] dirs = Directory.GetDirectories(@"C:\Users\User\Desktop\VStudio\");
//    Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
//    foreach (string dir in dirs)
//    {
//        Console.WriteLine(dir);
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine("The process failed: {0}", e.ToString());
//}
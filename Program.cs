using System;
using LibGit2Sharp;
//using GitInfo;
namespace gitVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
                        //Head.Remote leer repositorio remoto
            
            //IExecutionContext context
            //Console.WriteLine("commit");
            //onsole.WriteLine("2.0");
            //var repositoryLocation = Repository.Discover(context.InputFolder);
            //if (repositoryLocation == null)
              //  throw new ArgumentException("No git repository found");

            //var repo = new Repository("https://github.com/coretech/mymso2-api.git");
            var repo = new Repository(@"./gitVersion2");
            
                Console.WriteLine(repo);
                Commit commit = repo.Head.Tip;
                Console.WriteLine("Author: {0}", commit.Author.Name);
                Console.WriteLine("Message: {0}", commit.MessageShort);
            
            Console.WriteLine("Hello World!");
            Console.WriteLine(commit);
            //con gitInfo
            //Console.WriteLine('cOMMIT': This.Assembly.Commit)

            //Inge estaba probando tambien con GitInfo pero me da error la libreria y no encuentro mucho al respecto
            //dotnet add package GitInfo --version 2.0.34
        }
    }
}

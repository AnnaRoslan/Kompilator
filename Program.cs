// Template generated code from Antlr4BuildTasks.Template v 8.17
namespace Kom
{
    using Antlr4.Runtime;
    using Antlr4.Runtime.Tree;
    using AntlrTemplate;
    using System.IO;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            var program = File.ReadAllText("C:\\Users\\annar\\Desktop\\Kompilator\\Kom\\test.nw");
            Try(program + "\n");
        }

        static void Try(string input)
        {
            var str = new AntlrInputStream(input);

            //System.Console.WriteLine(input);

            var lexer = new GramatykaLexer(str);
            var tokens = new CommonTokenStream(lexer);
            var parser = new GramatykaParser(tokens);
            tokens.Fill();

            var listener_lexer = new ErrorListener<int>();
            var listener_parser = new ErrorListener<IToken>();

            lexer.AddErrorListener(listener_lexer);
            parser.AddErrorListener(listener_parser);

            var tree = parser.prog();

            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(new LLVMListener(tokens), tree);

        }
    }
}

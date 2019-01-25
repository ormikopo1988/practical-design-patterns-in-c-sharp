using System.IO;

namespace DesignPatternsGangOfFour.Structural.Facade
{
    // This acts as the facade class for the compiler subsystem introduced by the rest mock classes of the folder
    public class CompilerFacade
    {
        public virtual void Compile(Stream input, BytecodeStream output)
        {
            Scanner scanner = new Scanner(input);
            ProgramNodeBuilder builder = new ProgramNodeBuilder();
            Parser parser = new Parser();

            parser.Parse(scanner, builder);

            RISCCodeGenerator generator = new RISCCodeGenerator(output);
            ProgramNode parseTree = builder.GetRootNode();

            parseTree.Traverse(generator);
        }
    }
}
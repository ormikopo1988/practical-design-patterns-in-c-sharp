using System.IO;

namespace DesignPatternsGangOfFour.Structural.Facade
{
    public class Scanner
    {
        private readonly Stream inputStream;

        public Scanner(Stream inputStream)
        {
            this.inputStream = inputStream;
        }

        public virtual Token Scan()
        {
            using (var stream = new MemoryStream())
            {
                byte[] buffer = new byte[2048]; // read in chunks of 2KB

                int bytesRead;

                while ((bytesRead = this.inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, bytesRead);
                }

                byte[] result = stream.ToArray();

                // Produce a Token result
                return new Token(result);
            }
        }
    }
}
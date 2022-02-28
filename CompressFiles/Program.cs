using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "mitsos.txt";
            CompressionContext CTX = new CompressionContext(new RarCompression());

            CTX.CreateArchive(file);

            CTX.SetStrategy(new ZipCompression());
            CTX.CreateArchive(file);
        }
    }

    public interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);
    }

    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName+ ".rar' file is created");
        }
    }
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }

    public class CompressionContext
    {
        //-----------High LVL Programmer Sets Strategy-------------- START
        private ICompression Compression;

        public CompressionContext(ICompression Compression)      //Constructor = Dependancy Injection
        {
            this.Compression = Compression;
        }
        public void SetStrategy(ICompression Compression)       //Method = Dependancy Injection
        {
            this.Compression = Compression;
        }
        //-----------High LVL Programmer Sets Strategy-------------- END
        public void CreateArchive(string compressedArchiveFileName)
        {
            Compression.CompressFolder(compressedArchiveFileName);
        }
    }





}

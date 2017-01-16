using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shrinko
{
    class Compute
    {

        public string load(string input)
        {
            //var sn = input.GroupBy(c => c).Select(c => new { num = c.Count(), c.Key }).OrderByDescending(c => c.Key).OrderByDescending(c => c.num);
            //var eo = string.Concat(sn.Select(c => c.Key + c.num.ToString() + " ")).ToUpper();

            var d = compress(input);
            Console.WriteLine(decompress(d));
            return input;
        }


        public byte[] compress(string input)
        {
            var inputToByte = File.ReadAllBytes(input);
            using (var inputStream = new MemoryStream(inputToByte))
            {
                using (var outPutStream = new MemoryStream())
                {
                    using (var inpCompress = new GZipStream(outPutStream, CompressionMode.Compress))
                    {
                        inputStream.CopyTo(inpCompress);
                    }

                    return outPutStream.ToArray();
                }
            }
        }


        public byte[] decompress(byte[] input)
        {

            using (var inputStream = new MemoryStream(input))
            {
                using (var outPutStream = new MemoryStream())
                {
                    using (var decompress = new GZipStream(inputStream, CompressionMode.Decompress))
                    {
                        decompress.CopyTo(outPutStream);
                    }


                    return outPutStream.ToArray();
                }
            }

        }



    }
}

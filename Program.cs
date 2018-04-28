using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockGenPMP_Demo
{
    class Program
    {
        /*   Each block has: 
         *   List of Transaction
         *   Previous hash
         *   Actual hash
         
         */
        List<Block> blockchain = new List<Block>(); 

        static void Main(string[] args)
        {
            string[] genesisTransaction = {"PMP Blockchain igor miquilena", "0 pmp begins" };

            Block genesisBlock = new Block(0, genesisTransaction);

            string[] block2Transaction = { "PMP Blockchain igor miquilena", "0 pmp begins" };

            Block block2 = new Block(genesisBlock.getblockHash(), block2Transaction);


            Console.WriteLine(genesisBlock.getblockHash());
            Debug.Print("Hash genesis block");
            Debug.Print(genesisBlock.getblockHash().ToString());
            Console.WriteLine(block2.getblockHash());
            Debug.Print("Hash block 2");
            Debug.Print(block2.ToString());
            Console.ReadKey();

        }
    }
}

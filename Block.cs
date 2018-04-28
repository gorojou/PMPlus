using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockGenPMP_Demo
{
    public class Block
    {
        private int previosHash;
        private String[] transactions;

        private int blockHash;

     
        public Block(int previosHash, String[] transactions)
        {
            this.previosHash = previosHash;
            this.transactions = transactions;

            object[] contents = { transactions.GetHashCode(), previosHash };

            this.blockHash = contents.GetHashCode();
        }

        public int getPreviosHash()
        {
            return previosHash;
        }

        public String[] getTransactions()
        {
            return transactions;
        }

        public int getblockHash()
        {
            return blockHash;
        }
    }
}

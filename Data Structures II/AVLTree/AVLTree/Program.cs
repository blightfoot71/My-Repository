﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new AVLTree();

            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);

        }
    }
}

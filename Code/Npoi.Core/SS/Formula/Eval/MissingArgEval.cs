﻿
namespace Npoi.Core.SS.Formula.Eval
{
    public class MissingArgEval : ValueEval
    {
        public static MissingArgEval instance = new MissingArgEval();

        private MissingArgEval()
        {
        }
    }
}

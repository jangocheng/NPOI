/*
* Licensed to the Apache Software Foundation (ASF) Under one or more
* contributor license agreements.  See the NOTICE file distributed with
* this work for Additional information regarding copyright ownership.
* The ASF licenses this file to You Under the Apache License, Version 2.0
* (the "License"); you may not use this file except in compliance with
* the License.  You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed Under the License is distributed on an "AS Is" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations Under the License.
*/


namespace Npoi.Core.SS.Formula.Functions
{
    using Npoi.Core.SS.Formula.Eval;
    using Npoi.Core.SS.Formula;

    /**
     * Implementation for Excel ROWS function.
     * 
     * @author Josh Micich
     */
    public class Rows : Fixed1ArgFunction
    {
        public override ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, ValueEval arg0)
        {

            int result;
            if (arg0 is TwoDEval)
            {
                result = ((TwoDEval)arg0).Height;
            }
            else if (arg0 is RefEval)
            {
                result = 1;
            }
            else
            { // anything else is not valid argument
                return ErrorEval.VALUE_INVALID;
            }
            return new NumberEval(result);
        }
    }
}
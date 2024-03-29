﻿using System.Collections.Generic;

namespace FlxCs
{
    public class Result
    {
        public List<int> indices;
        public int score;
        public int tail;

        public Result(List<int> indices, int score, int tail)
        {
            this.indices = indices;
            this.score = score;
            this.tail = tail;
        }

        public override string ToString()
        {
            return  score + " " + Util.ToString(indices);
        }
    }
}

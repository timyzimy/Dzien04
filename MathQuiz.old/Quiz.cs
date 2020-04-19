﻿ 1
 2
 3
 4
 5
 6
 7
 8
 9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    class Quiz
    {
        private int arg1;
        private int arg2;
        private String oper;
        private int result;

        public int Result { get { return result; } }

        public Quiz(int arg1, int arg2, string oper)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.oper = oper;
            switch (oper)
            {
                case "+":
                    result = arg1 + arg2;
                    break;

                case "-":
                    result = arg1 - arg2;
                    break;

                case "*":
                    result = arg1 * arg2;
                    break;

                case "/":
                    result = arg1 / arg2;
                    break;

                default:
                    break;
            }

        }

        public override string ToString()
        {
            return String.Format("{0,3} {1} {2,3} =", arg1, oper, arg2);
        }

    }
}
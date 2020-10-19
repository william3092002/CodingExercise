using System;
using System.Collections.Generic;
using System.Linq;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "((2.33 / (2.9+3.5)*4) - -6)";
            double result = Evaluate(expression);
            Console.WriteLine(result);
        }
        public static double Evaluate(string expression)
        {
            expression = ReconstructString(expression);
            
            List<string> expresList = makeNewList(expression);
            double result = 0.0;
            int parenthsisCount = countParenthesis(expresList);
            while (parenthsisCount > 0)
            {
                int endIndx = expresList.IndexOf(")");
                int startIndx = expresList.LastIndexOf("(");
                
                if(startIndx > endIndx)
                {
                    endIndx = expresList.IndexOf(")");
                    startIndx = expresList.IndexOf("(");
                    string subString = makeSubString(expresList, startIndx, endIndx);
                    List<string> newExpresList = makeNewList(ReconstructString(subString));
                    int newPCount = countParenthesis(newExpresList);
                    while (newPCount > 1)
                    {
                        int oldSIndx = startIndx;
                        subString = makeSubString(expresList, startIndx, endIndx);
                        newExpresList = makeNewList(ReconstructString(subString));
                        startIndx += newExpresList.LastIndexOf("(");
                        newExpresList.RemoveRange(newExpresList.IndexOf("("), startIndx - oldSIndx);
                        newPCount = countParenthesis(newExpresList);
                    }
                }

                parenthesisOp(expresList, startIndx, endIndx);
                parenthsisCount--;
            }; 
            
            if (expresList.Count < 3)
            {
                for (int i = 0; i < expresList.Count; i++)
                {
                    if(expresList[i] != "-" & expresList[i] != "+")
                        result += double.Parse(expresList[i]);
                    else if(expresList[i] == "-")
                    {
                        expresList[i+1] = (0 - Double.Parse(expresList[i + 1])).ToString();
                        expresList.RemoveAt(i);
                        if (expresList.Count==1)
                        {
                            result += Double.Parse(expresList[0]);
                        }
                    }
                }
            }
            for (int i = 0; i < expresList.Count; i++)
            {
                if (expresList[i] == "*")
                {
                    result = double.Parse(expresList[i - 1]) * double.Parse(expresList[i + 1]);
                    expresList.Insert(i + 2, result.ToString());
                    expresList.RemoveRange(i - 1, 3);
                    i--;

                }
                else if (expresList[i] == "/")
                {
                    if(expresList[i+1] == "-")
                    {
                        expresList.RemoveAt(i + 1);
                        expresList[i+1] = (0 - Double.Parse(expresList[i + 1])).ToString();
                        i--;
                    }
                    else if(i != 0)
                    {
                        result = double.Parse(expresList[i - 1]) / double.Parse(expresList[i + 1]);
                        expresList.Insert(i + 2, result.ToString());
                        expresList.RemoveRange(i - 1, 3);
                        i--;
                    }
                }
                else if (expresList.Count == 2)
                    result = Double.Parse(expresList[0]) + Double.Parse(expresList[1]);
            }
            for (int i = 0; i < expresList.Count; i++)
            {
                if (expresList[i] == "+")
                {
                    if (expresList[i + 1] == "-" | expresList[i + 1] == "+")
                    {
                        expresList.RemoveAt(i);
                        i--;
                    }
                    else if (expresList[i] == "+")
                    {
                        result = double.Parse(expresList[i - 1]) + double.Parse(expresList[i + 1]);
                        expresList.Insert(i + 2, result.ToString());

                    }
                    else if (expresList[i] == "-")
                    {
                        result = double.Parse(expresList[i - 1]) - double.Parse(expresList[i + 1]);
                        expresList.Insert(i + 2, result.ToString());
                    }
                    if (i != 0)
                    {
                        expresList.RemoveRange(i - 1, 3);
                        i--;
                        if(i != 0)
                        {
                            if (i == expresList.Count - 1)
                                i--;
                        }
                        
                    }
                }
                else if (expresList[i] == "-")
                {
                    if (expresList[i + 1] == "-")
                    {
                        expresList.RemoveRange(i, 2);
                        expresList.Insert(i, "+");
                        i--;
                    }
                    else if (expresList[i + 1].Contains('-'))
                    {
                        expresList.RemoveAt(i);
                        expresList[i]= (0 - Double.Parse(expresList[i])).ToString();
                        i--;
                        if (i == expresList.Count - 1)
                            i--;

                    }

                    else if (expresList[i - 1] != "/" & expresList[i + 1] != "-")
                    {
                        result = double.Parse(expresList[i - 1]) - double.Parse(expresList[i + 1]);
                        expresList.Insert(i + 2, result.ToString());
                        expresList.RemoveRange(i - 1, 3);
                        i--;
                    }
                    else
                    {
                        if (expresList[i + 1].Contains('-'))
                        {
                            expresList[i + 1] = (0 - Double.Parse(expresList[i + 1])).ToString();

                        }
                    }
                }
                else if (expresList.Count == 2)
                    result = Double.Parse(expresList[0]) + Double.Parse(expresList[1]);
            }
            
            return result;
        }
        public static string ReconstructString(string expression)
        {
            List<char> charList = new List<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                charList.Add(expression[i]);
                

                if (i == 0 & expression[i] != '-' & !char.IsNumber(expression[i]))
                {
                    charList.Add(' ');
                }
                else if (i != 0 & i != expression.Length -1)
                {
                    if (!char.IsNumber(expression[i]) & expression[i] != '-' & expression[i] != '.')
                    {
                        if (expression[i - 1] != ' ' & expression[i] != '-')
                            charList.Insert(charList.Count - 1, ' ');
                        if (expression[i + 1] != ' ' & expression[i] != '-')
                            charList.Add(' ');

                    }
                    else if (charList[charList.Count - 2] == '+' | charList[charList.Count - 2] == '*' | charList[charList.Count - 2] == '/')
                    {
                        charList.Insert(charList.Count - 1, ' ');
                    }
                    else if (expression[i] == '-' & i != 0)
                    {
                        if (expression[i - 1] != ' ')
                            charList.Insert(charList.Count - 1, ' ');
                        else if (!char.IsNumber(expression[i + 1]) & expression[i + 1] != ' ')
                            charList.Add(' ');
                        else if (char.IsNumber(expression[i-1]))
                            charList.Insert(charList.Count - 1, ' ');

                    }
                    else if (expression[i] == ')' & expression[i - 1] != ' ')
                        charList.Insert(charList.Count - 1, ' ');
                }
                if (i == expression.Length - 1 & expression[i] == ')')
                    charList.Insert(charList.Count - 1, ' ');
               
                if (i != expression.Length - 1)
                {
                    if (expression[i] == '(' )
                        charList.Add(' ');
                }
                
                

            }
            char[] cleanedCharArray = charList.ToArray();
            string newExpression = new string(cleanedCharArray);
            return newExpression;
        }
        public static void parenthesisOp(List<string> expresList, int startIndx, int endIndx)
        {
            string subExpression = "";
            for (int i = startIndx + 1; i <= endIndx - 1; i++)
            {
                subExpression += expresList[i];
            }
            double subResult = Evaluate(subExpression);
            expresList.RemoveRange(startIndx, endIndx - startIndx + 1);
            expresList.Insert(startIndx, subResult.ToString());
        }
        public static string makeSubString(List<string> expresList, int startIndx, int endIndx)
        {
            string subExpression = "";
            for (int i = startIndx; i <= endIndx; i++)
            {
                subExpression += expresList[i];
            }
            return subExpression;
        }
        public static List<string> makeNewList (string expression)
        {
            string[] delimeter = new string[] { " ", "  ", "   " };
            string[] newExpresArray = expression.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            List<string> expresList = new List<string>();
            for (int i = 0; i < newExpresArray.Length; i++)
            {
                expresList.Add(newExpresArray[i]);
            }
            return expresList;
        }
        public static int countParenthesis (List<string> expresList)
        {
            int parenthsisCount = 0;
            for (int i = 0; i < expresList.Count; i++)
            {
                if (expresList[i] == "(")
                    parenthsisCount++;
            }
            return parenthsisCount;
        }
    }
}

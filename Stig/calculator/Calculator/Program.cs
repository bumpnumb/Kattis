using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
    public enum TokenType { Operand, Operator } // operand == 4, operator == +
    public class lexeme
    {
        public TokenType Token;
        public int Value;
        public char Operator;
    }
    class Program
    {
        public static List<lexeme> lexicalAnalysis(string text)
        {
            List<lexeme> lexemes = new List<lexeme>();

            //match string with regex to find valuable tokens and remove bad input
            Regex reg = new Regex(@"^[0-9]+|[0-9]+|\+|\-|\*|\(|\)|\/");
            foreach (Match match in reg.Matches(text))
            {
                lexeme t = new lexeme();
                //assign value or operator to lexeme
                if (match.Value == "+" || match.Value == "-" || match.Value == "*" || match.Value == "/" || match.Value == "(" || match.Value == ")")
                {
                    t.Token = TokenType.Operator;
                    t.Operator = match.Value[0]; //first since regex match single literal
                }
                else
                {
                    t.Token = TokenType.Operand;
                    t.Value = Int32.Parse(match.Value);
                }
                lexemes.Add(t);
            }
            return lexemes;
        }

        public static List<lexeme> syntaxAnalysis(List<lexeme> lexemes)
        {
            List<lexeme> sorted = new List<lexeme>();

            //This is a queue where floating operators are being kept
            List<lexeme> operators = new List<lexeme>();

            //modifier is all the magic in this program.
            //if a token has a higher modifier than next token, apply token immediately
            //else, store the token untill a token of lower power apperars
            int modifier = 0;

            //sort through all tokens and add numerals immediately, store or add tokens as see fit
            foreach (lexeme l in lexemes)
            {
                if (l.Token == TokenType.Operand)
                {
                    sorted.Add(l);
                }
                else if (l.Operator == '+' || l.Operator == '-')
                {
                    //if addition or subtraction
                    //if a operator with higher power is queue, add that one to sorted
                    for (int i = operators.Count - 1; i >= 0; i--)
                    {
                        if (operators[i].Value > modifier)
                        {
                            sorted.Add(operators[i]);
                            operators.RemoveAt(i);
                        }
                        else
                            break; //tiny performance boost                        
                    }

                    l.Value = modifier;
                    operators.Add(l);
                }
                else if (l.Operator == '*' || l.Operator == '/')
                {
                    //if a operator with higher power is queue, add that one to sorted
                    for (int i = operators.Count - 1; i >= 0; i--)
                    {
                        if (operators[i].Value > modifier)
                        {
                            sorted.Add(operators[i]);
                            operators.RemoveAt(i);
                        }
                        else
                            break; //tiny performance boost                        
                    }

                    l.Value = modifier + 1;
                    operators.Add(l);
                }
                else if (l.Operator == '(')
                {
                    modifier++;
                }
                else // ')'
                {
                    modifier--;
                }
            }

            //dump operator queue
            for (int i = operators.Count - 1; i >= 0; i--)
            {
                sorted.Add(operators[i]);
                operators.RemoveAt(i);
            }
            return sorted;
        }

        public static List<lexeme> lexemeFixer(List<lexeme> lex)
        {
            //  -4--2
            for (int i = lex.Count - 1; i >= 0 ; i--)
            {
                //solve if first token is operator
                if (i == 0 && lex[i].Token == TokenType.Operator)
                {
                    if(lex[i].Operator == '-')// && lex[i+1].Token != TokenType.Operator 
                    {
                        lex[i + 1].Value *= -1;
                        lex.RemoveAt(0);
                    }
                }
                else
                {
                    if (lex[i].Token == TokenType.Operator) //if this is a '-' for example
                    {
                        if (lex[i-1].Token == TokenType.Operator)//and previous token is also operator
                        {
                            if(lex[i].Operator == '-')
                            {
                                lex[i + 1].Value *= -1;
                                lex.RemoveAt(i);
                                
                            }
                            else if(lex[i].Operator == '+'){
                                lex.RemoveAt(i);
                            }
                        }
                    }
                }
            }

            return lex;
        }

        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                //Find tokens in input string
                List<lexeme> lexemes = lexicalAnalysis(line);

                //lexemes are at this point every valid input
                //though problem is with expreessions like -4--2
                //so we need a fixer for that.
                lexemes = lexemeFixer(lexemes);


                //Apply grammar to tokens
                lexemes = syntaxAnalysis(lexemes);


                //Print result
                foreach (lexeme l in lexemes)
                {
                    if (l.Token == TokenType.Operand)
                        Console.Write(l.Value + " ");
                    else
                        Console.Write(l.Operator + " ");
                    //Console.Write(l.Operator + "(" + l.Value + ") ");
                    //use above line to see the magic behind why all this works

                }
                Console.Write("\r\n");
            }

        }
    }
}

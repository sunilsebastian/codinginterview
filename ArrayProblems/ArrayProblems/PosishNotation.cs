using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class PosishNotation
    {
          public int evalRPN(String[] tokens) {
 
        int returnValue = 0;
 
        String operators = "+-*/";
 
        Stack<int> stack = new Stack<int>();
 
        foreach(var  t in  tokens){
            if(!operators.Contains(t)){
                stack.Push(Convert.ToInt32(t));
            }else{
                int a =stack.Pop();
                int b = stack.Pop();
             
                switch(t){
                    case "+":
                        stack.Push(a+b);
                        break;
                    case "-":
                            stack.Push(b-a);
                            break;
                    case "*":
                            stack.Push(a * b);
                            break;
                    case "/":
                            stack.Push(b/a);
                            break;
                }
            }
        }
 
        returnValue = stack.Pop();
 
        return returnValue;
 
    }
    
        //prefix loop start from last


    }
}

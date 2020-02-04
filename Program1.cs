using System;
using System.Collections;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Stack stack = new Stack();

            int stack_size = 0;

            while (true)
            {
                Console.WriteLine("Enter Command:");
                var input = Console.ReadLine();

                
                if (input.StartsWith("PUSH"))
                {
                    var splits = input.Split(' ');
                    if (splits.Length > 1)
                    {
                        if (stack.Count >= 10)
                        {
                            Console.WriteLine("Stack is Full! Perform operations or restart program to Push more values");
                        }
                        else
                        {
                            stack.Push(decimal.Parse(splits[1]));
                            stack_size++;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Missing argument for PUSH...");
                    }
                    
                }
                else if (input.StartsWith("POP"))
                {
                    stack.Pop();
                    stack_size--;
                }
                else if (input.StartsWith("PRINT"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Peek());
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty!");
                    }
                    
                    
                }
                else if (input.StartsWith("ADD"))
                {
                    if (stack.Count > 1)
                    {
                        decimal x1 = (decimal)stack.Pop();
                        decimal x2 = (decimal)stack.Pop();
                        decimal sum = (x1 + x2);
                        stack.Push(sum);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient number of items in stack (<= 1)");
                    }

                }
                else if (input.StartsWith("SUBTRACT"))
                {
                    if (stack.Count > 1)
                    {
                        decimal x1 = (decimal)stack.Pop();
                        decimal x2 = (decimal)stack.Pop();
                        decimal difference = (x2 - x1);
                        stack.Push(difference);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient number of items in stack (<= 1)");
                    }
                }
                else if (input.StartsWith("MULTIPLY"))
                {
                    if (stack.Count > 1)
                    {
                        decimal x1 = (decimal)stack.Pop();
                        decimal x2 = (decimal)stack.Pop();
                        decimal product = (x1 * x2);
                        stack.Push(product);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient number of items in stack (<= 1)");
                    }
                }
                else if (input.StartsWith("DIVIDE"))
                {
                    if (stack.Count > 1)
                    {
                        decimal x1 = (decimal)stack.Pop();
                        decimal x2 = (decimal)stack.Pop();
                        decimal quotient = (x2 / x1);
                        stack.Push(quotient);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient number of items in stack (<= 1)");
                    }
                }
                else if (input.StartsWith("EXIT"))
                {
                    break;
                }
                else
                {
                    break;
                }
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;

namespace TreeVariants.Node
{
    public static class BinaryTreePrinter
    {
        class NodeInfo
        {
            public BinaryTreeNode<int> Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }

        //        __________________________________________________
        //________________░▓█▓█▓▓▓▓█▓▓▒░____________________
        //_______________▒█▓▓▓█████████▓▓▓▒_________________
        //______________▓██▓██████▓▓▓▓▓▓▓▓▓▓░_______________
        //_____________▒▓██████▓▓▓▓▓▒▒░░░░░▒▓▓______________
        //_____________▓▓▓▓▓▓▓▓▒▒▒▒▒░__░░░▒▒▓█▓░____________
        //____________░▓▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒▓███░___________
        //____________▒▓▒▒▒▒▒▒▒▒░░░░░░░░░▒▒▒▒▓██▒___________
        //____________▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▓▓███___________
        //___________░▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▓▓▓███░__________
        //___________░▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▓▓▓███▒__________
        //___________░▒▒▒░▒▒▒▒░░░░░░▒▒▒▒▒▒▓▓▓████▒__________
        //___________▒▒▒▒░░░░░░░░░░░▒▒▒▒▒▒▓▓▓████▒__________
        //___________▒▒▒▒░░░░░░░░░░░▒▒▒▒▒▒▒▓▓███▓▒__________
        //___________▓▓▓▓▒▒░░░▒▒▓▓▓█▓▓▒▒▒▒▒▓▓█▓▓█▓__________
        //___________▓████▓▒░░▒▓▓▓▒▒▒▒▒▒▒▒▒▓▓████▒__________
        //___________▓▓▒▒▒▓▓▒░░▒▒▓▓▓▒▒▓▓▒▒▒▓▓███▓▓░_________
        //___________▓██▓▒▓▓▒░░▒▒▓▓█▓▓▓▒▒▒▒▒▓▓█▓▓▓▒_________
        //___________▒▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓██▓▓▓▒_________
        //___________▒▓▓▒▒▒▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▓███▓▓▒_________
        //___________▒▒▒▒▒▒▒░░▒▒▒░░░░░░░▒▒▒▒▓███▓▓░_________
        //___________▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▓▓██▓▒▒__________
        //___________▒▒▒▒▒▓█▓▓▓▓▓▒░░░░▒▒▒▒▒▓▓▓█▓▒░__________
        //___________▒▒▒▒▒███████▓▓▒░░▒▒▒▒▓▓▓▓▓▒▒___________
        //___________░▒▒▒██████████▓▒▒▒▒▒▒▓▓▓▓▓▓░___________
        //____________▒▒████▓▒▓▓▓▓██▓▒▒▒▒▒▓▓▓▓▓_____________
        //____________▒▒██████████▓▓▓▒▒▒▒▓▓▓▓▓█▓▒___________
        //____________░▒▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓████▒░________
        //____________░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓█▓▓▓▓▓▒░_______
        //__________░▒▒▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓█▓▓▓▓▓▓▒░░______
        //░_░░░░_░░░░▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓█▓▓▓▓█▓▓░▒░______
        //__░░░░░░░░▒▒▓█▓▓▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓█▓▓▓▓▓▓▓░▒▒░_░░___
        //░░░░░░░░░▒▒▓█▒█▓▓▒▒▒▒▒▒▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▒▒▒░░▒▒____
        //░░░░░▒▒▒▒▒▒▓▓▓███▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▒▒▒▒░▒▒░░░__
        //░░▒▒▒▒▒▒▒▒▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▒▓▒▒▒▒▒▒░░░░░
        //▒░▒▒▒▒▒▒▒▒▒▓▓▓▓▓███▓▓▓▓▓███▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒░░░░░░
        //▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▓▓███▓████▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▓▒▒░░░░░░
        // Fancy stuff below ↓↓
        public static void Print(this BinaryTreeNode<int> root, int topMargin = 2, int leftMargin = 2)
        {
            if(root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for(int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.Item.ToString(" 0 ") };
                if(level < last.Count)
                {
                    item.StartPos = last[level].EndPos + 1;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if(level > 0)
                {
                    item.Parent = last[level - 1];
                    if(next == item.Parent.Node.LeftChild)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos);
                    }
                }
                next = next.LeftChild ?? next.RightChild;
                for(; next == null; item = item.Parent)
                {
                    Print(item, rootTop + 2 * level);
                    if(--level < 0) break;
                    if(item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos;
                        next = item.Parent.Node.RightChild;
                    }
                    else
                    {
                        if(item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos;
                        else
                            item.Parent.StartPos += (item.StartPos - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(NodeInfo item, int top)
        {
            SwapColors();
            Print(item.Text, top, item.StartPos);
            SwapColors();
            if(item.Left != null)
                PrintLink(top + 1, "┌", "┘", item.Left.StartPos + item.Left.Size / 2, item.StartPos);
            if(item.Right != null)
                PrintLink(top + 1, "└", "┐", item.EndPos - 1, item.Right.StartPos + item.Right.Size / 2);
        }

        private static void PrintLink(int top, string start, string end, int startPos, int endPos)
        {
            Print(start, top, startPos);
            Print("─", top, startPos + 1, endPos);
            Print(end, top, endPos);
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if(right < 0) right = left + s.Length;
            while(Console.CursorLeft < right) Console.Write(s);
        }

        private static void SwapColors()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }
    }
}